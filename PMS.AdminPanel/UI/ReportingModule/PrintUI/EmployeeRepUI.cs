using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.AdminPanel.UI.ReportingModule.MapObjects;
using System.Windows.Forms;

namespace PMS.AdminPanel.UI.ReportingModule.PrintUI
{
    public partial class EmployeeRepUI : Form
    {
        List<EmployeeDetails> _list;
        public EmployeeRepUI(List<EmployeeDetails> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void EmployeeRepUI_Load(object sender, EventArgs e)
        {
            try
            {
                employeeReport1.SetDataSource(_list);
                crystalReportViewer1.ReportSource = employeeReport1;
                crystalReportViewer1.RefreshReport();
            }
            catch
            {
                throw;
            }
        }
    }
}
