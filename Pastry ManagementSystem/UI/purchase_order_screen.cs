using Pastry_ManagementSystem.DB;
using System.Data;
using System.Configuration;
using Dapper;
using Pastry_ManagementSystem.UI.HelpScreens;
using System;
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
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.UI
{
    public partial class purchase_order_screen : MetroFramework.Forms.MetroForm
    {
        //Database db = new Database();
        public int receiptNum { get; set; }
        public int purchaseID { get; set; }
        public string v_sup_cmpName { get; set; } = null;
        public purchase_order_screen()
        {
            InitializeComponent();
            timer1.Start();
        }
        int v_db_receiptNum;
        private void purchase_order_screen_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "SELECT DISTINCT * FROM received_raw_meterial_header_file WHERE receipt_No not in (SELECT TOP (SELECT COUNT(1)-1 FROM received_raw_meterial_header_file) receipt_No FROM received_raw_meterial_header_file)";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_db_receiptNum = Convert.ToInt32(reader["receipt_No"]);
                        }
                        v_db_receiptNum++;
                        if (v_db_receiptNum != 0)
                        {
                            txt_receiptNum.Text = v_db_receiptNum.ToString();
                            txt_sysDate.Text = DateTime.Now.Date.ToString().Substring(0, 9);
                            txt_sysTime.Text = DateTime.Now.Date.ToString().Substring(9);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database connectivity is failed,please ping to specified IP address,and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_receiptNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txt_purID.Focus();
            }
        }
        private void txt_receiptNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txt_receiptNum, "Only allowed to enter numeric values");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_receiptNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                receiptNum = Convert.ToInt32(txt_receiptNum.Text);
                //string sql = null;
                //sql = "Select ";
            }
            catch (Exception)
            {

            }
        }
        string v_purID = null;
      
        private void txt_purID_TextChanged(object sender, EventArgs e)
        {
           
            txt_itemID.Enabled = true;
            if (txt_purID.Text.Length == 0)
            {
                errorProvider1.SetError(txt_purID,"Please enter your purchase id");
                txt_cmpAddress.Clear();
                txt_Lname.Clear();
                txt_suppID.Clear();
                txt_Fname.Clear();
                txt_date.Clear();
                txt_suppcmpName.Clear();
                txt_purID.Clear();
                btnClear.Enabled = false;
                btn_proceed.Enabled = false;
                txt_itemID.Enabled = false;
            }           
        }
        public void loadData()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select pur_id,Suppllier_company_name,v_date From purchase_order_header_file where pur_id='" + txt_purID.Text.ToString() + "' ";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_purID = reader["pur_id"].ToString();
                            txt_suppcmpName.Text = reader["Suppllier_company_name"].ToString();
                            txt_date.Text = reader["v_date"].ToString().Substring(0, 9);
                        }
                        if (v_purID == txt_purID.Text)
                        {
                            txt_itemID.Enabled = true;
                            txt_itemID.Focus();
                        }
                        else
                        {
                            MsgBox.Warning("Invalid Purchase Id");
                            txt_purID.Focus();
                        }

                    }
                }
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txt_purID, "Please check your purchase id");
            }
            catch (Exception)
            {
                errorProvider1.SetError(txt_purID, "Please check your purchase id");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_suppcmpName_TextChanged(object sender, EventArgs e)
        {
            v_sup_cmpName = txt_suppcmpName.Text;
            Thread th1 = new Thread(new ThreadStart(methodLoadPODetails));
            th1.Start();
        }
        public void methodLoadPODetails()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From supplier_table where company_Name='" + v_sup_cmpName + "'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            txt_Fname.Text = reader["supp_FirstName"].ToString();
                            txt_Lname.Text = reader["supp_lastName"].ToString();
                            txt_suppID.Text = reader["supp_ID"].ToString();
                            txt_cmpAddress.Text = reader["company_Address"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public class CalculateReceiveNum
        {
            static Random generator = new Random();
            string receiveNum = generator.Next(00001, 1000000000).ToString();

            public string getReceiptNum()
            {
                return receiveNum;
            }
        }
        string _itemID;
        private void txt_itemID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_itemID.Text.Length == 0)
                {
                    errorProvider1.SetError(txt_itemID, "Please Enter Item Id");
                    txt_itemName.Clear();
                    txt_price.Clear();
                    txt_qty.Clear();
                }
            }
            catch (Exception)
            {
            }
        }
        public void loadItemData()
        {
            string sql = null;

            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        sql = "Select ItemID,Item_Name,tot_purchases,purchase_price From Item_File where ItemID ='" + txt_itemID.Text + "'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            _itemID = reader["ItemID"].ToString();
                            txt_itemName.Text = reader["Item_Name"].ToString();
                            txt_price.Text = ((Convert.ToDouble(reader["purchase_price"])) / (Convert.ToDouble(reader["tot_purchases"]))).ToString();

                        }
                        if (_itemID != txt_itemID.Text)
                        {
                            txt_itemName.Clear();
                            txt_price.Clear();
                            txt_qty.Clear();
                            txt_itemID.Enabled = true;
                            errorProvider1.SetError(txt_itemID, "Please Check your Item Id");
                        }
                        else
                        {
                            errorProvider1.Clear();
                            warehouseCode.Focus();
                            //txt_qty.Focus();
                        }
                    }
                }
            }
            catch
            {
                MsgBox.Warning("Please check you item id,use help screen to proceed");
            }
        }
        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            if (txt_price.Text !=null)
            {
                lbl_qty.Visible = true;
                txt_qty.Visible = true;
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length <= 0)
            {
                errorProvider1.SetError(txt_qty,"Please check you quantity");
                btn_proceed.Enabled = false;
                btnClear.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btn_proceed.Enabled = true;
                btnClear.Enabled = true;
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            txt_cmpAddress.Clear();
            txt_Lname.Clear();
            txt_suppID.Clear();
            txt_Fname.Clear();
            txt_date.Clear();
            txt_suppcmpName.Clear();
            txt_purID.Clear();
            txt_itemID.Clear();
            txt_itemID.Enabled = false;
            txt_itemName.Clear();
            txt_price.Clear();
            txt_qty.Clear();
            errorProvider1.Clear();      
        }

        private void txt_purID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadData();                
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                searchPO_Click(sender,e);
            }
           
        }
        private void txt_itemID_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txt_itemID.Text.Length != 0)
                {
                    loadItemData();
                    e.SuppressKeyPress = true;
                    txt_itemID.Enabled = false;
                }
                else
                {
                    txt_itemID.Enabled = true;
                }

            }
            else if (e.KeyCode == Keys.F2)
            {
                itemIDSearch_Click(sender,e);
            }                       
        }

        private void txt_purID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_purID, " Only allowed numeric values");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_itemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_itemID, " Only allowed numeric values");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_purID, " Only allowed numeric values");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_purID, " Only allowed numeric values");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_proceed.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txt_itemID.Enabled = true;
                txt_itemID.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            PurchaseOrderProcess obj1 = new PurchaseOrderProcess();
            obj1.loadData(txt_itemID.Text.ToString(),txt_itemName.Text.ToString(),Convert.ToDouble(txt_price.Text),Convert.ToInt32(txt_qty.Text), txt_suppcmpName.Text.ToString(),txt_date.Text,txt_suppID.Text,warehouseCode.Text);
            obj1.Show(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }

        private void searchPO_Click(object sender, EventArgs e)
        {
            PurchaseHelpScreen obj = new PurchaseHelpScreen();
            obj.ShowDialog();
            txt_purID.Text = obj.PurchaseOrder;
        }

        private void itemIDSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txt_itemID.Text =obj.itemID;
            txt_itemID.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseHelpScreen obj = new WarehouseHelpScreen();
                obj.ShowDialog();
                warehouseCode.Text = obj.WarehouseCode;
            }
            catch
            {
                throw;
            }
        }

        private void warehouseCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender,e);
                txt_qty.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormData(this);
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
                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Now;
                else
                {
                    errorProvider1.Clear();
                    ClearFormData(c);
                }
            }
        }

    }
}
