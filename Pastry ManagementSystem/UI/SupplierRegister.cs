using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pastry_ManagementSystem.UI
{
    public partial class SupplierRegister : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        protected string email { get; set; }
        public string supplier_Id { get; set; }
        private string uniqueNameForSuppID { get; set; } = "SUP";
        public string year { get; set; }
        public SupplierRegister()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void SupplierRegister_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
       
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            year = dt.Year.ToString();
        }
        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {
            if (txt_firstName.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_firstName, "Supplier Name required");
            }
            else
            {
                if (txt_firstName.Text.Length >= 3)
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
        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator.SetError(txt_firstName, "Accepting only Charactors");
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

                Error_empInfo.SetError(txt_lastName, "Supplier Name required");
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
        private void txt_companyName_TextChanged(object sender, EventArgs e)
        {
            if (txt_companyName.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_companyName, "Company Name required");
            }
            else
            {
                if (txt_companyName.Text.Length >= 3)
                {
                    formValidator3.Clear();
                    Error_empInfo.Clear();
                }
            }
        }
        private void txt_line1_TextChanged(object sender, EventArgs e)
        {
            if (txt_line1.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_line1, "Address should be filled");
            }
            else
            {
                if (txt_line1.Text.Length >= 3)
                {
                    formValidator3.Clear();
                    Error_empInfo.Clear();
                }
            }
        }
        private void txt_line2_TextChanged(object sender, EventArgs e)
        {
            if (txt_line2.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_line2, "Address should be filled");
            }
            else
            {
                if (txt_line2.Text.Length >= 3)
                {
                    formValidator3.Clear();
                    Error_empInfo.Clear();
                }
            }
        }
        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            if (txt_city.Text.Length == 0)
            {

                Error_empInfo.SetError(txt_city, "Address should be filled");
            }
            else
            {
                if (txt_city.Text.Length >= 3)
                {
                    formValidator3.Clear();
                    Error_empInfo.Clear();
                }
            }
        }
        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_contactNum.Text.Length == 0))
                {
                    FormValidator.Clear();
                    if (txt_contactNum.Text.Length > 10)
                    {
                        txt_contactNum.BackColor = Color.IndianRed;
                        FormValidator.SetError(txt_contactNum, "Please check your contact Number");
                    }
                    else if (txt_contactNum.Text.Length < 7)
                    {
                        txt_contactNum.BackColor = Color.IndianRed;
                        FormValidator.SetError(txt_contactNum, "Please check your contact Number");
                    }
                    else
                    {
                        formValidator3.Clear();
                        FormValidator.Clear();
                        txt_contactNum.BackColor = Color.LightGreen;
                    }
                }
                else if (txt_contactNum.Text.Length == 0)
                {
                    FormValidator.SetError(txt_contactNum, "Please enter your contact Number");
                }

            }
            catch (FormatException)
            {
                FormValidator.SetError(txt_contactNum, "not allowed to enter charactors");
            }
            catch (OverflowException)
            {
                FormValidator.SetError(txt_contactNum, "Please check your contact Number");
            }
            catch (Exception)
            {
                FormValidator.SetError(txt_contactNum, "Please check your contact Number");
            }
        }
        private void txt_contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                FormValidator2.SetError(txt_contactNum, "please check your contact number again");
            }
            else
            {
                this.FormValidator2.Clear();
            }
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
                    FormValidator.SetError(txt_nic, "please check  NIC Number");
                }
            }
            else
            {
                FormValidator2.SetError(txt_nic, "Please enter  nic number");
            }
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
        private void txt_faxNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(txt_faxNum.Text.Length == 0))
                {
                    FormValidator.Clear();
                    if (txt_faxNum.Text.Length > 10)
                    {
                        txt_faxNum.BackColor = Color.IndianRed;
                        FormValidator.SetError(txt_faxNum, "Please check your contact Number");
                    }
                    else if (txt_faxNum.Text.Length < 7)
                    {
                        txt_faxNum.BackColor = Color.IndianRed;
                        FormValidator.SetError(txt_faxNum, "Please check your contact Number");
                    }
                    else
                    {
                        formValidator3.Clear();
                        FormValidator.Clear();
                        txt_faxNum.BackColor = Color.LightGreen;
                    }
                }
                else if (txt_faxNum.Text.Length == 0)
                {
                    FormValidator.SetError(txt_faxNum, "Please enter your contact Number");
                }
            }
            catch (FormatException)
            {
                FormValidator.SetError(txt_faxNum, "not allowed to enter charactors");
            }
            catch (OverflowException)
            {
                FormValidator.SetError(txt_faxNum, "Please check your contact Number");
            }
            catch (Exception)
            {
                FormValidator.SetError(txt_faxNum, "Please check your contact Number");
            }
        }
        private void txt_faxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                FormValidator2.SetError(txt_faxNum, "please check your fax number again");
            }
            else
            {
                this.FormValidator2.Clear();
            }
        }
        private void rtxt_comments_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (!((txt_firstName.Text.Equals(null))&&(txt_lastName.Text.Equals(null))&&(txt_companyName.Text.Equals(null))&&(txt_line1.Text.Equals(null))&&(txt_line2.Text.Equals(null))&&(txt_contactNum.Text.Equals(null))))
            {
                string sql;
                sql = "Insert into supplier_table(supp_ID,supp_FirstName,supp_lastName,company_Name,company_Address,contactNumber,NIC,emailAddress,RegisteredDate,fax_Num,web_siteName,Comments)" +
                      "Values('" + txt_suppID.Text + "','" + txt_firstName.Text + "','" + txt_lastName.Text + "','" + txt_companyName.Text + "','" + ((txt_line1.Text) + (txt_line2.Text) + (txt_city.Text)) + "','" + txt_contactNum.Text + "','" + txt_nic.Text + "','" + txt_email.Text + "','" + dtp_regDate.Value.ToString() + "','" + txt_faxNum.Text + "','" + txt_siteName.Text + "','" + rtxt_comments.Text + "')";
                int line = db.update_del_insert_Data(sql);
                db.closeCon();
                if (line == 1)
                {
                    MessageBox.Show("Supplier successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplier register process is failed.Please try again thank you", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check the form and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_siteName_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(genarateSupplierID));
            th.Start();
        }
       
        private void genarateSupplierID()
        {
            string sql = null;
            int lineNum = 0;
            try
            {
                sql = "Select Count (supp_ID) From supplier_table";
                lineNum = db.returnDBRows(sql);
                db.closeCon();
                lineNum++;
                supplier_Id = ((uniqueNameForSuppID) + (year.Substring(2)) + lineNum);
                txt_suppID.Text = supplier_Id.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please check the form again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the form again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            new UpdateSupplier().Show(this);
        }

        private void txt_companyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator.SetError(txt_companyName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator.Clear();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            new SearchSupplierMessageBox().Show(this);
          
        }
    }
}
