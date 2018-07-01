using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Pastry_ManagementSystem.Other;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.PrintReportUI;

namespace Pastry_ManagementSystem.UI.ReportUI
{
    public partial class DailyIncomeReportScreen : MetroFramework.Forms.MetroForm
    {
        public DailyIncomeReportScreen()
        {
            InitializeComponent();
           
        }
     
        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
             
              using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
              {
                  if (db.State == ConnectionState.Closed)
                   {
                        db.Open();
                        string _sql = $"Select soh.bill_no,soh._empID,sod.food_no,soh.sub_total,soh.bill_gst,soh.bill_tot From Sales_Order_header_file soh Inner Join Sales_order_detailed_file sod on soh.bill_no =sod.bill_no where v_date ='{dtp_Date.Value.ToString().Substring(0,9)}'";
                        dailyIncomeClassBindingSource.DataSource = db.Query<Pastry_ManagementSystem.Other.DailyIncomeClass>(_sql, commandType: CommandType.Text);
                        metroButton2.Enabled = true;
                    }
              }
           }   
            catch (Exception)
            {

            }
        }

        private void DailyIncomeReportScreen_Load(object sender, EventArgs e)
        {
            try
            {
              using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                 {
                    if (db.State == ConnectionState.Closed)
                      {
                        db.Open();
                        string _sql = $"Select soh.bill_no,soh._empID,sod.food_no,soh.sub_total,soh.bill_gst,soh.bill_tot From Sales_Order_header_file soh Inner Join Sales_order_detailed_file sod on soh.bill_no =sod.bill_no";
                        dailyIncomeClassBindingSource.DataSource = db.Query<Pastry_ManagementSystem.Other.DailyIncomeClass>(_sql, commandType: CommandType.Text);
                     }
                  }               
            }
            catch
            {
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new ManagerMenu().Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DailyIncomeClass obj = new DailyIncomeClass();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string _sql = $"Select soh.bill_no,soh._empID,sod.food_no,soh.sub_total,soh.bill_gst,soh.bill_tot From Sales_Order_header_file soh Inner Join Sales_order_detailed_file sod on soh.bill_no =sod.bill_no where v_date ='{dtp_Date.Value.ToString().Substring(0, 9)}'";
                        List<DailyIncomeClass> list = db.Query<DailyIncomeClass>(_sql, commandType: CommandType.Text).ToList();
                        using (PrintDailyIncomeRep obj1 =new PrintDailyIncomeRep(list))
                        {
                            obj1.ShowDialog();
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
