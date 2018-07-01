using System;
using Pastry_ManagementSystem.DB;
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
    public partial class FoodOrderHeaderDetails :MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public FoodOrderHeaderDetails()
        {
            InitializeComponent();
        }

        private void FoodOrderHeaderDetails_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select order_No,cus_No,order_Date,Due_Time,foodName,OrderedTimes_Flag From Food_Order_Header";
                dataGridView1.DataSource = db.sendTable(sql);
                db.closeCon();
            }
            catch (Exception)
            {
            }
        }
    }
}
