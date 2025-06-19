using LabReservation.Domain;
using LabReservation.Services;
using LabReservation.Utils;
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
    public partial class DashboardUser : Form
    {
        private readonly LabService _labService = new LabService();
        private readonly ReservationService _reservationService = new ReservationService();
        private readonly UserService? _userService;
        private User _currentUser;

        public DashboardUser(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            this.Load += DashboardUser_Load;
            btnReserve.Click += BtnReserve_Click;
            btnCancelReservation.Click += BtnCancelReservation_Click;
            dgvMyReservations.SelectionChanged += DgvMyReservations_SelectionChanged;
        }

        private void DashboardUser_Load(object? sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_currentUser.Username}!";
            LoadLaboratories();
            LoadMyReservations();

            dtpDate.Value = DateTime.Today;
            dtpDate.MinDate = DateTime.Today;
            dtpStartTime.Value = DateTime.Today.AddHours(8);
            dtpEndTime.Value = DateTime.Today.AddHours(10);
        }

        private void LoadLaboratories()
        {
            try
            {
                var labs = _labService.LoadAll();
                cbLab.DataSource = labs;
                cbLab.DisplayMember = "Name";
                cbLab.ValueMember = "Id";
                cbLab.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading laboratories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMyReservations()
        {
            try
            {
                var myReservations = _reservationService.GetByUser(_currentUser.Id);
                var labs = _labService.LoadAll();

                var displayReservations = myReservations.Select(r => new
                {
                    Id = r.Id,
                    Laboratory = labs.FirstOrDefault(l => l.Id == r.LabId)?.Name ?? "Unknown",
                    Date = r.StartTime.ToString("yyyy-MM-dd"),
                    StartTime = r.StartTime.ToString("HH:mm"),
                    EndTime = r.EndTime.ToString("HH:mm"),
                    Status = r.Status
                }).OrderByDescending(r => r.Id).ToList();

                dgvMyReservations.DataSource = displayReservations;

                if (dgvMyReservations.Columns.Count > 0)
                {
                    dgvMyReservations.Columns["Id"].HeaderText = "ID";
                    dgvMyReservations.Columns["Laboratory"].HeaderText = "Laboratory";
                    dgvMyReservations.Columns["Date"].HeaderText = "Date";
                    dgvMyReservations.Columns["StartTime"].HeaderText = "Start Time";
                    dgvMyReservations.Columns["EndTime"].HeaderText = "End Time";
                    dgvMyReservations.Columns["Status"].HeaderText = "Status";
                    dgvMyReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReserve_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cbLab.SelectedValue == null)
                {
                    MessageBox.Show("Please select a laboratory.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedDate = dtpDate.Value.Date;
                var startTime = selectedDate.Add(dtpStartTime.Value.TimeOfDay);
                var endTime = selectedDate.Add(dtpEndTime.Value.TimeOfDay);

                if (endTime <= startTime)
                {
                    MessageBox.Show("End time must be after start time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TimeValidator.IsValidReservationTime(startTime, endTime))
                {
                    MessageBox.Show("Invalid reservation time. Reservations must be between 7 AM and 6 PM on the same day.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (startTime < DateTime.Now)
                {
                    MessageBox.Show("Cannot make reservations for past dates/times.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var reservation = new Reservation
                {
                    UserId = _currentUser.Id,
                    LabId = (int)cbLab.SelectedValue,
                    StartTime = startTime,
                    EndTime = endTime
                };

                _reservationService.Create(reservation);
                MessageBox.Show("Reservation created successfully! Status: Pending approval.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbLab.SelectedIndex = -1;
                dtpDate.Value = DateTime.Today;
                dtpStartTime.Value = DateTime.Today.AddHours(8);
                dtpEndTime.Value = DateTime.Today.AddHours(10);
                LoadMyReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMyReservations_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvMyReservations.SelectedRows.Count > 0)
            {
                var selectedRow = dgvMyReservations.SelectedRows[0];
                var status = selectedRow.Cells["Status"].Value?.ToString();

                btnCancelReservation.Enabled = status == "pending";
            }
            else
            {
                btnCancelReservation.Enabled = false;
            }
        }

        private void BtnCancelReservation_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvMyReservations.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a reservation to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvMyReservations.SelectedRows[0];
                var reservationId = (int)selectedRow.Cells["Id"].Value;
                var status = selectedRow.Cells["Status"].Value?.ToString();

                if (status != "pending")
                {
                    MessageBox.Show("Only pending reservations can be cancelled.", "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to cancel this reservation?",
                    "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _reservationService.Cancel(reservationId, _currentUser.Id);
                    MessageBox.Show("Reservation cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMyReservations();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
