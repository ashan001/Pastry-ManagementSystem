using System;
using PMS.AdminPanel.ExtraClasses;
using Dapper;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pastry_ManagementSystem.ExtraClassesToMapData;
using Pastry_ManagementSystem.Other;
using MessageBoxControlCenter.MessageBoxes;
using System.Threading;

namespace Pastry_ManagementSystem.UI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            Thread th = new Thread(new ThreadStart(Loading));
            th.Start();
            InitializeComponent();
            for (int i = 0; i <= 1000; i++)        
                Thread.Sleep(10);             
            th.Abort();           
        }
        void Loading()
        {
            UI.frmMain.frmSplashScrn frm = new frmMain.frmSplashScrn();
            Application.Run(frm);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MsgBox.Question("Are you sure,do you want to Exit ?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string UserName { get; set; }
        public static string EmployeeID { get; set; }
        private void btn_login_Click(object sender, EventArgs e)
        {
                     
           if (string.IsNullOrEmpty(txt_uerName.Text))
           {
                    MsgBox.Warning("Please enter user name");
                    txt_uerName.Focus();
                    return;
           }
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                MsgBox.Warning("Please enter password");
                txt_password.Focus();
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Thread.Sleep(2500);
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string _sql = $"Select EM.Designation,EL.userName,EL.userPassword,EM.emp_ID From Employee_Master_Table EM Inner Join Emp_Login EL on EL.employeeID=EM.emp_ID where EL.userName='{txt_uerName.Text}' AND EL.userPassword='{txt_password.Text}'";
                        MapLoginData obj = db.Query<MapLoginData>(_sql, commandType: CommandType.Text).SingleOrDefault();
                        if (obj != null)
                        {
                            if (obj.userName == txt_uerName.Text && obj.userPassword == txt_password.Text)
                            {
                                if (obj.Designation == "Admin")
                                {
                                    UserName = obj.userName;
                                    EmployeeID = obj.emp_ID;
                                    //using (PMS.AdminPanel.UI.frmMainForAdmin obj1 = new PMS.AdminPanel.UI.frmMainForAdmin())
                                    //{
                                    //    this.Hide();
                                    //    obj1.ShowDialog();
                                    //}
                                    using (UI.SystemAdminMenu obj1 = new SystemAdminMenu())
                                    {
                                        this.Hide();
                                        BackpanelObj obj3 = new BackpanelObj();
                                        obj1.ShowDialog();
                                    }
                                }
                                else if (obj.Designation == "Manager")
                                {
                                    using (UI.ManagerMenu obj2 = new UI.ManagerMenu())
                                    {
                                        this.Hide();
                                        obj2.ShowDialog();
                                    }
                                }
                                else if (obj.Designation == "Cashier")
                                {
                                    using (UI.CashierMenu obj2 = new UI.CashierMenu())
                                    {
                                        this.Hide();
                                        obj2.ShowDialog();
                                    }
                                }
                                else if (obj.Designation == "Chef")
                                {
                                    using (UI.PreparedFoodOrder obj2 = new UI.PreparedFoodOrder())
                                    {
                                        this.Hide();
                                        obj2.ShowDialog();
                                    }
                                }
                                //add some more
                                else
                                    MsgBox.InvalidUser("Invalid Access");
                            }
                            else
                                MsgBox.Show(4);
                        }
                        else
                            MsgBox.Show(4);                       
                    }
                    else
                        MsgBox.Show(5);
                    db.Close();
                }
            }
            catch
            {
                MsgBox.Error("invalid User name/password combination");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_login_Click(sender,e);
            }
        }

        private void txt_uerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txt_uerName.Text))
                {
                    e.SuppressKeyPress = true;
                    txt_password.Focus();
                }
            }
        }
    }
}
