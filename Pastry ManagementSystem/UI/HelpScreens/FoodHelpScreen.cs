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
    public partial class FoodHelpScreen : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string Food { get; set; }
        public string FoodName { get; set; }
        public FoodHelpScreen()
        {
            InitializeComponent();
        }

        private void FoodHelpScreen_Load(object sender, EventArgs e)
        {
            try
            {
                string _sql = "Select * from Food_Table";
                dataGridView1.DataSource = db.sendTable(_sql);
            }
            catch(Exception)
            {
                
            }
        }
        private void _btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentDoubleClick(sender,e);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Food = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            FoodName = (dataGridView1.CurrentRow.Cells[1].Value).ToString();
            Hide();
        }
    }
}
