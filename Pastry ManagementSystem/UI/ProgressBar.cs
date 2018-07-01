using Pastry_ManagementSystem.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastry_ManagementSystem.UI
{
    public partial class ProgressBar : MetroFramework.Forms.MetroForm
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        Task ProcessImport(List<string> data, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProgress = data.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() => {

                for (int i = 0; i < totalProgress; i++)
                {
                    progressReport.percentComplete = index++ * 100 / totalProgress;
                    progress.Report(progressReport);
                    Thread.Sleep(15);
                }
            });
        }

        private async void btn_Start_Click(object sender, EventArgs e)
        {
            //init data
            lbl_Process.Visible = true;
            List<string> list = new List<string>();
            for (int i = 0; i < 100; i++)
                list.Add(i.ToString());
            lbl_Process.Text = "Working";

            var progressReport = new Progress<ProgressReport>();
            progressReport.ProgressChanged += (o, report) => {
                lbl_Process.Text = string.Format("Processing...{0}%", report.percentComplete);
                metroProgressBar.Value = report.percentComplete;
                metroProgressBar.Update();
            };
            await ProcessImport(list, progressReport);
        }
    }
}
