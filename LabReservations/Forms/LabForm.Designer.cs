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
            dgvLabs = new System.Windows.Forms.DataGridView();
            gbForm = new System.Windows.Forms.GroupBox();
            btnSimpan = new System.Windows.Forms.Button();
            btnHapus = new System.Windows.Forms.Button();
            btnBatal = new System.Windows.Forms.Button();
            btnTambah = new System.Windows.Forms.Button();
            txtDesc = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvLabs).BeginInit();
            gbForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLabs
            // 
            dgvLabs.AllowUserToAddRows = false;
            dgvLabs.AllowUserToDeleteRows = false;
            dgvLabs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabs.Location = new System.Drawing.Point(441, 15);
            dgvLabs.Margin = new System.Windows.Forms.Padding(2);
            dgvLabs.MultiSelect = false;
            dgvLabs.Name = "dgvLabs";
            dgvLabs.ReadOnly = true;
            dgvLabs.RowHeadersWidth = 72;
            dgvLabs.Size = new System.Drawing.Size(810, 647);
            dgvLabs.TabIndex = 0;
            dgvLabs.CellClick += dgvLabs_CellClick;
            dgvLabs.Dock = System.Windows.Forms.DockStyle.Fill;
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
            gbForm.Location = new System.Drawing.Point(8, 8);
            gbForm.Margin = new System.Windows.Forms.Padding(2);
            gbForm.Name = "gbForm";
            gbForm.Padding = new System.Windows.Forms.Padding(2);
            gbForm.Size = new System.Drawing.Size(429, 647);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Laboratorium";
            gbForm.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new System.Drawing.Point(226, 383);
            btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new System.Drawing.Size(201, 87);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // btnHapus
            // 
            btnHapus.Location = new System.Drawing.Point(4, 382);
            btnHapus.Margin = new System.Windows.Forms.Padding(2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new System.Drawing.Size(221, 87);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            btnHapus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // btnBatal
            // 
            btnBatal.Location = new System.Drawing.Point(226, 292);
            btnBatal.Margin = new System.Windows.Forms.Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new System.Drawing.Size(203, 87);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            btnBatal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            // 
            // btnTambah
            // 
            btnTambah.Location = new System.Drawing.Point(0, 292);
            btnTambah.Margin = new System.Windows.Forms.Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new System.Drawing.Size(225, 87);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            btnTambah.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            // 
            // txtDesc
            // 
            txtDesc.Location = new System.Drawing.Point(0, 185);
            txtDesc.Margin = new System.Windows.Forms.Padding(2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(235, 87);
            txtDesc.TabIndex = 3;
            txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 149);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Deskripsi";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(0, 73);
            txtName.Margin = new System.Windows.Forms.Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(235, 27);
            txtName.TabIndex = 1;
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 38);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // LabForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 673);
            Controls.Add(dgvLabs);
            Controls.Add(gbForm);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "LabForm";
            Text = "LabForm";
            Load += LabForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLabs).EndInit();
            gbForm.ResumeLayout(false);
            gbForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLabs;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}
