using System;
using Pastry_ManagementSystem.ExtraClassesToMapData;
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
using Pastry_ManagementSystem.PrintReportUI;

namespace Pastry_ManagementSystem.UI.ReportUI
{
    public partial class PurchasedRawMaterialReportScreen : MetroFramework.Forms.MetroForm
    {
        public PurchasedRawMaterialReportScreen()
        {
            InitializeComponent();
        }

        private void PurchasedRawMaterialReportScreen_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select po.pur_id,po.emp_id,po.Suppllier_company_name,po.v_date,po.due_date,pod.item_id,pod.order_qty From purchase_order_header_file po inner join purchase_order_detailed_file pod on po.pur_id=pod.purchase_id";
                        purchaseDetailsBindingSource.DataSource = db.Query<PurchaseDetails>(sql,commandType:CommandType.Text).ToList();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new UI.ManagerMenu().Show();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select po.pur_id,po.emp_id,po.Suppllier_company_name,po.v_date,po.due_date,pod.item_id,pod.order_qty From purchase_order_header_file po inner join purchase_order_detailed_file pod on po.pur_id=pod.purchase_id where v_date Between '{_dtpFrmDate.Value}'AND '{_dtpToDate.Value}' ";
                        purchaseDetailsBindingSource.DataSource = db.Query<PurchaseDetails>(sql, commandType: CommandType.Text).ToList();
                        btn_print.Enabled = true;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select po.pur_id,po.emp_id,po.Suppllier_company_name,po.v_date,po.due_date,pod.item_id,pod.order_qty From purchase_order_header_file po inner join purchase_order_detailed_file pod on po.pur_id=pod.purchase_id where v_date Between '{_dtpFrmDate.Value}'AND '{_dtpToDate.Value}' ";
                        List<PurchaseDetails> list = db.Query<PurchaseDetails>(sql,commandType:CommandType.Text).ToList();
                        using (PurchaseRawMat_UI obj=new PurchaseRawMat_UI(list))
                        {
                            obj.ShowDialog();
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
