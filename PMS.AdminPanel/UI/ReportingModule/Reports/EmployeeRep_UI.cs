using System;
using PMS.AdminPanel.UI.ReportingModule.PrintUI;
using Dapper;
using System.Configuration;
using PMS.AdminPanel.UI.ReportingModule.MapObjects;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PMS.AdminPanel.UI.ReportingModule.Reports
{
    public partial class EmployeeRep_UI : Form
    {
        public EmployeeRep_UI()
        {
            InitializeComponent();
        }

        private void EmployeeRep_UI_Load(object sender, EventArgs e)
        {
            loadData();
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
                        string sql = "Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,age,empAddress,basicSalry,regDate From Employee_Master_Table";
                        employeeDetailsBindingSource.DataSource = db.Query<EmployeeDetails>(sql, commandType: CommandType.Text).ToList();

                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void btn_genRep_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State==ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,age,empAddress,basicSalry,regDate From Employee_Master_Table where regDate Between '{dtpFromDate.Value.ToString().Substring(0, 9)}' AND '{dtp_ToDate.Value.ToString().Substring(0, 9)}' ";
                        //string sql = $"Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,age,empAddress,basicSalry From Employee_Master_Table where regDate Between '{dtpFromDate.Value}' AND '{dtp_ToDate.Value}'";
                        //string sql="";//dummy
                        List<EmployeeDetails> list = db.Query<EmployeeDetails>(sql, commandType: CommandType.Text).ToList();
                        using (EmployeeRepUI obj=new EmployeeRepUI(list))
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,age,empAddress,basicSalry,regDate From Employee_Master_Table where regDate Between '{dtpFromDate.Value.ToString().Substring(0,9)}' AND '{dtp_ToDate.Value.ToString().Substring(0,9)}' ";
                        employeeDetailsBindingSource.DataSource = db.Query<EmployeeDetails>(sql, commandType: CommandType.Text).ToList();
                        btn_genRep.Enabled = true;
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
