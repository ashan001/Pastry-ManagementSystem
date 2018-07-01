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

namespace Pastry_ManagementSystem.UI.HelpScreens
{
    public partial class SupplierNameHelpScreen : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }

        public SupplierNameHelpScreen()
        {
            InitializeComponent();
        }
        string sql;
        private void SupplierHelpScreen_Load(object sender, EventArgs e)
        {
            try
            {
                sql = "Select supp_ID,company_Name,company_Address,contactNumber,emailAddress From supplier_table";
                grid1.DataSource = db.sendTable(sql);
                db.closeCon();
            }
            catch (Exception)
            {
            }
        }
        string v_value_name;
        
        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grid1_CellContentDoubleClick(sender,e);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

            ReceivedRawMaterialSscreen_Info obj1 = new ReceivedRawMaterialSscreen_Info();
            obj1.loadName(v_value_name);
            obj1.Show(this);
            Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierName = (grid1.CurrentRow.Cells["company_Name"].Value).ToString();
            SupplierCode = (grid1.CurrentRow.Cells["supp_ID"].Value).ToString();
            Hide();
        }
    }
}
