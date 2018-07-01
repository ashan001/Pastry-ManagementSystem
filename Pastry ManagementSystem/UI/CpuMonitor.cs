using MessageBoxControlCenter.MessageBoxes;
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
    public partial class CpuMonitor : MetroFramework.Forms.MetroForm
    {
        public CpuMonitor()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00%}",fcpu);
            lblRAM.Text = string.Format("{0:0.00%}",fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void CpuMonitor_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void closeFromRam_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgBox.Question("Do you want to re-boot your system") == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    Thread.Sleep(2500);                   
                    Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    this.Activate();
                }

            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
