using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class CustomerRegister : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string sysYear { get; set; }
        private string uniqueKeyForCus { get; set; } = "CUS";
        public string str { get; set; }
        protected string cusID { get; set; }
        public string address { get; set; }
        public CustomerRegister()
        {
            InitializeComponent();
            t_timer.Start();
        }

        private void t_timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            sysYear = dt.Year.ToString();
            lbl_time.Text = dt.ToString();
        }
        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;  
        }
        private void txt_fName_TextChanged(object sender, EventArgs e)
        {
            if (txt_fName.Text.Length==0)
            {
                error_pro1.SetError(txt_fName,"Please enter customer first name");
            }
            else
            {
                if (txt_fName.Text.Length >= 3)
                {
                    error_pro1.Clear();
                }
            }
        }
        private void txt_fName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    error_pro1.SetError(txt_fName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                error_pro1.Clear();
            }
        }

        private void txt_lName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    error_pro1.SetError(txt_lName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                error_pro1.Clear();
            }
        }
        private void txt_lName_TextChanged(object sender, EventArgs e)
        {
            if (txt_lName.Text.Length == 0)
            {
                error_pro1.SetError(txt_lName, "Please enter customer last name");
            }
            else
            {
                if (txt_fName.Text.Length >= 3)
                {
                    error_pro1.Clear();
                }
            }
        }
        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
           str = txt_nic.Text;
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
                    errorProvider1.SetError(txt_nic,"Please check customer nic");
                }
                error_pro1.Clear();
            }
            else
            {
                error_pro1.SetError(txt_nic, "Please enter your nic number");
            }
        }

        private void txt_line1_TextChanged(object sender, EventArgs e)
        {
            if (txt_line1.Text.Length == 0)
            {
                error_pro1.SetError(txt_line1, "Please fill customer address field");
            }
            else
            {
                if (txt_line1.Text.Length >= 3)
                {
                    error_pro1.Clear();
                }
            }

        }
        private void txt_line2_TextChanged(object sender, EventArgs e)
        {
            if (txt_line2.Text.Length == 0)
            {
                error_pro1.SetError(txt_line2, "Please fill customer address field");
            }
            else
            {
                if (txt_line2.Text.Length >= 3)
                {
                    error_pro1.Clear();
                }
            }
        }
        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            if (txt_city.Text.Length == 0)
            {
                error_pro1.SetError(txt_city, "Please fill the city text field");
            }
            else
            {
                if (txt_city.Text.Length >= 3)
                {
                    error_pro1.Clear();
                }
            }
        }
        private void txt_contactNo_TextChanged(object sender, EventArgs e)
        {
            if (txt_contactNo.Text.Length == 0)
            {
                error_pro1.SetError(txt_contactNo, "Please enter customer last name");
            }
            else
            {
                error_pro1.Clear();
                if (txt_contactNo.Text.Length >= 6 && txt_contactNo.Text.Length <= 10)
                {
                    error_pro1.Clear();
                }
                else
                {
                    error_pro1.SetError(txt_contactNo, "Please check customer contact no");

                }
            }
        }
        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_date.Value.Equals(null))
            {
                error_pro1.SetError(dtp_date, "Please today's date");
            }

        }
        private void txt_contactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                error_pro1.SetError(txt_contactNo, "Please check your contact Number");
            }
            else
            {
                this.error_pro1.Clear();
            }
        }
        private void rtxt_Comments_TextChanged(object sender, EventArgs e)
        {
            if (rtxt_Comments.Text.Length == 0)
            {
                error_pro1.SetError(rtxt_Comments, "Please fill comment field");
            }
            else
            {
                if (rtxt_Comments.Text.Length >= 3)
                {
                   error_pro1.Clear();
                }
            }
        }

        private void createCusID()
        {
            try
            {
                string sbStringYear;
                sbStringYear = sysYear.Substring(2);
                string query;
                int No_id = 0;
                query = "Select Count (cusID) From Customer_Table";
                No_id = db.returnDBRows(query);
                db.closeCon();
                No_id++;
                cusID = ((uniqueKeyForCus) + (sbStringYear) + (No_id)).ToString();
                txt_id.Text = cusID.ToString();
                //MessageBox.Show("" + cusID);
                //id works fine
            }
            catch (Exception)
            {
                MessageBox.Show("System crashed plz log out try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end of customer id 
        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }
       
        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_fName.Text.Length == 0)
            {
                MessageBox.Show("Please enter customer's first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_lName.Text.Length == 0)
            {
                MessageBox.Show("Please enter customer's last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_nic.Text.Length == 0)
            {
                MessageBox.Show("Please enter customer's NIC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txt_line1.Text.Length == 0) && (txt_line2.Text.Length == 0) && (txt_city.Text.Length == 0))
            {
                MessageBox.Show("Please check customer's address again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtp_date.Value.Equals(null))
            {
                MessageBox.Show("Please select the date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contactNo.Text.Length == 0)
            {
                MessageBox.Show("Please enter customer's contact number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rtxt_Comments.Text.Length == 0)
            {
                MessageBox.Show("Please fill comment field ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Thread th = new Thread(createCusID);
                    th.Start();
                    btn_save.Enabled = true;
                   
                }
                catch
                {
                    MessageBox.Show("Process is failed please check the inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = null;
                sql = "insert into Customer_Table values('" + txt_id.Text + "','" + txt_fName.Text + "','" + txt_lName.Text + "','" + txt_nic.Text + "','"+((txt_line1.Text) +(txt_line2.Text) +(txt_city.Text))+"','" + dtp_date.Value.ToString() + "','" + txt_contactNo.Text + "','" + rtxt_Comments.Text + "')";
                int line = 0;
                line = db.update_del_insert_Data(sql);
                db.closeCon();
                if (line == 1)
                {
                    MessageBox.Show("Customer Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Process is failed please check the inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Process is failed please check the inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new CashierMenu().Show();
            this.Hide();
        }
    }
}
