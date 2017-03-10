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
    public partial class CashierMenu : MetroFramework.Forms.MetroForm
    {
        public CashierMenu()
        {
            InitializeComponent();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new CustomerRegister().Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new CustomerOrder().Show();
            this.Hide();
        }
    }
}
