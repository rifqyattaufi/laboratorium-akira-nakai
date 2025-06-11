using LabReservation.Services;
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
    public partial class DashboardAdmin : Form
    {
        private LabService _labService;
        private UserService _userService;

        public DashboardAdmin()
        {
            InitializeComponent();
            btnAddLab.Click += btnAddLab_Click;

            _labService = new LabService();
            _userService = new UserService();

            LoadLabData();
            LoadUserData();
        }

        private void LoadLabData()
        {
            var labs = _labService.ListLabs();
            dgvLabs.DataSource = labs;
            lblTotalLabs.Text = $"Total Labs: {labs.Count}";
            dgvLabs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadUserData()
        {
            var users = _userService.LoadAll();
            dgvUsers.DataSource = users;
            lblTotalUsers.Text = $"Total Users: {users.Count}";
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvUsers.Columns.Contains("Password"))
                dgvUsers.Columns["Password"].Visible = false;
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LabForm().ShowDialog();
            this.Show();
            LoadLabData();
        }
    }

}
