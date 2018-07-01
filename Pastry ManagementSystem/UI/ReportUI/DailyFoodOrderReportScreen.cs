using System;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Pastry_ManagementSystem.Other;
using Pastry_ManagementSystem.PrintReportUI;

namespace Pastry_ManagementSystem.UI.ReportUI
{
    public partial class DailyFoodOrderReportScreen : MetroFramework.Forms.MetroForm
    {
        public DailyFoodOrderReportScreen()
        {
            InitializeComponent();
        }      
        private void btn_load_Click(object sender, EventArgs e)
        {
            if (dtp_date.Value !=null || txt_time.Text !=null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql;
                        sql = $"Select order_No,cus_No,Due_Date,Due_Time,foodName,item_price,quantity,totAmt From Food_Order_Header where order_Date='{dtp_date.Value}' OR Due_Time Like '%{txt_time.Text}%'";
                        foodDataBindingSource.DataSource = db.Query<FoodData>(sql, commandType: CommandType.Text);
                        btn_print.Enabled = true;
                    }
                }
            }
        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql;
                        sql = $"Select order_No,cus_No,Due_Date,Due_Time,foodName,item_price,quantity,totAmt From Food_Order_Header where Due_Time Like '%{txt_time.Text}%'";
                        foodDataBindingSource.DataSource = db.Query<FoodData>(sql, commandType: CommandType.Text);
                        btn_print.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                FoodData obj = foodDataBindingSource.Current as FoodData;
                if (obj != null)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            string sql = $"Select order_No,cus_No,Due_Date,Due_Time,foodName,item_price,quantity,totAmt From Food_Order_Header where Due_Time Like '%{txt_time.Text}%'";
                            List<ListFoodData> list = db.Query<ListFoodData>(sql, commandType: CommandType.Text).ToList();
                            using (PrintDailyFoodOrdRep print = new PrintDailyFoodOrdRep(list))
                            {
                                print.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            new ManagerMenu().Show();
            this.Hide();
        }
    }
}
