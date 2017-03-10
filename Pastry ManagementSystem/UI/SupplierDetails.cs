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
        public SupplierDetails()
        {
            InitializeComponent();
        }
        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            if (txt_contactNum.Text.Length == 0)
            {
                errorProvider1.SetError(txt_contactNum, "please enter supplier contact number");
                metroGrid1.DataSource = null;
            }
            else if (txt_contactNum.Text.Length < 7)
            {
                errorProvider1.SetError(txt_contactNum, "please check supplier contact number");
            }
            else if (txt_contactNum.Text.Length > 10)
            {
                errorProvider1.SetError(txt_contactNum, "please check supplier contact number");
            }
            else
            {
                string sql = null;
                sql = "select * From supplier_table where contactNumber='"+txt_contactNum.Text+"'";
                metroGrid1.DataSource = db.sendTable(sql);
                db.closeCon();
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
            }
            else
            {
                string sql = null;
                sql = "select * From supplier_table where company_Name like '%" +(txt_companyName.Text)+ "%'";
                metroGrid1.DataSource = db.sendTable(sql);
                db.closeCon();
            }
        }
    }
}
