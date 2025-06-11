﻿using LabReservation.Domain;
using LabReservation.Services;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.AcceptButton = registerButton;
            this.password.UseSystemPasswordChar = true;
            this.confirmPassword.UseSystemPasswordChar = true;
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string uname = username.Text.Trim();
            string pass = password.Text;
            string confirmPass = confirmPassword.Text;

            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userService = new UserService();
            bool result = userService.Register(uname, pass, "user");

            if (result)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already registered.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
