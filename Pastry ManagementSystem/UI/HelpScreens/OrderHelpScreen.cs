using System;
using Pastry_ManagementSystem.DB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI.HelpScreens
{
    public partial class OrderHelpScreen : MetroFramework.Forms.MetroForm
    {
        Database obj = new Database();
        public string OrderID { get; set; }
        public OrderHelpScreen()
        {
            InitializeComponent();
        }

        private void OrderHelpScreen_Load(object sender, EventArgs e)
        {
            try
            {
                string _sql = "select order_No,cus_No,foodName,Due_Date from  Food_Order_Header";
                dataGridView1.DataSource = obj.sendTable(_sql);
                obj.closeCon();
            }
            catch (Exception)
            {
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderID = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender,e);
        }
    }
}
