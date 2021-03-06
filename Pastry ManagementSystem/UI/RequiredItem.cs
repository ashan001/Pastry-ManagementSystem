﻿using System;
using System.Data.SqlClient;
using Pastry_ManagementSystem.DB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.UI.HelpScreens;

namespace Pastry_ManagementSystem.UI
{
    public partial class RequiredItem : MetroFramework.Forms.MetroForm
    {
        protected string v_sys_date { get; set; }
        protected string v_sys_time { get; set; }
        protected string empID { get; set; }
        public string itemID { get; set; }
        public string v_db_itemFieldValue { get; set; }
        Database db = new Database();
        public RequiredItem()
        {
            InitializeComponent();
        }

        private void RequiredItem_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            cmb_SuppCompanyName.SelectedText = "Please select your company name".ToString();
            cmb_SuppCompanyName.BackColor = Color.IndianRed;
            //read last record from the item master table
            //and then load the item no into txt_itemNo text field
            //
            try
            {
                string sql = null;
                SqlDataReader reader;
                sql = "SELECT * FROM Item_File WHERE ItemID not in (SELECT TOP (SELECT COUNT(1)-1 FROM Item_File) ItemID FROM Item_File);";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    txt_itemNo.Text = reader["ItemID"].ToString();
                }
                db.closeCon();
                reader = null;
                string query2 = null;
                query2 = "Select company_Name From supplier_table; ";
                try
                {
                    reader = db.getData(query2);
                    while (reader.Read())
                    {
                        cmb_SuppCompanyName.Items.Add(reader["company_Name"].ToString());
                    }
                    db.closeCon();
                }
                catch (Exception)
                {
                    //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //do the coding stuff for that item no field
            //
            //
            //take system date to txt_date Field
            //use same object 
            //for date and the time
            DateTime dt = DateTime.Now;
            v_sys_date = dt.Date.ToString().Substring(0,9);
            txt_date.Text = v_sys_date.ToString();
            //for time
            v_sys_time = dt.Date.ToString().Substring(9);
            txt_time.Text = v_sys_time.ToString();

        }
        string v_db_empID = null;
        private void txt_empId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_empId.Text.Length == 0)
                {
                    errorProvider1.SetError(txt_empId, "Please enter employee id");
                    txt_fName.Clear();
                    txt_lName.Clear();
                    txt_designation.Clear();
                    txt_nic.Clear();
                }
                else
                {
                    db.closeCon();
                    SqlDataReader reader = null;
                    string sql = null;
                    sql = "Select * From Employee_Master_Table where emp_ID='" + txt_empId.Text + "'";
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        v_db_empID = reader["emp_ID"].ToString();
                        txt_fName.Text = reader["emp_Fname"].ToString();
                        txt_lName.Text = reader["emp_Lname"].ToString();
                        txt_designation.Text = reader["Designation"].ToString();
                        txt_nic.Text = reader["Nic"].ToString();
                    }
                    db.closeCon();
                    
                }
            }
            catch (Exception)
            {
               // MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = grid_itemInfo.Rows.Add();
            grid_itemInfo.Rows[n].Cells[0].Value = txt_itemField.Text;
            grid_itemInfo.Rows[n].Cells[1].Value = txt_quatity.Text;
            grid_itemInfo.Rows[n].Cells[2].Value = cmb_SuppCompanyName.Text;
            grid_itemInfo.Rows[n].Cells[3].Value = txt_empId.Text;
        }
        int n,x,value=0;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grid_itemInfo.Rows.Count; i++)
                {
                    //MessageBox.Show(""+grid_foodMasterInfo.Rows[i].Cells["cl_index1"].Value);
                    string sql1 = null;
                    sql1 = "insert into purchase_order_detailed_file Values('" + grid_itemInfo.Rows[i].Cells["cl_index1"].Value + "','" + grid_itemInfo.Rows[i].Cells["cl_index2"].Value + "')";
                    n = db.update_del_insert_Data(sql1);
                    db.closeCon();
                    string sql2 = null;
                    sql2 = "Insert into purchase_order_header_file Values('" + grid_itemInfo.Rows[i].Cells["cl_index3"].Value + "','" + grid_itemInfo.Rows[i].Cells["cl_index4"].Value + "','" + txt_date.Text.ToString().Substring(0,9) + "','" + dtp_dueDate.Value.ToString().Substring(0,9) + "')";
                    x = db.update_del_insert_Data(sql2);
                    db.closeCon();
                }
                value = x + n;
                if (value > 0)
                {
                    MessageBox.Show("Your Data saved successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_ok.Enabled = false;
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

        private void txt_fName_TextChanged(object sender, EventArgs e)
        {
            if (txt_fName.Text!=null)
            {
                errorProvider1.Clear();
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            grid_itemInfo.Rows.Clear();
            this.btn_ok.Enabled = true;
        }

        private void cmb_SuppCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SuppCompanyName.BackColor = Color.LightGreen;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_empId.Clear();
            this.txt_fName.Clear();
            this.txt_lName.Clear();
            this.txt_designation.Clear();
            this.txt_nic.Clear();
            this.btnAdd.Enabled = false;
            this.txt_quatity.Clear();
            this.txt_itemField.Clear();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new SystemAdminMenu().Show();
            this.Hide();
        }

        private void txt_itemField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                itemIDSearch_Click(sender,e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                txt_quatity.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void itemIDSearch_Click(object sender, EventArgs e)
        {
            ItemHelpScreen obj = new ItemHelpScreen();
            obj.ShowDialog();
            txt_itemField.Text = obj.itemID;
            txt_itemField.Focus();
        }

        private void txt_itemField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql;
                SqlDataReader reader;
                sql = "Select * From Item_File where ItemID='" + txt_itemField .Text+ "'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    v_db_itemFieldValue=(reader["ItemID"].ToString());
                   
                }         
               
                db.closeCon();
                if (v_db_itemFieldValue == txt_itemField.Text)
                {
                    txt_quatity.Enabled = true;
                    errorProvider1.Clear();
                }
                else
                {
                    txt_quatity.Enabled = false;
                    errorProvider1.SetError(txt_itemField, "Please check the item number and try again");
                }
            }
            catch (Exception)
            {

            }
        }

        private void dtp_dueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_dueDate.Value.ToString() == null)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
    }
}
