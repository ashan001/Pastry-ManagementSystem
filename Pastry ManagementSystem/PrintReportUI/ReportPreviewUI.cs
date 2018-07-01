using Pastry_ManagementSystem.Other;
using Pastry_ManagementSystem.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.PrintReportUI
{
    public partial class ReportPreviewUI : MetroFramework.Forms.MetroForm
    {
        List<OrderDetail> _list;
        Orders _orders;
        public ReportPreviewUI(Orders orders,List<OrderDetail> list)
        {
            InitializeComponent();           
            _orders = orders;
            _list = list;
        }        
       
        private void OrderRepPrintUI_Load(object sender, EventArgs e)
        {
            orderReceipt1.SetDataSource(_list);
            orderReceipt1.SetParameterValue("p_cusName", _orders.cusID);
            orderReceipt1.SetParameterValue("p_cussNIc",_orders.NIC);
            orderReceipt1.SetParameterValue("p_cusAdd",_orders.cus_address);
            orderReceipt1.SetParameterValue("p_cusContact",_orders.ContactNum);
            orderReceipt1.SetParameterValue("p_ordID",_orders.order_No);
            orderReceipt1.SetParameterValue("p_ordDate", _orders.order_Date);
            crystalReportViewer1.ReportSource = orderReceipt1;
            crystalReportViewer1.Refresh();

        }
    }
}
