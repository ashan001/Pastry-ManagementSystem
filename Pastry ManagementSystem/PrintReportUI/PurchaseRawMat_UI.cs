using System;
using Pastry_ManagementSystem.ExtraClassesToMapData;
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
    public partial class PurchaseRawMat_UI : MetroFramework.Forms.MetroForm
    {
        List<PurchaseDetails> _list;
        public PurchaseRawMat_UI(List<PurchaseDetails> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void PurchaseRawMat_UI_Load(object sender, EventArgs e)
        {
            purchaseRawMatReport1.SetDataSource(_list);
            purchaseRawMatReport1.SetParameterValue("pDate",DateTime.Now.Date.ToString().Substring(0,9));
            crystalReportViewer1.ReportSource = purchaseRawMatReport1;
            crystalReportViewer1.Refresh();
        }
    }
}
