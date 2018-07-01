using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.DB;
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

namespace Pastry_ManagementSystem.UI
{
    public partial class ReceivedRawMaterialSscreen_Info : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();      
        public string cmpName { get; set; } = null;
        public string supp_id { get; set; } = null;
        public string item_Name { get; set; } = null;
        public int item_id { get; set; } = 0;
        public string v_supplierId { get; set; }
        public ReceivedRawMaterialSscreen_Info()
        {
            InitializeComponent();
          
        }
        private void PurchaseOrderScreen_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        string v_db_cmpName;
        private void txt_supp_cmpName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                db.closeCon();
                cmpName = txt_supp_cmpName.Text.ToString();
                if (cmpName == null)
                {
                    errorProvider1.SetError(txt_supp_cmpName, "Please Enter Supplier company name");
                }
                else
                {
                    string sql = "Select * From supplier_table where company_Name = '" + cmpName + "'";
                    SqlDataReader reader;
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        v_supplierId = reader["supp_ID"].ToString();
                        v_db_cmpName = reader["company_Name"].ToString();                        
                    }
                    db.closeCon();
                    if (v_db_cmpName == cmpName)
                    {
                        txt_supp_cmpName.Text = v_db_cmpName;                       
                        errorProvider1.Clear();
                        txt_supp_cmpName.Enabled = false;                       
                        txt_sup_id.Visible = true;                      
                        lbl_custom1.Visible = true;
                        suppCodeSearch.Visible = true;
                        txt_sup_id.Focus();
                        txt_sup_id.Text = v_supplierId;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_supp_cmpName, "Please check Supplier Company Name");
                        txt_supp_cmpName.Enabled = true;                      
                        txt_sup_id.Visible = false;                       
                        lbl_custom1.Visible = false;
                        txt_supp_cmpName.Focus();                        
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void txt_supp_cmpName_KeyDown(object sender, KeyEventArgs e)
        {
            db.closeCon();
            if (e.KeyCode == Keys.Enter)
            {
                lbl_custom1.Visible = true;
                txt_sup_id.Visible = true;             
                txt_sup_id.Focus();
                suppCodeSearch.Visible = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnNameSearch_Click(sender,e);
            }
            
        }
        string v_db_suppID;
        private void txt_sup_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.closeCon();
                supp_id = txt_sup_id.Text.ToString();
                if (supp_id == null)
                {
                    errorProvider1.SetError(txt_sup_id, "Please enter supplier identification number to continue the process");
                }
                else
                {
                    string sql = "Select * From supplier_table where supp_ID = '" + supp_id + "' ";
                    SqlDataReader reader;
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        v_db_suppID = reader["supp_ID"].ToString();
                    }
                    db.closeCon();
                }
                if (v_db_suppID != supp_id)
                {
                    errorProvider1.SetError(txt_sup_id, "Please check Supplier Identification Number again");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        string db_sID, db_sCmpName;

        private void txt_sup_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (cmpName != null || supp_id != null)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    Thread th1 = new Thread(new ThreadStart(LoadSupplierDetails));
                    if (v_db_suppID == supp_id)
                    {
                        lbl_custom2.Visible = true;
                        txt_item_name.Visible = true;
                        txt_item_name.Focus();
                        e.SuppressKeyPress = true;
                        th1.Start();
                        txt_sup_id.Enabled = false;
                        errorProvider1.Clear();
                        txt_supp_cmpName.Enabled = false;
                        ItemNameSearch.Visible = true;
                    }
                    else
                    {
                        errorProvider1.SetError(txt_sup_id, "Please check Supplier Identification Number again");
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    txt_supp_cmpName.Focus();
                    e.SuppressKeyPress = true;
                    lbl_custom1.Visible = false;
                    txt_sup_id.Visible = false;
                }               
            }
            else
            {
                errorProvider1.SetError(txt_sup_id, "Please check your inputs,to change the data press correct button");
            }
        }
        string v_db_item_Name=null,id=null;
        private void txt_item_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.closeCon();
                item_Name = txt_item_name.Text.ToString();
                string sql = "Select * From Item_File where Item_Name='" + item_Name + "'";
                SqlDataReader reader;
                reader = db.getData(sql);
                while (reader.Read())
                {
                    v_db_item_Name = reader["Item_Name"].ToString();
                    id = reader["ItemID"].ToString();
                }
                db.closeCon();
        
                if (v_db_item_Name == item_Name)
                {
                    errorProvider1.Clear();
                    txt_item_name.Enabled = false;                 
                    lbl_custom3.Visible = true;
                    txt_item_id.Visible = true;
                    txt_item_id.Text = id;           
                    txt_item_id.Focus();
                }
                else
                {
                    errorProvider1.SetError(txt_item_name," Please check your item name ");                    
                    txt_item_name.Enabled = true;                   
                    lbl_custom3.Visible = false;
                    txt_item_id.Visible = false;
                    ItemCodeSearch.Visible = false;
                }
         
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
      
        int v_db_item_id;

        private void txt_item_id_TextChanged(object sender, EventArgs e)
        {
            db.closeCon();
            try
            {
                item_id = Convert.ToInt32(txt_item_id.Text);
                string sql = "Select * From Item_File where ItemID ='" + item_id + "' ";
                SqlDataReader reader;
                reader = db.getData(sql);
                while (reader.Read())
                {
                    v_db_item_id = Convert.ToInt32(reader["ItemID"]);
                }
                db.closeCon();
                if (item_id != v_db_item_id)
                {
                    errorProvider1.SetError(txt_item_id, "Please check your item Id");
                }
                else
                {
                    groupBox1.Visible = false;
                    errorProvider1.Clear();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_item_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                Thread th1 = new Thread(new ThreadStart(loadDataIntoItemGroupBox));
                if (item_id == v_db_item_id || item_Name == v_db_item_Name)
                {
                    btn_proceed.Focus();
                    txt_item_id.Enabled = false;
                    txt_item_name.Enabled = false;
                    th1.Start();
                    btn_proceed.Focus();
                    e.SuppressKeyPress = true;
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                ItemCodeSearch_Click(sender,e);
            }
        }

        public void LoadSupplierDetails()
        {
            try
            {
                string query;
                SqlDataReader reader;
                query = "Select * From supplier_table where company_Name='" + cmpName + "' OR supp_ID='" + supp_id + "'";
                reader = db.getData(query);
                while (reader.Read())
                {
                    db_sID = reader["supp_ID"].ToString();
                    db_sCmpName = reader["company_Name"].ToString();
                    txt_fullName.Text = reader["supp_FirstName"].ToString();
                    txt_cmpName.Text = db_sCmpName.ToString();
                    txt_cmpAdd.Text = reader["company_Address"].ToString();
                    txt_emailAdd.Text = reader["emailAddress"].ToString();
                    txt_webSiteAdd.Text = reader["web_siteName"].ToString();
                    rtxt_cmmts.Text = reader["Comments"].ToString();
                    txt_NIC.Text = reader["NIC"].ToString();
                    txt_contactNum.Text = reader["contactNumber"].ToString();
                    txt_date.Text = reader["RegisteredDate"].ToString();
                    txt_faxNum.Text = reader["fax_Num"].ToString();
                }
                db.closeCon();
                if (db_sID == supp_id || db_sCmpName == cmpName)
                {
                    groupBox2.Visible = true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        string v_db_val_itemName, v_db_val_itemId;

        private void txt_item_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_custom3.Visible = true;
                txt_item_id.Visible = true;
                txt_item_id.Focus();            
                ItemCodeSearch.Visible = true;
                e.SuppressKeyPress = true;

            }
            else if (e.KeyCode == Keys.F2)
            {
                ItemNameSearch_Click(sender,e);
            }
        }

        private void btn_correct_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            lbl_custom3.Visible = false;
            txt_item_id.Visible = false;
            txt_item_name.Visible = false;
            lbl_custom2.Visible = false;
            txt_sup_id.Visible = false;
            lbl_custom1.Visible = false;
            txt_supp_cmpName.Enabled = true;
            txt_supp_cmpName.Clear();
            txt_supp_cmpName.Focus();
            errorProvider1.Clear();
            txt_sup_id.Clear();
            txt_sup_id.Enabled = true;
            txt_item_name.Enabled = true;
            txt_item_name.Clear();
            txt_item_id.Clear();
            txt_item_id.Enabled = true;
            btn_correct.Enabled = false;
            suppCodeSearch.Visible = false;
            ItemNameSearch.Visible = false;
            ItemCodeSearch.Visible = false;

        }

      
        public void loadDataIntoItemGroupBox()
        {
            try
            {
                if (item_Name != null || item_id != 0)
                {
                    string query;
                    SqlDataReader reader;
                    query = "Select * from Item_File where Item_Name ='" + item_Name + "' OR ItemID='" + item_id + "'";
                    reader = db.getData(query);
                    while (reader.Read())
                    {
                        v_db_val_itemId = reader["ItemID"].ToString();
                        v_db_val_itemName = reader["Item_Name"].ToString();
                        txt_itemName.Text = v_db_val_itemName;
                        txt_ItemDesc.Text = reader["item_Desc"].ToString();
                        txt_batchNo.Text = reader["batch_No"].ToString();
                        txt_mfgDate.Text = reader["mfg_date"].ToString();
                        txt_expDate.Text = reader["ex_date"].ToString();
                        txtCashwholeSale.Text = reader["cash_wholeSale"].ToString(); 
                        totPur.Text = reader["tot_purchases"].ToString();
                        txt_totQty.Text = reader["tot_Qty"].ToString();
                        txt_totPrice.Text = reader["purchase_price"].ToString();
                        txtNetAmt.Text = reader["net_Amt"].ToString();
                    }
                    db.closeCon();
                    if (Convert.ToInt32(v_db_val_itemId) == item_id || v_db_val_itemName == item_Name)
                    {
                        groupBox1.Visible = true;
                        btn_correct.Enabled = true;
                        btn_proceed.Enabled = true;                      
                        btn_proceed.Focus();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {           
            Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            //
            //
            lbl_custom1.Visible = false;
            lbl_custom3.Visible = false;
            lbl_custom2.Visible = false;
            //
            //
            txt_sup_id.Visible = false;
            txt_item_id.Visible = false;
            txt_item_name.Visible = false;
            //
            //
            txt_sup_id.Clear();
            txt_item_id.Clear();
            txt_item_name.Clear();
            txt_supp_cmpName.Clear();
            //
            //
            //
            errorProvider1.Clear();

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            new SupplierNameHelpScreen().Show();
            Hide();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            new ItemHelpScreen().Show(this);
        }

        private void txt_totPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtNetAmt.Text = ((Convert.ToDouble(txt_totQty.Text)) / (Convert.ToDouble(txt_totPrice.Text))).ToString();
            }
            catch(Exception ex)
            {
                MsgBox.Exception(ex);
            }
          
        }

        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            SupplierNameHelpScreen obj = new SupplierNameHelpScreen();
            obj.ShowDialog();
            txt_supp_cmpName.Text = obj.SupplierName;
        }
        public string Warehouse { get; set; }
        private void ItemNameSearch_Click(object sender, EventArgs e)
        {
            try
            {
                InvHelpScreen obj = new InvHelpScreen();
                obj.ShowDialog();
                txt_item_name.Text = obj.ItemName;
                Warehouse = obj.WarehouseCode;
                txt_item_name.Focus();
                ItemCodeSearch.Visible = true; 

            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void ItemCodeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                InvHelpScreen obj = new InvHelpScreen();
                obj.ShowDialog();
                txt_item_id.Text = obj.ItemName;
                txt_item_id.Focus();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void suppCodeSearch_Click(object sender, EventArgs e)
        {
            SupplierNameHelpScreen obj = new SupplierNameHelpScreen();
            obj.ShowDialog();
            txt_supp_cmpName.Text = obj.SupplierCode;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_supp_cmpName.Text.Length == 0 && txt_sup_id.Text.Length == 0)
                {
                    MessageBox.Show("Please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_item_name.Text.Length == 0 && txt_item_id.Text.Length == 0)
                {
                    MessageBox.Show("Please check your inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RawMaterialProcess obj1 = new RawMaterialProcess();
                    obj1.Show(this);
                    obj1.getSpecifiedData(cmpName,v_supplierId,txt_item_name.Text.ToString(), item_id.ToString(),((Convert.ToDouble(txt_totPrice.Text)) / (Convert.ToDouble(totPur.Text))).ToString(),Warehouse);
                }
            }
            catch (Exception)
            {

            }
        }
        public void loadName(string name)
        {
            txt_supp_cmpName.Text = name;
        }
        public void loadItemName(string name)
        {
            txt_item_name.Text = name;
        }    
    }
}
