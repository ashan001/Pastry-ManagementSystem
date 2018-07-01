using System;
using Dapper;
using MessageBoxControlCenter.MessageBoxes;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using PMS.AdminPanel.UI.ReportingModule.MapObjects;
using PMS.AdminPanel.UI.ReportingModule.PrintUI;

namespace PMS.AdminPanel.UI.ReportingModule.Reports
{
    public partial class CustomerRep_UI : Form
    {
        public CustomerRep_UI()
        {
            InitializeComponent();
        }

        private void CustomerRep_UI_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select CT.cusID,Ct.FirstName,CT.LastName,CT.ContactNum,CT.cus_address,CT.regDate,FOH.quantity,FOH.totAmt,FOH.OrderedTimes_Flag From Customer_Table CT Inner Join Food_Order_Header FOH on CT.cusID=FOH.cus_No";
                        customerDetailsBindingSource.DataSource = db.Query<CustomerDetails>(sql,commandType:CommandType.Text).ToList();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        string sql = $"Select CT.cusID,Ct.FirstName,CT.LastName,CT.ContactNum,CT.cus_address,CT.regDate,FOH.quantity,FOH.totAmt,FOH.OrderedTimes_Flag From Customer_Table CT Inner Join Food_Order_Header FOH on CT.cusID=FOH.cus_No where regDate BETWEEN '{dtp_FromDate.Value.ToString().Substring(0, 9)}' AND '{dtp_ToDate.Value.ToString().Substring(0, 9)}'";
                        List<CustomerDetails> list = db.Query<CustomerDetails>(sql, commandType: CommandType.Text).ToList();
                        using (CustomerUI obj = new CustomerUI(list))
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
        private void loadData()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select CT.cusID,Ct.FirstName,CT.LastName,CT.ContactNum,CT.cus_address,CT.regDate,FOH.quantity,FOH.totAmt,FOH.OrderedTimes_Flag From Customer_Table CT Inner Join Food_Order_Header FOH on CT.cusID=FOH.cus_No where regDate BETWEEN '{dtp_FromDate.Value.ToString().Substring(0, 9)}' AND '{dtp_ToDate.Value.ToString().Substring(0, 9)}'";
                        customerDetailsBindingSource.DataSource = db.Query<CustomerDetails>(sql, commandType: CommandType.Text).ToList();
                        btn_print.Enabled = true;
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
            loadData();
        }
    }
}
