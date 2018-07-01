using Dapper;
using Pastry_ManagementSystem.Other;
using Pastry_ManagementSystem.PrintReportUI;
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

namespace Pastry_ManagementSystem.UI.ReportUI
{
    public partial class DailyItemReportScreen : MetroFramework.Forms.MetroForm
    {
        public DailyItemReportScreen()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    //string sql = $"Select ItemID ,empID,warehouseCode ,Item_Name ,Available_Qty ,purchase_price ,Vat_Amt ,tot_purchases ,net_Amt  From Item_File where Item_Name Like '%{txt_itemName.Text}%' OR date_and_time = '{dtp_date.Value}'";
                    string sql = $"Select  IT.ItemID,IT.Item_Name,IT.batch_No,IT.empID,IT.warehouseCode,IT.Vat_Amt,IT.tot_purchases,IT.net_Amt,WT.AvailableQty From Item_File IT Inner Join Warehouse_Transaction_Table WT on WT.warehouseCode=IT.warehouseCode where Item_Name Like '%{txt_itemName.Text}%' OR date_and_time = '{dtp_date.Value}'";
                    itemClassBindingSource.DataSource = db.Query<ItemClass>(sql, commandType: CommandType.Text);
                    btn_print.Enabled = true;
                }
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_itemName_TextChanged(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    //string sql = $"Select item_id ,empID ,Item_Name ,Available_Qty ,purchase_price ,Vat_Amt ,tot_purchases ,net_Amt  From Item_Table where Item_Name Like '%{txt_itemName.Text}%'";
                    string sql = $"Select  IT.ItemID,IT.Item_Name,IT.batch_No,IT.empID,IT.warehouseCode,IT.Vat_Amt,IT.tot_purchases,IT.net_Amt,WT.AvailableQty From Item_File IT Inner Join Warehouse_Transaction_Table WT on WT.warehouseCode=IT.warehouseCode where Item_Name Like '%{txt_itemName.Text}%'";
                    itemClassBindingSource.DataSource = db.Query<ItemClass>(sql, commandType: CommandType.Text);
                    btn_print.Enabled = true;
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            ItemClass obj = itemClassBindingSource.Current as ItemClass;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        // string sql = $"Select item_id ,empID ,Item_Name ,Available_Qty ,purchase_price ,Vat_Amt ,tot_purchases ,net_Amt  From Item_Table where Item_Name Like '%{txt_itemName.Text}%' OR date_and_time = '{dtp_date.Value}'";
                        string sql = $"Select  IT.ItemID,IT.Item_Name,IT.batch_No,IT.empID,IT.warehouseCode,IT.Vat_Amt,IT.tot_purchases,IT.net_Amt,WT.AvailableQty From Item_File IT Inner Join Warehouse_Transaction_Table WT on WT.warehouseCode=IT.warehouseCode where Item_Name Like '%{txt_itemName.Text}%' OR date_and_time = '{dtp_date.Value}'";
                        List<MapItemData> list = db.Query<MapItemData>(sql, commandType: CommandType.Text).ToList();
                        using (PrintDailyItemRep print = new PrintDailyItemRep(list))
                        {
                            print.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new UI.ManagerMenu().Show();
            this.Hide();
        }
    }
}
