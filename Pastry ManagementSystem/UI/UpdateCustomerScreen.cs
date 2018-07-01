using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pastry_ManagementSystem.DB;

namespace Pastry_ManagementSystem.UI
{
    public partial class UpdateCustomerScreen : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public UpdateCustomerScreen()
        {
            InitializeComponent();
        }
        private string _cusID = null,_cusFName=null, _cusLName=null, cusNic=null;
        private int _cusContact = 0;
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text.Length == 0 && txt_contactNum.Text.Length == 0 && txt_name.Text.Length == 0 && txt_nic.Text.Length == 0)
                {
                    MessageBox.Show("Please fill one of the text fields to continue the process", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cust_info_grpBox.Enabled = true;
                    string sql;
                    SqlDataReader reader;
                    sql = "Select * From Customer_Table where cusID='"+ txt_id.Text+ "' OR ContactNum='" + txt_contactNum .Text+ "' OR FirstName='"+ txt_name .Text+ "' OR NIC='"+ txt_nic .Text+ "'";
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        _cusID = reader["cusID"].ToString();
                        _cusContact = Convert.ToInt32(reader["ContactNum"]);
                        _cusFName = reader["FirstName"].ToString();
                        _cusLName= reader["LastName"].ToString();
                        cusNic = reader["NIC"].ToString();
                        txt_fName.Text = _cusFName;
                        txt_lName.Text = _cusLName;
                        txt_cusNic.Text = cusNic;
                        rtxt_cusAddress.Text = reader["cus_address"].ToString();
                        dtp_date.Text= reader["regDate"].ToString();
                        txt_contactNo.Text = _cusContact.ToString();
                        rtxt_Comments.Text= reader["comments"].ToString();
                    }
                    db.closeCon();
                    if (txt_id.Text.Length !=0)
                    {
                        if (txt_id.Text != _cusID)
                        {
                            MessageBox.Show("Invalid customer id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cust_info_grpBox.Enabled = false;
                            return;
                        }
                        else
                        {
                            cust_info_grpBox.Enabled = true;
                            groupBox1.Enabled = false;
                        }
                    }
                    if (txt_contactNo.Text.Length !=0)
                    {
                        if (txt_contactNo.Text != _cusContact.ToString())
                        {
                            MessageBox.Show("Invalid contact number", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cust_info_grpBox.Enabled = false;
                            return;
                        }
                        else
                        {
                            cust_info_grpBox.Enabled = true;
                            groupBox1.Enabled = false;
                        }
                    }
                    if (txt_name.Text.Length !=0)
                    {
                        if (txt_name.Text != _cusFName)
                        {
                            MessageBox.Show("Invalid name", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cust_info_grpBox.Enabled = false;
                            return;
                        }
                        else if(txt_name.Text == _cusFName)
                        {
                            cust_info_grpBox.Enabled = true;
                            groupBox1.Enabled = false;
                        }
                    }
                    if (txt_nic.Text.Length !=0)
                    {
                        if (txt_nic.Text != cusNic)
                        {
                            MessageBox.Show("Invalid Customer NIC", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cust_info_grpBox.Enabled = false;
                            return;
                        }
                        else
                        {
                            cust_info_grpBox.Enabled = true;
                            groupBox1.Enabled = false;
                        }
                    }     
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.Text.Length==0)
            {
                txt_fName.Clear();
                txt_lName.Clear();
                txt_cusNic.Clear();
                rtxt_cusAddress.Clear();                
                txt_contactNo.Clear();
                rtxt_Comments.Clear();
                db.closeCon();
                errorProvider1.Clear();
                errorProvider2.Clear();
                cust_info_grpBox.Enabled = false;
            }
        }

        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            if (txt_contactNum.Text.Length==0)
            {
                txt_fName.Clear();
                txt_lName.Clear();
                txt_cusNic.Clear();
                rtxt_cusAddress.Clear();
                txt_contactNo.Clear();
                rtxt_Comments.Clear();
                db.closeCon();
                errorProvider1.Clear();
                errorProvider2.Clear();
                cust_info_grpBox.Enabled = false;
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text.Length==0)
            {
                txt_fName.Clear();
                txt_lName.Clear();
                txt_cusNic.Clear();
                rtxt_cusAddress.Clear();
                txt_contactNo.Clear();
                rtxt_Comments.Clear();
                db.closeCon();
                errorProvider1.Clear();
                errorProvider2.Clear();
                cust_info_grpBox.Enabled = false;
            }
        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            string str = txt_nic.Text;
            //formValidator3.Clear();
            if (!(str.Length == 0))
            {
                if ((str.Count(char.IsDigit) == 9) && // only 9 digits
                (str.EndsWith("X", StringComparison.OrdinalIgnoreCase)
                 || str.EndsWith("V", StringComparison.OrdinalIgnoreCase)) && //a letter at the end 'x' or 'v'
                (str[2] != '4' && str[2] != '9')) //3rd digit can not be equal to 4 or 9
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
                else
                {
                    errorProvider2.Clear();
                    errorProvider1.SetError(txt_nic, "please check your NIC Number");
                }
            }
            else 
            {
                txt_fName.Clear();
                txt_lName.Clear();
                txt_cusNic.Clear();
                rtxt_cusAddress.Clear();
                txt_contactNo.Clear();
                rtxt_Comments.Clear();
                db.closeCon();
                errorProvider1.Clear();
                errorProvider2.Clear();
                cust_info_grpBox.Enabled = false;
            }
        }

        private void txt_contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_contactNum, "Please check your contact Number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_name, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_fName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_fName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_lName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_lName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_cusNic_TextChanged(object sender, EventArgs e)
        {
            string str = txt_nic.Text;
            //formValidator3.Clear();
            if (!(str.Length == 0))
            {
                if ((str.Count(char.IsDigit) == 9) && // only 9 digits
                (str.EndsWith("X", StringComparison.OrdinalIgnoreCase)
                 || str.EndsWith("V", StringComparison.OrdinalIgnoreCase)) && //a letter at the end 'x' or 'v'
                (str[2] != '4' && str[2] != '9')) //3rd digit can not be equal to 4 or 9
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
                else
                {
                    errorProvider2.Clear();
                    errorProvider1.SetError(txt_cusNic, "please check your NIC Number");
                }
            }
        }

        private void txt_contactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_contactNum, "Please check your contact Number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        int line;

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            db.closeCon();
            try
            {
                string sql;
                sql = "Update Customer_Table Set FirstName='"+ txt_fName .Text+ "',LastName='"+ txt_lName .Text+ "',NIC='"+ txt_cusNic .Text+ "',cus_address='"+ rtxt_cusAddress .Text+ "',regDate='"+dtp_date.Value.ToString()+"',ContactNum='"+ txt_contactNo.Text+ "',comments='"+ rtxt_Comments .Text+ "' where  cusID='"+ _cusID + "'";
                line = db.update_del_insert_Data(sql);
                db.closeCon();
                if (line == 1)
                {
                    MessageBox.Show("Customer Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fName.Clear();
            txt_lName.Clear();
            txt_cusNic.Clear();
            rtxt_cusAddress.Clear();
            txt_contactNo.Clear();
            rtxt_Comments.Clear();
            db.closeCon();
            errorProvider1.Clear();
            errorProvider2.Clear();
            cust_info_grpBox.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
