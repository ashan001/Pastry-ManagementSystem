using MessageBoxControlCenter.MessageBoxes;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMS.AdminPanel.AdminObj;
using System.Text.RegularExpressions;
using PMS.AdminPanel.Validations;
using PMS.AdminPanel.ExtraClasses;

namespace PMS.AdminPanel.UI.Admin
{
    public partial class CreateLogin : Form
    {
        LoginObject obj = new LoginObject();

        public CreateLogin()
        {
            InitializeComponent();
            cmbEmployeeRole.Text = "Employee Role ??";
        }

        private void CreateLogin_Load(object sender, EventArgs e)
        {
            cmbValueLoad();
        }
        void cmbValueLoad()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Designation_Master_table";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            cmbEmployeeRole.Items.Add(reader["Designation_Type"].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }      
        public string _userName { get; set; }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            _userName = txtUserName.Text;
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            obj.EmployeeID = txtEmpID.Text;
        }

        private void cmbEmployeeRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.EmployeeRole = cmbEmployeeRole.SelectedItem.ToString();           
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            obj.UserName = txtUserName.Text;
            int result = obj.AvoidDuplicateUserName();

            if (result == 1)
            {
                MsgBox.Warning("user name already exist");
            }
            else
            {
                obj.UserName = _userName;
                groupBox2.Enabled = true;
            }
        }
        private string newpassword { get; set; }
        private string confirmPassword { get; set; }
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            newpassword = txtNewPassword.Text;
            if (newpassword == string.Empty)
                txtConfirmPassword.Clear();
            btnSubmit.Enabled = false;
            if (newpassword == txtConfirmPassword.Text)
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;


        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            confirmPassword = txtConfirmPassword.Text;
            if (newpassword == confirmPassword)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                if (txtConfirmPassword.Text != newpassword)
                {
                    //txt_confirmpass.Clear();
                    //txt_password.Focus();
                    btnSubmit.Enabled = false;
                }
                else
                    btnSubmit.Enabled = true;
            }

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Password = confirmPassword;

               int res= obj.save();
                if (res == 1)
                {
                    MsgBox.Show(res);
                }
                else
                {
                    MsgBox.Show(res);
                }
            
            }
            catch
            {
                MsgBox.Error("please check you parameter values");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
