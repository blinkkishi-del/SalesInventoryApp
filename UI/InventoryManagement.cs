using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboardForm = new AdminDashboard();
            adminDashboardForm.Show();
            this.Hide();
        }
    }
}
