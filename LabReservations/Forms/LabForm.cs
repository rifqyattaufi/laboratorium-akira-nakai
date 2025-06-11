using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabReservations.Forms
{
    public partial class LabForm : Form
    {
        private readonly LabService _labService;
        private int? _selectedLabId = null; // Pakai nullable int untuk tahu ada lab yg dipilih atau tidak

        public LabForm()
        {
            InitializeComponent();
            _labService = new LabService();
        }

        // ... (kode lainnya akan ditambahkan di sini)
        private void RefreshGrid()
        {
            dgvLabs.DataSource = null; // Kosongkan dulu untuk refresh
            dgvLabs.DataSource = _labService.ListLabs(); // Isi dengan data terbaru
            dgvLabs.Columns["Id"].HeaderText = "ID";
            dgvLabs.Columns["Name"].HeaderText = "Nama Laboratorium";
            dgvLabs.Columns["Description"].HeaderText = "Deskripsi";
        }

        private void LabForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvLabs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan yang diklik adalah baris data, bukan header
            {
                DataGridViewRow row = dgvLabs.Rows[e.RowIndex];

                // Simpan ID yang dipilih
                _selectedLabId = Convert.ToInt32(row.Cells["Id"].Value);

                // Tampilkan data ke TextBox
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDesc.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtDesc.Text = "";
            _selectedLabId = null;
            dgvLabs.ClearSelection(); // Hapus seleksi di grid
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _labService.AddLab(txtName.Text, txtDesc.Text);
                MessageBox.Show("Data berhasil ditambahkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid(); // Muat ulang data
                ClearForm();   // Bersihkan form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_selectedLabId == null)
            {
                MessageBox.Show("Pilih data yang akan diubah terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _labService.EditLab(_selectedLabId.Value, txtName.Text, txtDesc.Text);
                MessageBox.Show("Data berhasil diubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_selectedLabId == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi sebelum menghapus
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                                             "Konfirmasi Hapus",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _labService.DeleteLab(_selectedLabId.Value);
                    MessageBox.Show("Data berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
