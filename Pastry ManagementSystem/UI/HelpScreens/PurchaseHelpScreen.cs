using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI.HelpScreens
{
    public partial class PurchaseHelpScreen : MetroFramework.Forms.MetroForm
    {
        public string PurchaseOrder { get; set; }
        Database db = new Database();
        public PurchaseHelpScreen()
        {
            InitializeComponent();
        }

        private void PurchaseHelpScreen_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From purchase_order_header_file";
                dataGridView1.DataSource = db.sendTable(sql);
                db.closeCon();
            }
            catch (Exception)
            {
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void PurchaseHelpScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseOrder = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender,e);
        }
    }
}
