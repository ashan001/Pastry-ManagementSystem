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
            Environment.Exit(0);
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            new ReceivedRawMaterialSscreen_Info().ShowDialog();
           
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            new UI.ReportUI.DailyItemReportScreen().Show();
            this.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            new UI.ReportUI.DailyFoodOrderReportScreen().Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            new UI.ReportUI.DailyIncomeReportScreen().Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new UI.ReportUI.RawMaterialExpence().Show();
            this.Hide();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            new UI.ReportUI.PurchasedRawMaterialReportScreen().Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1500);
            Environment.Exit(0);
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            new UI.CpuMonitor().Show();Hide();
        }
    }
}
