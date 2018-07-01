using Pastry_ManagementSystem.DB;
using System;
using System.Data;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.ExtraClassesToMapData;
using Pastry_ManagementSystem.UI.HelpScreens;

namespace Pastry_ManagementSystem.UI
{
    public partial class ItemScreen : MetroFramework.Forms.MetroForm
    {
        public string sys_date_and_time { get; set; }
        public string batchNo { get; set; }      
        protected string  v_inc { get; set; }
        protected string sys_year { get; set; }
        public int available_qty { get; set; }
        public int required_Qty { get; set; }
        public double totCostForItem { get; set; }
        public double purchase_price { get; set; }
        public double vat_Amt { get; set; }
        public string mfg_date { get; set; } = null;
        public string exp_date { get; set; } = null;
        public double dueCost { get; set; }
        Database db = new Database();
        public ItemScreen()
        {
            InitializeComponent();          
            txt_totPurchaseQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_totQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;            
            txt_netAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;         
            itemNo.Text = null;
        }

        private void ItemScreen_Load(object sender, EventArgs e)
        {
            cmb_ItemType.BackColor = Color.IndianRed;
            cmb_ItemType.SelectedText = "  Item Type  ".ToString();
            dtp_Date.MinDate = DateTime.Now;
            dtp_Date.MaxDate = DateTime.Now;
            dtp_mfgDate.MaxDate = DateTime.Now;
            dtp_expDate.MinDate = DateTime.Now;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_date_time.Text = dt.ToString();           
        }
        private void txt_ItemName_TextChanged(object sender, EventArgs e)
        {
            if (txt_ItemName.Text.Length == 0)
            {
                errorProvider1.SetError(txt_ItemName, "Please enter Item Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cmb_ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ItemType.BackColor = Color.LightGreen;
            if (cmb_ItemType.SelectedIndex == -1)
            {
                cmb_ItemType.BackColor = Color.IndianRed;
            }
            else
            {
                cmb_ItemType.BackColor = Color.LightGreen;
                txt_ItemType.Text = cmb_ItemType.SelectedItem.ToString();                
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
        
        int Rows;
        protected void createBatchID()
        {
            try
            {
                string sql;
                sys_year = DateTime.Now.Year.ToString().Substring(2);
                sql = "Select  Count (*) From Item_File";
                Rows = db.returnDBRows(sql);
                db.closeCon();
                Rows++;                        
                batchNo = (sys_year+Rows).ToString();
                txt_batchNo.Text = batchNo;                  
            }
            catch (Exception)
            {
            }
        }

        private void txt_purchasePrice_TextChanged(object sender, EventArgs e)
        {

            if (txt_purchasePrice.Text.Length == 0)
            {
                errorProvider1.SetError(txt_purchasePrice, "Please enter puchase price of the item");
            }
            else if (txt_purchasePrice.Text.Length < 0)
            {
                errorProvider1.Clear();
                errorProvider2.SetError(txt_purchasePrice, "Please check your purchase price");
            }
            else
            {
                errorProvider2.Clear();
                errorProvider1.Clear();
                purchase_price = Convert.ToDouble(txt_purchasePrice.Text);
            }
        }
        private void txt_cashWholeSale_TextChanged(object sender, EventArgs e)
        {
            if (txt_cashWholeSale.Text.Length == 0)
            { 
                errorProvider1.SetError(txt_cashWholeSale, " Please enter price in wholesale of the item ");
            }
            else if (txt_cashWholeSale.Text.Length < 0)
            {
                errorProvider1.Clear();
                errorProvider2.SetError(txt_cashWholeSale, "Please check your price in wholesale ");
            }
            else
            {
                errorProvider2.Clear();
                errorProvider1.Clear();
            }
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
                vat_Amt = (((purchase_price * Convert.ToDouble(txt_Vat.Text))) /(100));
                txt_taxAmt.Text = vat_Amt.ToString();
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
        public int DbBackValue { get; set; }
        private void txt_ItemDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void dtp_mfgDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_mfgDate.Value.Equals(null))
            {
                mfg_date = null;
            }
            else
            {
                mfg_date = dtp_mfgDate.Value.ToString().Substring(0,9);
            }
        }
        
        public void doCalculations()
        {
            try
            {
                totCostForItem = ((purchase_price) + (vat_Amt));
                txt_netAmount.Text = totCostForItem.ToString();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        private void dtp_expDate_ValueChanged(object sender, EventArgs e)
        {

            if (dtp_expDate.Value.Equals(null))
            {
                exp_date = null;
            }
            else
            {
                exp_date = dtp_expDate.Value.ToString().Substring(0,9);
            }
        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ItemName.Text.Length == 0)
                { 
                    MsgBox.Error("Please enter item name");
                }
                else if (cmb_ItemType.Text.Length == 0)
                {
                    MsgBox.Error("Please Select item type ");
                }
                else if (txt_purchasePrice.Text.Length == 0)
                {                  
                    MsgBox.Error(" Please enter purchase price ");
                }
                else
                {
                    MapItemData obj = new MapItemData();
                    obj.itemID = Reference;
                    if (obj.select() == 1)
                    {
                        if (MsgBox.Question("This item already in the item file do you need to change the item ?") == System.Windows.Forms.DialogResult.Yes)
                        {
                            new UI.UpdateItemForm().ShowDialog();
                        }
                    }
                    else
                    {
                        if (DbBackValue == 0)
                        {
                            obj.EmployeeID = Login.EmployeeID;
                            obj.WarehouseCode = warehouseCode.Text;
                            obj.ItemName = txt_ItemName.Text;
                            obj.ItemType = cmb_ItemType.Text;
                            obj.ItemDesc = txt_ItemDesc.Text;
                            obj.DateTime = dtp_Date.Value.ToString();
                            obj.BatchID = txt_batchNo.Text;
                            obj.ManifacturingDate = dtp_mfgDate.Value.Date.ToString().Substring(0, 9);
                            obj.ExpireDate = dtp_expDate.Value.Date.ToString().Substring(0, 9);
                            obj.PurchasePrice = Convert.ToDouble(txt_purchasePrice.Text);
                            obj.CashInWoleSale = Convert.ToDouble(txt_cashWholeSale.Text);
                            obj.VatPercentage = Convert.ToDouble(txt_Vat.Text);
                            obj.VatAmount = Convert.ToDouble(txt_taxAmt.Text);
                            obj.TotalPurchase = Convert.ToInt32(txt_totPurchaseQty.Text);
                            obj.TotalQuantity = Convert.ToInt32(txt_totQty.Text);
                            obj.NetAmount = Convert.ToDouble(txt_netAmount.Text);                         
                        }
                        else
                        {
                            obj.itemID = Reference;
                            obj.EmployeeID = Login.EmployeeID;
                            obj.WarehouseCode = warehouseCode.Text;
                            obj.ItemName = txt_ItemName.Text;
                            obj.ItemType = cmb_ItemType.Text;
                            obj.ItemDesc = txt_ItemDesc.Text;
                            obj.DateTime = dtp_Date.Value.ToString();
                            obj.BatchID = txt_batchNo.Text;
                            obj.ManifacturingDate = dtp_mfgDate.Value.Date.ToString().Substring(0, 9);
                            obj.ExpireDate = dtp_expDate.Value.Date.ToString().Substring(0, 9);
                            obj.PurchasePrice = Convert.ToDouble(txt_purchasePrice.Text);
                            obj.CashInWoleSale = Convert.ToDouble(txt_cashWholeSale.Text);
                            obj.VatPercentage = Convert.ToDouble(txt_Vat.Text);
                            obj.VatAmount = Convert.ToDouble(txt_taxAmt.Text);
                            obj.TotalPurchase = Convert.ToInt32(txt_totPurchaseQty.Text);
                            obj.TotalQuantity = Convert.ToInt32(txt_totQty.Text);
                            obj.NetAmount = Convert.ToDouble(txt_netAmount.Text);
                        }

                        int result = obj.save();
                        if (result == 1)
                        {
                            MsgBox.Show(1);
                        }
                        else
                        {
                            MsgBox.Show(3);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MsgBox.Exception(ex);
            }
            finally
            {              
                 
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            new UpdateItemForm().Show();
            this.Hide();  
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }
        private void txt_ItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_ItemName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_totPurchaseQty_TextChanged(object sender, EventArgs e)
        {
          
        }
        public string _Fname=null,_Lname=null,_empRole=null;

        private void cmb_ItemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ItemDesc.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_ItemDesc_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                dtp_Date.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_availableQty_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {             
                e.SuppressKeyPress = true;
            }
        }

        private void txt_RequiredQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {              
                e.SuppressKeyPress = true;
                if (cmb_ItemType.SelectedIndex == 0)
                {
                    txt_batchNo.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txt_WarningLvl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void txt_ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadItem();
                Thread th1 = new Thread(new ThreadStart(createBatchID));
                th1.Start();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                itemNameSearch_Click(sender,e);
            }
        }
        public string v_status { get; set; }
        public void loadItem()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string itemid=null;
                        // string sql = $"Select Inv.InvITemCode,wm.warehouse_code,wm.Warehouse_description,wm.warehouseStatus From Inventory Inv Inner Join Warehouse_Master wm on Inv.warehouse = wm.warehouse_code where Inv.itemName='{txt_ItemName.Text}'";
                        string sql = $"Select Inv.InvITemCode,Inv.itemGroup,Inv.itemDesc,wm.warehouse_code,wm.Warehouse_description,wm.warehouseStatus  From Inventory Inv Inner Join Warehouse_Master WM on Inv.warehouseCode = wm.warehouse_code where Inv.itemName='{txt_ItemName.Text}'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        { 
                            itemid =reader["InvITemCode"].ToString();
                            txtItemID.Text = itemid;
                            warehouseCode.Text = reader["warehouse_code"].ToString();
                            warehouseDesc.Text = reader["Warehouse_description"].ToString();
                            v_status = reader["warehouseStatus"].ToString();
                            cmb_ItemType.Text = reader["itemGroup"].ToString();cmb_ItemType.BackColor = Color.LightGreen;
                            txt_ItemDesc.Text = reader["itemDesc"].ToString();
                            if (v_status == "Active")
                            {
                                chk_active.Checked = true;
                            }
                            else
                            {
                                chk_boxInactive.Checked = true;
                            }
                            cmb_ItemType.Focus();
                        }
                        if (txtItemID.Text != itemid)
                        {
                            if (MsgBox.Question("This is not a Registered Item,So do you want to add this item to item file ?") == DialogResult.Yes)
                            {
                                groupBox2.Visible = true;
                                if (groupBox2.Visible == true)
                                {
                                    GenerateItemNo obj = new GenerateItemNo();
                                    itemNo.Text = obj.getItemNum();
                                    txtItemID.Text = itemNo.Text;
                                    cmb_ItemType.Focus();
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
//load Item
        private void dtp_Date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                e.SuppressKeyPress = true;
            }
        }

        private void txt_ReorderLvl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_mfgDate.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void dtp_mfgDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_expDate.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void dtp_expDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_purchasePrice.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void txt_purchasePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cashWholeSale.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void txt_Vat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Enabled = true;
                btn_update.Enabled = true;             
                btn_save.Focus();
                e.SuppressKeyPress = true;              
            }
        }

        private void txt_cashWholeSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Vat.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_netAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_batchNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                dtp_mfgDate.Focus();
                e.SuppressKeyPress=true;
            }
        }

        private void StartClick_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show(this);
        }

        private void selectWarehouse_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            txtItemID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
        }

        private void txt_availableQty_TextChanged(object sender, EventArgs e)
        {
            //txt_totPurchaseQty.Text = txt_availableQty.Text;
        }

        private void txt_totQty_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        ItemObjects itemObj = new ItemObjects();
        private void btn_saveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //map values
                    itemObj.warehouse_code = warehouseCode.Text;
                    itemObj.ReferenceItemCode = Reference.ToString();
                    itemObj.ItemStatus = ItemStatus;
                    itemObj.InvCode = ItemID;
                    itemObj.ReOrderLvl = Convert.ToInt32(txtReorderLvl.Text);
                    itemObj.requiredQty = Convert.ToInt32(txtReqQty.Text);
                    itemObj.purchasedQty = Convert.ToInt32(txtPurchasedQyantity.Text);
                    itemObj.availableQty = Convert.ToInt32(txt_availableQty.Text);
                    itemObj.date = dtpDate.Value;

                 if (DbBackValue == 0)
                   {
                    if (itemObj.save() == 1)
                    {
                        MsgBox.Show(1);                      
                        SetTotRquiredQty();
                        groupBox2.Visible = false;
                        UpdateMessageLable.Text = "You have successfully updated warehouse :" + itemObj.warehouse_code;
                    }
                    else
                    {
                        UpdateMessageLable.Text = "Warehouse Updation is failed :" + itemObj.warehouse_code;
                    }
                }
                else if (DbBackValue == 1)
                {
                    int res = itemObj.update();
                    if (res == 1)
                    {
                        MsgBox.Show(res);
                    }
                    else
                    {
                        MsgBox.Show(res);
                    }
                }               
            }
            catch//(Exception ex)
            {
                throw;
            }
        }
       
        void SetTotRquiredQty()
        {
            if (Convert.ToInt32(txtReqQty.Text) > Convert.ToInt32(txtPurchasedQyantity.Text))
            {
                txt_totQty.Text = (Convert.ToInt32(txtReqQty.Text) + (Convert.ToInt32(txtReqQty.Text) - Convert.ToInt32(txtPurchasedQyantity.Text))).ToString();
            }
            else if (Convert.ToInt32(txtReqQty.Text) < Convert.ToInt32(txtPurchasedQyantity.Text))
            {
                MsgBox.Warning("Please check your purchased quantity level");
            }
        }
        private void txtReqQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_totQty.Text = txtReqQty.Text;
            }
            catch(Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void chk_active_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_active.Checked == true)
            {
                chk_boxInactive.Enabled = false;
            }
            else
            {
                chk_boxInactive.Enabled = true;
            }
        }

        private void chk_boxInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_boxInactive.Checked == true)
            {
                chk_active.Enabled = false;
            }
            else
            {
                chk_active.Enabled = true;
            }
        }

        private void txt_availableQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtReorderLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtReqQty_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtReqQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txtReqQty, "Numeric Values only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void warehouseCode_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Paint(object sender, PaintEventArgs e)
        {
           
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
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loadWarehouseDetails();
            }
            else if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                btnSearch_Click(sender,e);
                errorProvider1.Clear();
            }
        }
        string _wcode = null, _desc = null, _status = null;
        void loadWarehouseDetails()
        {
            try
            {
               
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select * From Warehouse_Master where warehouse_code='{warehouseCode.Text}'";
                        IDataReader readaer = db.ExecuteReader(sql);
                        while (readaer.Read())
                        {
                            _wcode = readaer["warehouse_code"].ToString().Trim();
                            _desc= readaer["Warehouse_description"].ToString();
                            _status = readaer["warehouseStatus"].ToString();                            
                        }
                        if (warehouseCode.Text == _wcode)
                        {
                            errorProvider1.Clear();
                            warehouseDesc.Text = _desc;
                            if (_status == "Active")
                            {
                                chk_active.Checked = true;
                            }
                            else
                            {
                                chk_boxInactive.Checked = true;
                            }
                            txtItemID.Focus();
                        }
                        else if (warehouseCode.Text != _wcode)
                        {                            
                            warehouseDesc.Clear();
                            chk_active.Checked = false;
                            chk_boxInactive.Checked = false;
                            warehouseCode.Focus();
                            errorProvider1.SetError(warehouseCode, "invalid warehouse code,use help screen");
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void txtPurchasedQyantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPurchasedQyantity, "Numeric Values only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtPurchasedQyantity_TextChanged(object sender, EventArgs e)
        {
            txt_totPurchaseQty.Text = txtPurchasedQyantity.Text;
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            if (txtItemID.Text == string.Empty)
            {
                txt_availableQty.Clear();
                txtReorderLvl.Clear();
                txtReqQty.Clear();
                txtPurchasedQyantity.Clear();
                btn_saveInfo.Enabled = false;
            }
        }
        string itemCode = null;
        int reOrd, AvailableQty, ReqQty;
        public string ItemID;
        public string Reference { get; set; }
        public string ItemStatus { get; set; }

        private void itemNameSearch_Click(object sender, EventArgs e)
        {
            InvHelpScreen obj = new InvHelpScreen();
            obj.ShowDialog();
            txt_ItemName.Text = obj.ItemName;
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            selectWarehouse.Focus();
        }

        private void txtPurchasedQyantity_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPurchasedQyantity.Text.Length != 0)
            {
                btn_saveInfo.Enabled = true;
            }
            txt_totPurchaseQty.Text = txtPurchasedQyantity.Text;
        }

        private void txtPurchasedQyantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_saveInfo.Focus();
            }
            //done
        }

        private void txtReqQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPurchasedQyantity_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        GenerateItemNo obj = new GenerateItemNo();

        private void txtReqQty_TextChanged_1(object sender, EventArgs e)
        {
            txt_totQty.Text = txtReqQty.Text;
        }

        void loadWarehouseTrans()
        {
               using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql1 =$"Select COUNT(referenceItemCode) From Warehouse_Transaction_Table where referenceItemCode ='{txtItemID.Text}';";
                        DbBackValue = db.ExecuteScalar<int>(sql1);
                    if (DbBackValue == 1)
                    {
                        DbBackValue = 1;
                    }
                    else
                    {
                        DbBackValue = 0;
                    }
                        //keep that value in dbBackVal
                        string sql = $"Select WT.reOrdeLvl,WT.required_lvl,WT.AvailableQty,Inv.InvITemCode From Inventory Inv Inner Join Warehouse_Transaction_Table WT on Inv.InvITemCode=WT.InvCode where Inv.InvITemCode='{txtItemID.Text}'";
                        IDataReader readaer = db.ExecuteReader(sql);
                        while (readaer.Read())
                        {
                            itemCode = readaer["InvITemCode"].ToString().Trim();
                            reOrd = Convert.ToInt32(readaer["reOrdeLvl"]);
                            ReqQty = Convert.ToInt32(readaer["required_lvl"]);
                            AvailableQty = Convert.ToInt32(readaer["AvailableQty"]);
                        }
                        db.Close();
                        if (itemCode == txtItemID.Text.ToString().Trim())
                        {
                            txtItemID.Focus();
                            Reference = txtItemID.Text.ToString().Trim();
                            txt_availableQty.Text = AvailableQty.ToString();
                            txt_availableQty.ReadOnly = true;
                            txtReorderLvl.Text = reOrd.ToString();
                            txtReorderLvl.ReadOnly = true;
                            txtReqQty.Text = ReqQty.ToString();
                            txtReqQty.ReadOnly = true;
                            txtPurchasedQyantity.Focus();
                            ItemStatus = "R";
                           //  = Convert.ToInt32(obj.getItemNum());
                            btn_saveInfo.Enabled = true;
                        }
                        else
                        {                         
                            Reference = (obj.getItemNum()).ToString();
                            txtItemID.Text = Reference.ToString();
                            itemNo.Text = obj.getItemNum();
                            txt_availableQty.Text = "0";
                            txtReorderLvl.Text = "0";
                            txtReqQty.Text = "0";
                            ItemStatus = "N";
                            ItemID = "null";
                            txt_availableQty.Focus();
                            btn_saveInfo.Enabled = true;
                       }
                }
            }
        }

        private void txtItemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                itemIDSearch_Click(sender, e);
                txtItemID.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loadWarehouseTrans();
                Thread th = new Thread(new ThreadStart(createBatchID));
                th.Start();
            }

        }

        private void itemIDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                InvHelpScreen obj = new InvHelpScreen();
                obj.ShowDialog();
                txtItemID.Text= obj.ItemCode;
                txtItemID.Focus();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        private void warehouseCode_TextChanged(object sender, EventArgs e)
        {
            loadWarehouseDetails();
            if (warehouseCode.Text == string.Empty)
            {
                warehouseDesc.Clear();
                chk_active.Checked = false;
                chk_boxInactive.Checked = false;
            }
        }

        private void cmb_ItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void txt_empID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_ItemName.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
    public class GenerateItemNo
    {
        static Random generator = new Random();
        string itemNo = generator.Next(00002221, 1700000000).ToString();

        public string getItemNum()
        {
            return itemNo;
        }
    }
}
