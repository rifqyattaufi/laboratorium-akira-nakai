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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            btnAddLab.Click += btnAddLab_Click;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            
            var labForm = new LabForm();
            labForm.ShowDialog();
        }
    }
}
