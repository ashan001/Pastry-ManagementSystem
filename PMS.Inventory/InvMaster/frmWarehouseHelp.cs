using Dapper;
using MessageBoxControlCenter.MessageBoxes;
using PMS.Inventory.InvObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Inventory.InvMaster
{
    public partial class frmWarehouseHelp : Form
    {
        public string Warehouse { get; set; }
        public frmWarehouseHelp()
        {
            InitializeComponent();
        }

        private void frmWarehouseHelp_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Warehouse_Master";
                        warehouseObjBindingSource.DataSource = db.Query<WarehouseObj>(sql, commandType: CommandType.Text);
                    }
                }
            }
            catch (Exception ex)
            {
              
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Warehouse = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            Hide();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender,e);
        }
    }
}
