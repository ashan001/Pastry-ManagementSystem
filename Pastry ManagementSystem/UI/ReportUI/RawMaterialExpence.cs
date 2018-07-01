using System;
using Dapper;
using Pastry_ManagementSystem.PrintReportUI;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.ExtraClassesToMapData;
using PMS.AdminPanel.ExtraClasses;

namespace Pastry_ManagementSystem.UI.ReportUI
{
    public partial class RawMaterialExpence : MetroFramework.Forms.MetroForm
    {
        public RawMaterialExpence()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RawMaterialExpence_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select RRH.receipt_No,RRH.item_name,RRH.date_received,ST.supp_ID,ST.company_Name,RMD.item_id,RMD.item_price,RMD.total_amount,RMD.quantity From supplier_table ST Inner Join received_raw_meterial_header_file RRH on RRH.supp_id=ST.supp_ID Inner Join recieved_raw_meterial_detailed_file RMD on RMD.receipt_no=RRH.receipt_No  where RRH.date_received Between '{dtp_FromDate.Value}' AND '{dtp_ToDate.Value}' ";
                        List<MapDataAndHideForRawMatExp> list = db.Query<MapDataAndHideForRawMatExp>(sql,commandType:CommandType.Text).ToList();
                        using (RawMaterial_ExpRepGen obj=new RawMaterial_ExpRepGen(list))
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select RRH.receipt_No,RRH.item_name,RRH.date_received,ST.supp_ID,ST.company_Name,RMD.item_id,RMD.item_price,RMD.total_amount,RMD.quantity From supplier_table ST Inner Join received_raw_meterial_header_file RRH on RRH.supp_id=ST.supp_ID Inner Join recieved_raw_meterial_detailed_file RMD on RMD.receipt_no=RRH.receipt_No  where RRH.date_received Between '{dtp_FromDate.Value}' AND '{dtp_ToDate.Value}' ";
                        mapDataAndHideForRawMatExpBindingSource.DataSource = db.Query<MapDataAndHideForRawMatExp>(sql, commandType: CommandType.Text).ToList();                       
                    }
                }

            }
            catch
            {
                throw;
            }
        }

        public void loadData()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = " Select RRH.receipt_No,RRH.item_name,RRH.date_received,ST.supp_ID,ST.company_Name,RMD.item_id,RMD.item_price,RMD.total_amount,RMD.quantity From supplier_table ST Inner Join received_raw_meterial_header_file RRH on RRH.supp_id=ST.supp_ID Inner Join recieved_raw_meterial_detailed_file RMD on RMD.receipt_no=RRH.receipt_No ";
                        mapDataAndHideForRawMatExpBindingSource.DataSource = db.Query<MapDataAndHideForRawMatExp>(sql, commandType: CommandType.Text).ToList();
                    }
                }

            }
            catch
            {
                throw;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            new UI.ManagerMenu().Show();
            this.Hide();
        }
    }
}
