namespace Pastry_ManagementSystem.UI
{
    partial class SearchSupplierMessageBox
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cmpnyName = new MetroFramework.Controls.MetroTextBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.txt_contact = new MetroFramework.Controls.MetroTextBox();
            this.txt_suppID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.blue_gradient_wallpaper_hd_20_color1;
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 24);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1216, 178);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cmpnyName);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.txt_suppID);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_cmpnyName
            // 
            // 
            // 
            // 
            this.txt_cmpnyName.CustomButton.Image = null;
            this.txt_cmpnyName.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_cmpnyName.CustomButton.Name = "";
            this.txt_cmpnyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cmpnyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cmpnyName.CustomButton.TabIndex = 1;
            this.txt_cmpnyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cmpnyName.CustomButton.UseSelectable = true;
            this.txt_cmpnyName.CustomButton.Visible = false;
            this.txt_cmpnyName.Lines = new string[0];
            this.txt_cmpnyName.Location = new System.Drawing.Point(950, 30);
            this.txt_cmpnyName.MaxLength = 32767;
            this.txt_cmpnyName.Name = "txt_cmpnyName";
            this.txt_cmpnyName.PasswordChar = '\0';
            this.txt_cmpnyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cmpnyName.SelectedText = "";
            this.txt_cmpnyName.SelectionLength = 0;
            this.txt_cmpnyName.SelectionStart = 0;
            this.txt_cmpnyName.ShortcutsEnabled = true;
            this.txt_cmpnyName.Size = new System.Drawing.Size(238, 23);
            this.txt_cmpnyName.TabIndex = 7;
            this.txt_cmpnyName.UseSelectable = true;
            this.txt_cmpnyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cmpnyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.search_icon;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(1110, 59);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(78, 40);
            this.btn_search.TabIndex = 16;
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_contact
            // 
            // 
            // 
            // 
            this.txt_contact.CustomButton.Image = null;
            this.txt_contact.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txt_contact.CustomButton.Name = "";
            this.txt_contact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contact.CustomButton.TabIndex = 1;
            this.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contact.CustomButton.UseSelectable = true;
            this.txt_contact.CustomButton.Visible = false;
            this.txt_contact.Lines = new string[0];
            this.txt_contact.Location = new System.Drawing.Point(529, 30);
            this.txt_contact.MaxLength = 32767;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.PasswordChar = '\0';
            this.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contact.SelectedText = "";
            this.txt_contact.SelectionLength = 0;
            this.txt_contact.SelectionStart = 0;
            this.txt_contact.ShortcutsEnabled = true;
            this.txt_contact.Size = new System.Drawing.Size(251, 23);
            this.txt_contact.TabIndex = 6;
            this.txt_contact.UseSelectable = true;
            this.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_suppID
            // 
            // 
            // 
            // 
            this.txt_suppID.CustomButton.Image = null;
            this.txt_suppID.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txt_suppID.CustomButton.Name = "";
            this.txt_suppID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_suppID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_suppID.CustomButton.TabIndex = 1;
            this.txt_suppID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_suppID.CustomButton.UseSelectable = true;
            this.txt_suppID.CustomButton.Visible = false;
            this.txt_suppID.Lines = new string[0];
            this.txt_suppID.Location = new System.Drawing.Point(120, 30);
            this.txt_suppID.MaxLength = 32767;
            this.txt_suppID.Name = "txt_suppID";
            this.txt_suppID.PasswordChar = '\0';
            this.txt_suppID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_suppID.SelectedText = "";
            this.txt_suppID.SelectionLength = 0;
            this.txt_suppID.SelectionStart = 0;
            this.txt_suppID.ShortcutsEnabled = true;
            this.txt_suppID.Size = new System.Drawing.Size(238, 23);
            this.txt_suppID.TabIndex = 5;
            this.txt_suppID.UseSelectable = true;
            this.txt_suppID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_suppID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(786, 30);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(158, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Supplier Company Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(364, 30);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Supplier Contact Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Supplier ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Supplier Information";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(8, 11);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(114, 25);
            this.lbl_welcome.TabIndex = 16;
            this.lbl_welcome.Text = "Information";
            // 
            // SearchSupplierMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 197);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SearchSupplierMessageBox";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_cmpnyName;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroTextBox txt_contact;
        private MetroFramework.Controls.MetroTextBox txt_suppID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
    }
}