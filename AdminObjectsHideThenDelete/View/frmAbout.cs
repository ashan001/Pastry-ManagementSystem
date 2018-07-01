using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminObjectsHide.View
{
    public partial class frmAbout : MetroFramework.Forms.MetroForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;
        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblProductID.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(lblProductID.Text);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"key.lic",Application.StartupPath),ref lic);
            string productKey = lic.ProductKey;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey,ref kv))
                {
                    lblName.Text = "Pastry Management System";
                    lblProductKey.Text = productKey;
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lblLicenseType.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                    }
                    else
                    {
                        lblLicenseType.Text = "Full";
                    }
                }
            }
        } 
        private void btnOK_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
