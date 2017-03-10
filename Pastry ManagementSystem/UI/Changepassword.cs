using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class Changepassword : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        protected SqlDataReader dataReader;
        private string v_empId { get; set; }
        private string confirm_password { get; set; }
        private string v_email { get; set; }
        private string new_password { get; set; }
        protected string  userVerification { get; set; }
        public Changepassword()
        {
            InitializeComponent();
        }

        private void txt_verification_TextChanged(object sender, EventArgs e)
        {
            userVerification = txt_verification.Text;
            try
            {
                if (userVerification.Length == 0)
                {
                    error_verfication.SetError(txt_verification, "Your  verification is required");
                    db.closeCon();
                    txt_newPassword.Visible = false;
                    txt_confirmPass.Visible = false;
                    userVerification = null;
                }
                else
                {
                    string sql = null;
                    for (int i = 0; i <=userVerification.Length; i++)
                    {
                        db.closeCon();
                    }//check whether that verification is still editing or not  

                    sql = "Select * from Emp_Login where employeeID='" + userVerification + "' OR user_email='" + userVerification + "'";
                    dataReader = db.getData(sql);
                    while (dataReader.Read())
                    {
                        v_empId = dataReader["employeeID"].ToString();
                        v_email = dataReader["user_email"].ToString();
                    }
               
                    if (v_empId.Equals(userVerification) || v_email.Equals(userVerification))
                    {
                        txt_newPassword.Visible = true;
                        txt_confirmPass.Visible = true;
                        txt_newPassword.Enabled = true;
                        txt_confirmPass.Enabled = true;
                        error_verfication.Clear();
                    }
                    else if (!(v_empId.Equals(userVerification) || v_email.Equals(userVerification)))
                    {
                        txt_newPassword.Enabled = false;
                        txt_confirmPass.Enabled = false;
                        error_verfication.SetError(txt_verification, "Please check your verification and try again");
                    }
                }

            }
            catch (Exception)
            {


            }
        }

        private void txt_newPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new_password = txt_newPassword.Text.ToString();

                //check whecther the password weak or strong
                if (new_password.Length == 0)
                {
                    lbl_pass_status.Visible = false;
                    error_password.SetError(txt_newPassword, "Please enter your new password");
                    txt_confirmPass.Text = null;
                    Error_confirm.Clear();
                }

                else if (new_password.Length < 7)
                {
                    error_password.Clear();
                    lbl_pass_status.Text = "weak password";
                    lbl_pass_status.BackColor = System.Drawing.Color.IndianRed;
                    lbl_pass_status.Visible = true;
                }
                else if (new_password.Length > 7)
                {
                    error_password.Clear();
                    lbl_pass_status.Text = "strong password";
                    lbl_pass_status.BackColor = System.Drawing.Color.LightGreen;
                    lbl_pass_status.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_confirmPass_TextChanged(object sender, EventArgs e)
        {
            try
            {

                confirm_password = txt_confirmPass.Text.ToString();
                if (confirm_password.Length == 0)
                {
                    error_password.Clear();
                    Error_confirm.SetError(txt_confirmPass, "please enter your confirm password");
                    lbl_confirm.Visible = false;
                    btn_change.Visible = false;
                    txt_newPassword.Text = "";
                }
                else
                {

                    if (confirm_password.Length < 7)
                    {
                        Error_confirm.Clear();
                        error_password.Clear();
                        lbl_confirm.Text = "Weak password";
                        lbl_confirm.Visible = true;
                        lbl_confirm.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (confirm_password.Length > 7)
                    {
                        Error_confirm.Clear();
                        error_password.Clear();
                        lbl_confirm.Text = "Strong password";
                        lbl_confirm.Visible = true;
                        lbl_confirm.BackColor = System.Drawing.Color.LightGreen;
                    }

                    if (confirm_password.Equals(new_password))
                    {
                        btn_change.Enabled = true;
                        btn_change.Visible = true;
                        Error_confirm.Clear();
                        error_password.Clear();
                    }
                    else if (!(confirm_password.Equals(new_password)))
                    {
                        btn_change.Enabled = false;
                        error_password.Clear();
                        Error_confirm.SetError(txt_confirmPass, "Please check your confirm password again");
                        lbl_confirm.Visible = false;
                    }
                }

            }

            catch (NullReferenceException)
            {
                MessageBox.Show("please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                int row;
                db.closeCon();
                query = "Update Emp_Login Set userPassword ='" + confirm_password + "'";
                if (confirm_password.Equals(new_password))
                {
                    row = db.update_del_insert_Data(query);
                    if (row == 1)
                    {
                        MessageBox.Show($"your current password updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (InvalidOperationException)
            {

                MessageBox.Show("please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Refresh();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
