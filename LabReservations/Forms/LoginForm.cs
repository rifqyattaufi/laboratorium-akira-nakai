﻿using LabReservation.Domain;
using LabReservation.Services;
using LabReservations.Utils;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = loginButton;
            this.password.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string uname = username.Text.Trim();
            string pass = password.Text;

            var userService = new UserService();
            LabReservation.Domain.User userData = userService.Login(uname, pass); // Fully qualify 'User' to resolve ambiguity

            if (userData != null)
            {
                UserSession.Instance.User = userData;
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;

                Form dashboardForm;
                if (userData.Role == "admin")
                {
                    dashboardForm = new DashboardAdmin();
                }
                else
                {
                    dashboardForm = new DashboardUser(userData);
                }

                this.Hide();
                dashboardForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
