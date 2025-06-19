using LabReservation.Services;
using System;
using System.Windows.Forms;

namespace LabReservations.Forms
{
    public partial class DashboardAdmin : Form
    {
        private LabService _labService;
        private UserService _userService;
        private ReservationService _reservationService;

        public DashboardAdmin()
        {
            InitializeComponent();
            btnAddLab.Click += btnAddLab_Click;

            _labService = new LabService();
            _userService = new UserService();
            _reservationService = new ReservationService();

            LoadLabData();
            LoadUserData();
            LoadReservationData();

            btnApprove.Click += btnApprove_Click;
            btnReject.Click += btnReject_Click;
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

        private void LoadReservationData()
        {
            var reservations = _reservationService.LoadAll();
            var users = _userService.LoadAll();
            var labs = _labService.ListLabs();

            var displayReservations = reservations.Select(r => new
            {
                Id = r.Id,
                User = users.FirstOrDefault(u => u.Id == r.UserId)?.Username ?? "Unknown",
                Laboratory = labs.FirstOrDefault(l => l.Id == r.LabId)?.Name ?? r.LabId.ToString(),
                StartTime = r.StartTime,
                EndTime = r.EndTime,
                Status = r.Status
            }).ToList();

            dgvReservations.DataSource = displayReservations;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LabForm().ShowDialog();
            this.Show();
            LoadLabData();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                var id = (int)dgvReservations.SelectedRows[0].Cells["Id"].Value;
                _reservationService.UpdateStatus(id, "approved");
                MessageBox.Show("Reservation approved.");
                LoadReservationData();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                var id = (int)dgvReservations.SelectedRows[0].Cells["Id"].Value;
                _reservationService.UpdateStatus(id, "rejected");
                MessageBox.Show("Reservation rejected.");
                LoadReservationData();
            }
        }
    }
}
