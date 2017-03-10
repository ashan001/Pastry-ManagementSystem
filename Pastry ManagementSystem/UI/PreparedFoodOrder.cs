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
    public partial class PreparedFoodOrder : MetroFramework.Forms.MetroForm
    {
        public string v_year { get; set; }
        public string foodID { get; set; }      
        public string v_foodNo { get; set; }
        Database db = new Database();
        public PreparedFoodOrder()
        {
            InitializeComponent();
        }
        private void PreparedFoodOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                DateTime dt = DateTime.Now;
                v_year = dt.Date.ToString().Substring(0, 9);
                txt_date.Text = v_year.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void txt_empID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader;
                string sql;
                sql = "Select emp_Fname,emp_Lname,Designation From Employee_Master_Table where emp_ID ='" + txt_empID.Text + "' ";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    txt_empFName.Text = reader["emp_Fname"].ToString();
                    txt_empLName.Text = reader["emp_Lname"].ToString();
                    txt_Desig.Text = reader["Designation"].ToString();
                }
                db.closeCon();
            }
            catch (Exception)
            {
                //MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        string v_db_foodNo = null;
        private void txt_foodNo_TextChanged(object sender, EventArgs e)
        {

            try
            {
                foodID = txt_foodNo.Text;
                string sql;
                SqlDataReader reader;
                sql = "Select * from Food_Table where food_No='" + txt_foodNo.Text + "'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    v_db_foodNo = reader["food_No"].ToString();
                }
                db.closeCon();
                if (v_db_foodNo == txt_foodNo.Text)
                {
                    errorProvider1.Clear();
                    errorProvider2.Clear();
                    txt_quantity.Enabled = true;
                }
                else if (v_db_foodNo != txt_foodNo.Text)
                {
                    errorProvider1.SetError(txt_foodNo, "Please check your food no");
                    txt_quantity.Enabled = false;
                }
                else if (txt_foodNo.Text.Length == 0)
                {
                    errorProvider1.Clear();
                    errorProvider2.SetError(txt_foodNo, "Please Enter Food No");
                    txt_quantity.Enabled = false;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int n = grid_foodMasterInfo.Rows.Add();
                grid_foodMasterInfo.Rows[n].Cells[0].Value = txt_foodNo.Text;
                grid_foodMasterInfo.Rows[n].Cells[1].Value = txt_quantity.Text;
            }
            catch (Exception)
            {
                //MessageBox.Show("","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_empID.Clear();
            txt_empFName.Clear();
            txt_empLName.Clear();
            txt_Desig.Clear();
            txt_foodNo.Clear();
            txt_quantity.Clear();
        }
        int n;
        private void btn_ok_Click(object sender, EventArgs e)
        {
             try
            {
                if (foodID==v_db_foodNo)
                {
                    for (int i = 0; i < grid_foodMasterInfo.Rows.Count; i++)
                    {
                         //MessageBox.Show(""+grid_foodMasterInfo.Rows[i].Cells["cl_index1"].Value);
                        string sql = null;
                        sql = "insert into Food_Order_Detailed_Table(food_no,Order_No,Order_Qty) Values('"+ grid_foodMasterInfo.Rows[i].Cells["cl_index1"].Value + "','"+txt_orderID.Text+"','"+grid_foodMasterInfo.Rows[i].Cells["cl_index2"].Value+"')";
                        n=db.update_del_insert_Data(sql);
                        //MessageBox.Show(""+n);
                        //table complecated give me the right table
                        //up to this okay !!!!                 
                    }
                    if (n > 0)
                    {
                        db.closeCon();
                        MessageBox.Show("Your data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Add.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Process is failed and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.closeCon();
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                //MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
