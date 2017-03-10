using Pastry_ManagementSystem.DB;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{

    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
         Database db = new Database();
        private SqlDataReader reader;
        public string userName { get; set; }
        private string password { get; set; }
        protected string v_name { get; set; }
        private string v_password { get; set; }
        public string empType { get; set; }

        string sql;
        protected string user_name { get; set; }
       
        public LoginForm()
        {
            InitializeComponent();
           
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmb_empRole.SelectedText = "Select your employee role".ToString();
            cmb_empRole.BackColor = Color.LightCoral;
        }
        private void cmb_empRole_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmb_empRole.BackColor = Color.LightGreen;
            string sql;            
            string v_type = null;
            try
            {
                if (cmb_empRole.SelectedIndex == 0)
                {
                    empType = cmb_empRole.SelectedItem.ToString();
                }
                else if (cmb_empRole.SelectedIndex == 1)
                {
                    empType = cmb_empRole.SelectedItem.ToString();
                }
                //you can continue from here to enhance the roles

                sql = "Select * From Emp_Login where emp_role='" + empType + "'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    v_type = reader["emp_role"].ToString();
                }
                db.closeCon();
                if (v_type.Equals(empType))
                {
                    txt_userName.Enabled = true;
                    txt_password.Enabled = true;
                    btn_login.Enabled = true;
                }
                else
                {
                    txt_userName.Enabled = false;
                    txt_password.Enabled = false;
                    btn_login.Enabled = false;
                   
                }
            }
            catch (NullReferenceException)
            {
                cmb_empRole.BackColor = Color.LightCoral;
                MessageBox.Show($"Please check your employee role again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);               
            }
        }
        private void txt_userName_TextChanged_1(object sender, EventArgs e)
        {
            userName = txt_userName.Text;
            if (userName.Length == 0)
            {
                userName = null;
                db.closeCon();
            }
            else
            {
                for (int i = 0; i <= userName.Length; i++)
                {
                    db.closeCon();
                }
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_userName.Text.Length == 0)
            {
                MessageBox.Show("User name required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_password.Text.Length == 0)
                {
                    MessageBox.Show("Password required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        sql = "Select * From Emp_Login where userName='" + userName + "' AND userPassword='" + password + "'";
                        reader = db.getData(sql);
                        while (reader.Read())
                        {
                            v_name = reader["userName"].ToString();
                            v_password = reader["userPassword"].ToString();
                        }
                        if (userName.Equals(v_name) && password.Equals(v_password))
                        {
                            if (empType.Equals("Manager"))
                            {
                                new ManagerMenu().Show();
                                this.Hide();                                                        
                            }
                            //please do like other Roles
                            
                        }
                        else if (!(userName.Equals(v_name) && password.Equals(v_password)))
                        {
                            MessageBox.Show("Invalid username/password combination.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!(userName.Equals(v_name)))
                        {
                            MessageBox.Show("Invalid username/password combination.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Invalid username/password combination.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        MessageBox.Show("System curruption please restart the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("System curruption please restart the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            password = txt_password.Text.ToString();
            if (password.Length == 0)
            {
                password = null;
                db.closeCon();
            }
            else
            {
                for (int i = 0; i <= password.Length; i++)
                {
                    db.closeCon();
                }
            }
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            new Changepassword().Show();
            this.Hide();
        }

        private void txt_userName_MouseMove(object sender, MouseEventArgs e)
        {
            ToolTip t1 = new ToolTip();           
            t1.Show("asdsad", txt_userName);
        }

        private void txt_userName_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.Show("asdsad", txt_userName);
        }
    }
}
