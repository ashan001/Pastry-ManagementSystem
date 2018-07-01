namespace Pastry_ManagementSystem.UI
{
    partial class purchase_order_screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchase_order_screen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btn_proceed = new MetroFramework.Controls.MetroButton();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.warehouseCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.itemIDSearch = new System.Windows.Forms.Panel();
            this.txt_price = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.lbl_qty = new MetroFramework.Controls.MetroLabel();
            this.txt_itemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_itemID = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cmpAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_suppID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_Lname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_Fname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchPO = new System.Windows.Forms.Panel();
            this.txt_date = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_suppcmpName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_purID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sysTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_sysDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_receiptNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btn_back);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btn_proceed);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.groupBox4);
            this.metroPanel1.Controls.Add(this.groupBox3);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1246, 558);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(190, 503);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 34);
            this.btn_back.TabIndex = 85;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(100, 503);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 84;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_proceed.BackgroundImage")));
            this.btn_proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed.Enabled = false;
            this.btn_proceed.Location = new System.Drawing.Point(8, 503);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 34);
            this.btn_proceed.TabIndex = 83;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseSelectable = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(7, 10);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(205, 25);
            this.lbl_welcome.TabIndex = 81;
            this.lbl_welcome.Text = "Purchase Order Screen";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.warehouseCode);
            this.groupBox4.Controls.Add(this.metroLabel18);
            this.groupBox4.Controls.Add(this.itemIDSearch);
            this.groupBox4.Controls.Add(this.txt_price);
            this.groupBox4.Controls.Add(this.metroLabel19);
            this.groupBox4.Controls.Add(this.txt_qty);
            this.groupBox4.Controls.Add(this.lbl_qty);
            this.groupBox4.Controls.Add(this.txt_itemName);
            this.groupBox4.Controls.Add(this.metroLabel17);
            this.groupBox4.Controls.Add(this.metroLabel16);
            this.groupBox4.Controls.Add(this.metroLabel15);
            this.groupBox4.Controls.Add(this.txt_itemID);
            this.groupBox4.Location = new System.Drawing.Point(8, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1220, 107);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(979, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 25);
            this.btnSearch.TabIndex = 83;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // warehouseCode
            // 
            // 
            // 
            // 
            this.warehouseCode.CustomButton.Image = null;
            this.warehouseCode.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.warehouseCode.CustomButton.Name = "";
            this.warehouseCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.warehouseCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.warehouseCode.CustomButton.TabIndex = 1;
            this.warehouseCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.warehouseCode.CustomButton.UseSelectable = true;
            this.warehouseCode.CustomButton.Visible = false;
            this.warehouseCode.DisplayIcon = true;
            this.warehouseCode.Icon = ((System.Drawing.Image)(resources.GetObject("warehouseCode.Icon")));
            this.warehouseCode.IconRight = true;
            this.warehouseCode.Lines = new string[0];
            this.warehouseCode.Location = new System.Drawing.Point(842, 53);
            this.warehouseCode.MaxLength = 32767;
            this.warehouseCode.Name = "warehouseCode";
            this.warehouseCode.PasswordChar = '\0';
            this.warehouseCode.PromptText = "Warehouse Code";
            this.warehouseCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.warehouseCode.SelectedText = "";
            this.warehouseCode.SelectionLength = 0;
            this.warehouseCode.SelectionStart = 0;
            this.warehouseCode.ShortcutsEnabled = true;
            this.warehouseCode.Size = new System.Drawing.Size(171, 25);
            this.warehouseCode.TabIndex = 82;
            this.warehouseCode.UseCustomBackColor = true;
            this.warehouseCode.UseCustomForeColor = true;
            this.warehouseCode.UseSelectable = true;
            this.warehouseCode.UseStyleColors = true;
            this.warehouseCode.WaterMark = "Warehouse Code";
            this.warehouseCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.warehouseCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.warehouseCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.warehouseCode_KeyDown);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(762, 55);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(74, 19);
            this.metroLabel18.TabIndex = 81;
            this.metroLabel18.Text = "Warehouse";
            // 
            // itemIDSearch
            // 
            this.itemIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemIDSearch.BackgroundImage")));
            this.itemIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itemIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemIDSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemIDSearch.Location = new System.Drawing.Point(182, 51);
            this.itemIDSearch.Name = "itemIDSearch";
            this.itemIDSearch.Size = new System.Drawing.Size(33, 23);
            this.itemIDSearch.TabIndex = 49;
            this.itemIDSearch.Click += new System.EventHandler(this.itemIDSearch_Click);
            // 
            // txt_price
            // 
            // 
            // 
            // 
            this.txt_price.CustomButton.Image = null;
            this.txt_price.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txt_price.CustomButton.Name = "";
            this.txt_price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price.CustomButton.TabIndex = 1;
            this.txt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price.CustomButton.UseSelectable = true;
            this.txt_price.CustomButton.Visible = false;
            this.txt_price.Enabled = false;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(634, 53);
            this.txt_price.MaxLength = 32767;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.ShortcutsEnabled = true;
            this.txt_price.Size = new System.Drawing.Size(122, 23);
            this.txt_price.TabIndex = 80;
            this.txt_price.UseSelectable = true;
            this.txt_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(510, 54);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(118, 19);
            this.metroLabel19.TabIndex = 79;
            this.metroLabel19.Text = "Item Price per one";
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(1109, 55);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(97, 23);
            this.txt_qty.TabIndex = 78;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.Visible = false;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_qty.Location = new System.Drawing.Point(1019, 55);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(66, 19);
            this.lbl_qty.TabIndex = 77;
            this.lbl_qty.Text = "Quantity";
            this.lbl_qty.Visible = false;
            // 
            // txt_itemName
            // 
            // 
            // 
            // 
            this.txt_itemName.CustomButton.Image = null;
            this.txt_itemName.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txt_itemName.CustomButton.Name = "";
            this.txt_itemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemName.CustomButton.TabIndex = 1;
            this.txt_itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemName.CustomButton.UseSelectable = true;
            this.txt_itemName.CustomButton.Visible = false;
            this.txt_itemName.Enabled = false;
            this.txt_itemName.Lines = new string[0];
            this.txt_itemName.Location = new System.Drawing.Point(296, 50);
            this.txt_itemName.MaxLength = 32767;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.SelectionLength = 0;
            this.txt_itemName.SelectionStart = 0;
            this.txt_itemName.ShortcutsEnabled = true;
            this.txt_itemName.Size = new System.Drawing.Size(209, 23);
            this.txt_itemName.TabIndex = 76;
            this.txt_itemName.UseSelectable = true;
            this.txt_itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(218, 52);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(75, 19);
            this.metroLabel17.TabIndex = 75;
            this.metroLabel17.Text = "Item Name";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(10, 52);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(51, 19);
            this.metroLabel16.TabIndex = 74;
            this.metroLabel16.Text = "Item ID";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(10, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(88, 19);
            this.metroLabel15.TabIndex = 73;
            this.metroLabel15.Text = "Item Details";
            // 
            // txt_itemID
            // 
            // 
            // 
            // 
            this.txt_itemID.CustomButton.Image = null;
            this.txt_itemID.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txt_itemID.CustomButton.Name = "";
            this.txt_itemID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemID.CustomButton.TabIndex = 1;
            this.txt_itemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemID.CustomButton.UseSelectable = true;
            this.txt_itemID.CustomButton.Visible = false;
            this.txt_itemID.Enabled = false;
            this.txt_itemID.Lines = new string[0];
            this.txt_itemID.Location = new System.Drawing.Point(67, 51);
            this.txt_itemID.MaxLength = 32767;
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.PasswordChar = '\0';
            this.txt_itemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemID.SelectedText = "";
            this.txt_itemID.SelectionLength = 0;
            this.txt_itemID.SelectionStart = 0;
            this.txt_itemID.ShortcutsEnabled = true;
            this.txt_itemID.Size = new System.Drawing.Size(145, 23);
            this.txt_itemID.TabIndex = 0;
            this.txt_itemID.UseSelectable = true;
            this.txt_itemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemID.TextChanged += new System.EventHandler(this.txt_itemID_TextChanged);
            this.txt_itemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemID_KeyDown);
            this.txt_itemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemID_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cmpAddress);
            this.groupBox3.Controls.Add(this.metroLabel14);
            this.groupBox3.Controls.Add(this.txt_suppID);
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.txt_Lname);
            this.groupBox3.Controls.Add(this.metroLabel12);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.txt_Fname);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(7, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1220, 154);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txt_cmpAddress
            // 
            // 
            // 
            // 
            this.txt_cmpAddress.CustomButton.Image = null;
            this.txt_cmpAddress.CustomButton.Location = new System.Drawing.Point(427, 1);
            this.txt_cmpAddress.CustomButton.Name = "";
            this.txt_cmpAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cmpAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cmpAddress.CustomButton.TabIndex = 1;
            this.txt_cmpAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cmpAddress.CustomButton.UseSelectable = true;
            this.txt_cmpAddress.CustomButton.Visible = false;
            this.txt_cmpAddress.Lines = new string[0];
            this.txt_cmpAddress.Location = new System.Drawing.Point(758, 47);
            this.txt_cmpAddress.MaxLength = 32767;
            this.txt_cmpAddress.Name = "txt_cmpAddress";
            this.txt_cmpAddress.PasswordChar = '\0';
            this.txt_cmpAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cmpAddress.SelectedText = "";
            this.txt_cmpAddress.SelectionLength = 0;
            this.txt_cmpAddress.SelectionStart = 0;
            this.txt_cmpAddress.ShortcutsEnabled = true;
            this.txt_cmpAddress.Size = new System.Drawing.Size(449, 23);
            this.txt_cmpAddress.TabIndex = 75;
            this.txt_cmpAddress.UseSelectable = true;
            this.txt_cmpAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cmpAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(635, 47);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(117, 19);
            this.metroLabel14.TabIndex = 74;
            this.metroLabel14.Text = "Company Address";
            // 
            // txt_suppID
            // 
            // 
            // 
            // 
            this.txt_suppID.CustomButton.Image = null;
            this.txt_suppID.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.txt_suppID.CustomButton.Name = "";
            this.txt_suppID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_suppID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_suppID.CustomButton.TabIndex = 1;
            this.txt_suppID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_suppID.CustomButton.UseSelectable = true;
            this.txt_suppID.CustomButton.Visible = false;
            this.txt_suppID.Lines = new string[0];
            this.txt_suppID.Location = new System.Drawing.Point(758, 93);
            this.txt_suppID.MaxLength = 32767;
            this.txt_suppID.Name = "txt_suppID";
            this.txt_suppID.PasswordChar = '\0';
            this.txt_suppID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_suppID.SelectedText = "";
            this.txt_suppID.SelectionLength = 0;
            this.txt_suppID.SelectionStart = 0;
            this.txt_suppID.ShortcutsEnabled = true;
            this.txt_suppID.Size = new System.Drawing.Size(320, 23);
            this.txt_suppID.TabIndex = 73;
            this.txt_suppID.UseSelectable = true;
            this.txt_suppID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_suppID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(635, 93);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(73, 19);
            this.metroLabel13.TabIndex = 72;
            this.metroLabel13.Text = "Supplier ID";
            // 
            // txt_Lname
            // 
            // 
            // 
            // 
            this.txt_Lname.CustomButton.Image = null;
            this.txt_Lname.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txt_Lname.CustomButton.Name = "";
            this.txt_Lname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Lname.CustomButton.TabIndex = 1;
            this.txt_Lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Lname.CustomButton.UseSelectable = true;
            this.txt_Lname.CustomButton.Visible = false;
            this.txt_Lname.Lines = new string[0];
            this.txt_Lname.Location = new System.Drawing.Point(297, 93);
            this.txt_Lname.MaxLength = 32767;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.PasswordChar = '\0';
            this.txt_Lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Lname.SelectedText = "";
            this.txt_Lname.SelectionLength = 0;
            this.txt_Lname.SelectionStart = 0;
            this.txt_Lname.ShortcutsEnabled = true;
            this.txt_Lname.Size = new System.Drawing.Size(258, 23);
            this.txt_Lname.TabIndex = 71;
            this.txt_Lname.UseSelectable = true;
            this.txt_Lname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Lname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(149, 93);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(78, 19);
            this.metroLabel12.TabIndex = 70;
            this.metroLabel12.Text = ": Last Name";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(147, 47);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(80, 19);
            this.metroLabel11.TabIndex = 69;
            this.metroLabel11.Text = ": First Name";
            // 
            // txt_Fname
            // 
            // 
            // 
            // 
            this.txt_Fname.CustomButton.Image = null;
            this.txt_Fname.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txt_Fname.CustomButton.Name = "";
            this.txt_Fname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Fname.CustomButton.TabIndex = 1;
            this.txt_Fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Fname.CustomButton.UseSelectable = true;
            this.txt_Fname.CustomButton.Visible = false;
            this.txt_Fname.Lines = new string[0];
            this.txt_Fname.Location = new System.Drawing.Point(297, 47);
            this.txt_Fname.MaxLength = 32767;
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.PasswordChar = '\0';
            this.txt_Fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Fname.SelectedText = "";
            this.txt_Fname.SelectionLength = 0;
            this.txt_Fname.SelectionStart = 0;
            this.txt_Fname.ShortcutsEnabled = true;
            this.txt_Fname.Size = new System.Drawing.Size(258, 23);
            this.txt_Fname.TabIndex = 68;
            this.txt_Fname.UseSelectable = true;
            this.txt_Fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(31, 47);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(97, 19);
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "Supplier Name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(10, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(141, 19);
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "Purchase Order To :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchPO);
            this.groupBox2.Controls.Add(this.txt_date);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txt_suppcmpName);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txt_purID);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(7, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // searchPO
            // 
            this.searchPO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPO.BackgroundImage")));
            this.searchPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPO.Location = new System.Drawing.Point(359, 36);
            this.searchPO.Name = "searchPO";
            this.searchPO.Size = new System.Drawing.Size(33, 23);
            this.searchPO.TabIndex = 71;
            this.searchPO.Click += new System.EventHandler(this.searchPO_Click);
            // 
            // txt_date
            // 
            // 
            // 
            // 
            this.txt_date.CustomButton.Image = null;
            this.txt_date.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txt_date.CustomButton.Name = "";
            this.txt_date.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_date.CustomButton.TabIndex = 1;
            this.txt_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_date.CustomButton.UseSelectable = true;
            this.txt_date.CustomButton.Visible = false;
            this.txt_date.Enabled = false;
            this.txt_date.Lines = new string[0];
            this.txt_date.Location = new System.Drawing.Point(999, 36);
            this.txt_date.MaxLength = 32767;
            this.txt_date.Name = "txt_date";
            this.txt_date.PasswordChar = '\0';
            this.txt_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_date.SelectedText = "";
            this.txt_date.SelectionLength = 0;
            this.txt_date.SelectionStart = 0;
            this.txt_date.ShortcutsEnabled = true;
            this.txt_date.Size = new System.Drawing.Size(208, 23);
            this.txt_date.TabIndex = 69;
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_date.UseSelectable = true;
            this.txt_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(893, 36);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(91, 19);
            this.metroLabel7.TabIndex = 69;
            this.metroLabel7.Text = "Ordered Date";
            // 
            // txt_suppcmpName
            // 
            // 
            // 
            // 
            this.txt_suppcmpName.CustomButton.Image = null;
            this.txt_suppcmpName.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txt_suppcmpName.CustomButton.Name = "";
            this.txt_suppcmpName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_suppcmpName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_suppcmpName.CustomButton.TabIndex = 1;
            this.txt_suppcmpName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_suppcmpName.CustomButton.UseSelectable = true;
            this.txt_suppcmpName.CustomButton.Visible = false;
            this.txt_suppcmpName.Enabled = false;
            this.txt_suppcmpName.Lines = new string[0];
            this.txt_suppcmpName.Location = new System.Drawing.Point(579, 36);
            this.txt_suppcmpName.MaxLength = 32767;
            this.txt_suppcmpName.Name = "txt_suppcmpName";
            this.txt_suppcmpName.PasswordChar = '\0';
            this.txt_suppcmpName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_suppcmpName.SelectedText = "";
            this.txt_suppcmpName.SelectionLength = 0;
            this.txt_suppcmpName.SelectionStart = 0;
            this.txt_suppcmpName.ShortcutsEnabled = true;
            this.txt_suppcmpName.Size = new System.Drawing.Size(292, 23);
            this.txt_suppcmpName.TabIndex = 69;
            this.txt_suppcmpName.UseSelectable = true;
            this.txt_suppcmpName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_suppcmpName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_suppcmpName.TextChanged += new System.EventHandler(this.txt_suppcmpName_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(404, 36);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(158, 19);
            this.metroLabel6.TabIndex = 68;
            this.metroLabel6.Text = "Supplier Company Name";
            // 
            // txt_purID
            // 
            // 
            // 
            // 
            this.txt_purID.CustomButton.Image = null;
            this.txt_purID.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_purID.CustomButton.Name = "";
            this.txt_purID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_purID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_purID.CustomButton.TabIndex = 1;
            this.txt_purID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_purID.CustomButton.UseSelectable = true;
            this.txt_purID.CustomButton.Visible = false;
            this.txt_purID.Lines = new string[0];
            this.txt_purID.Location = new System.Drawing.Point(191, 36);
            this.txt_purID.MaxLength = 32767;
            this.txt_purID.Name = "txt_purID";
            this.txt_purID.PasswordChar = '\0';
            this.txt_purID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_purID.SelectedText = "";
            this.txt_purID.SelectionLength = 0;
            this.txt_purID.SelectionStart = 0;
            this.txt_purID.ShortcutsEnabled = true;
            this.txt_purID.Size = new System.Drawing.Size(200, 23);
            this.txt_purID.TabIndex = 0;
            this.txt_purID.UseSelectable = true;
            this.txt_purID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_purID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_purID.TextChanged += new System.EventHandler(this.txt_purID_TextChanged);
            this.txt_purID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_purID_KeyDown);
            this.txt_purID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_purID_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 36);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Purchase ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(10, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Purchase Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_sysTime);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_sysDate);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txt_receiptNum);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(7, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_sysTime
            // 
            // 
            // 
            // 
            this.txt_sysTime.CustomButton.Image = null;
            this.txt_sysTime.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txt_sysTime.CustomButton.Name = "";
            this.txt_sysTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_sysTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sysTime.CustomButton.TabIndex = 1;
            this.txt_sysTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sysTime.CustomButton.UseSelectable = true;
            this.txt_sysTime.CustomButton.Visible = false;
            this.txt_sysTime.Lines = new string[0];
            this.txt_sysTime.Location = new System.Drawing.Point(999, 39);
            this.txt_sysTime.MaxLength = 32767;
            this.txt_sysTime.Name = "txt_sysTime";
            this.txt_sysTime.PasswordChar = '\0';
            this.txt_sysTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sysTime.SelectedText = "";
            this.txt_sysTime.SelectionLength = 0;
            this.txt_sysTime.SelectionStart = 0;
            this.txt_sysTime.ShortcutsEnabled = true;
            this.txt_sysTime.Size = new System.Drawing.Size(208, 23);
            this.txt_sysTime.TabIndex = 70;
            this.txt_sysTime.UseSelectable = true;
            this.txt_sysTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sysTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(912, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 69;
            this.metroLabel3.Text = "Time";
            // 
            // txt_sysDate
            // 
            // 
            // 
            // 
            this.txt_sysDate.CustomButton.Image = null;
            this.txt_sysDate.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txt_sysDate.CustomButton.Name = "";
            this.txt_sysDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_sysDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_sysDate.CustomButton.TabIndex = 1;
            this.txt_sysDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_sysDate.CustomButton.UseSelectable = true;
            this.txt_sysDate.CustomButton.Visible = false;
            this.txt_sysDate.Lines = new string[0];
            this.txt_sysDate.Location = new System.Drawing.Point(644, 39);
            this.txt_sysDate.MaxLength = 32767;
            this.txt_sysDate.Name = "txt_sysDate";
            this.txt_sysDate.PasswordChar = '\0';
            this.txt_sysDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_sysDate.SelectedText = "";
            this.txt_sysDate.SelectionLength = 0;
            this.txt_sysDate.SelectionStart = 0;
            this.txt_sysDate.ShortcutsEnabled = true;
            this.txt_sysDate.Size = new System.Drawing.Size(227, 23);
            this.txt_sysDate.TabIndex = 68;
            this.txt_sysDate.UseSelectable = true;
            this.txt_sysDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_sysDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(552, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "Date";
            // 
            // txt_receiptNum
            // 
            // 
            // 
            // 
            this.txt_receiptNum.CustomButton.Image = null;
            this.txt_receiptNum.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txt_receiptNum.CustomButton.Name = "";
            this.txt_receiptNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_receiptNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_receiptNum.CustomButton.TabIndex = 1;
            this.txt_receiptNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_receiptNum.CustomButton.UseSelectable = true;
            this.txt_receiptNum.CustomButton.Visible = false;
            this.txt_receiptNum.Lines = new string[0];
            this.txt_receiptNum.Location = new System.Drawing.Point(191, 39);
            this.txt_receiptNum.MaxLength = 32767;
            this.txt_receiptNum.Name = "txt_receiptNum";
            this.txt_receiptNum.PasswordChar = '\0';
            this.txt_receiptNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_receiptNum.SelectedText = "";
            this.txt_receiptNum.SelectionLength = 0;
            this.txt_receiptNum.SelectionStart = 0;
            this.txt_receiptNum.ShortcutsEnabled = true;
            this.txt_receiptNum.Size = new System.Drawing.Size(292, 23);
            this.txt_receiptNum.TabIndex = 66;
            this.txt_receiptNum.UseSelectable = true;
            this.txt_receiptNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_receiptNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_receiptNum.TextChanged += new System.EventHandler(this.txt_receiptNum_TextChanged);
            this.txt_receiptNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_receiptNum_KeyDown);
            this.txt_receiptNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_receiptNum_KeyPress);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(28, 39);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(105, 19);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "Receipt Number";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(10, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Receipt Details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // purchase_order_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 571);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "purchase_order_screen";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.purchase_order_screen_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_sysTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_sysDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txt_date;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_suppcmpName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_purID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        public MetroFramework.Controls.MetroTextBox txt_itemID;
        private System.Windows.Forms.GroupBox groupBox4;
        public MetroFramework.Controls.MetroTextBox txt_itemName;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        public MetroFramework.Controls.MetroTextBox txt_price;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        public MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroLabel lbl_qty;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btn_proceed;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox txt_receiptNum;
        public MetroFramework.Controls.MetroTextBox txt_suppID;
        public MetroFramework.Controls.MetroTextBox txt_Lname;
        public MetroFramework.Controls.MetroTextBox txt_Fname;
        public MetroFramework.Controls.MetroTextBox txt_cmpAddress;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.Panel searchPO;
        private System.Windows.Forms.Panel itemIDSearch;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox warehouseCode;
        private System.Windows.Forms.Panel btnSearch;
    }
}