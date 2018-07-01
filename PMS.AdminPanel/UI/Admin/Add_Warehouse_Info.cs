using Dapper;
using MessageBoxControlCenter.MessageBoxes;
using PMS.AdminPanel.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.AdminPanel.UI.Admin
{
    public partial class Add_Warehouse_Info : Form
    {
        public Add_Warehouse_Info()
        {
            InitializeComponent();
        }

        WarehouseDetailedTable obj = new WarehouseDetailedTable();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseDetailedTable obj = new WarehouseDetailedTable();
                obj.warehouse_code = warehouseCode.Text;
                obj.Warehouse_description = txt_desc.Text;
                if (chk_1.Checked == true)
                {
                    obj.warehouseStatus = "Active";
                }
                else
                {
                    obj.warehouseStatus = "In-Active";
                }
                obj.save();
                MsgBox.Show(obj.result);
            }
            catch(Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        private string _value;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                obj.warehouse_code = warehouseCode.Text;
                obj.Warehouse_description = txt_desc.Text;
                if (chk_1.Checked == true)
                {
                    obj.warehouseStatus = "Active";
                }
                else
                {
                    obj.warehouseStatus = "In-Active";
                }
                obj.update();
                MsgBox.Show(obj.result);
            }
            catch
            {
                MsgBox.Show(obj.result);
            }
        }

        private void warehouseCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadData();
                e.SuppressKeyPress = true;
            }
        }
        public void loadData()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = $"Select * From Warehouse_Master where warehouse_code='{warehouseCode.Text}'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            txt_desc.Text = reader["Warehouse_description"].ToString();
                            _value = reader["warehouseStatus"].ToString();
                            if (_value == "Active")
                            {
                                chk_1.Checked = true;
                            }
                            else
                            {
                                chk_2.Checked = true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_1.Checked == true)
            {
                chk_2.Enabled = false;
            }
            else
            {
                chk_2.Enabled = true;
            }
        }

        private void chk_2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_2.Checked == true)
            {
                chk_1.Enabled = false;
            }
            else
            {
                chk_1.Enabled = true;
            }
        }
    }
}
