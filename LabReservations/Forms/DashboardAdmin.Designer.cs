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

        private void InitializeComponent()
        {
            tabControl = new System.Windows.Forms.TabControl();
            tabSummary = new System.Windows.Forms.TabPage();
            lblTotalLabs = new System.Windows.Forms.Label();
            lblTotalUsers = new System.Windows.Forms.Label();
            tabLabs = new System.Windows.Forms.TabPage();
            dgvLabs = new System.Windows.Forms.DataGridView();
            panelLabsButton = new System.Windows.Forms.Panel();
            btnAddLab = new System.Windows.Forms.Button();
            tabUsers = new System.Windows.Forms.TabPage();
            dgvUsers = new System.Windows.Forms.DataGridView();
            panelUsersButton = new System.Windows.Forms.Panel();
            btnAddUser = new System.Windows.Forms.Button();

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
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Location = new System.Drawing.Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(800, 450);
            tabControl.TabIndex = 0;

            // 
            // tabSummary
            // 
            tabSummary.Controls.Add(lblTotalLabs);
            tabSummary.Controls.Add(lblTotalUsers);
            tabSummary.Location = new System.Drawing.Point(4, 29);
            tabSummary.Name = "tabSummary";
            tabSummary.Padding = new System.Windows.Forms.Padding(3);
            tabSummary.Size = new System.Drawing.Size(792, 417);
            tabSummary.TabIndex = 0;
            tabSummary.Text = "Summary";
            tabSummary.UseVisualStyleBackColor = true;

            // 
            // lblTotalLabs
            // 
            lblTotalLabs.Location = new System.Drawing.Point(20, 20);
            lblTotalLabs.Name = "lblTotalLabs";
            lblTotalLabs.Size = new System.Drawing.Size(200, 23);
            lblTotalLabs.TabIndex = 0;
            lblTotalLabs.Text = "Total Labs: 0";

            // 
            // lblTotalUsers
            // 
            lblTotalUsers.Location = new System.Drawing.Point(20, 60);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new System.Drawing.Size(200, 23);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "Total Users: 0";

            // 
            // tabLabs
            // 
            tabLabs.Controls.Add(dgvLabs);
            tabLabs.Controls.Add(panelLabsButton);
            tabLabs.Location = new System.Drawing.Point(4, 29);
            tabLabs.Name = "tabLabs";
            tabLabs.Padding = new System.Windows.Forms.Padding(3);
            tabLabs.Size = new System.Drawing.Size(792, 417);
            tabLabs.TabIndex = 1;
            tabLabs.Text = "Labs";
            tabLabs.UseVisualStyleBackColor = true;

            // 
            // dgvLabs
            // 
            dgvLabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabs.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvLabs.Location = new System.Drawing.Point(3, 3);
            dgvLabs.Name = "dgvLabs";
            dgvLabs.RowHeadersWidth = 51;
            dgvLabs.RowTemplate.Height = 29;
            dgvLabs.Size = new System.Drawing.Size(786, 371);
            dgvLabs.TabIndex = 0;

            // 
            // panelLabsButton
            // 
            panelLabsButton.Controls.Add(btnAddLab);
            panelLabsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelLabsButton.Height = 40;
            panelLabsButton.Location = new System.Drawing.Point(3, 374);
            panelLabsButton.Name = "panelLabsButton";
            panelLabsButton.Size = new System.Drawing.Size(786, 40);
            panelLabsButton.TabIndex = 1;

            // 
            // btnAddLab
            // 
            btnAddLab.Location = new System.Drawing.Point(10, 8);
            btnAddLab.Name = "btnAddLab";
            btnAddLab.Size = new System.Drawing.Size(100, 25);
            btnAddLab.TabIndex = 0;
            btnAddLab.Text = "Add Lab";
            btnAddLab.UseVisualStyleBackColor = true;

            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Controls.Add(panelUsersButton);
            tabUsers.Location = new System.Drawing.Point(4, 29);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new System.Windows.Forms.Padding(3);
            tabUsers.Size = new System.Drawing.Size(792, 417);
            tabUsers.TabIndex = 2;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;

            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsers.Location = new System.Drawing.Point(3, 3);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new System.Drawing.Size(786, 371);
            dgvUsers.TabIndex = 0;

            // 
            // panelUsersButton
            // 
            panelUsersButton.Controls.Add(btnAddUser);
            panelUsersButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelUsersButton.Height = 40;
            panelUsersButton.Location = new System.Drawing.Point(3, 374);
            panelUsersButton.Name = "panelUsersButton";
            panelUsersButton.Size = new System.Drawing.Size(786, 40);
            panelUsersButton.TabIndex = 1;

            // 
            // btnAddUser
            // 
            btnAddUser.Location = new System.Drawing.Point(10, 8);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(100, 25);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;

            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tabControl);
            this.Name = "DashboardAdmin";
            this.Text = "Dashboard Admin";
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
