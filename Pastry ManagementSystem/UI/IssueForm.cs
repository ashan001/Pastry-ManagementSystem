using Pastry_ManagementSystem.UI.HelpScreens;
using System;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.ExtraClassesToMapData;
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.UI
{
    public partial class IssueForm : MetroFramework.Forms.MetroForm
    {
        public IssueForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txtItemCode.Text = obj.itemID;
            txtItemName.Text = obj.itemName;
            txtItemDescription.Text = obj.ItemDescription;
            ItemPrice.Text = (obj.ItemPrice).ToString();
            txtWarehouseCode.Text = obj.WarehouseCode;
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnSearch_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                txtWarehouseCode.Focus();
            }
        }
        public int AvailableQty { get; set; }
        public int ReorderLvl { get; set; }
        public string ItemStatus { get; set; }
        private int QtyLvl;
        private void txtWarehouseCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        //string sql = $"Select * From Warehouse_Master where warehouse_code='{txtWarehouseCode.Text}'";
                        string sql =$"Select WM.Warehouse_description,WM.warehouseStatus,WT.AvailableQty,WT.reOrdeLvl,WT.itemStatus from Warehouse_Master WM Inner Join Warehouse_Transaction_Table WT on WM.warehouse_code=WT.warehouseCode where WT.referenceItemCode='{txtItemCode.Text}' OR WT.InvCode='{txtItemCode.Text}';";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            //take reorder lvl and available qty
                            //
                            //
                            txtDescription.Text = reader["Warehouse_description"].ToString();
                            txtStatus.Text = reader["warehouseStatus"].ToString();
                            //
                            AvailableQty = Convert.ToInt32(reader["AvailableQty"]);
                            ReorderLvl = Convert.ToInt32(reader["reOrdeLvl"]);
                            //
                            ItemStatus = reader["itemStatus"].ToString();
                         
                            //txtQty.Visible = true; metroLabel7.Visible = true;
                            //txtQty.Focus();
                        }
                        if (AvailableQty == ReorderLvl)
                        {
                            QtyLvl = AvailableQty;
                            MsgBox.Warning("Please Re-Order Item  " + txtItemName.Text);
                            txtQty.Visible = true; metroLabel7.Visible = true;
                            txtQty.Focus();
                        }
                        else if (AvailableQty > ReorderLvl)
                        {
                            QtyLvl = AvailableQty;
                            txtQty.Visible = true; metroLabel7.Visible = true;
                            txtQty.Focus();
                        }
                        else if (AvailableQty < ReorderLvl)
                        {
                            QtyLvl = AvailableQty;
                            MsgBox.Warning("Quantity of item  " + txtItemName.Text + "  is low, please Re order this item");
                            txtQty.Visible = true; metroLabel7.Visible = true;
                            txtQty.Focus();
                        }
                        else if (AvailableQty == 0)
                        {
                            QtyLvl = AvailableQty;
                            MsgBox.Error("Not Allowed to cotinue process,out of stock in warehouse");
                            txtQty.Visible = false; metroLabel7.Visible = false;
                            btnSubmit.Enabled = false;
                            txtQty.Focus();
                        }
                    }
                }                
            }
        }
        
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateQty();
            }
        }
        void ValidateQty()
        {
            if (txtQty.Text.Length == 0)
            {
                btnSubmit.Enabled = false;
                MsgBox.Warning("Please enter quantity");
            }
            else if ((Convert.ToInt32(txtQty.Text)) < Convert.ToInt32(QtyLvl))
            {
                btnSubmit.Enabled = true;
                btnSubmit.Focus();
            }
            else if ((Convert.ToInt32(txtQty.Text)) > Convert.ToInt32(QtyLvl))
            {
                MsgBox.Error(" Should not be greater than Available Quantity level. In Stock You have have only " + QtyLvl + "  in warehouse  " + txtWarehouseCode.Text);
                btnSubmit.Enabled = false;
                txtQty.Focus();
            }
            else if (txtQty.Text == "0")
            {
                btnSubmit.Enabled = false;
                MsgBox.Warning("Please enter quantity");
            }

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtItemCode.Text.Length == 0)
            {
                MsgBox.Error("Please enter item code");
                return;
            }

            ObjectsOfIssueForm obj = new ObjectsOfIssueForm();
            obj.ItemCode = txtItemCode.Text;
            obj.WarehouseCode = txtWarehouseCode.Text;
            obj.Quantity = Convert.ToInt32(txtQty.Text);           
            //
            //
            int res=obj.save();
            if (res == 2)
            {
                MsgBox.Show(1);
                ClearFormData(this);
                txtItemCode.Focus();
                btnSubmit.Enabled = false;  
            }
            else
            {
                MsgBox.Information("Process is failed");
            }
         }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;              
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }
    }
}
