namespace Pastry_ManagementSystem.UI
{
    partial class IssueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ItemPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtItemDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtItemCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtWarehouseCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 373);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Location = new System.Drawing.Point(10, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1195, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(240, 19);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(194, 23);
            this.txtQty.TabIndex = 0;
            this.txtQty.UseSelectable = true;
            this.txtQty.Visible = false;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisplayFocus = true;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(1017, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisplayFocus = true;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Highlight = true;
            this.btnSubmit.Location = new System.Drawing.Point(1098, 14);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 39);
            this.btnSubmit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(59, 20);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Item Quantity";
            this.metroLabel7.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ItemPrice);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txtItemDescription);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.txtItemCode);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Information";
            // 
            // ItemPrice
            // 
            // 
            // 
            // 
            this.ItemPrice.CustomButton.Image = null;
            this.ItemPrice.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.ItemPrice.CustomButton.Name = "";
            this.ItemPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ItemPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ItemPrice.CustomButton.TabIndex = 1;
            this.ItemPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ItemPrice.CustomButton.UseSelectable = true;
            this.ItemPrice.CustomButton.Visible = false;
            this.ItemPrice.Lines = new string[0];
            this.ItemPrice.Location = new System.Drawing.Point(240, 212);
            this.ItemPrice.MaxLength = 32767;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.PasswordChar = '\0';
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemPrice.SelectedText = "";
            this.ItemPrice.SelectionLength = 0;
            this.ItemPrice.SelectionStart = 0;
            this.ItemPrice.ShortcutsEnabled = true;
            this.ItemPrice.Size = new System.Drawing.Size(260, 23);
            this.ItemPrice.TabIndex = 7;
            this.ItemPrice.UseSelectable = true;
            this.ItemPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ItemPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(87, 212);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Item Price";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(538, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(240, 61);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ReadOnly = true;
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(331, 23);
            this.txtItemName.TabIndex = 9;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(80, 61);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Item Name";
            // 
            // txtItemDescription
            // 
            // 
            // 
            // 
            this.txtItemDescription.CustomButton.Image = null;
            this.txtItemDescription.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.txtItemDescription.CustomButton.Name = "";
            this.txtItemDescription.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtItemDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemDescription.CustomButton.TabIndex = 1;
            this.txtItemDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemDescription.CustomButton.UseSelectable = true;
            this.txtItemDescription.CustomButton.Visible = false;
            this.txtItemDescription.Lines = new string[0];
            this.txtItemDescription.Location = new System.Drawing.Point(240, 99);
            this.txtItemDescription.MaxLength = 32767;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.PasswordChar = '\0';
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemDescription.SelectedText = "";
            this.txtItemDescription.SelectionLength = 0;
            this.txtItemDescription.SelectionStart = 0;
            this.txtItemDescription.ShortcutsEnabled = true;
            this.txtItemDescription.Size = new System.Drawing.Size(331, 100);
            this.txtItemDescription.TabIndex = 7;
            this.txtItemDescription.UseSelectable = true;
            this.txtItemDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(51, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(104, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Item Description";
            // 
            // txtItemCode
            // 
            // 
            // 
            // 
            this.txtItemCode.CustomButton.Image = null;
            this.txtItemCode.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtItemCode.CustomButton.Name = "";
            this.txtItemCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemCode.CustomButton.TabIndex = 1;
            this.txtItemCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemCode.CustomButton.UseSelectable = true;
            this.txtItemCode.CustomButton.Visible = false;
            this.txtItemCode.Lines = new string[0];
            this.txtItemCode.Location = new System.Drawing.Point(240, 23);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PromptText = "Enter Item Code";
            this.txtItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.SelectionLength = 0;
            this.txtItemCode.SelectionStart = 0;
            this.txtItemCode.ShortcutsEnabled = true;
            this.txtItemCode.Size = new System.Drawing.Size(331, 23);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.UseSelectable = true;
            this.txtItemCode.WaterMark = "Enter Item Code";
            this.txtItemCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(84, 23);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Item Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtWarehouseCode);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(613, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warehouse Information";
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.CustomButton.Image = null;
            this.txtStatus.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtStatus.CustomButton.Name = "";
            this.txtStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus.CustomButton.TabIndex = 1;
            this.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus.CustomButton.UseSelectable = true;
            this.txtStatus.CustomButton.Visible = false;
            this.txtStatus.Lines = new string[0];
            this.txtStatus.Location = new System.Drawing.Point(245, 205);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.ShortcutsEnabled = true;
            this.txtStatus.Size = new System.Drawing.Size(331, 23);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.UseSelectable = true;
            this.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Warehouse Status";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(245, 58);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(331, 120);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Warehouse Description";
            // 
            // txtWarehouseCode
            // 
            // 
            // 
            // 
            this.txtWarehouseCode.CustomButton.Image = null;
            this.txtWarehouseCode.CustomButton.Location = new System.Drawing.Point(309, 1);
            this.txtWarehouseCode.CustomButton.Name = "";
            this.txtWarehouseCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWarehouseCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWarehouseCode.CustomButton.TabIndex = 1;
            this.txtWarehouseCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWarehouseCode.CustomButton.UseSelectable = true;
            this.txtWarehouseCode.CustomButton.Visible = false;
            this.txtWarehouseCode.Lines = new string[0];
            this.txtWarehouseCode.Location = new System.Drawing.Point(245, 19);
            this.txtWarehouseCode.MaxLength = 32767;
            this.txtWarehouseCode.Name = "txtWarehouseCode";
            this.txtWarehouseCode.PasswordChar = '\0';
            this.txtWarehouseCode.ReadOnly = true;
            this.txtWarehouseCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWarehouseCode.SelectedText = "";
            this.txtWarehouseCode.SelectionLength = 0;
            this.txtWarehouseCode.SelectionStart = 0;
            this.txtWarehouseCode.ShortcutsEnabled = true;
            this.txtWarehouseCode.Size = new System.Drawing.Size(331, 23);
            this.txtWarehouseCode.TabIndex = 0;
            this.txtWarehouseCode.UseSelectable = true;
            this.txtWarehouseCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWarehouseCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtWarehouseCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWarehouseCode_KeyDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Warehouse Code";
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1213, 402);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssueForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Stock Issue Form";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtWarehouseCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtItemDescription;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtItemCode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox ItemPrice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtQty;
    }
}