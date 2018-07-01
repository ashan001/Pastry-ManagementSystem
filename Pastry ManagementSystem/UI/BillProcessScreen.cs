using Pastry_ManagementSystem.DB;
using Dapper;
using Pastry_ManagementSystem.Other;
using Pastry_ManagementSystem.PrintReportUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastry_ManagementSystem.UI.HelpScreens;
using MessageBoxControlCenter.MessageBoxes;

namespace Pastry_ManagementSystem.UI
{
    public partial class BillProcessScreen : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        private string _fdName { get; set; }
        public string _empName;
        public BillProcessScreen()
        {
            InitializeComponent();
            timer1.Start();
        }
        private string _orderedTimes_ { get; set; }
        protected string _ordID = null, _cusID = null, _foodName = null,_billNo=null;
        public string _cusFname = null, _cusLname = null, _cusNIC = null, _cusAdd = null,_food_id=null;        
       
        double _totNetAmt;
        private void _txtOrderedTimes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_txtOrderedTimes.Text != "*")
                {
                    _orderedTimes_ = _txtOrderedTimes.Text;
                    _totNetAmt = Convert.ToDouble(_totAmt * Convert.ToDouble(_orderedTimes_));
                }
                else
                {
                    _orderedTimes_ = null;
                }
            }
            catch (Exception)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            _dateTime.Visible = true;
            _dateTime.Text = dt.ToString();
        }

        private void _txtTotAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _totNetAmt = Convert.ToDouble(_txtTotAmt.Text);
            }
            catch (Exception)
            {
            }
        }
      
        private void BillProcessScreen_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private string empID = null, _empDesig = null, fName = null, lName = null;

        private void _txtOrderID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                Search_Click_1(sender,e);
            }
        }

        private void _btn_orderNew_Click(object sender, EventArgs e)
        {
            _txtFoodNo.Enabled = true;
            //_txtQty.Enabled = true;
            _txtFoodNo.Clear();
            _txtFoodName.Clear();
            _txtFoodPrice.Clear();
            _txtQty.Clear();
            _txtTotAmt.Clear();
            _txtOrderedTimes.Clear();
        }

        private void _btn_orderNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                _txtFoodNo.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private int _food_Num;
        private void _txtFoodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _food_Num = Convert.ToInt32(_txtFoodNo.Text);
                if (_txtFoodNo.Text.Length == 0)
                {
                    _txtFoodNo.Enabled = true;
                    _txtQty.Enabled = true;
                    _txtFoodNo.Clear();
                    _txtFoodName.Clear();
                    _txtFoodPrice.Clear();
                    _txtQty.Clear();
                    _txtTotAmt.Clear();
                    _txtOrderedTimes.Clear();
                }
            }
            catch (Exception)
            {
            }
        }

        private void _txtFoodNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Thread th2 = new Thread(new ThreadStart(_getnewFoodData));
                th2.Start();
                _txtQty.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                
            }
        }
        private int food_no;
        public void _getnewFoodData()
        {
            try
            {
                string _sql = $"Select * From Food_Table where food_No='{_txtFoodNo.Text}'";
                SqlDataReader reader;
                reader = db.getData(_sql);
                while (reader.Read())
                {
                    food_no = Convert.ToInt32(reader["food_No"]);
                    _txtFoodName.Text = reader["Food_Name"].ToString();
                    _txtFoodPrice.Text = reader["price"].ToString();
                }
                db.closeCon();
                if (food_no == _food_Num)
                {
                    _txtQty.Enabled = true;
                    errorProvider1.Clear();
                }
                else
                {
                    MessageBox.Show("Please check the food no","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    _txtQty.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }
        private void _txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_txtQty.Text.Length == 0)
                {
                    _btnAddNew.Enabled = false;
                }
                else
                { 
                    e.SuppressKeyPress = true;
                    _btnAddNew.Visible = true;
                    _btnAddNew.Enabled = true;
                    _btnAddNew.Focus();
                    Thread th3 = new Thread(new ThreadStart(refreshCalculation));
                    th3.Start();
                    _btnAddNew.Enabled = true;
                }
            }
        }
        double tot_Amt;
        public void refreshCalculation()
        {
            try
            {
                tot_Amt = ((Convert.ToDouble(_txtFoodPrice.Text)) * (Convert.ToDouble(_txtQty.Text)));
                _txtTotAmt.Text = tot_Amt.ToString();
                _txtOrderedTimes.Text = "Not Allow To Change";
            }
            catch (Exception)
            {
            }
        }

        private void _txtFoodNo_Click(object sender, EventArgs e)
        {
            _btnAddNew.Enabled = false;
            _txtQty.Enabled = false;
        }

        private void _btnAddNew_Click(object sender, EventArgs e)
        {
            loadBillData();
            _btnAddNew.Enabled = false;
        }       

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _btn_orderNew.Focus();
            }
        }

        private void _txt_empName_TextChanged(object sender, EventArgs e)
        {
            _empName = _txt_empName.Text;
        }
        double subTot=0,gstval=0,billTot=0;
        int _line1,_line2,totlines;

        private void _btnAddNew_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            subTot = 0;
            btn_generate.Enabled = true;
            _generateBill.Enabled = true;
            _txtSub.Clear();
            _txtGst.Clear();
            _txtBillAmt.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
            new CashierMenu().Show();
            Hide();
        }

        private void _txt_empName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {

                if (!(e.Handled == true))
                {
                    errorProvider1.SetError(_txt_empName, "Accepting only Charactors");
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar) == true && Char.IsNumber(e.KeyChar) == false)
            {
                _txt_empName.Clear();
            }
        }

        private void _txtFoodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(_txtFoodNo, "Numeric Values only Accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void _txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(_txtFoodNo, "Numeric Values only Accepted");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void Search_Click_1(object sender, EventArgs e)
        {
            try
            {
                OrderHelpScreen obj = new OrderHelpScreen();
                obj.ShowDialog();
                _txtOrderID.Text = obj.OrderID;
                _txtOrderID.Focus();
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }

        private void fooSearch_Click(object sender, EventArgs e)
        {
            FoodHelpScreen obj = new FoodHelpScreen();
            obj.ShowDialog();
            _txtFoodNo.Text = obj.Food;
            _txtFoodNo.Focus();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                btn_clear.Visible = true;
                if (db.State==ConnectionState.Closed)
                {
                    db.Open();
                    string sql;
                    sql = $"Select sod.food_no,ft.Food_Name,ft.price,sod.total_Price From Sales_Order_header_file soh Inner Join Sales_order_detailed_file sod on soh.bill_no=sod.bill_no Inner Join Food_Table ft on ft.food_No=sod.food_no where soh.bill_no='{_generatedBillNo.Text}'";
                    List<BillingInfo> list = db.Query<BillingInfo>(sql, commandType: CommandType.Text).ToList();
                    using (BillingUI print = new BillingUI(list, _txtID.Text, _txtName.Text, _txtNIC.Text, _txtAdd.Text, _txtContact.Text, _generatedBillNo.Text,_txtGst.Text, _txtBillAmt.Text, _txtSub.Text))
                    {
                        print.ShowDialog();
                    }
                    //working fine
                }
            }
          
        }

        private void _txtQty_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void _generateBill_Click(object sender, EventArgs e)
        {
            try
            {
                string _sqlQuery = $"Insert Into Sales_Order_header_file(bill_no,_empID,v_date,v_time,sub_total,bill_gst,bill_tot)Values('{_generatedBillNo.Text}','{empID}','{_dateTime.Text.ToString().Substring(0,9)}','{_dateTime.Text.ToString().Substring(9)}','{_txtSub.Text}','{_txtGst.Text}','{_txtBillAmt.Text}')";               
                _line1 = db.update_del_insert_Data(_sqlQuery);
                db.closeCon();
                for (int _c=0;_c<dataGridView1.Rows.Count;_c++)
                {
                    //string _sql = $"Insert Into Sales_order_detailed_file(bill_no,d_no,total_Price)Values('{_generatedBillNo.Text}','{dataGridView1.Rows[_c].Cells["cl_index1"].Value}','{dataGridView1.Rows[_c].Cells["cl_omdex4"].Value}')";
                    string _sql = $"Insert Into Sales_order_detailed_file(bill_no,food_no,total_Price)Values('{_generatedBillNo.Text}','{dataGridView1.Rows[_c].Cells["cl_index1"].Value}','{dataGridView1.Rows[_c].Cells["cl_omdex4"].Value}')";
                    _line2 = db.update_del_insert_Data(_sql);
                    db.closeCon();
                }
                totlines = _line1 + _line2;
                if (totlines > 0)
                {
                    MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _generateBill.Enabled = false;
                    btn_print.Visible = true;

                }
                else
                {
                    _generateBill.Enabled = true;
                    MessageBox.Show("Process is failed please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int c=0;c<dataGridView1.Rows.Count;c++)
                {
                    subTot += (Convert.ToDouble(dataGridView1.Rows[c].Cells["cl_omdex4"].Value));
                }              
                _generateBill.Visible = true;
                gstval =((subTot * 10)/100);
                billTot = subTot + gstval;
                _lblSub.Visible = true;
                _lblGst.Visible = true;
                _lblBill.Visible = true;
                _txtSub.Visible = true;
                _txtGst.Visible = true;
                _txtBillAmt.Visible = true;
                _txtSub.Text = subTot.ToString();
                _txtGst.Text = gstval.ToString();
                _txtBillAmt.Text = billTot.ToString();
                btn_generate.Enabled = false;

            }
            catch (Exception)
            {
            }
        }

        private void _txt_empName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _txtOrderID.Focus();
                e.SuppressKeyPress = true;
                Thread th1 = new Thread(new ThreadStart(LoadData));
                th1.Start();
            }
        }
        public void LoadData()
        {
            try
            {
                //MessageBox.Show("Hello World" + _empName);
                SqlDataReader reader;
                string sql = $"Select * From Employee_Master_Table  where emp_Fname='{_txt_empName.Text}' OR emp_Lname='{_txt_empName.Text}'";
                reader = db.getData(sql);
                while (reader.Read())
                {
                    //MessageBox.Show(""+reader["emp_Fname"].ToString());
                    fName = reader["emp_Fname"].ToString();
                    lName = reader["emp_Lname"].ToString();
                    _empDesig = reader["Designation"].ToString();
                    empID = reader["emp_ID"].ToString();
                }
                db.closeCon();
                if (fName == _txt_empName.Text || lName == _txt_empName.Text)
                {
                    if (_empDesig == "Cashier")
                    {
                        panel1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("You do not have access for this process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please check your Employee Name and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }
        private void _txtOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(_txtOrderID, "Please check your Order Number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        public int _contact = 0;
        protected int _qty = 0;
        protected double _price = 0.0,_totAmt=0.0,_foodPrice=0.0;
        private string _flag;
        private void _txtOrderID_TextChanged(object sender, EventArgs e)
        {
            if (_txtOrderID.Text.Length == 0)
            {
                errorProvider1.SetError(_txtOrderID, "Please Enter Order ID");
                _txtID.Clear();
                _txtName.Clear();
                _txtNIC.Clear();
                _txtAdd.Clear();
                _txtContact.Clear();
                _txtFoodNo.Clear();
                _txtFoodName.Clear();
                _txtFoodPrice.Clear();
                _txtTotAmt.Clear();
                _txtOrderedTimes.Clear();
                errorProvider1.Clear();
                btn_add.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    SqlDataReader reader;
                    //string _sql = $"Select * From Food_Order_Header where order_No='{_txtOrderID.Text}'";
                    string _sql = $"Select foh.order_No,foh.cus_No,foh.foodName,foh.item_price,foh.OrderedTimes_Flag,foh.quantity,foh.totAmt,ct.FirstName,ct.LastName,ct.NIC,ct.cus_address,ct.ContactNum,ft.food_No From Food_Order_Header foh Inner Join Customer_Table ct on ct.cusID = foh.cus_No Inner Join Food_Table ft on ft.Food_Name=foh.foodName where order_No='{_txtOrderID.Text}'";
                    reader = db.getData(_sql);
                    while (reader.Read())
                    {
                        _ordID = reader["order_No"].ToString();
                        _cusID = reader["cus_No"].ToString();
                        _foodName = reader["foodName"].ToString();
                        _qty = Convert.ToInt32(reader["quantity"]);
                        _price = Convert.ToDouble(reader["item_price"]);
                        _totAmt = Convert.ToDouble(reader["totAmt"]);
                        _cusFname = reader["FirstName"].ToString();
                        _cusLname = reader["LastName"].ToString();
                        _cusNIC = reader["NIC"].ToString();
                        _cusAdd = reader["cus_address"].ToString();
                        _contact = Convert.ToInt32(reader["ContactNum"]);
                        _food_id = reader["food_No"].ToString();
                        _flag = reader["OrderedTimes_Flag"].ToString();
                    }
                    db.closeCon();
                    if (_ordID == _txtOrderID.Text.ToString())
                    {
                        btn_add.Enabled = true;
                        _txtID.Text = _cusID.ToString();
                        _txtName.Text = (_cusFname + _cusLname);
                        _txtNIC.Text = _cusNIC;
                        _txtAdd.Text = _cusAdd;
                        _txtContact.Text = _contact.ToString();                      
                        //MessageBox.Show(""+_flag);
                        //end of customer data
                        _txtFoodNo.Text = _food_id;
                        _txtFoodName.Text = _foodName;
                        _txtFoodPrice.Text = _price.ToString();
                        _txtQty.Text = _qty.ToString();
                        _txtTotAmt.Text = _totAmt.ToString();
                        _txtOrderedTimes.Text = _flag;
                    }
                    else
                    {
                        errorProvider1.SetError(_txtOrderID, "please check order id");
                        btn_add.Enabled = false;
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        public void loadBillData()
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = _cusID;
            dataGridView1.Rows[n].Cells[1].Value = _txtFoodNo.Text;
            dataGridView1.Rows[n].Cells[2].Value = _txtFoodName.Text;
            dataGridView1.Rows[n].Cells[3].Value = _txtQty.Text;
            dataGridView1.Rows[n].Cells[4].Value = _txtFoodPrice.Text;
            dataGridView1.Rows[n].Cells[5].Value = _totNetAmt;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateBillNo obj1 = new GenerateBillNo();
                _billNo = obj1.getBillNo();
                cusDetailGroupBox.Visible = true;
                _generatedBillNo.Text = _billNo;
                _lableBillNo.Visible = true;
                _generatedBillNo.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                //MessageBox.Show("" + _totNetAmt);
                loadBillData();
                btn_add.Enabled = false;
                /*
       dataGridView1.Rows[n].Cells[5].Value = suppCmpName;
       dataGridView1.Rows[n].Cells[6].Value = txt_quantity.Text;
       dataGridView1.Rows[n].Cells[7].Value = txt_Itemprice.Text;
       dataGridView1.Rows[n].Cells[8].Value = txt_totAmt.Text;
       btn_submit.Enabled = true;
       * */
            }
            catch (Exception)
            {

            }
        }
    }
    
    public class GenerateBillNo
    {
        static Random generator = new Random();
        string billNo = generator.Next(000221101, 1000000100).ToString();

        public string getBillNo()
        {
            return billNo;
        }
    }
  
}
