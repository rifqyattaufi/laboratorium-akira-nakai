namespace LabReservations.Forms
{
    partial class LabForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvLabs = new DataGridView();
            gbForm = new GroupBox();
            btnSimpan = new Button();
            btnHapus = new Button();
            btnBatal = new Button();
            btnTambah = new Button();
            txtDesc = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLabs).BeginInit();
            gbForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLabs
            // 
            dgvLabs.AllowUserToAddRows = false;
            dgvLabs.AllowUserToDeleteRows = false;
            dgvLabs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabs.Location = new Point(441, 15);
            dgvLabs.Margin = new Padding(2);
            dgvLabs.MultiSelect = false;
            dgvLabs.Name = "dgvLabs";
            dgvLabs.ReadOnly = true;
            dgvLabs.RowHeadersWidth = 72;
            dgvLabs.Size = new Size(810, 647);
            dgvLabs.TabIndex = 0;
            dgvLabs.CellClick += dgvLabs_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(btnSimpan);
            gbForm.Controls.Add(btnHapus);
            gbForm.Controls.Add(btnBatal);
            gbForm.Controls.Add(btnTambah);
            gbForm.Controls.Add(txtDesc);
            gbForm.Controls.Add(label2);
            gbForm.Controls.Add(txtName);
            gbForm.Controls.Add(label1);
            gbForm.Location = new Point(8, 8);
            gbForm.Margin = new Padding(2);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(2);
            gbForm.Size = new Size(429, 469);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Laboratorium";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(226, 383);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(201, 87);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(4, 382);
            btnHapus.Margin = new Padding(2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(221, 87);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(226, 292);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(203, 87);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(0, 292);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(225, 87);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(0, 185);
            txtDesc.Margin = new Padding(2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(235, 87);
            txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Deskripsi";
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 73);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // LabForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgvLabs);
            Controls.Add(gbForm);
            Margin = new Padding(2);
            Name = "LabForm";
            Text = "LabForm";
            Load += LabForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLabs).EndInit();
            gbForm.ResumeLayout(false);
            gbForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLabs;
        private GroupBox gbForm;
        private Button btnSimpan;
        private Button btnHapus;
        private Button btnBatal;
        private Button btnTambah;
        private TextBox txtDesc;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}