using System;
using Dapper;
using PMS.AdminPanel.ExtraClasses;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.Other;
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.UI.RoutingToAdminBackPanel
{
    public partial class RoutToBackPanel : MetroFramework.Forms.MetroForm
    {
     
        public RoutToBackPanel()
        {
            InitializeComponent();
        }

        private void RoutToBackPanel_Load(object sender, EventArgs e)
        {
            txt_uerName.Text = SystemAdminMenu.UserName;
            txt_password.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (string.IsNullOrEmpty(txt_uerName.Text))
                    {
                        MsgBox.Warning("Enter User Name");
                        txt_uerName.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_password.Text))
                    {
                        MsgBox.Warning("password required");
                        txt_password.Focus();
                        return;
                    }
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string _sql = $"Select EM.Designation,EL.userName,EL.userPassword From Employee_Master_Table EM Inner Join Emp_Login EL on EL.employeeID=EM.emp_ID where EL.userName='{txt_uerName.Text}' AND EL.userPassword='{txt_password.Text}'";
                        BackpanelObj obj = db.Query<BackpanelObj>(_sql, commandType: CommandType.Text).SingleOrDefault();
                        if (obj.userName == txt_uerName.Text && obj.userPassword == txt_password.Text)
                        {
                            if (obj.Designation == "Admin")
                            {
                                using (PMS.AdminPanel.UI.frmMainForAdmin frmObj = new PMS.AdminPanel.UI.frmMainForAdmin())
                                {
                                    Cursor.Current = Cursors.WaitCursor;
                                    try
                                    {
                                        Thread.Sleep(3100);  // wait for a while
                                    }
                                    finally
                                    {
                                        Cursor.Current = Cursors.Default;
                                        this.Close();
                                        frmObj.ShowDialog();
                                    }
                                }
                            }
                            else
                            {
                                MsgBox.Show(8);
                            }
                        }
                        else
                        {
                            MsgBox.Show(4);
                        }
                    }
                }
            }
            catch 
            {
                MsgBox.Show(4);
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_login_Click(sender,e);
            }
        }
    }
}
