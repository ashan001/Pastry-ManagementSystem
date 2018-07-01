using Dapper;
using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.DB;
using Pastry_ManagementSystem.UI.HelpScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class RawMaterialProcess : MetroFramework.Forms.MetroForm
    {
        public string v_cmpName { get; set; }
        Database db = new Database();
        public string v_suppID { get; set; }
        public string v_itemName { get; set; }
        public string v_cmpmnyName { get; set; }
        public int v_itemID { get; set; }
        public RawMaterialProcess()
        {
            InitializeComponent();

        }
        private void RawMaterialProcess_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
        }
        public void getSpecifiedData(string cmpName, string suppID, string itemName, string itemID, string itemPrice,string house)
        {
            txt_cmpName.Text = cmpName;
            txt_suppID.Text = suppID;
            txt_itemName.Text = itemName;
            txt_itemID.Text = itemID;
            txt_itemPrice.Text = itemPrice;
            warehouseCode.Text = house;
        }
        int v_qty = 0;
        string v_db_cmpName, v_db_suppID;
        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                v_qty = Convert.ToInt32(txt_qty.Text);
                Thread th1 = new Thread(new ThreadStart(doCal));
                if (v_qty != 0)
                {
                    th1.Start();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please check your inputs,and try agian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your inputs,and try agian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        double v_tot_amt;
        public void doCal()
        {
            try
            {
                v_tot_amt = ((Convert.ToDouble(txt_itemPrice.Text)) * (Convert.ToDouble(txt_qty.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Check the item price again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string v_receiptNum;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length == 0)
            {
                errorProvider1.SetError(txt_qty, "Pleae check your quantity");
            }
            else if (txt_qty.Text.Length < 0)
            {
                errorProvider1.SetError(txt_qty, "Pleae check your quantity");
            }
            else
            {
                try
                {
                    errorProvider1.Clear();
                    CalculateReceiveNum obj1 = new CalculateReceiveNum();
                    v_receiptNum = obj1.getReceiptNum();
                    txt_receiptNum.Text = v_receiptNum;
                    //
                    //
                    //
                    int n = custom_dataGrid1.Rows.Add();
                    custom_dataGrid1.Rows[n].Cells[0].Value = v_receiptNum;
                    custom_dataGrid1.Rows[n].Cells[1].Value = txt_itemID.Text;
                    custom_dataGrid1.Rows[n].Cells[2].Value = txt_qty.Text;
                    custom_dataGrid1.Rows[n].Cells[3].Value = txt_itemPrice.Text;
                    custom_dataGrid1.Rows[n].Cells[4].Value = v_tot_amt.ToString();
                    custom_dataGrid1.Rows[n].Cells[5].Value = warehouseCode.Text;
                }
                catch (Exception)
                {
                    //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
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
                else if (c is RichTextBox)
                    ((RichTextBox)c).Clear();
                else
                {
                    ClearFormData(c);
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }                    
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_submit.Enabled = true;
            custom_dataGrid1.Rows.Clear();
        }


        private void txt_cmpName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From supplier_table where company_Name = '" + txt_cmpName.Text+"' ";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_db_cmpName = reader["company_Name"].ToString();
                            v_db_suppID = reader["supp_ID"].ToString();
                        }
                        reader.Close();
                        if (txt_cmpName.Text == v_db_cmpName)
                        {
                            txt_cmpName.Text = v_db_cmpName;
                            txt_suppID.Text = v_db_suppID;
                            errorProvider2.Clear();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
        string v_db_supp_ID, cmpName;

        string v_db_item_id, db_itemName, v_db_price;
        private void txt_itemID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Item_File where ItemID ='" + txt_itemID.Text + "' ";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_db_item_id = (reader["ItemID"]).ToString().Trim();
                            db_itemName = reader["Item_Name"].ToString();
                            v_db_price = ((Convert.ToDouble(reader["purchase_price"])) / (Convert.ToDouble(reader["tot_purchases"]))).ToString();
                        }
                        if (v_db_item_id == txt_itemID.Text)
                        {
                            txt_itemName.Text = db_itemName;
                            txt_itemPrice.Text = v_db_price;
                            errorProvider1.Clear();
                            errorProvider2.Clear();
                        }
                        else
                        {
                            errorProvider1.SetError(txt_itemID, "Please check the item id");
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        string v_db_item_Name, v_dbitemID;

        private void txt_cmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                suppCodeSearch_Click(sender,e);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_itemID.Focus();
            }
        }

        private void txt_suppID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                suppCodeSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_itemID.Focus();
            }
        }

        private void txt_itemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ItemCodeSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                warehouseCode.Focus();
            }
        }

        private void txt_itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ItemNameSearch_Click(sender,e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                warehouseCode.Focus();
            }
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            SupplierNameHelpScreen obj = new SupplierNameHelpScreen();
            obj.ShowDialog();
            txt_cmpName.Text = obj.SupplierName;
            txt_suppID.Text = obj.SupplierCode;
        }

        private void suppCodeSearch_Click(object sender, EventArgs e)
        {
            SupplierNameHelpScreen obj = new SupplierNameHelpScreen();
            obj.ShowDialog();
            txt_cmpName.Text = obj.SupplierName;
        }

        private void ItemCodeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                InvHelpScreen obj = new InvHelpScreen();
                obj.ShowDialog();
                txt_itemID.Text = obj.ItemCode;
                txt_itemID.Focus();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void ItemNameSearch_Click(object sender, EventArgs e)
        {

            try
            {
                InvHelpScreen obj = new InvHelpScreen();
                obj.ShowDialog();
                txt_itemName.Text = obj.ItemName;
                txt_itemName.Focus();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
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
                btnSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_qty.Focus();
            }
        }

        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }

        private void txt_itemName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Item_File where Item_Name='" + txt_itemName.Text.ToString() + "'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_db_item_Name = reader["Item_Name"].ToString();
                            v_dbitemID = reader["ItemID"].ToString();
                            v_db_price = ((Convert.ToDouble(reader["purchase_price"])) / (Convert.ToDouble(reader["tot_purchases"]))).ToString();
                        }
                        if (v_db_item_Name == txt_itemName.Text.ToString())
                        {
                            txt_itemID.Text = v_dbitemID;
                            txt_itemPrice.Text = v_db_price;
                            errorProvider1.Clear();
                        }
                        else
                        {
                            errorProvider1.SetError(txt_itemName, "Please Check Item Name");
                        }
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_suppID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From supplier_table where supp_ID = '" + txt_suppID.Text.ToString() + "' ";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_db_supp_ID = reader["supp_ID"].ToString();
                            cmpName = reader["company_Name"].ToString();
                        }
                        if (v_db_supp_ID == txt_suppID.Text.ToString())
                        {
                            txt_cmpName.Text = cmpName;
                            txt_suppID.Text = v_db_supp_ID;
                            errorProvider1.Clear();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int n, line_1, value;
        private void btn_submit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_qty.Text.Length == 0 || txt_qty.Text.Length < 0)
                {
                    MessageBox.Show("Please check quantity text field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int c = 0; c < custom_dataGrid1.Rows.Count; c++)
                    {
                         
                        //db.closeCon();
                        //n = db.update_del_insert_Data(sql1);
                        //db.closeCon();
                        using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                            {
                                db.Open();
                                string query1;
                                query1 = $"Insert into received_raw_meterial_header_file Values('{custom_dataGrid1.Rows[c].Cells["cl_index5"].Value}','{txt_suppID.Text}','{DateTime.Now.ToString().Substring(0, 9)}','{txt_itemName.Text}')";
                                line_1 = db.Execute(query1);

                                string sql2;
                                //sql2 = "Insert Into recieved_raw_meterial_detailed_file Values('" + custom_dataGrid1.Rows[c].Cells["cl_index5"].Value.ToString() + "','" + custom_dataGrid1.Rows[c].Cells["cl_warehouse"].Value.ToString() + "','" + custom_dataGrid1.Rows[c].Cells["cl_index1"].Value.ToString() + "','" + custom_dataGrid1.Rows[c].Cells["cl_index2"].Value + "','" + custom_dataGrid1.Rows[c].Cells["cl_index3"].Value.ToString() + "','" + custom_dataGrid1.Rows[c].Cells["cl_index4"].Value.ToString() + "')";
                                sql2 = $"Insert Into recieved_raw_meterial_detailed_file values('{custom_dataGrid1.Rows[c].Cells["cl_index5"].Value.ToString()}','{custom_dataGrid1.Rows[c].Cells["cl_warehouse"].Value.ToString()}','{custom_dataGrid1.Rows[c].Cells["cl_index1"].Value.ToString()}','{ custom_dataGrid1.Rows[c].Cells["cl_index2"].Value}','{custom_dataGrid1.Rows[c].Cells["cl_index3"].Value.ToString()}','{custom_dataGrid1.Rows[c].Cells["cl_index4"].Value.ToString()}')";
                                n = db.Execute(sql2);
                            }
                        }

                    }
                    value = n + line_1;
                    if (value > 0)
                    {
                        MessageBox.Show("Data Saved Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Process is failed ,please press find button and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch/* (Exception)*/
            {
                throw;
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
}
