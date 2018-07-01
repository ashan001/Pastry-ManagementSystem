using System;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS.AdminPanel.AdminObj;

namespace PMS.AdminPanel.UI.Admin
{
    public partial class ViewEmployeeID : Form
    {
        public ViewEmployeeID()
        {
            InitializeComponent();
        }

        //public string emp_ID { get; set; }
        //public string emp_Fname { get; set; }
        //public string emp_Lname { get; set; }
        //public string fix_ContactNo { get; set; }
        //public string mobileNo { get; set; }
        //public string Nic { get; set; }
        //public string Designation { get; set; }
        //public string email { get; set; }
        //public string dob { get; set; }
        //public int age { get; set; }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,dob,age From Employee_Master_Table where emp_Fname like '%{txtName.Text}%' OR emp_Lname like '%{txtName.Text}%'";
                        employeeDetaObjBindingSource.DataSource = db.Query<EmployeeDetaObj>(sql, commandType: CommandType.Text).ToList();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_empNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,dob,age From Employee_Master_Table where mobileNo like '%{txt_empNum.Text}%' OR fix_ContactNo like '%{txt_empNum.Text}%'";
                        employeeDetaObjBindingSource.DataSource = db.Query<EmployeeDetaObj>(sql, commandType: CommandType.Text).ToList();
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
