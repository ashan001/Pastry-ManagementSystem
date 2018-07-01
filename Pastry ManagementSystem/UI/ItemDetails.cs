using Pastry_ManagementSystem.DB;
using System;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;
using PMS.AdminPanel.ExtraClasses;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.UI
{
    public partial class ItemDetails : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public ItemDetails()
        {
            InitializeComponent();
        }

        private void txt_itemType_TextChanged(object sender, EventArgs e)
        {
            if (txt_itemType.Text == string.Empty)
            {
                dataGridView1.DataSource = null;
                MsgBox.Warning("Please enter item type");
            }
            else
            {
                try
                {
                    string sql = $"Select ItemID,Item_Name,Item_Type,date_and_time,batch_No,mfg_date,ex_date,purchase_price,cash_wholeSale,Vat_Amt,tot_purchases,tot_Qty,net_Amt From Item_File where Item_Type like '%{txt_itemType.Text}%'";
                    dataGridView1.DataSource = db.sendTable(sql);
                    db.closeCon();
                }
                catch
                {
                    throw;
                }
            }
        }

        private void txt_itemName_TextChanged(object sender, EventArgs e)
        {
            if (txt_itemName.Text == string.Empty)
            {
                MsgBox.Warning("Please enter item name");
                dataGridView1.DataSource = null;
            }
            else
            {
                try
                {
                    //string sql = $"Select item_id,Item_Name,Item_Type,date_and_time,Available_Qty,warning_lvl,Reorder_lvl,purchase_price,cash_wholeSale,Vat_Amt,tot_purchases,tot_Qty,net_Amt From Item_File where Item_Name like '%{txt_itemName.Text}%'";
                    string sql = $"Select ItemID,Item_Name,Item_Type,date_and_time,batch_No,mfg_date,ex_date,purchase_price,cash_wholeSale,Vat_Amt,tot_purchases,tot_Qty,net_Amt From Item_File where Item_Name like '%{txt_itemName.Text}%'";
                    dataGridView1.DataSource = db.sendTable(sql);
                    db.closeCon();
                }
                catch
                {
                    throw;
                }
            }
        }
        public string _itemID { get; set; }
        public  int _line = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _itemID = this.dataGridView1.CurrentRow.Cells["ItemID"].Value.ToString();
          //  MessageBox.Show(""+_itemID);
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //string query = $"Delete from Item_Table where Item_Name ='{_itemID}'";
                //_line = db.update_del_insert_Data(query);
                //db.closeCon();
                //if (_line == 1)
                //{
                //    MessageBox.Show("Data Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Data not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string query = $"Delete from Item_File where Item_File.ItemID ='{_itemID}'";
                        int result = db.Execute(query);
                        if (result == 1)
                        {
                            MsgBox.Information("Data Deleted Successfully");
                        }
                        else
                            MsgBox.ShowDeleteStatus(2);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Close();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == string.Empty)
            {
                MsgBox.Warning("Please enter item ID");
                dataGridView1.DataSource = null;
            }
            else
            {
                try
                {
                    //string sql = $"Select item_id,Item_Name,Item_Type,date_and_time,Available_Qty,warning_lvl,Reorder_lvl,purchase_price,cash_wholeSale,Vat_Amt,tot_purchases,tot_Qty,net_Amt From Item_File where Item_Name like '%{txt_itemName.Text}%'";
                    string sql = $"Select ItemID,Item_Name,Item_Type,date_and_time,batch_No,mfg_date,ex_date,purchase_price,cash_wholeSale,Vat_Amt,tot_purchases,tot_Qty,net_Amt From Item_File where ItemID like '%{metroTextBox1.Text}%'";
                    dataGridView1.DataSource = db.sendTable(sql);
                    db.closeCon();
                }
                catch
                {
                    throw;
                }
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
                else
                    ClearFormData(c);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFormData(this);
        }
    }
}
