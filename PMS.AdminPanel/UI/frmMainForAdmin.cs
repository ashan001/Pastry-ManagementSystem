using System;
using PMS.AdminPanel.ExtraClasses;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessageBoxControlCenter.MessageBoxes;

namespace PMS.AdminPanel.UI
{
    public partial class frmMainForAdmin :Form
    {
        private delegate void viewSubForms(Form frmSub, object sender);

        public frmMainForAdmin()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MsgBox.Question("Are you sure,Do you want to Exit?") == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void createLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.Admin.CreateLogin(),sender);              
            }
            catch
            {
                throw;
            }
        }
        #region Common funtions

        private void ViewChildForm(Form frmObj, object sender)
        {
            try
            {
                ViewChildForm(frmObj, false, sender);
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }


        private void ViewChildForm(Form frmObj, bool isMax, object sender)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    viewSubForms vsf = new viewSubForms(ViewChildForm);
                    this.Invoke(vsf, new object[] { frmObj, isMax, sender });
                }
                else
                {
                    Form objFrm = frmObj;
                    ApplicationSettings.ChildFormView(this, ref objFrm, isMax);
                    objFrm.Show();                  
                    LayoutMdi(MdiLayout.Cascade);
                   

                }
            }
            catch (Exception ex)
            {
                MsgBox.Exception(ex);
            }
        }
        #endregion

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.User.frmChangePassword(), sender);
            }
            catch
            {
                throw;
            }
        }

        private void createEmployeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.ReportingModule.Reports.EmployeeRep_UI(),sender);
            }
            catch
            {
                throw;
            }
        }
        private void createCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.ReportingModule.Reports.CustomerRep_UI(), sender);
            }
            catch
            {
                throw;
            }
        }

        private void inventoryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.Inventory.InvMaster.InventoryMaster(), sender);
            }
            catch
            {
                throw;
            }
        }

        private void employeeIDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.Admin.ViewEmployeeID(),sender);
            }
            catch
            {
                throw;
            }
        }

        private void saveWarehouseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.Admin.Add_Warehouse_Info(),sender);
            }
            catch
            {
                throw;
            }
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewChildForm(new PMS.AdminPanel.UI.ReportingModule.Reports.StockTransactionReport(),sender);
            }
            catch
            {
                throw;
            }
        }

        private void customerServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewChildForm(new PMS.AdminPanel.UI.ReportingModule.PrintUI.CustomerService(),sender);
        }
    }
}
