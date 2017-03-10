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
    public partial class ManagePayrol : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public ManagePayrol()
        {
            InitializeComponent();
        }

        private void ManagePayrol_Load(object sender, EventArgs e)
        {
            cmb_empName.SelectedText = "Please select employee name".ToString();
            cmb_empName.BackColor = Color.IndianRed;         
        }
        private void cmb_empName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = null;
                SqlDataReader reader = null;
                sql = "Select * From Employee_Master_Table";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    cmb_empName.Items.Add((reader["emp_Fname"].ToString()));
                }
                db.closeCon();
            }
            catch (Exception)
            {
                MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
