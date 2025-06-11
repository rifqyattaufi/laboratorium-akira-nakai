namespace LabReservations.Forms
{
    partial class LoginForm
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
            username = new TextBox();
            password = new TextBox();
            loginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            registerButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(388, 303);
            username.Name = "username";
            username.Size = new Size(510, 27);
            username.TabIndex = 0;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(388, 383);
            password.Name = "password";
            password.Size = new Size(510, 27);
            password.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(589, 444);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 359);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 280);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 512);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Dont have account?";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(536, 508);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(552, 174);
            label4.Name = "label4";
            label4.Size = new Size(190, 46);
            label4.TabIndex = 15;
            label4.Text = "Login Form";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label4);
            Controls.Add(registerButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginButton);
            Controls.Add(password);
            Controls.Add(username);
            Name = "LoginForm";
            Text = "LabReservation";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Button loginButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button registerButton;
        private Label label4;
    }
}