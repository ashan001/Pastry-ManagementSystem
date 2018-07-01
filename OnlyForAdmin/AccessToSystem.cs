using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminObjectsHide.HiddenAdminObjects;
using System.Text.RegularExpressions;
using MessageBoxControlCenter.MessageBoxes;
using System.IO;
using System.Web.Script.Serialization;

namespace OnlyForAdmin
{
    public partial class AccessToSystem :MetroFramework.Forms.MetroForm
    {
        public string  Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AccessToSystem()
        {
            InitializeComponent();
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool value;  
            if (!(txtEmail.Text.Length == 0))
            {
                value = emailIsValid(txtEmail.Text);

                if (value == true)
                {
                    errorProvider1.Clear();
                    Email = txtEmail.Text;
                }
                else
                {
                    errorProvider1.SetError(txtEmail,"Invalid Email");
                }
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Enter Email");
            }
        }
        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MapAdminObj objOfAdmin = new MapAdminObj();
                objOfAdmin.Email = Email;
                objOfAdmin.UserName = txtUsrName.Text;
                objOfAdmin.Password = txtconfirmPassword.Text;
                int line = objOfAdmin.saveInText();
                if (line == 1)
                {
                    MsgBox.Show(1);
                    Pastry_ManagementSystem.UI.EmployeeRegister obj = new Pastry_ManagementSystem.UI.EmployeeRegister();
                    Hide();
                    obj.Show();
                    obj.metroButton2.Enabled = false;
                    obj.metroButton3.Enabled = false;
                    //if (obj.x == 1)
                    //{
                    //    obj.Close();
                    //    Application.Run(new Pastry_ManagementSystem.UI.frmMain.frmSplashScrn());
                    //}
                }
                else
                {
                    MsgBox.Show(3);
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                btnLogin.Enabled = false;
                txtconfirmPassword.Clear();
                txtPassword.Focus();
                return;
            }        
            if (txtPassword.Text.Length != txtconfirmPassword.Text.Length)
            {
                btnLogin.Enabled = false;
                return;
            }          
            if (txtPassword.Text == txtconfirmPassword.Text)
            {
                btnLogin.Enabled = true;
                return;
            }
        }

        private void txtconfirmPassword_TextChanged(object sender, EventArgs e)
        {          
            if (txtconfirmPassword.Text.Length == 0)
            {
                btnLogin.Enabled = false;
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text.Length != txtconfirmPassword.Text.Length)
            {
                btnLogin.Enabled = false;
                return;
            }          
            if (txtconfirmPassword.Text == txtPassword.Text)
            {
                btnLogin.Enabled = true;
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if((MsgBox.Question("Do you want to exit ?"))== DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}
