using Pastry_ManagementSystem.DB;
using Pastry_ManagementSystem.ExtraClassesToMapData;
using System;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.UI
{
    public partial class UpdateEmployee : MetroFramework.Forms.MetroForm
    {
        public string imgLoc { get; set; }
        public string path { get; set; }
        public string correctFileName { get; set; }
        public string email { get; private set; } 
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
                    path = Application.StartupPath;
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
               // MessageBox.Show("Please check your file again and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txt_mobile.Text.Length == 0)
            {
                errorProvider1.SetError(txt_mobile, "Please enter employee mobile number");
            }
            else if (txt_mobile.Text.Length < 10)
            {
                errorProvider1.SetError(txt_mobile, "Please check mobile number");
            }
            else if (txt_mobile.Text.Length > 10)
            {
                errorProvider1.SetError(txt_mobile, "Please check mobile number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_nic_KeyPress(object sender, KeyPressEventArgs e)
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

                    errorProvider1.SetError(txt_nic, "please check your NIC Number");
                }
            }
            else
            {
                errorProvider1.SetError(txt_nic, "Please enter your nic number");
            }
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_salary, "Accept only numeric values");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
           
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
                    errorProvider1.SetError(txt_email, "Please check your email again");
                }
            }
            else
            {
                errorProvider1.SetError(txt_email, "Please enter your email again");
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

        private void txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_Age, "Only Accept Numeri values");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            if (txt_address.Text.Length == 0)
            {
                errorProvider1.SetError(txt_address, "Please enter employee address");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_contactNum_KeyDown(object sender, KeyEventArgs e)
        {
        }
      
       
        private void txt_empNIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              //  txt_empID.Focus();
            }
        }

        private void txt_empID_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtVerification.Text.Length == 0)
                {
                    txt_empName.Clear();
                    txt_lastName.Clear();
                    txt_contact.Clear();
                    txt_mobile.Clear();
                    txt_nic.Clear();
                    txt_salary.Clear();
                    cmb_desigType.BackColor = Color.IndianRed;
                    txt_email.Clear();
                    txt_Age.Clear();
                    txt_address.Clear();
                    emp_picture.Image = null;
                    errorProvider1.Clear();
                    db.closeCon();
                }
            }
            catch(Exception)
            {
            }
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            cmb_desigType.BackColor = Color.IndianRed;
            cmb_desigType.SelectedText = "Please select employee designation".ToString();
        }

        private void cmb_desigType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_desigType.BackColor = Color.LightGreen;
          
        }
        private void txt_empID_TextChanged(object sender, EventArgs e)
        {
            if (txtVerification.Text.Length == 0)
            {
                txt_empName.Clear();
                txt_lastName.Clear();
                txt_contact.Clear();
                txt_mobile.Clear();
                txt_nic.Clear();
                txt_salary.Clear();
                cmb_desigType.BackColor = Color.IndianRed;
                txt_email.Clear();
                txt_Age.Clear();
                txt_address.Clear();
                emp_picture.Image = null;
                errorProvider1.Clear();
                db.closeCon();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtVerification.Text.Length !=0)
            {
                Update2();
            }
            else if (txtVerify.Text.Length !=0)
            {
                Update();
            }
         
        }
       
        public string EmpID { get; set; }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtVerification.Text.Length ==0)
            {
                MessageBox.Show(this, "Please fill employee details to search the employee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVerification.Focus();
                return;
            }
            try
            {
                int db_value1 = 0, db_value2 = 0;
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State==ConnectionState.Closed)
                    {
                        db.Open();
                        string sql;
                        emp_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        sql = $"Select * From Employee_Master_Table where  mobileNo='{txtVerification.Text}' OR fix_ContactNo='{txtVerification.Text}' OR email='{txtVerification.Text}'";
                        path = Application.StartupPath;
                        EmployeeClass obj = db.Query<EmployeeClass>(sql,commandType:CommandType.Text).SingleOrDefault();
                        if (obj != null)
                        {
                            ChangeDesign();
                            txt_empName.Text = obj.emp_Fname;
                            txt_lastName.Text = obj.emp_Lname;
                            txt_contact.Text = obj.fix_ContactNo.ToString();
                            txt_mobile.Text = obj.mobileNo.ToString();
                            //
                            db_value1 = Convert.ToInt32(txt_contact.Text);
                            db_value2 = Convert.ToInt32(txt_mobile.Text);
                            //
                            txt_nic.Text = obj.Nic;
                            txt_salary.Text = obj.basicSalry.ToString();
                            cmb_desigType.Text = obj.Designation;
                            txt_email.Text = obj.email.ToString();
                            dtp_dob.Text = obj.dob;
                            txt_Age.Text = obj.age.ToString();
                            txt_address.Text = obj.empAddress;
                            emp_picture.Image = Image.FromFile((path + obj.imgPath).ToString());


                            if (db_value1 !=Convert.ToInt32(txt_contact.Text))
                            {
                                MsgBox.Error("Invalid inputs");
                                return;
                            }
                            if (db_value2 != Convert.ToInt32(txt_mobile.Text))
                            {
                                MsgBox.Error("Invalid inputs");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid inputs please try again ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        public void ChangeDesign()
        {
            gb_employeeDetails.Enabled = true;
            fb_empPhoto.Enabled = true;
            cmb_desigType.BackColor = Color.LightGreen;
            groupBox3.Enabled = false;
        }

        private void dtp_dob_ValueChanged(object sender, EventArgs e)
        {
            txt_Age.Text = ((Convert.ToInt32(DateTime.Now.Year)) - (Convert.ToInt32(dtp_dob.Value.Year))).ToString();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text.Length == 0)
            {
                MessageBox.Show(this, "Please fill employee details to search the employee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVerification.Focus();
                return;
            }
            try
            {
                string db_vlue1=null, db_vlue2 = null;
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql;
                        emp_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                        sql = $"Select * From Employee_Master_Table where  email='{txtVerify.Text}' OR Nic='{txtVerify.Text}'";                       
                        path = Application.StartupPath;
                        IDataReader reader = db.ExecuteReader(sql);
                                               
                        while (reader.Read())
                        {
                            ChangeDesign();
                            txt_empName.Text = reader["emp_Fname"].ToString();
                            txt_lastName.Text = reader["emp_Lname"].ToString();
                            txt_contact.Text = reader["fix_ContactNo"].ToString();
                            txt_mobile.Text = reader["mobileNo"].ToString();
                            txt_nic.Text = reader["Nic"].ToString();
                            txt_salary.Text = reader["basicSalry"].ToString();
                            cmb_desigType.Text = reader["Designation"].ToString();
                            txt_email.Text = reader["email"].ToString();
                            dtp_dob.Text = reader["dob"].ToString();
                            txt_Age.Text = reader["age"].ToString();
                            txt_address.Text = reader["empAddress"].ToString();
                            emp_picture.Image = Image.FromFile((path + reader["imgPath"]).ToString());
                            //
                            db_vlue1 = txt_email.Text;
                            db_vlue2 = txt_nic.Text;
                            //

                        }
                        if (txt_email.Text != db_vlue1)
                        {
                            MsgBox.Error("Invalid Inputs");
                            return;
                        }
                        if (txt_nic.Text != db_vlue2)
                        {
                            MsgBox.Error("Invalid Inputs");
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFormData(this);
            groupBox3.Enabled = true;
            errorProvider1.Clear();
        }
        void ClearFormData(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                else if (c is DataGridView)
                    ((DataGridView)c).Rows.Clear();
                else if (c is RichTextBox)
                    ((RichTextBox)c).Clear();
                else if (c is PictureBox)
                    ((PictureBox)c).Image = null;
                else
                    ClearFormData(c);
            }
        }

        void Update()
        {
            using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();

                    string sql = "Update Employee_Master_Table Set emp_Fname='" + txt_empName.Text + "',emp_Lname='" + txt_lastName.Text + "',fix_ContactNo='" + Convert.ToInt32(txt_contact.Text) + "'" +
                    ",mobileNo='" + Convert.ToInt32(txt_mobile.Text) + "',Designation='" + cmb_desigType.Text.ToString() + "'," +
                    "email='" + txt_email.Text + "',dob='" + dtp_dob.Value.ToString() + "',age='" + Convert.ToInt32(txt_Age.Text) + "',empAddress='" + txt_address.Text + "',imgPath='\\ServerSideImageFolder\\" + correctFileName + "'" +
                    "where  Nic='" + Verify + "' OR email ='"+ Verify + "'";
                   
                    int result = db.Execute(sql);
                    if (result == 1)
                    {
                        MsgBox.Show(6);
                    }
                    else
                    {
                        MsgBox.Show(9);
                    }
                }
            }
        }
        void Update2()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed) {
                        string sql = "Update Employee_Master_Table Set emp_Fname='" + txt_empName.Text + "',emp_Lname='" + txt_lastName.Text + "',fix_ContactNo='" + Convert.ToInt32(txt_contact.Text) + "'" +
                        ",mobileNo='" + Convert.ToInt32(txt_mobile.Text) + "',Designation='" + cmb_desigType.Text.ToString() + "'," +
                        "email='" + txt_email.Text + "',dob='" + dtp_dob.Value.ToString() + "',age='" + Convert.ToInt32(txt_Age.Text) + "',empAddress='" + txt_address.Text + "',imgPath='\\ServerSideImageFolder\\" + correctFileName + "'" +
                        "where mobileNo='" + Verification + "' OR fix_ContactNo='" + Verification + "'";


                        int result = db.Execute(sql);
                        if (result == 1)
                        {
                            MsgBox.Show(6);
                        }
                        else
                        {
                            MsgBox.Show(9);
                        }

                    }
                }


            }
            catch (Exception ex)
            {

            }
        }
        public string Verification { get; set; }
        private void txtVerification_TextChanged(object sender, EventArgs e)
        {
            Verification = txtVerification.Text.ToString();
        }
        public string Verify { get; set; }
        private void txtVerify_TextChanged(object sender, EventArgs e)
        {
            Verify = txtVerify.Text.ToString();
        }

        private void txtVerification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_search_Click(sender,e);
            }
        }

        private void txtVerify_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnVerify_Click(sender,e);
            }
        }
    }
}
