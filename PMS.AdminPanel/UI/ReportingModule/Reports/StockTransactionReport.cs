using System;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS.AdminPanel.UI.ReportingModule.MapObjects;
using MessageBoxControlCenter.MessageBoxes;
using PMS.AdminPanel.UI.ReportingModule.PrintUI;

namespace PMS.AdminPanel.UI.ReportingModule.Reports
{
    public partial class StockTransactionReport : Form
    {
        public StockTransactionReport()
        {
            InitializeComponent();
        }
        private void StockTransactionReport_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select TT.TransactionReference,TT.itemCode,TT.warehouseCode,TT.TransactionType,TT.quantity,IT.Item_Name From TransactionTable TT Inner Join Item_File IT on TT.itemCode=IT.ItemID";
                        transactionObjectsBindingSource.DataSource = db.Query<TransactionObjects>(sql,commandType:CommandType.Text).ToList();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select TT.TransactionReference,TT.itemCode,TT.warehouseCode,TT.TransactionType,TT.quantity,IT.Item_Name From TransactionTable TT Inner Join Item_File IT on TT.itemCode=IT.ItemID where TT.TransDate Between '{dtp_FromDate.Value.ToShortDateString()}' AND '{dtp_ToDate.Value.ToShortDateString()}'";
                        transactionObjectsBindingSource.DataSource = db.Query<TransactionObjects>(sql, commandType: CommandType.Text).ToList();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void dtp_FromDate_ValueChanged(object sender, EventArgs e)
        {
            sortOnDate(dtp_FromDate.Value.ToShortDateString());
        }
        void sortOnDate(string val)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql =$"Select TT.TransactionReference,TT.itemCode,TT.warehouseCode,TT.TransactionType,TT.quantity,IT.Item_Name From TransactionTable TT Inner Join Item_File IT on TT.itemCode=IT.ItemID where TT.TransDate='{val}'";
                        transactionObjectsBindingSource.DataSource = db.Query<TransactionObjects>(sql, commandType: CommandType.Text).ToList();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void dtp_ToDate_ValueChanged(object sender, EventArgs e)
        {
            sortOnDate(dtp_ToDate.Value.ToShortDateString());
        }
        public string SelectedDateRange { get; set; }
        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedDateRange = dtp_FromDate.Value.ToShortDateString() + " To " + dtp_ToDate.Value.ToShortDateString();
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select TT.TransactionReference,TT.itemCode,TT.warehouseCode,TT.TransactionType,TT.quantity,IT.Item_Name From TransactionTable TT Inner Join Item_File IT on TT.itemCode=IT.ItemID where TT.TransDate Between '{dtp_FromDate.Value.ToShortDateString()}' AND '{dtp_ToDate.Value.ToShortDateString()}'";
                        List<TransactionObjects> list = db.Query<TransactionObjects>(sql, commandType:CommandType.Text).ToList();
                        using (TrascationUI_Rep obj=new TrascationUI_Rep(list, SelectedDateRange))
                        {
                            obj.ShowDialog();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
    }
}
