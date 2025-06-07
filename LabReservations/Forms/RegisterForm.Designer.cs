namespace LabReservations.Forms
{
    partial class RegisterForm
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
            loginButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            registerButton = new Button();
            password = new TextBox();
            username = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(560, 436);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 13;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 440);
            label3.Name = "label3";
            label3.Size = new Size(178, 20);
            label3.TabIndex = 12;
            label3.Text = "Already have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 208);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 287);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.Text = "Password";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(577, 372);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // password
            // 
            password.Location = new Point(376, 311);
            password.Name = "password";
            password.Size = new Size(510, 27);
            password.TabIndex = 8;
            // 
            // username
            // 
            username.Location = new Point(376, 231);
            username.Name = "username";
            username.Size = new Size(510, 27);
            username.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(517, 102);
            label4.Name = "label4";
            label4.Size = new Size(228, 46);
            label4.TabIndex = 14;
            label4.Text = "Register Form";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label4);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(password);
            Controls.Add(username);
            Name = "RegisterForm";
            Text = "LabReservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button registerButton;
        private TextBox password;
        private TextBox username;
        private Label label4;
    }
}