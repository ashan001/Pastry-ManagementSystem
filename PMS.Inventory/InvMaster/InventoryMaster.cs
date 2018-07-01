using PMS.Inventory.InvObjects;
using MessageBoxControlCenter.MessageBoxes;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Inventory.InvMaster
{
    public partial class InventoryMaster : Form
    {
        public InventoryMaster()
        {
            InitializeComponent();
            cmb_group.Text = "Select Item group".ToString();            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                InvObjectClass obj = new InvObjectClass();

                obj.itemCode = txtItemCode.Text;
                obj.itemName = txt_itemName.Text;
                obj.itemDesc = rtxt_itemDesc.Text;
                obj.itemGroup = cmb_group.SelectedItem.ToString();
                obj.itemprice = (Convert.ToDouble(txt_unitPrice.Text));
                obj.storage = txt_storage.Text;
                obj.shelfLife = txt_shelfLife.Text;
                obj.PurchasedQty = Convert.ToInt32(txtPurchasedQty.Text);
                obj.RequiredLvl = Convert.ToInt32(txtRequiredQty.Text);
                obj.ReorderLvl = Convert.ToInt32(txtReorderLvl.Text);
                obj.warehouse = txtWarehouse.Text.ToString();
                obj.fromDate = dtp_fromdate.Value.ToString();
                obj.toDate = dtp_todate.Value.ToString();

                if (chkBoxCon.Checked == true)
                {
                    obj.condition = "continue".ToString();
                }
                else
                {
                    obj.condition = "Dis-Continue";
                }

                obj.save();
                if (obj.tot > 1 && obj.tot < 3)
                {
                    MsgBox.Show(1);
                    ClearFormData(this);
                }
            }
            catch
            {                
                MsgBox.Error("Please check the form again");
            }
        }

        private void cmb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateItemNo obj = new GenerateItemNo();
            if (txtItemCode.Text.Length == 0)
            {
                txtItemCode.Text= obj.getItemNum().ToString();               
            }
            if (txtItemCode.Text !=string.Empty)
            {
                //do nothing
                return;
            }
        }

        private void chkBoxCon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCon.CheckState == CheckState.Checked)
            {
                chkBox.Enabled = false;
            }
            else
            {
                chkBox.Enabled = true;               
            }               
        }

        private void chkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox.CheckState == CheckState.Checked)
            {
                chkBoxCon.Enabled = false;
            }
            else
                chkBoxCon.Enabled = true;
        }

        private void txt_itemName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_itemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(txt_itemName, "Accepting only Charactors");
                    e.Handled = true;
                }
                errorProvider1.Clear();
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_unitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_unitPrice, "Numeric Values only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_storage_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryMaster_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //    {
            //        if (db.State == ConnectionState.Closed)
            //        {
            //            db.Open();
            //            string sql = "Select * From Warehouse_Master";
            //            IDataReader reader = db.ExecuteReader(sql);
            //            while (reader.Read())
            //            {
            //                cmbWarehouseCode.Items.Add(reader["warehouse_code"].ToString());
            //            }
            //            db.Close();
            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MsgBox.Exception(ex);
            //}
        }
        public class GenerateItemNo
        {
            static Random generator = new Random();
            string itemNo = generator.Next(00002221, 1700000000).ToString();

            public  string getItemNum()
            {
                return itemNo;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                InvObjectClass obj2 = new InvObjectClass();
                //
                obj2.itemCode = txtItemCode.Text;
                obj2.itemName = txt_itemName.Text;
                obj2.itemDesc = rtxt_itemDesc.Text;
                obj2.itemGroup = cmb_group.Text;
                obj2.itemprice = Convert.ToDouble(txt_unitPrice.Text);
                obj2.storage = txt_storage.Text;
                obj2.shelfLife = txt_shelfLife.Text;
                obj2.warehouse = txtWarehouse.Text.ToString();
                obj2.fromDate = dtp_fromdate.Value.ToString();
                obj2.toDate = dtp_todate.Value.ToString();
                if (chkBoxCon.Checked == true)
                {
                    obj2.condition = "continue";
                }
                else
                {
                    obj2.condition = "Continue";
                }
                int res = obj2.update();
                MsgBox.Show(res);
                ClearFormData(this);
            }
            catch
            {
                MsgBox.Error("Please select the item code");
            }         
        }

        private void itemIDSearch_Click(object sender, EventArgs e)
        {
            InvHelpScrn obj = new InvHelpScrn();
            obj.ShowDialog();
            txtItemCode.Text = obj.InvItemCode;
            txtItemCode.Focus();
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                itemIDSearch_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                loadInvItem();
            }     
        }
        public string itemCode { get; set; }
        void loadInvItem()
        {
            using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select * From Inventory Inv Inner Join Warehouse_Transaction_Table WT on WT.InvCode=INv.InvITemCode where InvITemCode='{txtItemCode.Text}'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            itemCode = reader["InvITemCode"].ToString().Trim();
                            txt_itemName.Text = reader["itemName"].ToString();
                            rtxt_itemDesc.Text = reader["itemDesc"].ToString();
                            cmb_group.Text = reader["itemGroup"].ToString();
                            txt_unitPrice.Text = reader["itemprice"].ToString();
                            txt_storage.Text = reader["storage"].ToString();
                            txt_shelfLife.Text = reader["shelfLife"].ToString();
                            txtPurchasedQty.Text = reader["purchasedQty"].ToString();
                            txtRequiredQty.Text = reader["required_lvl"].ToString();
                            txtReorderLvl.Text = reader["reOrdeLvl"].ToString();
                            txtWarehouse.Text = reader["warehouseCode"].ToString();
                            dtp_fromdate.Text = reader["fromDate"].ToString();
                            dtp_todate.Text = reader["toDate"].ToString();
                            string value = reader["condition"].ToString();
                            if (value == "continue")
                            {
                                chkBoxCon.Checked = true;
                            }
                            else
                            {
                                chkBox.Checked = true;
                            }
                        }
                        if (itemCode == txtItemCode.Text.Trim())
                        {
                            txtPurchasedQty.ReadOnly = true;
                            txtRequiredQty.ReadOnly = true;
                            txtReorderLvl.ReadOnly = true;
                        }
                        else if (itemCode != txtItemCode.Text.Trim())
                        {
                            txtPurchasedQty.ReadOnly = false;
                            txtRequiredQty.ReadOnly = false;
                            txtReorderLvl.ReadOnly = false;
                        }
                        else if (txtItemCode.Text == string.Empty)
                        {
                            txtPurchasedQty.ReadOnly = false;
                            txtRequiredQty.ReadOnly = false;
                            txtReorderLvl.ReadOnly = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MsgBox.Exception(ex);
                }
            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            if (txtItemCode.Text.Length == 0)
            {
                ClearFormData(this);
            }
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
                else if (c is RichTextBox)
                    ((RichTextBox)c).Clear();
                else
                    ClearFormData(c);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearFormData(this);
            txtReorderLvl.ReadOnly = false;
            txtRequiredQty.ReadOnly = false;
            txtPurchasedQty.ReadOnly = false;
        }

        private void WarehouseSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmWarehouseHelp obj = new frmWarehouseHelp();
                obj.ShowDialog();
                txtWarehouse.Text = obj.Warehouse;
                txtWarehouse.Focus(); 
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void txtWarehouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                WarehouseSearch_Click(sender,e);
            }
        }
    }  
}
