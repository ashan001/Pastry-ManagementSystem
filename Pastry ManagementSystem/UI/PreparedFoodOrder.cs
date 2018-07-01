using Dapper;
using MessageBoxControlCenter.MessageBoxes;
using Pastry_ManagementSystem.DB;
using Pastry_ManagementSystem.UI.HelpScreens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public string v_db_val { get; set; }
        public string empID { get; set; }
        public int contactNum { get; set; }
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
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        private void txt_empID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_empID.Text.Length == 0)
                {
                    errorProvider1.SetError(txt_empID, "Please Enter Employee ID");
                    txt_empFName.Clear();
                    txt_empLName.Clear();
                    txt_Desig.Clear();
                    txt_contactNum.Clear();
                    return;
                }
                empID = txt_empID.Text.Trim();
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
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
                    btn_Add.Enabled = true;
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
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                addData();
                DialogResult dr = MessageBox.Show("Do you want add another row","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dr.ToString() == "Yes")
                {
                    txt_contactNum.Enabled = false;
                    txt_empID.Enabled = false;
                    txt_foodNo.Clear();
                    txt_quantity.Clear();
                    errorProvider1.Clear();
                    errorProvider1.Clear();
                    txt_foodNo.Focus();
                }
                else
                {
                    db.closeCon();
                    btn_ok.Focus();
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        public void addData()
        {

            int n = grid_foodMasterInfo.Rows.Add();
            grid_foodMasterInfo.Rows[n].Cells[0].Value = txt_foodNo.Text;
            grid_foodMasterInfo.Rows[n].Cells[1].Value = txt_orderID.Text;
            grid_foodMasterInfo.Rows[n].Cells[2].Value = txt_quantity.Text;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_contactNum.Clear();
            txt_empID.Clear();
            txt_empFName.Clear();
            txt_empLName.Clear();
            txt_Desig.Clear();
            txt_foodNo.Clear();
            txt_quantity.Clear();
            errorProvider1.Clear();
            errorProvider2.Clear();
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
                        string sql = null;
                        sql = "insert into Food_Order_Detailed_Table Values('"+ grid_foodMasterInfo.Rows[i].Cells["cl_index3"].Value + "','"+grid_foodMasterInfo.Rows[i].Cells["cl_index2"].Value+"')";
                        n=db.update_del_insert_Data(sql);                                
                    }
                    db.closeCon();
                    if (n > 0)
                    {
                        db.closeCon();                       
                        MsgBox.Information("Your data saved successfully");
                        btn_Add.Enabled = false;
                    }
                    else
                    { 
                        MsgBox.Information("Process is failed and try again");
                    }
                }          
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void txt_orderID_TextChanged(object sender, EventArgs e)
        {
            if (txt_orderID.Text.Length == 0)
            {
                errorProvider1.SetError(txt_orderID, "Please enter order id to continue the process");
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            grid_foodMasterInfo.Rows.Clear();
        }

        private void txt_orderID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                ordSearch_Click(sender,e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                validateOrdID();
                txt_empID.Focus();
                e.SuppressKeyPress = true;              
            }
        }
        private void validateOrdID()
        {
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Food_Order_Header where order_No='" + txt_orderID.Text.ToString() + "'";
                        IDataReader reader = db.ExecuteReader(sql);
                        while (reader.Read())
                        {
                            v_db_val = reader["order_No"].ToString();
                        }
                        if (v_db_val == txt_orderID.Text.ToString())
                {
                    groupBox2.Enabled = true;
                    errorProvider1.Clear();
                }
                else
                {                 
                    MsgBox.Warning("Your Order id is wrong please use help screen to continue the process");
                    groupBox2.Enabled = false;
                }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        public string _empID { get; set; }
        public int db_contactNum { get; set; }
        private void loadEmpData()
        {
           
            try
            {
                using (IDbConnection db=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string query = "Select * From Employee_Master_Table where emp_ID ='" + empID.Trim() + "'";
                        IDataReader reader = db.ExecuteReader(query);
                        while (reader.Read())
                        {
                            if (reader["Designation"].ToString() == "Chef")
                            {
                                btn_Add.Enabled = true;
                                // MsgBox.Information("" + reader["Designation"]);
                                _empID = reader["emp_ID"].ToString();
                                txt_empFName.Text = reader["emp_Fname"].ToString();
                                txt_empLName.Text = reader["emp_Lname"].ToString();
                                txt_Desig.Text = "Chef";
                                txt_contactNum.Text = reader["mobileNo"].ToString();
                            }
                            else
                            {
                                MsgBox.Error("Invalid access");
                                txt_empID.Focus();
                                btn_Add.Enabled = false;
                            }
                        }
                        if (_empID == txt_empID.Text.Trim())
                        {
                            txt_foodNo.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void txt_empID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (txt_empID.Text.Length == 0)
                {
                    txt_foodNo.Enabled = false;
                }
                else
                {    
                    loadEmpData();
                    
                }
               
            }
        }
        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_contactNum.Text.Length == 0)
                {                  
                    MsgBox.Warning("Please Enter customer contact number");
                    txt_empFName.Clear();
                    txt_empLName.Clear();
                    txt_Desig.Clear();
                    txt_empID.Clear();
                    txt_foodNo.Clear();
                    txt_foodNo.Enabled = false;
                }
                else
                {
                    contactNum = Convert.ToInt32(txt_contactNum.Text);
                    txt_foodNo.Enabled = true;
                }
            }
            catch (Exception ex)
            {            
                MsgBox.Warning("Please invalid input ,check the form again");
                MsgBox.Exception(ex);
            }
        }
        private void txt_contactNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataload();
                e.SuppressKeyPress = true;
                errorProvider1.Clear();
                errorProvider2.Clear();
                txt_foodNo.Focus();
            }
        }
        void dataload()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    string query = "Select * From Employee_Master_Table where  mobileNo='" + txt_contactNum.Text + "'";
                    IDataReader reader = db.ExecuteReader(query);
                    while (reader.Read())
                    {
                        if (reader["Designation"].ToString() == "Chef")
                        {
                            btn_Add.Enabled = true;
                            //  MsgBox.Information("" + reader["Designation"]);
                           
                            _empID = reader["emp_ID"].ToString();
                            txt_empID.Text =_empID;
                            txt_empFName.Text = reader["emp_Fname"].ToString();
                            txt_empLName.Text = reader["emp_Lname"].ToString();
                            txt_Desig.Text = "Chef";
                            txt_contactNum.Text = reader["mobileNo"].ToString();
                        }
                        else
                        {
                            MsgBox.Error("Invalid access");
                            txt_empID.Focus();
                            btn_Add.Enabled = false;
                        }
                    }
                    if (_empID == txt_empID.Text.Trim())
                    {
                        txt_foodNo.Focus();
                    }
                }
            }
        }
        private void txt_foodNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_foodNo.Text.Length == 0 && txt_quantity.Text.Length == 0)
                {
                    btn_Add.Enabled = false;
                    txt_quantity.Enabled = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                    txt_quantity.Focus();
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                FoodSearch_Click(sender, e);
            }
        }
        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_foodNo.Text.Length == 0 && txt_quantity.Text.Length == 0)
                {
                    btn_Add.Enabled = false;
                }
                else if (txt_quantity.Text.Length == 0)
                {
                    btn_Add.Enabled = false;
                }
                else if (txt_foodNo.Text.Length == 0)
                {
                    btn_Add.Enabled = false;
                }
                else
                {
                    btn_Add.Enabled = true;
                    e.SuppressKeyPress = true;
                    btn_Add.Focus();
                    db.closeCon();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(MsgBox.Question("Do you want to exit ?")==DialogResult.Yes)
              Environment.Exit(0);
        }

        private void ordSearch_Click(object sender, EventArgs e)
        {
            OrderHelpScreen obj = new OrderHelpScreen();
            obj.ShowDialog();
            txt_orderID.Text = obj.OrderID;
            txt_orderID.Focus();
        }

        private void FoodSearch_Click(object sender, EventArgs e)
        {
            FoodHelpScreen obj = new HelpScreens.FoodHelpScreen();
            obj.ShowDialog();
            txt_foodNo.Text = obj.Food;
            txt_foodNo.Focus();
        }

        private void linkPreparedFood_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }
}
