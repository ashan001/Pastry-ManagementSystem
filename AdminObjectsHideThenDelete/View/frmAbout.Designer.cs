namespace AdminObjectsHide.View
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MetroFramework.Controls.MetroButton btnOK;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblProductID = new MetroFramework.Controls.MetroLabel();
            this.lblProductKey = new MetroFramework.Controls.MetroLabel();
            this.lblLicenseType = new MetroFramework.Controls.MetroLabel();
            btnOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(277, 197);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(105, 40);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseSelectable = true;
            btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Product Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Product ID :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(55, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Product Key :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(53, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "License Type :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(148, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "?";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(148, 96);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(15, 19);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "?";
            // 
            // lblProductKey
            // 
            this.lblProductKey.AutoSize = true;
            this.lblProductKey.Location = new System.Drawing.Point(147, 126);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(15, 19);
            this.lblProductKey.TabIndex = 2;
            this.lblProductKey.Text = "?";
            // 
            // lblLicenseType
            // 
            this.lblLicenseType.AutoSize = true;
            this.lblLicenseType.Location = new System.Drawing.Point(147, 157);
            this.lblLicenseType.Name = "lblLicenseType";
            this.lblLicenseType.Size = new System.Drawing.Size(15, 19);
            this.lblLicenseType.TabIndex = 2;
            this.lblLicenseType.Text = "?";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 248);
            this.Controls.Add(this.lblLicenseType);
            this.Controls.Add(this.lblProductKey);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblProductID;
        private MetroFramework.Controls.MetroLabel lblProductKey;
        private MetroFramework.Controls.MetroLabel lblLicenseType;
    }
}