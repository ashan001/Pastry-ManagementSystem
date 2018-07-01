using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMS.AdminPanel.ExtraClasses
{
    public class ApplicationSettings
    {
        public static void ChildFormView(Form form, ref Form frmObj, bool isMax)
        {
            try
            {
                //frmObj.Text = getFormattedText(frmObj.Text);
                frmObj.ShowIcon = false;
                frmObj.StartPosition = FormStartPosition.CenterParent;
                frmObj.MdiParent = form;

                if (isMax)
                {
                    frmObj.WindowState = FormWindowState.Maximized;
                }

                if (frmObj.WindowState != FormWindowState.Maximized)
                {
                    frmObj.MaximizeBox = isMax;
                    frmObj.MaximumSize = new Size(frmObj.Width, frmObj.Height);
                    frmObj.FormBorderStyle = FormBorderStyle.FixedDialog;
                }
                frmObj.ShowInTaskbar = false;
                //new ApplicationSettings().ClearFormControles(frmObj);
            }


            catch (Exception)
            {

                throw;
            }
        }
    }
}
