using Pastry_ManagementSystem.DB;
using System;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class EmployeeDetails : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public EmployeeDetails()
        {
            InitializeComponent();
        }
        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_firstName.Text.Length == 0)
                {
                    gridValueEmp.DataSource = null;
                    errorProvider1.SetError(txt_firstName, "Please enter employee first name");
                }
                else {
                    string sql;
                    sql = "Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,dob,age,empAddress,basicSalry From Employee_Master_Table where emp_Fname like '%" + txt_firstName.Text + "%'";
                    gridValueEmp.DataSource = db.sendTable(sql);
                    db.closeCon();
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the inputs and try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void txt_empPosition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_empPosition.Text.Length == 0)
                {
                    gridValueEmp.DataSource = null;
                    errorProvider1.SetError(txt_empPosition, "Please enter employee first name");
                }
                else
                {
                    string sql;
                    sql = "Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,dob,age,empAddress,basicSalry From Employee_Master_Table where Designation like '%" + txt_empPosition.Text + "%'";
                    gridValueEmp.DataSource = db.sendTable(sql);
                    db.closeCon();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please check the inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
