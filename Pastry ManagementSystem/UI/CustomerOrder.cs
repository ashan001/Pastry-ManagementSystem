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
      
        public CustomerOrder()
        {
            InitializeComponent();
            t_timer.Start();
        }
        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            cmb_foodName.SelectedText = "Please select your food".ToString();
            cmb_foodName.BackColor = Color.LightCoral;
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
                last2DigitsOfYear = sysYear.Substring(2);
                string sql = "Select * From Food_Order_Header";
                int line;//line == number of rows
                line = db.returnDBRows(sql);
                db.closeCon();
                line++;
                orderID = ((last2DigitsOfYear) + (line)).ToString();
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
            if (!(cmb_foodName.SelectedIndex==-1))
            {
                Thread th = new Thread(new ThreadStart(createOrderID));
                th.Start();
            }
        }
       
        string fName, lName,address,cusID = null;

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
                ErrorPro_1.SetError(txt_contact, "Please check your contact Number");
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
                txt_id.Text = orderID.ToString();
                //will set the order id after the finale text field
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
                    }
                    if (val_contact==(Convert.ToInt32(txt_contact.Text)))
                    {
                        txt_fName.Text = fName;
                        txt_lName.Text = lName;
                        txt_line1.Text = address;                       
                        txt_CusID.Text = cusID;
                        ErrorPro_1.Clear();
                    }
                    else if (val_contact < (Convert.ToInt32(txt_contact.Text)))
                    {
                        txt_fName.Clear();
                        txt_lName.Clear();
                        txt_line1.Clear();                        
                        txt_CusID.Clear();
                        ErrorPro_1.SetError(txt_contact, "Please check customer contact number");
                    }
                    else if (val_contact > (Convert.ToInt32(txt_contact.Text)))
                    {
                        txt_fName.Clear();
                        txt_lName.Clear();
                        txt_line1.Clear();
                        txt_CusID.Clear();
                        ErrorPro_1.SetError(txt_contact, "Please check customer contact number");
                    }
                    db.closeCon();
                }
               
            }
            catch (Exception)
            {

            }
        }
        string sql;
        private void btn_order_Click(object sender, EventArgs e)
        {
            try
            {

                sql = "Insert into Food_Order_Header values ('"+ txt_id .Text+ "','"+ txt_CusID .Text+ "','"+dtp_orderDate.Value.ToString()+"','"+dtp_dueDate.Value.ToString()+"','"+ txt_time.Text + "','"+ cmb_foodName .SelectedItem.ToString()+ "','"+ txt_qty .Text+ "')";
                int line = 0;
                line = db.update_del_insert_Data(sql);
                db.closeCon();
                if (line == 1)
                {
                    MessageBox.Show("Food order saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Food order is failed please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

            }
        }

    }
}
