using MessageBoxControlCenter.MessageBoxes;
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
using System.Windows.Forms;
using PMS.AdminPanel.Validations;
using PMS.AdminPanel.ExtraClasses;

namespace PMS.AdminPanel.UI.User
{
    public partial class frmChangePassword : Form
    {
        ChangePassProp obj = new ChangePassProp();
        CheckUser chkObj = new CheckUser();
        public frmChangePassword()
        {
            InitializeComponent();
            
        }

        private void btn_chngPass_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        DynamicParameters p = new DynamicParameters();
                        p.AddDynamicParams(new {                           
                            userName=obj.userName,
                            usrPassword = obj.userPassword });
                        int result = db.Execute("sp_Emp_Login_update", p, commandType: CommandType.StoredProcedure);
                        if (result == 1)
                        {
                            MsgBox.Show(6);
                        }
                        else
                            MsgBox.Show(3);
                    }
                    else
                        MsgBox.Warning("Please check database connection");
                }
            }
            catch
            {
                /*throw*/;
                MsgBox.Error("Invalid Employee ID");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_userName_TextChanged(object sender, EventArgs e)
        {
            obj.userName = txt_userName.Text;
        }
        public string newPassword { get; set; }
        //public string confirmPassword { get; set; }
        private void txt_newPassword_TextChanged(object sender, EventArgs e)
        {
            newPassword = txt_newPassword.Text;
            if (newPassword != txt_confirmPassword.Text)
            {
                btn_chngPass.Enabled = false;
                return;
            }
            if(newPassword ==txt_confirmPassword.Text)
            {
                btn_chngPass.Enabled = true;
                return;
            }
            if (newPassword == string.Empty)
            {
                btn_chngPass.Enabled = false;
                txt_newPassword.Focus();
            }
        }

        private void txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            //confirmPassword = txt_confirmPassword.Text;
            obj.userPassword = txt_confirmPassword.Text;
            if (newPassword == obj.userPassword)
            {
                btn_chngPass.Enabled = true;
                return;
            }
            if(newPassword !=obj.userPassword)
            {
                btn_chngPass.Enabled = false;
                return;
            }
            if (txt_confirmPassword.Text == null)
            {
                btn_chngPass.Enabled = false;
                return;
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkObj.ChkUser();
                e.SuppressKeyPress = true;
               
            }
        }
        private void txt_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                chkObj.ChkUser();
                if (chkObj.flagged == 1)
                {
                    txt_newPassword.Enabled = true;
                    txt_confirmPassword.Enabled = true;
                    txt_newPassword.Focus();
                }
                else
                {
                    txt_newPassword.Enabled = false;
                    txt_confirmPassword.Enabled = false;
                }
            }
        }

        private void txt_newPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_confirmPassword.Focus();
            }
        }

        private void txt_confirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_chngPass.Focus();
            }
        }
    }
}
