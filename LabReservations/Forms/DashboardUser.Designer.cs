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
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabMyReservations = new TabPage();
            dgvMyReservations = new DataGridView();
            panelMyReservationsButton = new Panel();
            btnCancelReservation = new Button();
            lblWelcome = new Label();
            tabNewReservation = new TabPage();
            lblLab = new Label();
            cbLab = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            btnReserve = new Button();
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
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 363);
            tabControl.TabIndex = 0;
            // 
            // tabMyReservations
            // 
            tabMyReservations.Controls.Add(dgvMyReservations);
            tabMyReservations.Controls.Add(panelMyReservationsButton);
            tabMyReservations.Controls.Add(lblWelcome);
            tabMyReservations.Location = new Point(4, 29);
            tabMyReservations.Name = "tabMyReservations";
            tabMyReservations.Padding = new Padding(3);
            tabMyReservations.Size = new Size(792, 330);
            tabMyReservations.TabIndex = 0;
            tabMyReservations.Text = "My Reservations";
            tabMyReservations.UseVisualStyleBackColor = true;
            // 
            // dgvMyReservations
            // 
            dgvMyReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyReservations.Dock = DockStyle.Fill;
            dgvMyReservations.Location = new Point(3, 3);
            dgvMyReservations.Name = "dgvMyReservations";
            dgvMyReservations.RowHeadersWidth = 51;
            dgvMyReservations.Size = new Size(786, 284);
            dgvMyReservations.TabIndex = 1;
            // 
            // panelMyReservationsButton
            // 
            panelMyReservationsButton.Controls.Add(btnCancelReservation);
            panelMyReservationsButton.Dock = DockStyle.Bottom;
            panelMyReservationsButton.Location = new Point(3, 287);
            panelMyReservationsButton.Name = "panelMyReservationsButton";
            panelMyReservationsButton.Size = new Size(786, 40);
            panelMyReservationsButton.TabIndex = 2;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.Location = new Point(10, 8);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(150, 25);
            btnCancelReservation.TabIndex = 0;
            btnCancelReservation.Text = "Cancel Reservation";
            btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(20, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(400, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [User]";
            // 
            // tabNewReservation
            // 
            tabNewReservation.Controls.Add(lblLab);
            tabNewReservation.Controls.Add(cbLab);
            tabNewReservation.Controls.Add(lblDate);
            tabNewReservation.Controls.Add(dtpDate);
            tabNewReservation.Controls.Add(lblStartTime);
            tabNewReservation.Controls.Add(dtpStartTime);
            tabNewReservation.Controls.Add(lblEndTime);
            tabNewReservation.Controls.Add(dtpEndTime);
            tabNewReservation.Controls.Add(btnReserve);
            tabNewReservation.Location = new Point(4, 29);
            tabNewReservation.Name = "tabNewReservation";
            tabNewReservation.Padding = new Padding(3);
            tabNewReservation.Size = new Size(792, 417);
            tabNewReservation.TabIndex = 1;
            tabNewReservation.Text = "New Reservation";
            tabNewReservation.UseVisualStyleBackColor = true;
            // 
            // lblLab
            // 
            lblLab.Location = new Point(40, 40);
            lblLab.Name = "lblLab";
            lblLab.Size = new Size(120, 23);
            lblLab.TabIndex = 0;
            lblLab.Text = "Laboratory:";
            // 
            // cbLab
            // 
            cbLab.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLab.Location = new Point(180, 40);
            cbLab.Name = "cbLab";
            cbLab.Size = new Size(250, 28);
            cbLab.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(40, 90);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(120, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(180, 90);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 3;
            // 
            // lblStartTime
            // 
            lblStartTime.Location = new Point(40, 140);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(120, 23);
            lblStartTime.TabIndex = 4;
            lblStartTime.Text = "Start Time:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(180, 140);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(250, 27);
            dtpStartTime.TabIndex = 5;
            // 
            // lblEndTime
            // 
            lblEndTime.Location = new Point(40, 190);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(120, 23);
            lblEndTime.TabIndex = 6;
            lblEndTime.Text = "End Time:";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(180, 190);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(250, 27);
            dtpEndTime.TabIndex = 7;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(180, 240);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(120, 30);
            btnReserve.TabIndex = 8;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = true;
            // 
            // DashboardUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 363);
            Controls.Add(tabControl);
            Name = "DashboardUser";
            Text = "Dashboard User";
            tabControl.ResumeLayout(false);
            tabMyReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyReservations).EndInit();
            panelMyReservationsButton.ResumeLayout(false);
            tabNewReservation.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
