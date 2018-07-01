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
    public partial class CustomerUI : Form
    {
        List<CustomerDetails> _list;
        public string date { get; set; }
        DateTime dt = DateTime.Now;
        public CustomerUI(List<CustomerDetails> list)
        {
            InitializeComponent();
            _list = list;
            date = dt.ToString();
        }
     
        private void CustomerUI_Load(object sender, EventArgs e)
        {
            customerRep1.SetDataSource(_list);
            customerRep1.SetParameterValue("pDate", date.ToString().Substring(0,9));
            crystalReportViewer1.ReportSource = customerRep1;
            crystalReportViewer1.Refresh();
        }
    }
}
