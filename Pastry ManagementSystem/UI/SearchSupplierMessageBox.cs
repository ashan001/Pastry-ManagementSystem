using Pastry_ManagementSystem.DB;
using System;
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
    public partial class SearchSupplierMessageBox : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string  v_id { get; set; }
        public string v_contact { get; set; }
        public string v_cmpName { get; set; }
        public SearchSupplierMessageBox()
        {
            InitializeComponent();
        }
        string v_suppID, v_companyName = null;
        int v_contactNum = 0;
        string v_fname, v_lName, v_compName, v_address, v_nic, v_email, v_rDate,  v_siteName, v_cmmts = null;

        private void txt_cmpnyName_TextChanged(object sender, EventArgs e)
        {
            v_cmpName = txt_cmpnyName.Text.ToString();
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            v_contact = txt_contact.Text.ToString();
        }

        private void txt_suppID_TextChanged(object sender, EventArgs e)
        {
            v_id = txt_suppID.Text.ToString();
        }

        int faxNum,v_cNum;
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_suppID.Text.Length == 0 && txt_contact.Text.Length == 0 && txt_cmpnyName.Text.Length == 0)
            {
                MessageBox.Show($"Please Fill all fields or one field is enough for find the supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //do the process
                string sql = null;
                SqlDataReader reader;
                try
                {
                    sql = "Select DISTINCT * From supplier_table where supp_ID ='" + txt_suppID.Text + "' OR contactNumber='" + txt_contact.Text + "' OR company_Name='" + txt_cmpnyName.Text + "'";
                    reader = db.getData(sql);
                    while (reader.Read())
                    {
                        v_suppID = reader["supp_ID"].ToString();
                        v_contactNum = Convert.ToInt32(reader["contactNumber"].ToString());
                        v_companyName = reader["company_Name"].ToString();
                        v_fname = reader["supp_FirstName"].ToString();
                        v_lName = reader["supp_lastName"].ToString();
                        v_compName = v_companyName.ToString();
                        v_address = reader["company_Address"].ToString();
                        v_cNum = Convert.ToInt32(reader["contactNumber"].ToString());
                        v_nic = reader["NIC"].ToString();
                        v_email = reader["emailAddress"].ToString();
                        v_rDate = reader["RegisteredDate"].ToString();
                        faxNum =Convert.ToInt32(reader["fax_Num"].ToString());
                        v_siteName = reader["web_siteName"].ToString();
                        v_cmmts = reader["Comments"].ToString();
                    }
                    db.closeCon();
                    if (v_suppID != txt_suppID.Text && v_contactNum.ToString() != txt_contact.Text && v_companyName != txt_cmpnyName.Text)
                    {
                        MessageBox.Show("There's no record like that please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    { 
                        UpdateSupplier us = new UpdateSupplier();//us object refers to update supplier
                        us.Show();
                        us.loadData(v_id,v_contact,v_fname, v_lName,v_compName,v_address,v_cNum,v_nic,v_email,v_rDate,faxNum,v_siteName, v_cmmts);
                        this.Hide();                        
                    }
                }
                catch (Exception)
                {

                }
             }   
        }


    }
}
