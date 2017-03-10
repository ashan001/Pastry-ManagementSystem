using Pastry_ManagementSystem.DB;
using System;
using System.Windows.Forms;
using Pastry_ManagementSystem.UI;
using System.Threading;

namespace Pastry_ManagementSystem.UI.SubUI
{
    public partial class ChooseFoodNo : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public string v_foodNo { get; set; }
        public ChooseFoodNo()
        {
            InitializeComponent();
        }
        private void ChooseFoodNo_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string sql;
            try
            {
                sql = "Select * From Food_Table";
                foodInfo.DataSource = db.sendTable(sql);            
            }
            catch (Exception)
            {
                MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            new PreparedFoodOrder().Show();
            this.Hide();
        }
        private void foodInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }
       
    }
}
