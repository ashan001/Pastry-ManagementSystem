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
    public partial class SystemAdminMenu : MetroFramework.Forms.MetroForm
    {
        public SystemAdminMenu()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new EmployeeRegister().Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new SupplierRegister().Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new UpdateSupplier().Show();
            this.Hide();
        }
    }
}
