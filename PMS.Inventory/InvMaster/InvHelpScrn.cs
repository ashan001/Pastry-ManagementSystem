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
using PMS.Inventory.InvObjects;

namespace PMS.Inventory.InvMaster
{
    public partial class InvHelpScrn : Form
    {
        public string InvItemCode { get; set; }
        public InvHelpScrn()
        {
            InitializeComponent();
        }

        private void InvHelpScrn_Load(object sender, EventArgs e)
        {
            using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string sql = "Select InvITemCode,warehouseCode,itemName,itemDesc,itemGroup,Storage From Inventory";
                    dataGridView1.DataSource = db.Query<HelpObj>(sql).ToList();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender,e);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InvItemCode=(dataGridView1.CurrentRow.Cells[0].Value).ToString();
            Hide();
        }
    }
}
