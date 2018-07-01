using Pastry_ManagementSystem.DB;
using System;
using System.Configuration;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.ExtraClassesToMapData;

namespace Pastry_ManagementSystem.UI.HelpScreens
{
    public partial class ItemHelpScreen : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string itemID { get; set; }
        public string itemName { get; set; }
        public string ItemDescription { get; set; }
        public string BatchID { get; set; }
        public double ItemPrice { get; set; }
        public string WarehouseCode { get; set; }
        public ItemHelpScreen()
        {
            InitializeComponent();
        }
        string sql;
      
        private void ItemHelpScreen_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        sql = "Select ItemID,Item_Name,item_Desc,batch_No,purchase_price,tot_purchases,warehouseCode From Item_File";
                        itemInfoBindingSource.DataSource = db.Query<ItemInfo>(sql,commandType:CommandType.Text);
                    }
                }
            }
            catch 
            {
                throw;
            }
        }
        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid1_CellContentDoubleClick(sender, e);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void grid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            itemID = (grid1.CurrentRow.Cells[0].Value).ToString();
            itemName =(grid1.CurrentRow.Cells[1].Value).ToString();
            BatchID = (grid1.CurrentRow.Cells[3].Value).ToString();
            ItemDescription = (grid1.CurrentRow.Cells[2].Value).ToString();
            ItemPrice = Convert.ToDouble(grid1.CurrentRow.Cells[7].Value);
            WarehouseCode = (grid1.CurrentRow.Cells[5].Value).ToString();
            Hide();

        }
    }
}
