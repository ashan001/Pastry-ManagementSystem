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
    public partial class frmSystemEntrance : MetroFramework.Forms.MetroForm
    {
        public frmSystemEntrance()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (AdminObjectsHide.View.Generate obj=new Generate())
            {
                obj.ShowDialog();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (RegisterSys obj=new RegisterSys())
            {
                obj.ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout obj=new frmAbout())
            {
                obj.ShowDialog();
            }
        }
    }
}
