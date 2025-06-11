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
            dgvLabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabs.Location = new Point(694, 22);
            dgvLabs.Name = "dgvLabs";
            dgvLabs.RowHeadersWidth = 72;
            dgvLabs.Size = new Size(573, 693);
            dgvLabs.TabIndex = 0;
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
            gbForm.Location = new Point(12, 12);
            gbForm.Name = "gbForm";
            gbForm.Size = new Size(644, 703);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Laboratorium";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(339, 574);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(301, 130);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(6, 573);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(331, 130);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(339, 438);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(305, 130);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(0, 438);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(337, 130);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(0, 278);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(351, 129);
            txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 223);
            label2.Name = "label2";
            label2.Size = new Size(96, 30);
            label2.TabIndex = 2;
            label2.Text = "Deskripsi";
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(351, 35);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 57);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // LabForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 727);
            Controls.Add(gbForm);
            Controls.Add(dgvLabs);
            Name = "LabForm";
            Text = "LabForm";
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