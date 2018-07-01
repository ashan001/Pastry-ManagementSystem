using MessageBoxControlCenter.MessageBoxes;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.UI.HelpScreens;

namespace Pastry_ManagementSystem.UI
{
    public partial class PreparedFood : MetroFramework.Forms.MetroForm
    {
        public string empID { get; set; }
        public PreparedFood()
        {
            InitializeComponent();
        }

        private void txt_empID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (txt_empID.Text.Length == 0)
                {
                    txt_foodNo.Enabled = false;
                }
                else
                {
                    loadEmpData();
                    txt_foodNo.Focus();
                }

            }
        }
        public string _empID { get; set; }
        public int db_contactNum { get; set; }
        private void loadEmpData()
        {

            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
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
                            groupBox2.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void txt_empID_TextChanged(object sender, EventArgs e)
        {
            if (txt_empID.Text.Length == 0)
            {
                ClearFormData(this);
                MsgBox.Error("Please enter employee id");              
                return;
            }
            empID = txt_empID.Text.Trim();
        }
        private void txt_contactNum_TextChanged(object sender, EventArgs e)
        {
            if (txt_contactNum.Text.Length ==0)
            {
                ClearFormData(this);
                MsgBox.Error("Please enter employee contact no");
                return;
            }
        }
        void ClearFormData(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                else if (c is DataGridView)
                    ((DataGridView)c).Rows.Clear();
                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Now.Date;
                else
                    ClearFormData(c);
            }
        }

        private void FoodSearch_Click(object sender, EventArgs e)
        {
            FoodHelpScreen obj = new HelpScreens.FoodHelpScreen();
            obj.ShowDialog();
            txt_foodNo.Text = obj.Food;
            txtFoodName.Text = obj.FoodName;
            txt_foodNo.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_quantity.Text == string.Empty)
            {
                txt_quantity.Enabled = false;
            }
            else
            {
                txt_quantity.Enabled = true;
                if (txt_foodNo.Text == string.Empty)
                {
                    GenFoodID obj = new GenFoodID();
                    txt_foodNo.Text=obj.getFoodID();
                }
                addData();
            }           
        }
        void addData()
        {
            try
            {
                int rows = grid_foodMasterInfo.Rows.Add();
                grid_foodMasterInfo.Rows[rows].Cells[0].Value = txt_foodNo.Text;
                grid_foodMasterInfo.Rows[rows].Cells[1].Value = txtFoodName.Text;
                grid_foodMasterInfo.Rows[rows].Cells[2].Value = txt_quantity.Text;
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void txt_contactNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                dataload();
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
                            txt_empID.Text = _empID;
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
                        groupBox2.Enabled = true;
                    }
                }
            }
        }

        private void txt_foodNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_quantity.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                FoodSearch_Click(sender,e);
            }
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add_Click(sender,e);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            ClearFormData(this);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MsgBox.Question("Do you want to exit from the system ??") == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFormData(this);
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
              
            }
        }
    }
    public class GenFoodID
    {
        static Random generator = new Random();
        string FoodID = generator.Next(00002221, 1700000000).ToString();

        public string getFoodID()
        {
            return FoodID;
        }
    }
}
