using System;
using System.Data;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.ExtraClassesToMapData;
using Pastry_ManagementSystem.DB;

namespace Pastry_ManagementSystem.UI.HelpScreens
{
    public partial class WarehouseHelpScreen : MetroFramework.Forms.MetroForm
    {
        public string WarehouseCode { get; set; }
        public WarehouseHelpScreen()
        {
            InitializeComponent();
        }

        private void WarehouseHelpScreen_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Warehouse_Master";
                        warehouseInfoBindingSource.DataSource = db.Query<WarehouseInfo>(sql, commandType: CommandType.Text);
                    }
                }             
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
    
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WarehouseCode = (dataGridView1.CurrentRow.Cells[0].Value).ToString().Trim();
            Hide();
        }
        //void test()
        //{
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        if (row.Selected)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                int index = cell.ColumnIndex;
        //                if (index == 0)
        //                {
        //                    WarehouseCode = cell.Value.ToString();
        //                    //do what you want with the value
        //                }
        //            }
        //        }
        //    }
        //}

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender,e);
        }
    }
}
