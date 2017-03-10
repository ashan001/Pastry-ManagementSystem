using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class ManagerMenu : MetroFramework.Forms.MetroForm
    {
      
        public ManagerMenu()
        {
           
            InitializeComponent();
        }
        private void ManagerMenu_Load(object sender, EventArgs e)
        {
          


        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            new SupplierDetails().Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new EmployeeDetails().Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
