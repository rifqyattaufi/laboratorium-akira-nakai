namespace LabReservations.Forms
{
    partial class DashboardAdmin
    {
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabLabs;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Label lblTotalLabs;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.DataGridView dgvLabs;
        private System.Windows.Forms.Button btnAddLab;
        private System.Windows.Forms.Panel panelLabsButton;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panelUsersButton;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabSummary = new TabPage();
            lblTotalLabs = new Label();
            lblTotalUsers = new Label();
            tabLabs = new TabPage();
            dgvLabs = new DataGridView();
            panelLabsButton = new Panel();
            btnAddLab = new Button();
            tabUsers = new TabPage();
            dgvUsers = new DataGridView();
            panelUsersButton = new Panel();
            btnAddUser = new Button();
            tabControl.SuspendLayout();
            tabSummary.SuspendLayout();
            tabLabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLabs).BeginInit();
            panelLabsButton.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelUsersButton.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSummary);
            tabControl.Controls.Add(tabLabs);
            tabControl.Controls.Add(tabUsers);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabSummary
            // 
            tabSummary.Controls.Add(lblTotalLabs);
            tabSummary.Controls.Add(lblTotalUsers);
            tabSummary.Location = new Point(4, 29);
            tabSummary.Name = "tabSummary";
            tabSummary.Padding = new Padding(3);
            tabSummary.Size = new Size(792, 417);
            tabSummary.TabIndex = 0;
            tabSummary.Text = "Summary";
            tabSummary.UseVisualStyleBackColor = true;
            // 
            // lblTotalLabs
            // 
            lblTotalLabs.Location = new Point(20, 20);
            lblTotalLabs.Name = "lblTotalLabs";
            lblTotalLabs.Size = new Size(200, 23);
            lblTotalLabs.TabIndex = 0;
            lblTotalLabs.Text = "Total Labs: 0";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.Location = new Point(20, 60);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(200, 23);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "Total Users: 0";
            // 
            // tabLabs
            // 
            tabLabs.Controls.Add(dgvLabs);
            tabLabs.Controls.Add(panelLabsButton);
            tabLabs.Location = new Point(4, 29);
            tabLabs.Name = "tabLabs";
            tabLabs.Padding = new Padding(3);
            tabLabs.Size = new Size(792, 417);
            tabLabs.TabIndex = 1;
            tabLabs.Text = "Labs";
            tabLabs.UseVisualStyleBackColor = true;
            // 
            // dgvLabs
            // 
            dgvLabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabs.Dock = DockStyle.Fill;
            dgvLabs.Location = new Point(3, 3);
            dgvLabs.Name = "dgvLabs";
            dgvLabs.RowHeadersWidth = 51;
            dgvLabs.Size = new Size(786, 371);
            dgvLabs.TabIndex = 0;

            tabLabs.Controls.Add(dgvLabs);
            tabLabs.Controls.Add(panelLabsButton);

            // Tambahkan DataGridView untuk reservations
            dgvReservations = new DataGridView();
            dgvReservations.Dock = DockStyle.Bottom;
            dgvReservations.Height = 150;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabLabs.Controls.Add(dgvReservations);

            // Tambahkan tombol Approve dan Reject
            btnApprove = new Button();
            btnApprove.Text = "Approve";
            btnApprove.Location = new Point(120, 8);
            btnApprove.Size = new Size(100, 25);

            btnReject = new Button();
            btnReject.Text = "Reject";
            btnReject.Location = new Point(230, 8);
            btnReject.Size = new Size(100, 25);

            panelLabsButton.Controls.Add(btnApprove);
            panelLabsButton.Controls.Add(btnReject);
            // 
            // panelLabsButton
            // 
            panelLabsButton.Controls.Add(btnAddLab);
            panelLabsButton.Dock = DockStyle.Bottom;
            panelLabsButton.Location = new Point(3, 374);
            panelLabsButton.Name = "panelLabsButton";
            panelLabsButton.Size = new Size(786, 40);
            panelLabsButton.TabIndex = 1;
            // 
            // btnAddLab
            // 
            btnAddLab.Location = new Point(10, 8);
            btnAddLab.Name = "btnAddLab";
            btnAddLab.Size = new Size(100, 25);
            btnAddLab.TabIndex = 0;
            btnAddLab.Text = "Add Lab";
            btnAddLab.UseVisualStyleBackColor = true;
            btnAddLab.Click += btnAddLab_Click;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Controls.Add(panelUsersButton);
            tabUsers.Location = new Point(4, 29);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(792, 417);
            tabUsers.TabIndex = 2;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(3, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(786, 371);
            dgvUsers.TabIndex = 0;
            // 
            // panelUsersButton
            // 
            panelUsersButton.Controls.Add(btnAddUser);
            panelUsersButton.Dock = DockStyle.Bottom;
            panelUsersButton.Location = new Point(3, 374);
            panelUsersButton.Name = "panelUsersButton";
            panelUsersButton.Size = new Size(786, 40);
            panelUsersButton.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(10, 8);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 25);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "DashboardAdmin";
            Text = "Dashboard Admin";
            tabControl.ResumeLayout(false);
            tabSummary.ResumeLayout(false);
            tabLabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLabs).EndInit();
            panelLabsButton.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelUsersButton.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
