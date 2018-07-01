using MessageBoxControlCenter.MessageBoxes;
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
                CreateCusID id = new CreateCusID();
                string sbStringYear;
                sbStringYear = sysYear.Substring(2);
                string query;
                int No_id = 0;
                query = "Select Count (cusID) From Customer_Table";
                No_id = db.returnDBRows(query);
                db.closeCon();
                No_id++;
                cusID = ((id.getCusID()) + (sbStringYear) + (No_id)).ToString();
                txt_id.Text = cusID.ToString();
                //MessageBox.Show("" + cusID);
                //id works fine
            }
            catch (Exception)
            {               
                MsgBox.Error("Will saved up to here ,please start with new session");
            }
        }//end of customer id 
        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }
       
        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_fName.Text.Length == 0)
            {             
                MsgBox.Error("Please enter customer's first name");
            }
            else if (txt_lName.Text.Length == 0)
            {
                MsgBox.Error("Please enter customer's last name");
            }
            else if (txt_nic.Text.Length == 0)
            {
                MsgBox.Error("Please enter customer's NIC");
            }
            else if ((txt_line1.Text.Length == 0) && (txt_line2.Text.Length == 0) && (txt_city.Text.Length == 0))
            {               
                MsgBox.Error("Please check customer's address again");
            }
            else if (dtp_date.Value.Equals(null))
            {
                MsgBox.Error("Please select the date");
            }
            else if (txt_contactNo.Text.Length == 0)
            {
                MsgBox.Error("Please enter customer's contact number ");
            }
            else if (rtxt_Comments.Text.Length == 0)
            {               
                MsgBox.Error("Please fill comment field ");
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
                    MsgBox.Error("Process is failed please check the inputs and try again");
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
                    MsgBox.Information("Customer Successfully saved");
                }
                else
                {                    
                    MsgBox.Error("Process is failed please check the inputs and try again");
                }
            }
            catch (Exception)
            {                
                MsgBox.Error("Process is failed please check the inputs and try again");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {          
           Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            new UpdateCustomerScreen().ShowDialog();
            Hide();            
        }
    }
    public class CreateCusID
    {
        static Random generator = new Random();
        string cusID = generator.Next(0001, 10001).ToString();

        public string getCusID()
        {
            return cusID;
        }
    }
}
