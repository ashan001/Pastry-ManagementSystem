using MessageBoxControlCenter.MessageBoxes;
using System;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.ExtraClassesToMapData;

namespace Pastry_ManagementSystem.UI.HelpScreens
{
    public partial class InvHelpScreen : MetroFramework.Forms.MetroForm
    {
        public string ItemCode { get; set; }
        public string sql { get; set; }
        public string ItemName { get; internal set; }
        public string WarehouseCode { get; set; }

        public InvHelpScreen()
        {
            InitializeComponent();
        }
        private void InvHelpScreen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        sql = "Select  Inv.InvITemCode,Inv.itemName,WT.reOrdeLvl,WT.required_lvl,WT.AvailableQty,Inv.warehouseCode From Inventory Inv Inner Join Warehouse_Transaction_Table WT on Inv.InvITemCode=WT.InvCode";
                        invetoryInfoBindingSource.DataSource = db.Query<InvetoryInfo>(sql,commandType:CommandType.Text);
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
            try
            {
                ItemCode = (dataGridView1.CurrentRow.Cells[0].Value).ToString().Trim();
                ItemName= (dataGridView1.CurrentRow.Cells[1].Value).ToString().Trim();
                WarehouseCode = (dataGridView1.CurrentRow.Cells[5].Value).ToString();
                Hide();
            }
            catch
            {
                throw;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender,e);
        }
    }
}
