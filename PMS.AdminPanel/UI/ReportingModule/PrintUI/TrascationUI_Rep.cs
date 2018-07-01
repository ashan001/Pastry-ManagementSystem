using PMS.AdminPanel.UI.ReportingModule.MapObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.AdminPanel.UI.ReportingModule.PrintUI
{
    public partial class TrascationUI_Rep : Form
    {
        List<TransactionObjects> _list;
        string DateRange;
        public TrascationUI_Rep(List<TransactionObjects>list,string dateRanges)
        {
            InitializeComponent();
            _list = list;
            DateRange = dateRanges;
        }

        private void TrascationUI_Rep_Load(object sender, EventArgs e)
        {
            try
            {
                transactionReport1.SetDataSource(_list);
                transactionReport1.SetParameterValue("genDate",DateTime.Now.Date.ToShortDateString());
                transactionReport1.SetParameterValue("p_date", DateRange);
                crystalReportViewer1.ReportSource = transactionReport1;
                crystalReportViewer1.Refresh();
            }
            catch
            {
                throw;
            }
        }
    }
}
