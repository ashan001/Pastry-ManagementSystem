using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class UpdateEmployee : MetroFramework.Forms.MetroForm
    {
        public string imgLoc { get; set; }
        public string path { get; set; }
        public string correctFileName { get; set; }
        Database db = new Database();
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                open.Title = "Select Employe picture";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = open.FileName.ToString();
                    emp_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    emp_picture.ImageLocation = imgLoc;
                    path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    correctFileName = System.IO.Path.GetFileName(open.FileName);
                    System.IO.File.Copy(open.FileName, path + "\\ServerSideImageFolder\\" + correctFileName);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check your file again and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Please check your file again and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your file again and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string v_empID, v_nic;
        int contact_fix,contact_mobile;
        private void btn_search_Click(object sender, EventArgs e)
        {

            if (txt_contactNum.Text.Length==0 && txt_empNIC.Text.Length==0 && txt_empID.Text.Length==0)
            {
                MessageBox.Show("Please fill one of text fields to find the employee,no need to fill all text fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string sql = null;
                    SqlDataReader reader;
                    sql = "Select * From Employee_Master_Table where fix_ContactNo='" + txt_contactNum.Text + "' OR mobileNo='" + txt_contactNum.Text + "' OR Nic='" + txt_empNIC.Text + "' OR emp_ID='" + txt_empID.Text + "'";
                    emp_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        v_empID = reader["emp_ID"].ToString();
                        v_nic= reader["Nic"].ToString();
                        contact_fix = Convert.ToInt32(reader["fix_ContactNo"].ToString());
                        contact_mobile= Convert.ToInt32(reader["mobileNo"].ToString());
                        txt_empName.Text = reader["emp_Fname"].ToString();
                        txt_lastName.Text = reader["emp_Lname"].ToString();
                        txt_contact.Text = contact_fix.ToString();
                        txt_mobile.Text = contact_mobile.ToString();
                        txt_nic.Text = v_nic.ToString();
                        txt_salary.Text = reader["basicSalry"].ToString();
                        cmb_desigType.Text = reader["Designation"].ToString();
                        txt_email.Text = reader["email"].ToString();
                        dtp_dob.Text = reader["dob"].ToString();
                        txt_Age.Text = reader["age"].ToString();
                        txt_address.Text = reader["empAddress"].ToString();                      
                        emp_picture.Image = Image.FromFile(path + reader["imgPath"].ToString());                    
                    }
                    db.closeCon();
                }
                catch (Exception)
                {

                }
            }
        }

        private void txt_contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_contact, "Please check your contact Number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_empNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = txt_nic.Text;            
            if (!(str.Length == 0))
            {
                if ((str.Count(char.IsDigit) == 9) && // only 9 digits
                (str.EndsWith("X", StringComparison.OrdinalIgnoreCase)
                 || str.EndsWith("V", StringComparison.OrdinalIgnoreCase)) && //a letter at the end 'x' or 'v'
                (str[2] != '4' && str[2] != '9')) //3rd digit can not be equal to 4 or 9
                {                    
                    errorProvider1.Clear();
                }
                else
                {
                   
                    errorProvider1.SetError(txt_empNIC, "please check your NIC Number");
                }
            }
            else
            {
                errorProvider1.SetError(txt_nic, "Please enter your nic number");
            }
        }

        private void txt_empName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_empName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_lastName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_contact, "Please check your contact Number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            if (txt_contact.Text.Length == 0)
            {
                errorProvider1.SetError(txt_contact, "Contact Number should not be empty text feild");
            }
            else if (txt_contact.Text.Length < 7)
            {
                errorProvider1.SetError(txt_contact, "Please check your contact number");
            }
            else if (txt_contact.Text.Length > 10)
            {
                errorProvider1.SetError(txt_contact, "Please check your contact number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_mobile, "Please check your Mobile Contact Number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            
        }

        int line =0;
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update Employee_Master_Table Set emp_Fname='" + txt_empName.Text + "',emp_Lname='" + txt_lastName.Text + "',fix_ContactNo='" + txt_contact.Text + "'"+
                    ",mobileNo='" + txt_mobile.Text + "',basicSalry='" + txt_salary.Text + "',Designation='" + cmb_desigType.Text.ToString() + "'," +
                    "email='"+ txt_email .Text+ "',dob='"+ dtp_dob .Value.ToString()+ "',age='"+ txt_Age .Text+ "',empAddress='"+ txt_address .Text+ "',imgPath='\\ServerSideImageFolder\\" + correctFileName + "'" +
                    "where fix_ContactNo='" + txt_contactNum.Text + "'OR mobileNo='" + txt_contactNum.Text + "'OR emp_ID='" + txt_empNIC.Text + "'OR emp_ID='" + txt_empID.Text + "'";
                line = db.update_del_insert_Data(sql);
                db.closeCon();
                if (line==1)
                {
                    MessageBox.Show("Employee Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Process is failed ,please check the form and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            catch (Exception)
            {

            }
        }



    }
}
