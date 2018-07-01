using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class CustomerOrder : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
     
        public string orderedDate { get; set; }
        public string orderID { get; set; }
        public string sysYear { get; set; }
        public string val = "*";
      
        public CustomerOrder()
        {
            InitializeComponent();
            t_timer.Start();
        }
        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            cmb_foodName.SelectedText = "Please select your food".ToString();
            cmb_foodName.BackColor = Color.LightCoral;
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                SqlDataReader reader;
                string sql = "Select * From Food_Table";
                reader = db.getData(sql);                
                while (reader.Read()) {
                    cmb_foodName.Items.Add(reader["Food_Name"].ToString());
                    //should load the all the food names from the DB
                }
                db.closeCon();
            }
            catch (Exception)
            {

            }
        }
        private void createOrderID()
        {
            string last2DigitsOfYear;
            try
            {
                CreateOrdID ord1 = new CreateOrdID();
                last2DigitsOfYear = sysYear.Substring(2);
                string sql = "Select Count (*) From Food_Order_Header";
                int line;//line == number of rows
                line = db.returnDBRows(sql);
                db.closeCon();
                line++;
                orderID = ((ord1.getOrdID()) +(last2DigitsOfYear) + (line)).ToString();
                txt_id.Text = orderID.ToString();
                //will set the order id after the finale text field
            }
            catch (Exception)
            {

            }

        }
        private void t_timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_Time.Text = dt.ToString();
            orderedDate = dt.Date.ToString();
            sysYear = dt.Date.Year.ToString();           
        }
        
        private void cmb_foodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_foodName.BackColor = Color.LightGreen;
            string sql = null;
            SqlDataReader reader = null;        
            if (!(cmb_foodName.SelectedIndex==-1))
            {
                sql = "Select Food_Name,price From Food_Table where Food_Name = '" + cmb_foodName.SelectedItem.ToString()+"' ";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    if (cmb_foodName.SelectedItem.ToString() == reader["Food_Name"].ToString())
                    {
                        txt_itemPrice.Text = reader["price"].ToString();
                        ErrorPro_1.Clear();
                    }
                    else
                    {
                        ErrorPro_1.SetError(cmb_foodName,"Please check your item name");
                    }
                }
                db.closeCon();
               
            }
        }
       
        string fName = null, lName = null, address = null, cusID = null,nic = null,cmmnts = null,date = null;

        private void txt_time_TextChanged(object sender, EventArgs e)
        {
            if (txt_time.Text.Length==0)
            {
                ErrorPro_1.SetError(txt_contact, "Please check your input and try again");

            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ErrorPro_1.SetError(txt_qty, "Numeric Values Onlu Accepted");
            }
            else
            {
                this.ErrorPro_1.Clear();
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length == 0)
            {
                ErrorPro_1.SetError(txt_qty, "Please fill quantity field");
            }
            else if (!(txt_qty.Text.Length == 0))
            {
                Thread th2 = new Thread(new ThreadStart(doCal));
                th2.Start();
            }
        }
        public void doCal()
        {
            try
            {
                double tot_amt;
                tot_amt = ((Convert.ToDouble(txt_qty.Text))*(Convert.ToDouble(txt_itemPrice.Text)));
                txtTotAmt.Text = tot_amt.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void txt_itemPrice_TextChanged(object sender, EventArgs e)
        {
            if (txt_itemPrice.Text != null)
            {
                txt_qty.Enabled = true;
            }
        }

        private void txtTotAmt_TextChanged(object sender, EventArgs e)
        {
            if (txtTotAmt.Text != null)
            {
                Thread th = new Thread(new ThreadStart(createOrderID));
                th.Start();
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ErrorPro_1.SetError(txt_contact, "Please check your contact Number");
            }
            else
            {
                this.ErrorPro_1.Clear();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new CashierMenu().Show();
            this.Hide();
        }

        private void dtp_dueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_dueDate.Value.Equals(null))
            {
                ErrorPro_1.SetError(dtp_dueDate, "Please today's date");
            }
        }

        int val_contact = 0;
        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader;
                if (txt_contact.Text.Length == 0)
                {
                    ErrorPro_1.SetError(txt_contact, "Please enter customer contact number");
                    txt_fName.Clear();
                    txt_lName.Clear();
                    txt_line1.Clear();                   
                    txt_CusID.Clear();
                }
                else
                {
                    ErrorPro_1.Clear();
                    string sql;                                        
                    sql = "select * from Customer_Table where ContactNum='" + txt_contact.Text + "'";
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        val_contact = Convert.ToInt32(reader["ContactNum"]);
                        fName = reader["FirstName"].ToString();
                        lName = reader["LastName"].ToString();
                        address = reader["cus_address"].ToString();
                        cusID = reader["cusID"].ToString();
                        nic = reader["NIC"].ToString();
                        date = reader["regDate"].ToString();
                        cmmnts = reader["comments"].ToString();

                    }
                    if (val_contact==(Convert.ToInt32(txt_contact.Text)))
                    {
                        txt_fName.Text = fName;
                        txt_lName.Text = lName;
                        txt_line1.Text = address;                       
                        txt_CusID.Text = cusID;
                        txt_nic.Text = nic;
                        txt_regDate.Text = date;
                        rtxt_box1.Text = cmmnts;
                        ErrorPro_1.Clear();
                    }
                    else if (val_contact < (Convert.ToInt32(txt_contact.Text)))
                    {
                        txt_fName.Clear();
                        txt_lName.Clear();
                        txt_line1.Clear();                        
                        txt_CusID.Clear();
                        txt_nic.Clear();
                        txt_regDate.Clear();
                        rtxt_box1.Clear();
                        ErrorPro_1.SetError(txt_contact, "Please check customer contact number");
                    }
                    else if (val_contact > (Convert.ToInt32(txt_contact.Text)))
                    {
                        txt_fName.Clear();
                        txt_lName.Clear();
                        txt_line1.Clear();
                        txt_CusID.Clear();
                        txt_nic.Clear();
                        txt_regDate.Clear();
                        rtxt_box1.Clear();
                        ErrorPro_1.SetError(txt_contact, "Please check customer contact number");
                    }
                    db.closeCon();
                }
               
            }
            catch (Exception)
            {

            }
        }
        private void btn_order_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                sql = "Insert into Food_Order_Header values ('" + txt_id.Text + "','" + txt_CusID.Text + "','" + dtp_orderDate.Value.ToString().Substring(0,9) + "','" + dtp_dueDate.Value.ToString().Substring(0,9) + "','" + txt_time.Text + "','" + cmb_foodName.SelectedItem.ToString() + "','"+txt_itemPrice.Text.ToString()+"','" + txt_qty.Text + "','"+txtTotAmt.Text.ToString()+"','"+ val + "')";
                int line = 0;
                line = db.update_del_insert_Data(sql);
                db.closeCon();
                if (line == 1)
                {
                    MsgBox.Information("Food order saved successfully");                  
                    txt_id.Clear();
                    txt_contact.Clear();
                    txt_fName.Clear();
                    txt_lName.Clear();
                    txt_line1.Clear();
                    txt_CusID.Clear();
                    dtp_dueDate.Value = DateTime.Today;
                    txt_time.Clear();
                    txt_qty.Clear();
                    txt_nic.Clear();
                    txt_regDate.Clear();
                    rtxt_box1.Clear();
                    txt_itemPrice.Clear();
                    txtTotAmt.Clear();
                    cmb_foodName.SelectedText = null;
                    cmb_foodName.SelectedText = "Please select your food Item".ToLower().ToString().Substring(0,28);
                    cmb_foodName.BackColor = Color.LightCoral;
                    txt_qty.Enabled = false;
                    ErrorPro_1.Clear();
                    Thread.Sleep(1000);
                    db.closeCon();
                }
                else
                {
                    MsgBox.Error("Food order is failed please try again");
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }        
    }
    public class CreateOrdID
    {
        static Random generator = new Random();
        string ordID = generator.Next(0001, 10001).ToString();

        public string getOrdID()
        {
            return ordID;
        }
    }
}
