namespace LabReservations.Forms
{
    partial class DashboardUser
    {
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMyReservations;
        private System.Windows.Forms.TabPage tabNewReservation;
        private System.Windows.Forms.DataGridView dgvMyReservations;
        private System.Windows.Forms.Panel panelMyReservationsButton;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;

        private void InitializeComponent()
        {
            tabControl = new System.Windows.Forms.TabControl();
            tabMyReservations = new System.Windows.Forms.TabPage();
            tabNewReservation = new System.Windows.Forms.TabPage();
            dgvMyReservations = new System.Windows.Forms.DataGridView();
            panelMyReservationsButton = new System.Windows.Forms.Panel();
            btnCancelReservation = new System.Windows.Forms.Button();
            lblWelcome = new System.Windows.Forms.Label();
            cbLab = new System.Windows.Forms.ComboBox();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            dtpTime = new System.Windows.Forms.DateTimePicker();
            btnReserve = new System.Windows.Forms.Button();
            lblLab = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();

            tabControl.SuspendLayout();
            tabMyReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyReservations).BeginInit();
            panelMyReservationsButton.SuspendLayout();
            tabNewReservation.SuspendLayout();
            SuspendLayout();

            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMyReservations);
            tabControl.Controls.Add(tabNewReservation);
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(800, 450);
            tabControl.TabIndex = 0;

            // 
            // tabMyReservations
            // 
            tabMyReservations.Controls.Add(dgvMyReservations);
            tabMyReservations.Controls.Add(panelMyReservationsButton);
            tabMyReservations.Controls.Add(lblWelcome);
            tabMyReservations.Location = new System.Drawing.Point(4, 29);
            tabMyReservations.Name = "tabMyReservations";
            tabMyReservations.Padding = new System.Windows.Forms.Padding(3);
            tabMyReservations.Size = new System.Drawing.Size(792, 417);
            tabMyReservations.TabIndex = 0;
            tabMyReservations.Text = "My Reservations";
            tabMyReservations.UseVisualStyleBackColor = true;

            // 
            // lblWelcome
            // 
            lblWelcome.Location = new System.Drawing.Point(20, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(400, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [User]";

            // 
            // dgvMyReservations
            // 
            dgvMyReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMyReservations.Location = new System.Drawing.Point(3, 36);
            dgvMyReservations.Name = "dgvMyReservations";
            dgvMyReservations.RowHeadersWidth = 51;
            dgvMyReservations.RowTemplate.Height = 29;
            dgvMyReservations.Size = new System.Drawing.Size(786, 338);
            dgvMyReservations.TabIndex = 1;

            // 
            // panelMyReservationsButton
            // 
            panelMyReservationsButton.Controls.Add(btnCancelReservation);
            panelMyReservationsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelMyReservationsButton.Height = 40;
            panelMyReservationsButton.Location = new System.Drawing.Point(3, 374);
            panelMyReservationsButton.Name = "panelMyReservationsButton";
            panelMyReservationsButton.Size = new System.Drawing.Size(786, 40);
            panelMyReservationsButton.TabIndex = 2;

            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new System.Drawing.Point(10, 8);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new System.Drawing.Size(150, 25);
            btnCancelReservation.TabIndex = 0;
            btnCancelReservation.Text = "Cancel Reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;

            // 
            // tabNewReservation
            // 
            tabNewReservation.Controls.Add(lblLab);
            tabNewReservation.Controls.Add(cbLab);
            tabNewReservation.Controls.Add(lblDate);
            tabNewReservation.Controls.Add(dtpDate);
            tabNewReservation.Controls.Add(lblTime);
            tabNewReservation.Controls.Add(dtpTime);
            tabNewReservation.Controls.Add(btnReserve);
            tabNewReservation.Location = new System.Drawing.Point(4, 29);
            tabNewReservation.Name = "tabNewReservation";
            tabNewReservation.Padding = new System.Windows.Forms.Padding(3);
            tabNewReservation.Size = new System.Drawing.Size(792, 417);
            tabNewReservation.TabIndex = 1;
            tabNewReservation.Text = "New Reservation";
            tabNewReservation.UseVisualStyleBackColor = true;

            // 
            // lblLab
            // 
            lblLab.Location = new System.Drawing.Point(40, 40);
            lblLab.Name = "lblLab";
            lblLab.Size = new System.Drawing.Size(120, 23);
            lblLab.TabIndex = 0;
            lblLab.Text = "Laboratory:";

            // 
            // cbLab
            // 
            cbLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbLab.Location = new System.Drawing.Point(180, 40);
            cbLab.Name = "cbLab";
            cbLab.Size = new System.Drawing.Size(250, 28);
            cbLab.TabIndex = 1;

            // 
            // lblDate
            // 
            lblDate.Location = new System.Drawing.Point(40, 90);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(120, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";

            // 
            // dtpDate
            // 
            dtpDate.Location = new System.Drawing.Point(180, 90);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(250, 27);
            dtpDate.TabIndex = 3;
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // 
            // lblTime
            // 
            lblTime.Location = new System.Drawing.Point(40, 140);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(120, 23);
            lblTime.TabIndex = 4;
            lblTime.Text = "Time:";

            // 
            // dtpTime
            // 
            dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
            dtpTime.Location = new System.Drawing.Point(180, 140);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new System.Drawing.Size(250, 27);
            dtpTime.TabIndex = 5;

            // 
            // btnReserve
            // 
            btnReserve.Location = new System.Drawing.Point(180, 200);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new System.Drawing.Size(120, 30);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = true;

            // 
            // DashboardUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tabControl);
            this.Name = "DashboardUser";
            this.Text = "Dashboard User";
            tabControl.ResumeLayout(false);
            tabMyReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyReservations).EndInit();
            panelMyReservationsButton.ResumeLayout(false);
            tabNewReservation.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
