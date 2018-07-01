using Pastry_ManagementSystem.Other;
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
    public partial class BillingUI : MetroFramework.Forms.MetroForm
    {
        string _cusID,_cusName,_cusNic,_cusAdd,_cusContact,_billNo,_gstVal, _totVal,_totalVal;
        List<BillingInfo> _list;
        public BillingUI(List<BillingInfo> list, string cusID,string cusName,string nic,string cusAdd,string cusContact,string billNo,string gst,string tot,string totVal)
        {
            InitializeComponent();
            _cusID = cusID;
            _cusName = cusName;
            _cusNic = nic;
            _cusAdd = cusAdd;
            _cusContact = cusContact;
            _billNo = billNo;
            _list = list;
            _gstVal = gst;
            _totVal = tot;
            _totalVal = totVal;
        }
        DateTime dt = DateTime.Now;
        private void BillingUI_Load(object sender, EventArgs e)
        {
            bill1.SetDataSource(_list);
            bill1.SetParameterValue("p_cusID", _cusID);
            bill1.SetParameterValue("p_cusName", _cusName);
            bill1.SetParameterValue("p_cusNic", _cusNic);
            bill1.SetParameterValue("p_cusAdd", _cusAdd);
            bill1.SetParameterValue("p_cusContact", _cusContact);
            bill1.SetParameterValue("p_date", dt.ToString().Substring(0,9));
            bill1.SetParameterValue("p_time",dt.ToString().Substring(9));
            bill1.SetParameterValue("p_billNo", _billNo);
            bill1.SetParameterValue("p_gst", _gstVal);
            bill1.SetParameterValue("p_grandTot",_totVal);
            bill1.SetParameterValue("p_total", _totalVal);
            crystalReportViewer1.ReportSource = bill1;
            crystalReportViewer1.Refresh();
        }
    }
}
