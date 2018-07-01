using Pastry_ManagementSystem.DB;
using System;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class EmployeeDetails : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string empID { get; set; }
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
                    errorProvider1.SetError(txt_firstName,"Please enter employee Name");

                }
                else {
                    errorProvider1.Clear();
                    string sql;
                    sql = "Select emp_ID,emp_Fname,emp_Lname,fix_ContactNo,mobileNo,Nic,Designation,email,dob,age,empAddress,basicSalry From Employee_Master_Table where emp_Fname like '%" + txt_firstName.Text + "%' OR emp_Lname like '%"+ txt_firstName.Text + "%'";
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
                    errorProvider1.Clear();
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            new ManagerMenu().Show();
            this.Hide();
        }

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_firstName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_empPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_empPosition, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }
        int line;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete the selected row ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr.ToString() == "Yes")
                {
                    empID = gridValueEmp.CurrentRow.Cells[0].Value.ToString();
                    string query = "Delete from Employee_Master_Table where emp_ID = '" + empID + "'";
                    line = db.update_del_insert_Data(query);
                    db.closeCon();
                    if (line == 1)
                    {
                        MessageBox.Show("Data Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btn_refrsh_Click(object sender, EventArgs e)
        {
            gridValueEmp.DataSource = null;
            gridValueEmp.Refresh();
            gridValueEmp.Update();
            txt_empPosition.Clear();
            txt_firstName.Clear();
            errorProvider1.Clear();
        }

    }
}
