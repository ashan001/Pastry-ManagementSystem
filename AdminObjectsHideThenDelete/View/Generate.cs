using FoxLearn.License;
using System;
using System.CodeDom.Compiler;
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
    public partial class Generate : MetroFramework.Forms.MetroForm
    {
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            KeyManager keyManagerObj = new KeyManager(txtProductID.Text);
            KeyValuesClass keyValueObj;
            string productKey=string.Empty;
            if (cmbLicenseType.SelectedIndex == 0)
            {
                keyValueObj = new KeyValuesClass()
                {

                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                };
                if (!keyManagerObj.GenerateKey(keyValueObj, ref productKey))
                    txtProductKey.Text = "ERROR";
            }
            else
            {
                keyValueObj = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtDays.Text))
                };
                if (!keyManagerObj.GenerateKey(keyValueObj, ref productKey))
                    txtProductKey.Text = "ERROR";
            }
            txtProductKey.Text = productKey;
        }
        const int ProductCode = 1;
        public Generate()
        {
            InitializeComponent();
        }

        private void Generate_Load(object sender, EventArgs e)
        {
            cmbLicenseType.SelectedIndex = 0;
            txtProductID.Text = ComputerInfo.GetComputerId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmbLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLicenseType.SelectedIndex == 1)
            {
                txtDays.Text = "90";
            }
            else
            {
                txtDays.Text = string.Empty;
                txtDays.Enabled = false;
            }
        }
    }
}
