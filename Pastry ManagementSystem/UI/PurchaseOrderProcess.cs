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
    public partial class PurchaseOrderProcess : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string receiptNo { get; set; }
        public string suppCmpName { get; set; }
        public string _vdate { get; set; }
        public string _suppID { get; set; }
        public PurchaseOrderProcess()
        {
            InitializeComponent();
            btn_add.Cursor = Cursors.Hand;
            btn_exit.Cursor = Cursors.Hand;
            btn_submit.Cursor = Cursors.Hand;
        }
        public void loadData(string itemID,string itemName,double _price,int _qty,string cmpName,string date,string suppID,string warehouse)
        {
            txt_itemID.Text = itemID;
            txt_itemName.Text = itemName;
            txt_Itemprice.Text = _price.ToString();
            txt_quantity.Text = _qty.ToString();
            suppCmpName = cmpName;
            _vdate = date;
            _suppID = suppID;
            warehouseCode.Text = warehouse;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            GetReceiptNo obj1 = new GetReceiptNo();
            receiptNo = obj1.getReceiptNum();
            int n=dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = receiptNo;
            dataGridView1.Rows[n].Cells[1].Value = _suppID;
            dataGridView1.Rows[n].Cells[2].Value = _vdate;
            dataGridView1.Rows[n].Cells[3].Value = txt_itemName.Text; 
            dataGridView1.Rows[n].Cells[4].Value = txt_itemID.Text;
            dataGridView1.Rows[n].Cells[5].Value = suppCmpName;          
            dataGridView1.Rows[n].Cells[6].Value = txt_quantity.Text;
            dataGridView1.Rows[n].Cells[7].Value = txt_Itemprice.Text;
            dataGridView1.Rows[n].Cells[8].Value = txt_totAmt.Text;
            dataGridView1.Rows[n].Cells[9].Value = warehouseCode.Text;
            btn_submit.Enabled = true;
        }
        public int _var_itemID;
        private void txt_itemID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_itemID.Text.Length == 0)
                {
                    txt_itemName.Clear();
                    txt_Itemprice.Clear();
                    txt_quantity.Clear();
                    btn_submit.Enabled = false;
                }
                SqlDataReader reader;
                string sql = $"Select * From Item_File where ItemID='{txt_itemID.Text}'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    _var_itemID = Convert.ToInt32(reader["ItemID"]);
                    txt_itemName.Text = reader["Item_Name"].ToString();
                    txt_Itemprice.Text = (Convert.ToDouble(reader["purchase_price"]) / (Convert.ToInt32(reader["tot_purchases"]))).ToString();
                    errorProvider1.Clear();
                }
                db.closeCon();
                if (Convert.ToInt32(txt_itemID.Text) != _var_itemID)
                {
                    errorProvider1.SetError(txt_itemID, "Please check your item id");
                }

            }
            catch (Exception)
            {
            }
            
        }
        public double totAmt;
        private int _Line3;

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(doCal));
            if (txt_quantity.Text !=null)
            {
                btn_add.Enabled = true;
                th1.Start();
            }        
        }
        public void doCal()
        {
            try
            {
                totAmt = (Convert.ToDouble(txt_Itemprice.Text) * (Convert.ToInt64(txt_quantity.Text)));
                txt_totAmt.Text = totAmt.ToString();
            }
            catch (Exception)
            {
            }         
        }
        private void txt_itemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_quantity.Focus();
                e.SuppressKeyPress = true;
                txt_itemID.Enabled = false;
            }
            else if (e.KeyCode==Keys.F2)
            {
                itemIDSearch_Click(sender,e);
            }
        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseOrderProcess_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txt_itemID.Enabled = true;
                warehouseCode.Focus();
                e.SuppressKeyPress = true;               
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txt_itemName.Clear();
            txt_Itemprice.Clear();
            txt_quantity.Clear();
            txt_totAmt.Clear();
            txt_itemID.Clear();
            btn_submit.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_itemName.Clear();
            txt_Itemprice.Clear();
            txt_quantity.Clear();
            txt_totAmt.Clear();
            txt_itemID.Clear();
            warehouseCode.Clear();
            txt_itemID.Enabled = true;
            btn_submit.Enabled = false;
        }

        private void btn_new_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_itemID.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                int _line1=0, _line2=0,tot=0;
                for (int c = 0; c < dataGridView1.Rows.Count; c++)
                {
                    string sql = $"Insert Into received_raw_meterial_header_file values('{dataGridView1.Rows[c].Cells["cl_index1"].Value}','{dataGridView1.Rows[c].Cells["cl_suppID"].Value}','{dataGridView1.Rows[c].Cells["cl_date"].Value}','{dataGridView1.Rows[c].Cells["cl_index3"].Value}')";
                    _line1 = db.update_del_insert_Data(sql);
                    db.closeCon();
                    string sql2 = $"Insert Into recieved_raw_meterial_detailed_file values('{dataGridView1.Rows[c].Cells["cl_index1"].Value}','{dataGridView1.Rows[c].Cells["cl_warehouse"].Value}','{dataGridView1.Rows[c].Cells["cl_index2"].Value}','{dataGridView1.Rows[c].Cells["cl_index4"].Value}','{dataGridView1.Rows[c].Cells["cl_index7"].Value}','{dataGridView1.Rows[c].Cells["cl_index8"].Value}')";
                    _line2 = db.update_del_insert_Data(sql2);
                    db.closeCon();
                    string sql3 = $"Insert into TransactionTable Values('{dataGridView1.Rows[c].Cells["cl_index2"].Value.ToString()}','{dataGridView1.Rows[c].Cells["cl_warehouse"].Value.ToString()}','po','{dataGridView1.Rows[c].Cells["cl_index4"].Value.ToString()}','{DateTime.Now.Date.ToString().Substring(0,9)}')";
                    _Line3 = db.update_del_insert_Data(sql3);
                    db.closeCon();
                }
                tot = _line1 + _line2 + _Line3;
                if (tot > 0)
                {
                    MsgBox.Show(1);
                    btn_submit.Enabled = false;
                }
                else
                {
                    MsgBox.Error("Process is failed,please try gain");
                }
            }
            catch (Exception)
            {

            }
        }

        private void txt_itemID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_itemID, "Numeric Values Only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_itemID, "Numeric Values Only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseHelpScreen obj = new WarehouseHelpScreen();
                obj.ShowDialog();
                warehouseCode.Text = obj.WarehouseCode;
                btn_add.Focus();
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
                btnSearch_Click(sender,e);
            }
        }

        private void itemIDSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txt_itemID.Text = obj.itemID;
            txt_itemID.Focus();
        }
    }
    public class GetReceiptNo
    {
        static Random generator = new Random();
        string receiveNum = generator.Next(00001,1000000000).ToString();

        public string getReceiptNum()
        {
            return receiveNum;
        }
    }
}
