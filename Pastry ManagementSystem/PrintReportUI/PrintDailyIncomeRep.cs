using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Pastry_ManagementSystem.Other;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.PrintReportUI
{
    public partial class PrintDailyIncomeRep : MetroFramework.Forms.MetroForm
    {
        List<DailyIncomeClass> _list;
        DateTime dt = DateTime.Now;       
        public PrintDailyIncomeRep(List<DailyIncomeClass>  list)
        {
            InitializeComponent();
            _list = list;
        }

        private void PrintDailyIncomeRep_Load(object sender, EventArgs e)
        {
            dailyIncomeReport1.SetDataSource(_list);
            dailyIncomeReport1.SetParameterValue(@"p_Date", dt.Date.ToString().Substring(0,9));
            dailyIncomeReport1.SetParameterValue(@"p_genTime", dt.Date.ToString().Substring(9));
            crystalReportViewer1.ReportSource = dailyIncomeReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
