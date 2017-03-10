using Pastry_ManagementSystem.DB;
using System;
using System.Threading; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class AvailableRawMaterialScreen : MetroFramework.Forms.MetroForm
    {
        protected string v_sys_date { get; set; }
        protected string v_sys_time { get; set; }
        protected string v_purchasedID { get; set; }
        protected string itemID { get; set; }
        public string db_ItemName { get; set; }
        Database db = new Database();
        public AvailableRawMaterialScreen()
        {
            InitializeComponent();
        }
        string sql2 = null;
        SqlDataReader reader2 = null;
        
        private void AvailableRawMaterialScreen_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            cmb_purchID.BackColor = Color.IndianRed;
            cmb_purchID.SelectedText = "Please Select purchase ID".ToString();
            cmb_itemId.BackColor = Color.IndianRed;
            cmb_itemId.SelectedText = "Please Select item id".ToString();
            try
            {
                string sql = null;
                SqlDataReader reader = null;
                sql = "SELECT DISTINCT * FROM Item_Table WHERE item_id not in (SELECT TOP (SELECT COUNT(1)-1 FROM Item_Table) item_id FROM Item_Table)";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    txt_itemNo.Text = reader["item_id"].ToString();
                }
                db.closeCon();
                if (!(txt_itemNo.Text.Length == 0 && txt_date.Text.Length == 0 && txt_time.Text.Length == 0))//condition works fine
                {
                    sql2 = "Select DISTINCT * From purchase_order_header_file";
                    reader2 = db.getData(sql2);
                    while (reader2.Read())
                    {
                        cmb_purchID.Items.Add(reader2["pur_id"].ToString());
                    }
                    db.closeCon();
                }
            }
            catch (TimeoutException)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (InsufficientMemoryException)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (InvalidProgramException)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //load system date and time to text fields
            //for date
            DateTime dt = DateTime.Now;
            v_sys_date = dt.Date.ToString().Substring(0, 9);
            txt_date.Text = v_sys_date.ToString();
            //for time
            v_sys_time = dt.Date.ToString().Substring(9);
            txt_time.Text = v_sys_time.ToString();
        }
        string v_db_purID;
        private void cmb_purchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_purchID.BackColor = Color.LightGreen;
            try
            {
                string sql = null;
                SqlDataReader reader = null;
                v_purchasedID = cmb_purchID.SelectedItem.ToString();
                sql = "Select DISTINCT * From purchase_order_header_file where pur_id='" + v_purchasedID + "'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    v_db_purID = reader["pur_id"].ToString();
                }
                db.closeCon();
                if (v_purchasedID == v_db_purID)
                {
                    txt_empID.Enabled = true;
                }
                else
                {
                    txt_empID.Enabled = false;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }
        string sql = null;
        SqlDataReader reader = null;
        string empID = null;
        private void txt_empID_TextChanged(object sender, EventArgs e)
        {  
            try
            {
                sql = "Select  * From Employee_Master_Table where emp_ID='" + txt_empID .Text+ "'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    empID = reader["emp_ID"].ToString();
                    txt_empFName.Text = reader["emp_Fname"].ToString();
                    txt_lName.Text = reader["emp_Lname"].ToString();
                    txt_designation.Text = reader["Designation"].ToString();
                }
                if (txt_empID.Text.Length == 0)
                {
                    errorProvider1.SetError(txt_empID, "Please enter employee id");
                    txt_empFName.Clear();
                    txt_lName.Clear();
                    txt_designation.Clear();
                }
                db.closeCon();
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void txt_designation_TextChanged(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(loadItemIDCombobox));
            if (!(txt_empFName.Text.Length == 0 && txt_lName.Text.Length == 0 && txt_designation.Text.Length == 0))
            {
                th1.Start();   
            }
        }
        private void loadItemIDCombobox()
        {
            try
            {
                string sql = null;
                SqlDataReader reader = null;
                sql = "Select DISTINCT  * From Item_Table";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    cmb_itemId.Items.Add(reader["item_id"].ToString());
                }
                db.closeCon();
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
       
        private void cmb_itemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_itemId.BackColor = Color.LightGreen;
            errorProvider1.Clear();
            try
            {
                itemID = cmb_itemId.SelectedItem.ToString();
                string sql = "Select DISTINCT * From Item_Table where item_id ='" + itemID + "'";
                SqlDataReader reader;
                reader = db.getData(sql);
                while (reader.Read())
                {
                    db_ItemName = reader["item_Name"].ToString();
                }
                db.closeCon();
            }
            catch (Exception)
            {

            }
            //try
            //{
            //    string sql, itemID_db_val = null;
            //    SqlDataReader reader = null;
            //    sql = "Select * From purchase_order_detailed_file where item_id='" + cmb_itemId.SelectedItem.ToString() + "'";
            //    reader = db.getData(sql);
            //    while (reader.Read())
            //    {
            //        itemID_db_val = reader["item_id"].ToString();
            //    }
            //    //MessageBox.Show(itemID_db_val);
            //    //if (cmb_itemId.SelectedItem.ToString() == itemID_db_val)
            //    //{
            //    //   

            //    //}
            //    db.closeCon();
            //}
            //catch (Exception)
            //{

            //}
        }
        private void txt_empFName_TextChanged(object sender, EventArgs e)
        {
            if (txt_empFName.Text.Length!=0)
            {
                errorProvider1.Clear();
            }
        }

        private void txt_availableQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_availableQty, "Numaric values only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            int n=grid_InfoThrowData.Rows.Add();
            grid_InfoThrowData.Rows[n].Cells[0].Value = cmb_itemId.SelectedItem.ToString();
            grid_InfoThrowData.Rows[n].Cells[1].Value = db_ItemName.ToString();
            grid_InfoThrowData.Rows[n].Cells[2].Value = txt_qtyrequired.Text;
            grid_InfoThrowData.Rows[n].Cells[3].Value = txt_availableQty.Text;
           
        }

        private void txt_qtyrequired_TextChanged(object sender, EventArgs e)
        {
            if (txt_qtyrequired.Text.Length == 0)
            {
                errorProvider1.SetError(txt_qtyrequired, "Please enter quantity that required");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (txt_qtyrequired.Text.Length == 0)
            {
                MessageBox.Show("Please check the form again and proceed");
            }
            else
            {
                int n=0;
                if (txt_availableQty.Text.Length == 0)
                {
                    MessageBox.Show("Please check the form again and proceed");
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < grid_InfoThrowData.Rows.Count; i++)
                        {
                            //MessageBox.Show(""+grid_foodMasterInfo.Rows[i].Cells["cl_index1"].Value);
                            string sql1 = null;
                            sql1 = "insert into Item_transaction_File Values('" + grid_InfoThrowData.Rows[i].Cells["cl_index1"].Value + "','" + grid_InfoThrowData.Rows[i].Cells["cl_itemName"].Value + "','" + grid_InfoThrowData.Rows[i].Cells["cl_index2"].Value + "','" + grid_InfoThrowData.Rows[i].Cells["cl_index3"].Value + "')";
                            n = db.update_del_insert_Data(sql1);
                            db.closeCon();
                            
                        }
                        if (n > 0)
                        {
                            MessageBox.Show("Your Data saved successfully");
                            this.btn_OK.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Process is failed please try again");
                        }
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_qtyrequired_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_qtyrequired, "Numaric values only accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_availableQty_TextChanged(object sender, EventArgs e)
        {
            if (txt_availableQty.Text.Length == 0)
            {
                errorProvider1.SetError(txt_availableQty, "Please enter available quantity");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txt_availableQty.Clear();
            txt_qtyrequired.Clear();
            cmb_itemId.BackColor = Color.IndianRed;
            errorProvider1.SetError(cmb_itemId,"Select Item id if you want to enter more");
            grid_InfoThrowData.Rows.Clear();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            grid_InfoThrowData.Rows.Clear();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
