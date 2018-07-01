using Pastry_ManagementSystem.DB;
using System;
using Dapper;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class MultipleCustomerOrders : MetroFramework.Forms.MetroForm
    {
        public string year_lastTwoNum { get; set; }
        public string refNo { get; set; }
        public string orderID { get; set; }
        public string sysYear { get; set; }
        public int _noOfTimes_clicked { get; set; }
        public MultipleCustomerOrders()
        {
            InitializeComponent();
            timer1.Start();
            btn_order.Cursor = Cursors.Hand;
            btn_Back.Cursor = Cursors.Hand;
            btn_clear.Cursor = Cursors.Hand;
        }
        Database db = new Database();

        private void dtp_orderdate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_orderdate.Value.ToString() != string.Empty)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            else
            {

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }

        private void dtp_dueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_dueDate.Value.ToString() != string.Empty)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            else
            {

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }
        public string fName=null, lName=null, address=null, cusID=null, nic=null, date=null, cmmnts=null;

        private void MultipleCustomerOrders_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            cmb_foodName.SelectedText = "Please select your food".ToString();
            cmb_foodName.BackColor = Color.LightCoral;
            try
            {
                SqlDataReader reader;
                string sql = "Select * From Food_Table";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    cmb_foodName.Items.Add(reader["Food_Name"].ToString());
                    //should load the all the food names from the DB
                }
                db.closeCon();
            }
            catch (Exception)
            {

            }
        }

        private void cmb_foodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_foodName.BackColor = Color.LightGreen;
            string sql = null;
            SqlDataReader reader = null;
            if (!(cmb_foodName.SelectedIndex == -1))
            {
                sql = "Select Food_Name,price From Food_Table where Food_Name = '" + cmb_foodName.SelectedItem.ToString() + "' ";
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
                        ErrorPro_1.SetError(cmb_foodName, "Please check your item name");
                    }
                }
                db.closeCon();

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
                tot_amt = ((Convert.ToDouble(txt_qty.Text)) * (Convert.ToDouble(txt_itemPrice.Text)));
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            _noOfTimes_clicked++;
            string _year_last2;
            try
            {
                _year_last2 = sysYear.Substring(2);
                string _day = DateTime.Now.Day.ToString();
                GenerateReferenceNo obj = new GenerateReferenceNo();
                refNo = ((obj.getRefNo()) + (_year_last2) + (_day)).ToString();
                txt_refNum.Text = refNo.ToString();
                int n = grid1.Rows.Add();
                grid1.Rows[n].Cells[0].Value = txt_refNum.Text.ToString();
                grid1.Rows[n].Cells[1].Value = txt_CusID.Text.ToString();
                grid1.Rows[n].Cells[2].Value = txt_id.Text.ToString();
                grid1.Rows[n].Cells[3].Value = cmb_foodName.SelectedItem.ToString();
                grid1.Rows[n].Cells[4].Value = txt_qty.Text.ToString();
                grid1.Rows[n].Cells[5].Value = txt_itemPrice.Text.ToString();
                grid1.Rows[n].Cells[6].Value = txtTotAmt.Text.ToString();
                btn_order.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
        int totSum;
        private void btn_order_Click(object sender, EventArgs e)
        {
            try
            {
                int _line = 0;
                string _sql = "Insert into Food_Order_Header values ('" + txt_id.Text + "','" + txt_CusID.Text + "','" + dtp_orderdate.Value.ToString().Substring(0, 9) + "','" + dtp_dueDate.Value.ToString().Substring(0, 9) + "','" + txt_time.Text + "','" + cmb_foodName.SelectedItem.ToString() + "','" + txt_itemPrice.Text.ToString() + "','" + txt_qty.Text + "','" + txtTotAmt.Text.ToString() + "','" + _noOfTimes_clicked + "')";
                _line = db.update_del_insert_Data(_sql);
                db.closeCon();
                int _line1 = 0;
                for (int c = 0; c < grid1.Rows.Count; c++)
                {
                    string sql = $"Insert Into Multiple_Food_Order_transaction Values('{grid1.Rows[c].Cells["cl_index1"].Value.ToString()}','{grid1.Rows[c].Cells["cl_index2"].Value.ToString()}','{grid1.Rows[c].Cells["cl_index3"].Value.ToString()}','{grid1.Rows[c].Cells["cl_index4"].Value.ToString()}','{dtp_orderdate.Value.ToString().Substring(0,9)}','{dtp_dueDate.Value.ToString().Substring(0,9)}','{grid1.Rows[c].Cells["cl_index5"].Value.ToString()}','{grid1.Rows[c].Cells["cl_index6"].Value.ToString()}','{grid1.Rows[c].Cells["cl_index7"].Value.ToString()}')";
                    _line1 = db.update_del_insert_Data(sql);
                    db.closeCon();
                }
                totSum = _line + _line1;
                if (totSum > 0)
                {
                    MessageBox.Show("Your orders saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_order.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Process is failed,please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtTotAmt_TextChanged(object sender, EventArgs e)
        {
            if (txtTotAmt.Text != null)
            {
                btn_add.Enabled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            grid1.Rows.Clear();
            btn_add.Enabled = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            new CashierMenu().Show();
            this.Hide();
        }

        private void txt_time_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_foodName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ErrorPro_1.SetError(txt_contact, "Numeric Values only allowed");
            }
            else
            {
                this.ErrorPro_1.Clear();
            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ErrorPro_1.SetError(txt_qty, "Numeric Values only allowed");
            }
            else
            {
                this.ErrorPro_1.Clear();
            }
        }

        private void txt_contact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadData();
                e.SuppressKeyPress = true;
                txt_time.Focus();
            }
        }
        void loadData()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State ==ConnectionState.Closed)
                    {

                        if (Convert.ToInt64(txt_contact.Text) != 0)
                        {
                            ErrorPro_1.Clear();
                            string sql;
                            sql = "select * from Customer_Table where ContactNum='" + Convert.ToInt64(txt_contact.Text) + "'";
                            IDataReader reader = db.ExecuteReader(sql);
                            while (reader.Read())
                            {
                                if (Convert.ToInt64(txt_contact.Text) == Convert.ToInt64(reader["ContactNum"]))
                                {
                                    ErrorPro_1.Clear();
                                    txt_fName.Text = reader["FirstName"].ToString();
                                    txt_lName.Text = reader["LastName"].ToString();
                                    txt_line1.Text = reader["cus_address"].ToString();
                                    txt_CusID.Text = reader["cusID"].ToString();
                                    txt_nic.Text = reader["NIC"].ToString();
                                    txt_regDate.Text = reader["regDate"].ToString();
                                    rtxt_box1.Text = reader["comments"].ToString();
                                }
                                else if (Convert.ToInt64(txt_contact.Text) != Convert.ToInt64(reader["ContactNum"]))
                                {
                                    ErrorPro_1.SetError(txt_contact, "Please check customer contact number");
                                    txt_fName.Clear();
                                    txt_lName.Clear();
                                    txt_line1.Clear();
                                    txt_CusID.Clear();
                                    txt_nic.Clear();
                                    txt_regDate.Clear();
                                    rtxt_box1.Clear();
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        private void cmb_foodName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_qty.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            lbl_Time.Text = dt.ToString();           
            sysYear = dt.Date.Year.ToString();
        }

        private void rtxt_box1_TextChanged(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(setReferencNo));
            if (rtxt_box1.Text != null)
            {
                th1.Start();
            }
        }
        int line = 0;
        public void setReferencNo()
        {
          
            try
            {
                GenerateOrderID obj = new GenerateOrderID();
                year_lastTwoNum = sysYear.Substring(2);
                string sql = "Select Count (*) From Food_Order_Header";
                line = db.returnDBRows(sql);
                db.closeCon();
                line++;
                orderID = ((obj.getOrdNo()) + (year_lastTwoNum) + (line)).ToString();
                txt_id.Text = orderID.ToString();
            }
            catch (Exception)
            {
            }
        }
        SqlDataReader reader;
        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
        }
    }
    public class GenerateOrderID
    {
        static Random generator = new Random();
        string ordNo = generator.Next(0001, 1000000000).ToString();

        public string getOrdNo()
        {
            return ordNo;
        }
    }
    public class GenerateReferenceNo
    {
        static Random generator = new Random();
        string refNo = generator.Next(000100000000, 1000000000).ToString();

        public string getRefNo()
        {
            return refNo;
        }
    }
}
