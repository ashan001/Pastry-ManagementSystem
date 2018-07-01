namespace AdminObjectsHide.View
{
    partial class Generate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbLicenseType = new MetroFramework.Controls.MetroComboBox();
            this.txtDays = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtProductKey = new MetroFramework.Controls.MetroTextBox();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtProductID = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(74, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "License Type";
            // 
            // cmbLicenseType
            // 
            this.cmbLicenseType.DropDownHeight = 100;
            this.cmbLicenseType.FormattingEnabled = true;
            this.cmbLicenseType.IntegralHeight = false;
            this.cmbLicenseType.ItemHeight = 23;
            this.cmbLicenseType.Items.AddRange(new object[] {
            "Full",
            "Trail"});
            this.cmbLicenseType.Location = new System.Drawing.Point(225, 105);
            this.cmbLicenseType.MaximumSize = new System.Drawing.Size(270, 0);
            this.cmbLicenseType.MinimumSize = new System.Drawing.Size(271, 0);
            this.cmbLicenseType.Name = "cmbLicenseType";
            this.cmbLicenseType.Size = new System.Drawing.Size(271, 29);
            this.cmbLicenseType.TabIndex = 3;
            this.cmbLicenseType.UseSelectable = true;
            this.cmbLicenseType.SelectedIndexChanged += new System.EventHandler(this.cmbLicenseType_SelectedIndexChanged);
            // 
            // txtDays
            // 
            // 
            // 
            // 
            this.txtDays.CustomButton.Image = null;
            this.txtDays.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtDays.CustomButton.Name = "";
            this.txtDays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDays.CustomButton.TabIndex = 1;
            this.txtDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDays.CustomButton.UseSelectable = true;
            this.txtDays.CustomButton.Visible = false;
            this.txtDays.Lines = new string[0];
            this.txtDays.Location = new System.Drawing.Point(225, 140);
            this.txtDays.MaxLength = 32767;
            this.txtDays.Name = "txtDays";
            this.txtDays.PasswordChar = '\0';
            this.txtDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDays.SelectedText = "";
            this.txtDays.SelectionLength = 0;
            this.txtDays.SelectionStart = 0;
            this.txtDays.ShortcutsEnabled = true;
            this.txtDays.Size = new System.Drawing.Size(201, 23);
            this.txtDays.TabIndex = 1;
            this.txtDays.UseSelectable = true;
            this.txtDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Experience Days";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(66, 169);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Product Key";
            // 
            // txtProductKey
            // 
            // 
            // 
            // 
            this.txtProductKey.CustomButton.Image = null;
            this.txtProductKey.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.txtProductKey.CustomButton.Name = "";
            this.txtProductKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductKey.CustomButton.TabIndex = 1;
            this.txtProductKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductKey.CustomButton.UseSelectable = true;
            this.txtProductKey.CustomButton.Visible = false;
            this.txtProductKey.Lines = new string[0];
            this.txtProductKey.Location = new System.Drawing.Point(225, 169);
            this.txtProductKey.MaxLength = 32767;
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.PasswordChar = '\0';
            this.txtProductKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductKey.SelectedText = "";
            this.txtProductKey.SelectionLength = 0;
            this.txtProductKey.SelectionStart = 0;
            this.txtProductKey.ShortcutsEnabled = true;
            this.txtProductKey.Size = new System.Drawing.Size(521, 23);
            this.txtProductKey.TabIndex = 1;
            this.txtProductKey.UseSelectable = true;
            this.txtProductKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(655, 200);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(91, 34);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.CustomButton.Image = null;
            this.txtProductID.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.txtProductID.CustomButton.Name = "";
            this.txtProductID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductID.CustomButton.TabIndex = 1;
            this.txtProductID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductID.CustomButton.UseSelectable = true;
            this.txtProductID.CustomButton.Visible = false;
            this.txtProductID.Lines = new string[0];
            this.txtProductID.Location = new System.Drawing.Point(225, 75);
            this.txtProductID.MaxLength = 32767;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductID.SelectedText = "";
            this.txtProductID.SelectionLength = 0;
            this.txtProductID.SelectionStart = 0;
            this.txtProductID.ShortcutsEnabled = true;
            this.txtProductID.Size = new System.Drawing.Size(521, 23);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.UseSelectable = true;
            this.txtProductID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Generate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbLicenseType);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generate";
            this.Text = "Generate Key";
            this.Load += new System.EventHandler(this.Generate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbLicenseType;
        private MetroFramework.Controls.MetroTextBox txtDays;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtProductKey;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtProductID;
    }
}