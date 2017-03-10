using Pastry_ManagementSystem.DB;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;

namespace Pastry_ManagementSystem.UI
{
    public partial class EmployeeRegister : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        protected string designation { get; set; }
        protected string empName { get; set; }
        protected int age { get; set; }
        protected string email { get; set; }
        protected string SysDate { get; set; }
        private string BegEmpIDString { get; set; } = "Emp";//later on give new category
        protected string empID { get; set; }
        protected string password { get; set; }
        protected string confirmPassword { get; set; }
        protected string lastDigitForPass { get; set; }//use to create password        
        public string dateOfBirth { get; set; }
        public string  path { get; set; }
        public string correctFileName { get; set; }
        public string imgLoc { get; set; }
        public EmployeeRegister()
        {
            InitializeComponent();
            emp_reg_timer.Start();
        }
        private void EmployeeRegister_Load(object sender, EventArgs e)
        {
            cmb_desigType.BackColor = Color.LightBlue;
            cmb_desigType.SelectedText = "Please Select your Designation".ToString();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void emp_reg_timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            SysDate = Convert.ToString(dt.Year);
            lastDigitForPass = Convert.ToString(dt.Millisecond);
            lbl_time2.Text = dt.ToString();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"\c:";
                open.Filter = "Image Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
                open.FilterIndex = 1;
                if (open.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {

                        imgLoc = open.FileName.ToString();
                        emp_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        emp_picture.ImageLocation = imgLoc;
                        path = Application.StartupPath.Substring(0,(Application.StartupPath.Length - 10));
                        correctFileName = System.IO.Path.GetFileName(open.FileName);
                        System.IO.File.Copy(open.FileName,path + "\\ServerSideImageFolder\\" + correctFileName);
                    }
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

        private void txt_empName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator.SetError(txt_empName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator.Clear();
            }
        }

        private void txt_empName_TextChanged(object sender, EventArgs e)
        {

            if (txt_empName.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_empName, "Employee Name required");
            }
            else
            {
                if (txt_empName.Text.Length >= 3)
                {
                    formValidator3.Clear();
                    Error_empInfo.Clear();

                }
            }
        }

        private void txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator.SetError(txt_lastName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator.Clear();
            }
        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {
            if (txt_lastName.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_lastName, "Employee Name required");
            }
            else
            {
                if (txt_lastName.Text.Length >= 3)
                {
                    formValidator3.Clear();
                    Error_empInfo.Clear();

                }
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                FormValidator2.SetError(txt_contact, "Please check your contact Number");
            }
            else
            {
                this.FormValidator2.Clear();
            }
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_contact.Text.Length == 0))
                {
                    FormValidator.Clear();
                    if (txt_contact.Text.Length > 10)
                    {
                        txt_contact.BackColor = Color.IndianRed;
                        FormValidator.SetError(txt_contact, "Please check your contact Number");
                    }
                    else if (txt_contact.Text.Length < 7)
                    {
                        txt_contact.BackColor = Color.IndianRed;
                        FormValidator.SetError(txt_contact, "Please check your contact Number");
                    }
                    else
                    {
                        formValidator3.Clear();
                        FormValidator.Clear();
                        txt_contact.BackColor = Color.LightGreen;
                    }
                }
                else if (txt_contact.Text.Length == 0)
                {
                    FormValidator.SetError(txt_contact, "Please enter your contact Number");
                }

            }
            catch (FormatException)
            {
                FormValidator.SetError(txt_contact, "not allowed to enter charactors");
            }
            catch (OverflowException)
            {
                FormValidator.SetError(txt_contact, "Please check your contact Number");
            }
            catch (Exception)
            {
                FormValidator.SetError(txt_contact, "Please check your contact Number");
            }
        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
            formValidator3.Clear();
            // to make sure that error provider is emppty
            if (txt_mobile.Text.Length > 10)
            {
                Error_empInfo.SetError(txt_mobile, "invalid mobile number.check again");
            }//end of the mobile number will more than 10 digits
            else
            {
                Error_empInfo.Clear();
            }
        }
        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                FormValidator2.SetError(txt_mobile, "Please check your contact Number");
            }
            else
            {
                this.FormValidator2.Clear();
            }
        }

        private void txt_nic_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            string str = txt_nic.Text;
            formValidator3.Clear();
            if (!(str.Length == 0))
            {
                if ((str.Count(char.IsDigit) == 9) && // only 9 digits
                (str.EndsWith("X", StringComparison.OrdinalIgnoreCase)
                 || str.EndsWith("V", StringComparison.OrdinalIgnoreCase)) && //a letter at the end 'x' or 'v'
                (str[2] != '4' && str[2] != '9')) //3rd digit can not be equal to 4 or 9
                {
                    FormValidator.Clear();
                    FormValidator2.Clear();
                }
                else
                {
                    FormValidator2.Clear();
                    FormValidator.SetError(txt_nic, "please check your NIC Number");
                }
            }
            else
            {
                FormValidator2.SetError(txt_nic, "Please enter your nic number");
            }
        }
        SqlDataReader datareader;
        private void cmb_desigType_SelectedIndexChanged(object sender, EventArgs e)
        {
            formValidator3.Clear();
            designation = Convert.ToString(cmb_desigType.SelectedItem);
            string sql;
            sql = "Select Basic_Salary_amount From Designation_Master_table where Designation_Type = '" + designation + "'";
            datareader = db.getData(sql);
            while (datareader.Read())
            {
                txt_salary.Text = (datareader["Basic_Salary_amount"]).ToString();
            }
            db.closeCon();
            //dont forget to configure basic salary
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormValidator.Clear();
        }
        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            FormValidator.Clear();
            formValidator3.Clear();
            bool value;
            email = txt_email.Text;


            if (!(email.Length == 0))
            {
                value = emailIsValid(email);

                if (value == true)
                {
                    email = txt_email.Text;
                }
                else
                {
                    //show an error
                    FormValidator.SetError(txt_email, "Please check your email again");
                }
            }
            else
            {
                FormValidator.SetError(txt_email, "Please enter your email again");
            }

        }

        //Validate the email using regex
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
        private void dob_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirth = Convert.ToString(dob.Value.Date);
            age = DateTime.Today.Year - dob.Value.Year;
            txt_Age.Text = age.ToString();
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            formValidator3.Clear();
        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            //please select the salary amount from database for that perticular emp designation   
            Thread th1 = new Thread(new ThreadStart(createEmployeeID));
            Thread th2 = new Thread(new ThreadStart(setPassword));

            if (!(txt_salary.Text.Length == 0))
            {

                if (txt_salary.Text.Length > 4)
                {
                    th1.Start();
                    th2.Start();
                }
            }
            else
            {
                txt_userName.Clear();
            }
        }
        private void txt_question1_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_question1.Text.Length == 0))
            {
                formValidator3.Clear();
                FormValidator.Clear();
                FormValidator2.Clear();
            }
        }

        private void txt_question2_TextChanged(object sender, EventArgs e)
        {

            if (!(txt_question2.Text.Length == 0))
            {
                formValidator3.Clear();
                FormValidator.Clear();
                FormValidator2.Clear();
            }
        }

        private void txt_question3_TextChanged(object sender, EventArgs e)
        {
            if (!(txt_question3.Text.Length == 0))
            {
                formValidator3.Clear();
                FormValidator.Clear();
                FormValidator2.Clear();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_empName.Text.Length == 0)//check whecther emp name is not inserted
                {
                    formValidator3.SetError(txt_empName, "Employee name is required");
                }
                else
                {
                    formValidator3.Clear();
                    if (txt_lastName.Text.Length == 0)
                    {
                        formValidator3.SetError(txt_lastName, "Employee last name is required");
                    }//check whecther emp last name is not inserted
                    else
                    {
                        formValidator3.Clear();
                        if (txt_contact.Text.Length == 0)
                        {
                            formValidator3.SetError(txt_contact, "contact number  is required");
                        }//check whecther fix contact number is not inserted
                        else
                        {
                            formValidator3.Clear();
                            if (txt_mobile.Text.Length == 0)
                            {
                                formValidator3.SetError(txt_mobile, "Mobile number  is required");
                            }//check whecther fix contact number is not inserted
                            else
                            {
                                if (txt_nic.Text.Length == 0)
                                {
                                    formValidator3.SetError(txt_nic, "NIC  is required");
                                }
                                else
                                {
                                    formValidator3.Clear();
                                    if (cmb_desigType.SelectedIndex == -1)//Nothing selected 
                                    {
                                        formValidator3.SetError(cmb_desigType, "Select employee designation type");
                                    }
                                    else
                                    {
                                        formValidator3.Clear();
                                        if (txt_email.Text.Length == 0)
                                        {
                                            formValidator3.SetError(txt_email, "Email is required");
                                        }
                                        else
                                        {
                                            formValidator3.Clear();
                                            if (txt_address.Text.Length == 0)
                                            {
                                                formValidator3.SetError(txt_address, "Employee Address required");
                                            }
                                            else
                                            {

                                                if (txt_question1.Text.Length == 0)
                                                {
                                                    formValidator3.SetError(txt_question1, "Please check security question's are entered properly");
                                                }
                                                else
                                                {
                                                    formValidator3.Clear();
                                                    if (txt_question2.Text.Length == 0)
                                                    {
                                                        formValidator3.SetError(txt_question2, "Please check security question's are entered properly");
                                                    }
                                                    else
                                                    {
                                                        formValidator3.Clear();
                                                        if (txt_question3.Text.Length == 0)
                                                        {
                                                            formValidator3.SetError(txt_question3, "Please check security question's are entered properly");
                                                        }
                                                        else
                                                        {
                                                            //store data in db if all are properly inserted
                                                            
                                                            try
                                                            {
                                                                string sql = null;
                                                                int i;
                                                                sql = "Insert into Employee_Master_Table Values ('" + txt_userName.Text + "','" + txt_empName.Text + "','" + txt_lastName.Text + "','" + txt_contact.Text + "','" + txt_mobile.Text + "','" + txt_nic.Text + "','" + designation + "','" + txt_email.Text + "','" + dateOfBirth + "','" + age + "','" + txt_address.Text + "','" + txt_salary.Text + "','" + txt_question1.Text + "','" + txt_question2.Text + "','" + txt_question3.Text + "','\\ServerSideImageFolder\\" + correctFileName+ "')";
                                                                i = db.update_del_insert_Data(sql);
                                                                db.closeCon();
                                                                if (i == 1)
                                                                {
                                                                    MessageBox.Show("Successfully Saved","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                            }
                                                            catch (Exception)
                                                            {
                                                                MessageBox.Show("Please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }

                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }//end of employee validation
            }//end try block
            catch (Exception)
            {

            }
        }
        private void createEmployeeID()
        {
            try
            {
                empID = SysDate.Substring(2);
                string query;
                query = "Select Count (emp_ID) From Employee_Master_Table";
                int noOfId;
                noOfId = db.returnDBRows(query);
                db.closeCon();
                noOfId++;
                empID = (((BegEmpIDString) + (empID) + (noOfId)).ToString());
                txt_userName.Text = empID.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("System crashed plz log out try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setPassword()
        {
            password = ((empID) + (lastDigitForPass)).ToString();
            confirmPassword = ((empID) + (lastDigitForPass)).ToString();
            if (password.Equals(confirmPassword))
            {
                txt_password.Text = password.ToString();
                txt_confirmPass.Text = password.ToString();
            }
        }

        private void btn_loginDetails_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                int line;
                sql = "Insert into Emp_Login Values('" + txt_userName.Text + "','" + txt_empName.Text + "','" + txt_confirmPass.Text + "','" + txt_email.Text + "','" + cmb_desigType.SelectedItem.ToString() + "')";
                line = db.update_del_insert_Data(sql);
                if (line == 1)
                {
                    MessageBox.Show($"You have successfully saved employee {empName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Process is failed please try again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check the form again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the form again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}