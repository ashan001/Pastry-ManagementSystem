using System;
using PMS.AdminPanel.ExtraClasses;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxControlCenter.MessageBoxes;
using System.Threading;

namespace Pastry_ManagementSystem.UI
{
    public partial class SystemAdminMenu : MetroFramework.Forms.MetroForm
    {
        public static string UserName { get; set; } = Login.UserName;
        public string _usrName { get; set; }
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

        private void updateEmp_Click(object sender, EventArgs e)
        {
            new UpdateEmployee().Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            new UpdateCustomerScreen().ShowDialog();
            
        }

        private void tile_itemRegister_Click(object sender, EventArgs e)
        {
            new ItemScreen().Show();
            this.Hide();
        }

        private void tile_customerRegister_Click(object sender, EventArgs e)
        {
            new CustomerRegister().ShowDialog();
           
        }

        private void tile_update_Item_Click(object sender, EventArgs e)
        {
            new UpdateItemForm().Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            new purchase_order_screen().Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (MsgBox.Question("Are you sure ,Do you want to exit from the system ?") == DialogResult.Yes)
                Environment.Exit(0);
            else
                this.Activate();


        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            new UI.ItemDetails().Show();
            this.Hide();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Thread.Sleep(2100);  // wait for a while
            }
            finally
            {
                new UI.RoutingToAdminBackPanel.RoutToBackPanel().Show(this);
                Cursor.Current = Cursors.Default;               
            }
           
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            new UI.RequiredItem().Show();
            this.Hide();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            new UI.ReceivedRawMaterialSscreen_Info().ShowDialog();
          
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            new UI.AvailableRawMaterialScreen().ShowDialog();           
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            new UI.ItemDetails().Show();
            this.Hide();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            new UI.IssueForm().Show();
            Hide();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            new UI.CpuMonitor().Show();
            Hide();
        }
    }
}
