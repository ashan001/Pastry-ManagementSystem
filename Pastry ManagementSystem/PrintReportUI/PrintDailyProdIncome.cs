using System;
using Pastry_ManagementSystem.Other;
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
    
    public partial class PrintDailyProdIncome : MetroFramework.Forms.MetroForm
    {
        List<TakeProductData> _list;
        public PrintDailyProdIncome(List<TakeProductData> list)
        {
            InitializeComponent();
            _list = list;
        }
        private void PrintDailyProdIncome_Load(object sender, EventArgs e)
        {
            dailyProdIncomRep1.SetDataSource(_list);
            dailyProdIncomRep1.SetParameterValue("p_date",DateTime.Now.Date.ToString().Substring(0,9));
            crystalReportViewer1.ReportSource = dailyProdIncomRep1;
            crystalReportViewer1.Refresh();
        }
    }
}
