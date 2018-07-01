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
    public partial class PrintDailyProductIncome : MetroFramework.Forms.MetroForm
    {
        public PrintDailyProductIncome()
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
                        string sql = $"Select reference_No,cus_id,ord_Id ,food_Name , OrdDate ,quantity, price , tot_Amt From Multiple_Food_Order_transaction where food_Name Like'%{txt_prodName.Text}%' OR OrdDate between '{dtp_FromDate.Value}' AND '{dtp_toDate.Value}'";
                        productDataBindingSource.DataSource = db.Query<ProductData>(sql, commandType: CommandType.Text);
                    btn_print.Enabled = true;
                    }
                }
        }

        private void txt_prodName_TextChanged(object sender, EventArgs e)
        {
            if (txt_prodName.Text !=null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select reference_No,cus_id,ord_Id ,food_Name , OrdDate ,quantity, price , tot_Amt From Multiple_Food_Order_transaction where food_Name Like'%{txt_prodName.Text}%'";
                        productDataBindingSource.DataSource = db.Query<ProductData>(sql, commandType: CommandType.Text);
                        btn_print.Enabled = true;
                    }
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            ProductData obj = productDataBindingSource.Current as ProductData;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select reference_No,cus_id,ord_Id ,food_Name , OrdDate ,quantity, price , tot_Amt From Multiple_Food_Order_transaction where food_Name Like'%{txt_prodName.Text}%' OR OrdDate  BETWEEN '{dtp_FromDate.Value}' AND '{dtp_toDate.Value}'";
                        List<TakeProductData> list = db.Query<TakeProductData>(sql, commandType: CommandType.Text).ToList();
                        using (PrintDailyProdIncome print = new PrintDailyProdIncome(list))
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
