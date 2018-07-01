using Dapper;
using Pastry_ManagementSystem.DB;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI.ReportUI
{
    public partial class PrintOrderReciept : MetroFramework.Forms.MetroForm
    {
        Database db = new Database();
        public PrintOrderReciept()
        {
            InitializeComponent();
        }
       
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (fromDate.Value !=null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select o.order_No,o.order_Date,c.cusID,c.FirstName,c.LastName,c.ContactNum,c.cus_address,c.NIC From Food_Order_Header o Inner Join Customer_Table c on o.cus_No = c.cusID where o.order_Date between '" + fromDate.Value + "' and '" + toDate.Value + "'";
                        ordersBindingSource3.DataSource = db.Query<Orders>(sql, commandType: CommandType.Text);
                    }
                }
            }            
            //try
            //{
            //    string sql = "Select o.order_No,o.order_Date,c.cusID,c.FirstName,c.LastName,c.ContactNum,c.cus_address,c.NIC From Food_Order_Header o Inner Join Customer_Table c on o.cus_No = c.cusID where o.order_Date between '" + fromDate.Value + "' and '" + toDate.Value + "'";
            //    dataGridView1.DataSource = db.sendTable(sql);               
            //    db.closeCon();
            //}
            //catch (Exception)
            //{
            //}
        }
        //public string ordID = null, cusID = null,cusFName=null,cuslname=null,cusAdd = null, cusNIC = null, ordDate = null;
        //public int cusContact = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    string sql = $"Select * From Customer_Table where cusID='{dataGridView1.CurrentRow.Cells["cusID"].Value.ToString()}'";
            //    SqlDataReader reader = null;
            //    reader = db.getData(sql);
            //    while (reader.Read())
            //    {
            //        ordID = reader["cusID"].ToString();
            //        cusFName = reader["FirstName"].ToString();
            //        cuslname = reader["LastName"].ToString();
            //        cusAdd = reader["cus_address"].ToString();
            //        cusContact = Convert.ToInt32(reader["ContactNum"].ToString());
            //        cusNIC = reader["NIC"].ToString();
            //    }
            //    db.closeCon();
            //    CustomerDetails.getData(ordID, cusFName, cuslname, cusContact, cusAdd,cusNIC);
            //}
            //catch (Exception)
            //{
            //}
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            new UI.ManagerMenu().Show();
            this.Hide();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //string sql = "Select  FO.order_No,F.Food_Name,FO.quantity,F.price From Food_Order_Header FO Inner Join Food_Table F ON FO.foodName = F.Food_Name " +
            //    $"where F.Food_Name ='{}' AND FO.foodName='"++"'";
            //SqlDataReader reader;
            //string sql = "Select * From Food_Order_Header " +
            //    $"where Food_Order_Header.order_No ='{dataGridView1.CurrentRow.Cells["order_No"].Value.ToString()}'";
            //reader = db.getData(sql);
            //while (reader.Read())
            //{
            //    orderNo = reader["order_No"].ToString();
            //    itemName = reader["foodName"].ToString();
            //    unitPrice = Convert.ToDouble(reader["item_price"]);
            //    quantity = Convert.ToInt32(reader["quantity"]);
            //    TotalAmt = Convert.ToDouble(reader["totAmt"].ToString());
            //}
            //db.closeCon();
            //OrderDetails obj1 = new OrderDetails();
            //Orders ord = new Orders();
            //obj1.getvalues(orderNo, itemName, quantity, unitPrice, TotalAmt);
            //ord.getData(ordID,cusID, cusFName, cuslname, cusContact, cusAdd, cusNIC,ordDate);
            //btnPrint.Enabled = true;
            //up to here working good
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //new OrderRepPrintUI().Show();
            //btnPrint.Enabled = false;
            Orders obj = ordersBindingSource3.Current as Orders;
            if (obj !=null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        string sql = "Select * From Food_Order_Header " +
                            $"where Food_Order_Header.order_No ='{obj.order_No}'";
                        List<OrderDetail> list = db.Query<OrderDetail>(sql,commandType:CommandType.Text).ToList();
                        using (ReportPreviewUI print = new ReportPreviewUI(obj,list))
                        {
                            print.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
