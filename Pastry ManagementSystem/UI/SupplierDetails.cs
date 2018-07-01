using Pastry_ManagementSystem.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class SupplierDetails : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string supp_id { get; set; }
        public SupplierDetails()
        {
            InitializeComponent();
        }
        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            if (txt_contactNum.Text.Length == 0)
            {
                errorProvider1.SetError(txt_contactNum, "please enter supplier contact number");
                metroButton1.Enabled = false;
                metroGrid1.DataSource = null;
            }
            else if (txt_contactNum.Text.Length < 7)
            {
                errorProvider1.SetError(txt_contactNum, "please check supplier contact number");
                metroButton1.Enabled = false;
            }
            else if (txt_contactNum.Text.Length > 10)
            {
                errorProvider1.SetError(txt_contactNum, "please check supplier contact number");
                metroButton1.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                string sql = null;
                sql = "select * From supplier_table where contactNumber='"+txt_contactNum.Text+"'";
                metroGrid1.DataSource = db.sendTable(sql);
                db.closeCon();
                if (metroGrid1 != null)
                {
                    metroButton1.Enabled = true;
                }
                else
                {
                    metroButton1.Enabled = false;
                }
            }
        }
        private void txt_contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(txt_contactNum, "please check your contact number again");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txt_companyName_TextChanged(object sender, EventArgs e)
        {
            if (txt_companyName.Text.Length == 0)
            {
                errorProvider1.SetError(txt_companyName, "please enter supplier company name");
                metroGrid1.DataSource = null;
                metroButton1.Enabled = false;
            }
            else
            {
                this.errorProvider1.Clear();
                string sql = null;
                sql = "select * From supplier_table where company_Name like '%" +(txt_companyName.Text)+ "%'";
                metroGrid1.DataSource = db.sendTable(sql);             
                db.closeCon();
                if (metroGrid1 != null)
                {
                    metroButton1.Enabled = true;
                }
                else
                {
                    metroButton1.Enabled = false;
                }
            }
        }
        int line;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete the selected row ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr.ToString() == "Yes")
                {
                    supp_id = metroGrid1.CurrentRow.Cells[0].Value.ToString();
                    string sql = "Delete From supplier_table where supp_ID='" + supp_id.ToString() + "'";
                    line = db.update_del_insert_Data(sql);
                    if (line == 1)
                    {
                        MessageBox.Show("Data Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGrid1.Update();
                        metroGrid1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Data not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = null;
            txt_companyName.Clear();
            txt_contactNum.Clear();           
            metroGrid1.Refresh();
            errorProvider1.Clear();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            new ManagerMenu().Show();
            this.Hide();
        }
    }
}
