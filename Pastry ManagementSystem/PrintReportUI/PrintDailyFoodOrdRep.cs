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
    public partial class PrintDailyFoodOrdRep : MetroFramework.Forms.MetroForm
    {
        List<ListFoodData> _list;
        public PrintDailyFoodOrdRep(List<ListFoodData>list)
        {
            InitializeComponent();
            _list = list;
        }

        private void PrintDailyFoodOrdRep_Load(object sender, EventArgs e)
        {
            dailyFoodOrderRep1.SetDataSource(_list);
            dailyFoodOrderRep1.SetParameterValue("sysDate",DateTime.Now.Date.ToString().Substring(0,9));
            crystalReportViewer1.ReportSource = dailyFoodOrderRep1;
            crystalReportViewer1.Refresh();
        }
    }
}
