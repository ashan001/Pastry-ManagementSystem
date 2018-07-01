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
    public partial class RawMaterial_ExpRepGen : MetroFramework.Forms.MetroForm
    {
        List<MapDataAndHideForRawMatExp> _list;
        DateTime dt = DateTime.Now;
        public RawMaterial_ExpRepGen(List<MapDataAndHideForRawMatExp> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void RawMaterial_ExpRepGen_Load(object sender, EventArgs e)
        {
            rawMatExpRep1.SetDataSource(_list);
            rawMatExpRep1.SetParameterValue("p_date", dt.Date.ToString().Substring(0,9));
            rawMatExpRep1.SetParameterValue("p_time", dt.Date.ToString().Substring(9));
            crystalReportViewer1.ReportSource = rawMatExpRep1;
            crystalReportViewer1.Refresh();
        }
    }
}
