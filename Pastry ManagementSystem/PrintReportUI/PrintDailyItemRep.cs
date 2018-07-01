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

    public partial class PrintDailyItemRep : MetroFramework.Forms.MetroForm
    {
       List<MapItemData>_list;
        public PrintDailyItemRep(List<MapItemData>list)
        {
            InitializeComponent();
            _list = list;
        }

        private void PrintDailyItemRep_Load(object sender, EventArgs e)
        {
            dailyItemReport1.SetDataSource(_list);
            dailyItemReport1.SetParameterValue("p_date",DateTime.Now.Date.ToString().Substring(0,9));
            crystalReportViewer1.ReportSource = dailyItemReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
