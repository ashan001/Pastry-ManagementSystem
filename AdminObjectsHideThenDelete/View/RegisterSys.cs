using FoxLearn.License;
using MessageBoxControlCenter.MessageBoxes;
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
    public partial class RegisterSys : MetroFramework.Forms.MetroForm
    {
        public RegisterSys()
        {
            InitializeComponent();
        }
        private void RegisterSys_Load(object sender, EventArgs e)
        {
            txtProductID.Text = ComputerInfo.GetComputerId();
        }
        const int ProductCode = 1;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            KeyManager keyManagerObj = new KeyManager(txtProductID.Text);
            string productKey = txtProductKey.Text;
            if (keyManagerObj.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (keyManagerObj.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Pastry Management System";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    keyManagerObj.SaveSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), lic);
                    MsgBox.Information("You have been successfully registered the product");
                    Hide();
                }              
            }
            else
            {
                MsgBox.Error("Your product key is invalid");
                Hide();
            }
        }

      
    }
}
