using Dapper;
using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.DB;
using Pastry_ManagementSystem.ExtraClassesToMapData;
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
    public partial class UpdateItemForm : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public double vat_Amt { get; set; }
        public double purchase_price { get; set; }
        public string item_ID { get; set; }
        public string batch_ID { get; set; }
        public string item_Name { get; set; }
        public string available_qty { get; set; }
        public string required_Qty { get; set; }
        public UpdateItemForm()
        {
            InitializeComponent();
            cmb_ItemType.BackColor = Color.IndianRed;
            cmb_ItemType.SelectedText = "  Item Type  ".ToString();
        }
        private void txt_item_ID_TextChanged(object sender, EventArgs e)
        {
            db.closeCon();
            try
            {
                item_ID = txt_item_ID.Text;
                if (txt_item_ID.Text.Length == 0)
                {
                    txt_ItemName.Clear();
                    cmb_ItemType.BackColor = Color.IndianRed;
                    cmb_ItemType.SelectedText = "  Item Type  ".ToString();
                    txt_ItemType.Clear();
                    txt_ItemDesc.Clear();
                    dtp_Date.Value = DateTime.Today;                    
                    warehouse.Clear();                 
                    txt_purchasePrice.Clear();                   
                    txt_cashWholeSale.Clear();
                    txt_Vat.Clear();
                    txt_taxAmt.Clear();
                    txt_totPurchaseQty.Clear();
                    txt_totQty.Clear();
                    txt_netAmount.Clear();
                    db.closeCon();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Please check your inputs ","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void txt_batch_ID_TextChanged(object sender, EventArgs e)
        {
            db.closeCon();
            try
            {
                batch_ID = txt_batch_ID.Text.ToString();
                if (txt_batch_ID.Text.Length == 0)
                {
                    txt_ItemName.Clear();
                    cmb_ItemType.BackColor = Color.IndianRed;
                    cmb_ItemType.SelectedText = "  Item Type  ".ToString();
                    txt_ItemType.Clear();
                    txt_ItemDesc.Clear();
                    dtp_Date.Value = DateTime.Today;                 
                    warehouse.Clear();                  
                    txt_purchasePrice.Clear();                    
                    txt_cashWholeSale.Clear();
                    txt_Vat.Clear();
                    txt_taxAmt.Clear();
                    txt_totPurchaseQty.Clear();
                    txt_totQty.Clear();
                    txt_netAmount.Clear();
                    db.closeCon();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Please check your inputs ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txt_item_Name_TextChanged(object sender, EventArgs e)
        {
            db.closeCon();
            try
            {
                item_Name = txt_item_Name.Text.ToString();
                if (txt_item_Name.Text.Length == 0)
                {
                    txt_ItemName.Clear();
                    cmb_ItemType.BackColor = Color.IndianRed;
                    cmb_ItemType.SelectedText = "  Item Type  ".ToString();
                    txt_ItemType.Clear();
                    txt_ItemDesc.Clear();
                    dtp_Date.Value = DateTime.Today;                  
                    warehouse.Clear();                   
                    txt_purchasePrice.Clear();                   
                    txt_cashWholeSale.Clear();
                    txt_Vat.Clear();
                    txt_taxAmt.Clear();
                    txt_totPurchaseQty.Clear();
                    txt_totQty.Clear();
                    txt_netAmount.Clear();
                     db.closeCon();
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Please check your inputs ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            
            Control.CheckForIllegalCrossThreadCalls = false;        
            dtp_Date.MaxDate = DateTime.Now;          
        }

        private void cmb_ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ItemType.Text = cmb_ItemType.SelectedItem.ToString();
            cmb_ItemType.BackColor = Color.LightGreen;
            if (cmb_ItemType.SelectedIndex == -1)
            {
                cmb_ItemType.BackColor = Color.IndianRed;
                cmb_ItemType.SelectedText = "  Item Type  ".ToString();
            }
        }
        public void getTotReqQuantity()
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(required_Qty);
            y = Convert.ToInt32(available_qty);
            txt_totQty.Text =(x+y).ToString();
        }

        private void txt_Vat_TextChanged(object sender, EventArgs e)
        {
            if (txt_Vat.Text.Length == 0)
            {
                errorProvider1.SetError(txt_Vat, " Please enter Tax percentage of the item ");
                txt_taxAmt.Clear();
                txt_netAmount.Clear();
            }
            else if (txt_Vat.Text.Length < 0)
            {
                errorProvider1.Clear();
                errorProvider2.SetError(txt_Vat, "Please check your Tax percentage ");
                txt_taxAmt.Clear();
                txt_taxAmt.Clear();
                txt_netAmount.Clear();
            }
            else
            {
                errorProvider2.Clear();
                errorProvider1.Clear();
                vat_Amt = (((Convert.ToDouble(txt_purchasePrice.Text) * Convert.ToDouble(txt_Vat.Text))) / (100));
                txt_taxAmt.Text = vat_Amt.ToString();
            }
        }

        private void txt_taxAmt_TextChanged(object sender, EventArgs e)
        {
            if (txt_taxAmt.Text.Length == 0)
            {
                errorProvider1.SetError(txt_taxAmt, " Please enter Tax Amount of the item ");
            }
            else if (txt_taxAmt.Text.Length < 0)
            {
                errorProvider1.Clear();
                errorProvider2.SetError(txt_taxAmt, "Please check Tax Amount ");
            }
            else
            {
                errorProvider2.Clear();
                errorProvider1.Clear();
                Thread th2 = new Thread(new ThreadStart(doCalculations));
                th2.Start();
            }
        }
        public void doCalculations()
        {
            try
            {           
                txt_netAmount.Text = (Convert.ToDouble(txt_purchasePrice.Text) + (vat_Amt)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txt_ItemDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_ItemDesc, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_purchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_purchasePrice, "Numeric values only accepted,please fill with proper inputs");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txt_cashWholeSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_cashWholeSale, "Numeric values only accepted,please fill with proper inputs");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_Vat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_Vat, "Numeric values only accepted,please fill with proper inputs");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_taxAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_taxAmt, "Numeric values only accepted,please fill with proper inputs");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }

        private void txt_item_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_item_ID.Text.Length != 0)
                {
                    loadItemData();
                    e.SuppressKeyPress = true;
                }
                else
                {
                    itemIDSearch_Click(sender,e);
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                new Pastry_ManagementSystem.UI.HelpScreens.ItemHelpScreen().Show(this);
                db.closeCon();
            }
        }
        public string v_itemId { get; set; }
        string  vbatchID, v_Iname;
        public void loadItemData()
        {
            using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string sql = $" Select * From Item_File IT inner Join Warehouse_Transaction_Table WT  on IT.warehouseCode=WT.warehouseCode where IT.Item_Name='{txt_item_Name.Text}' OR IT.ItemID='{txt_item_ID.Text}' OR IT.batch_No='{txt_batch_ID.Text}'";
                    IDataReader reader = db.ExecuteReader(sql);
                    while (reader.Read())
                    {
                        v_itemId = reader["ItemID"].ToString();
                        vbatchID = reader["batch_No"].ToString();
                        v_Iname = reader["Item_Name"].ToString();
                        txt_ItemName.Text = v_Iname;
                        cmb_ItemType.Text = reader["Item_Type"].ToString();
                        txt_ItemDesc.Text = reader["item_Desc"].ToString();
                        dtp_Date.Text = reader["date_and_time"].ToString();                       
                        txt_purchasePrice.Text = reader["purchase_price"].ToString();
                        txt_cashWholeSale.Text = reader["cash_wholeSale"].ToString();
                        txt_Vat.Text = reader["vat_perc"].ToString();
                        txt_taxAmt.Text = reader["Vat_Amt"].ToString();
                        warehouse.Text = reader["warehouseCode"].ToString();
                        txt_totPurchaseQty.Text = reader["tot_purchases"].ToString();
                        txt_totQty.Text = reader["tot_Qty"].ToString();
                    }
                    if (txt_batch_ID.Text.Length != 0)
                    {
                        if (txt_batch_ID.Text == vbatchID)
                        {
                            groupBox2.Enabled = false;
                            enableGroupBoxes();
                        }
                        else
                        {
                            MessageBox.Show("invalid Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                    if (txt_ItemName.Text.Length != 0)
                    {
                        if (txt_ItemName.Text == v_Iname)
                        {
                            groupBox2.Enabled = false;
                            enableGroupBoxes();
                        }
                        else
                        {
                            MessageBox.Show("invalid Item name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                    if (txt_batch_ID.Text.Length != 0)
                    {
                        if (txt_batch_ID.Text == vbatchID)
                        {
                            groupBox2.Enabled = false;
                            enableGroupBoxes();
                        }
                        else
                        {
                            MessageBox.Show("invalid Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }

                }
            }
        }
        public void enableGroupBoxes()
        {
            groupBox1.Enabled = true;
            grp_Box_Initial_Details.Enabled = true;
            btn_update.Enabled = true;
            btn_update.Focus();
        }
        public void reEnablePrevgroupBox()
        {
            groupBox1.Enabled = false;
            grp_Box_Initial_Details.Enabled = false;
            btn_update.Enabled = false;
            groupBox2.Enabled = true;
            txt_item_Name.Focus();
        }
        private void btn_update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                reEnablePrevgroupBox();
            }
        }

        private void txt_batch_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_batch_ID.Text.Length != 0)
                {
                    loadItemData();
                    e.SuppressKeyPress = true;
                }
                else
                {
                    MessageBox.Show("Please enter item batch id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.KeyCode ==Keys.F2)
            {
                batchIDSearch_Click(sender,e);
            }
        }

        private void txt_item_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_item_Name.Text.Length != 0)
                {
                    loadItemData();
                    e.SuppressKeyPress = true;
                }
                else
                {
                    MessageBox.Show("Please enter item name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.KeyCode ==Keys.F2)
            {
                itenNameSearch_Click(sender,e);
            }
        }
      
        private void itenNameSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txt_item_Name.Text = obj.itemName;
            txt_item_Name.Focus();
        }

        private void itemIDSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txt_item_ID.Text = obj.itemID;
            txt_item_ID.Focus();
        }

        private void batchIDSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txt_batch_ID.Text = obj.BatchID;
            txt_batch_ID.Focus();
        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        int line = 0;

        private void txt_ItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_ItemDesc, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
                    ((DateTimePicker)c).Value = DateTime.Now.Date;
                else
                {
                    groupBox2.Enabled = true;
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    ClearFormData(c);
                }
                  
                   
            }
        }
        MapItemData obj = new MapItemData();
        private int res;

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (txt_item_ID.Text.Length == 0 && txt_batch_ID.Text.Length == 0 && txt_item_Name.Text.Length == 0)
            {
                MessageBox.Show("Please fill on of those text fields to complete the proccess", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();

                            obj.itemID = v_itemId;                            
                            obj.BatchID = txt_batch_ID.Text;
                            obj.ItemName = txt_ItemName.Text;
                            obj.ItemType = cmb_ItemType.SelectedItem.ToString();
                            obj.ItemDesc = txt_ItemDesc.Text;
                            obj.DateTime = dtp_Date.Value.ToString();
                            obj.PurchasePrice = Convert.ToDouble(txt_purchasePrice.Text);
                            obj.CashInWoleSale = Convert.ToDouble(txt_cashWholeSale.Text);
                            obj.VatPercentage = Convert.ToDouble(txt_Vat.Text);
                            obj.VatAmount = Convert.ToDouble(txt_taxAmt.Text);
                            int resultIF = obj.update();

                            if (resultIF == 1)
                            {
                                MsgBox.Show(6);
                            }
                        }
                    }
                }
                catch 
                {
                    throw;
                }                
            }
        }
        public void loadItemData(string v_id, string v_itemName,string v_batchId,string itemType,string description,string date,string availableQty,string v_requQty,string v_warningLVl,string v_reorderLvl,string v_purchasePrice ,string v_cashWholeSale,string v_vat,string v_vatAmt,string v_totPur,string v_totQty,string v_netAmt)
        {
            cmb_ItemType.BackColor = Color.LightGreen;
            txt_item_ID.Text = v_id;
            txt_item_Name.Text = v_itemName;
            txt_batch_ID.Text = v_batchId;            
            txt_ItemName.Text = v_itemName;
            cmb_ItemType.Text = itemType;
            txt_ItemDesc.Text = description;
            dtp_Date.Text = date;
            txt_purchasePrice.Text = v_purchasePrice;           
            txt_cashWholeSale.Text = v_cashWholeSale;
            txt_Vat.Text = v_vat;
            txt_taxAmt.Text = v_vatAmt;
            txt_totPurchaseQty.Text = v_totPur;
            txt_totQty.Text = v_totQty;
            txt_netAmount.Text = v_netAmt;
            groupBox1.Enabled = true;
            grp_Box_Initial_Details.Enabled = true;
            
        }
    }
}
