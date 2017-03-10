using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class UpdateSupplier : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        protected string email { get; set; }
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                FormValidator2.SetError(txt_contact, "please check your contact number again");
            }
            else
            {
                this.FormValidator2.Clear();
            }
        }

        private void txt_suppName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txt_companuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator2.SetError(txt_cmpnyName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator2.Clear();
            }
        }
        string v_suppID,v_companyName = null;
        int v_contactNum = 0;
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_suppID.Text.Length == 0 && txt_contact.Text.Length == 0 && txt_cmpnyName.Text.Length == 0)
            {
                MessageBox.Show($"Please Fill all fields or one field is enough for find the supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //do the process
                string sql = null;
                SqlDataReader reader;
                try
                {
                    sql = "Select DISTINCT * From supplier_table where supp_ID ='"+ txt_suppID .Text+ "' OR contactNumber='"+txt_contact.Text+ "' OR company_Name='"+txt_cmpnyName.Text+"'";
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        v_suppID = reader["supp_ID"].ToString();
                        v_contactNum = Convert.ToInt32(reader["contactNumber"].ToString());
                        v_companyName = reader["company_Name"].ToString();
                        txt_firstName.Text = reader["supp_FirstName"].ToString();
                        txt_lastName.Text = reader["supp_lastName"].ToString();
                        txt_companyName.Text = reader["company_Name"].ToString();
                        rrtxt_fullAddress.Text = reader["company_Address"].ToString();
                        txt_contactNum.Text = reader["contactNumber"].ToString();
                        txt_nic.Text = reader["NIC"].ToString();
                        txt_email.Text = reader["emailAddress"].ToString();
                        dtp_regDate.Text = reader["RegisteredDate"].ToString();
                        txt_faxNum.Text = reader["fax_Num"].ToString();
                        txt_siteName.Text = reader["web_siteName"].ToString();
                        rtxt_comments.Text = reader["Comments"].ToString();
                    }
                    db.closeCon();
                    if (v_suppID !=txt_suppID.Text && v_contactNum.ToString()!=txt_contact.Text && v_companyName!= txt_cmpnyName.Text)
                    {
                        MessageBox.Show("There's no record like that please check again","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }                    
                }
                catch (Exception)
                {

                }
            }

        }

        private void txt_suppID_TextChanged(object sender, EventArgs e)
        {
            if (txt_suppID.Text.Length==0)
            {
                txt_firstName.Clear();
                txt_lastName.Clear();
                txt_companyName.Clear();
                rrtxt_fullAddress.Clear();
                txt_contactNum.Clear();
                txt_nic.Clear();
                txt_email.Clear();
                txt_faxNum.Clear();
                txt_siteName.Clear();
                rtxt_comments.Clear();
            }
        }
        int line = 0;
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = null;
                sql = "Update supplier_table Set supp_FirstName='"+txt_firstName.Text+ "',supp_lastName='"+txt_lastName.Text+ "',company_Name='"+ txt_companyName .Text+ "',company_Address='"+ rrtxt_fullAddress .Text+ "'," +
                    "contactNumber='"+ txt_contactNum.Text+ "',NIC='"+txt_nic.Text+ "',emailAddress='"+ email + "',RegisteredDate='"+dtp_regDate.Value.ToString()+ "',fax_Num='"+txt_faxNum.Text+"',"
                    + "web_siteName='"+ txt_siteName .Text+ "',Comments='"+rtxt_comments.Text+ "' where supp_ID='"+txt_suppID.Text+ "' OR contactNumber='"+ txt_contact .Text+ "' OR company_Name='"+ txt_cmpnyName .Text+ "'";
                line = db.update_del_insert_Data(sql);
                if (line == 1)
                {
                    MessageBox.Show("Supplier updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplier is not updated,please try again with proper information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_cmpnyName_TextChanged(object sender, EventArgs e)
        {
            if (txt_cmpnyName.Text.Length == 0)
            {
                txt_firstName.Clear();
                txt_lastName.Clear();
                txt_companyName.Clear();
                rrtxt_fullAddress.Clear();
                txt_contactNum.Clear();
                txt_nic.Clear();
                txt_email.Clear();
                txt_faxNum.Clear();
                txt_siteName.Clear();
                rtxt_comments.Clear();
            }
        }

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator2.SetError(txt_firstName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator2.Clear();
            }
        }

        private void txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator2.SetError(txt_lastName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator2.Clear();
            }
        }

        private void txt_companyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    FormValidator2.SetError(txt_companyName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                FormValidator2.Clear();
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

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            string str = txt_nic.Text;
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
       
        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public void loadData(string v_name1, string v_name2, string v_cmpName, string v_add, int v_cont, string v_nic, string v_email, string v_date,int v_faxNum,string v_stiteName, string v_comment)
        {
            txt_firstName.Text = v_name1.ToString();
            txt_lastName.Text = v_name2.ToString();
            txt_companyName.Text = v_cmpName.ToString();
            rrtxt_fullAddress.Text = v_add.ToString();
            txt_contactNum.Text = v_cont.ToString();
            txt_nic.Text = v_nic.ToString();
            txt_email.Text = v_email.ToString();
            dtp_regDate.Text = v_date.ToString();
            txt_faxNum.Text = v_faxNum.ToString();
            txt_siteName.Text = v_stiteName.ToString();
            rtxt_comments.Text = v_comment.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            if (txt_contact.Text.Length == 0)
            {
                txt_firstName.Clear();
                txt_lastName.Clear();
                txt_companyName.Clear();
                rrtxt_fullAddress.Clear();
                txt_contactNum.Clear();
                txt_nic.Clear();
                txt_email.Clear();
                txt_faxNum.Clear();
                txt_siteName.Clear();
                rtxt_comments.Clear();
            }
        }

    }
}
