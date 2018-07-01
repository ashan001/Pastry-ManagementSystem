namespace Pastry_ManagementSystem.UI
{
    partial class RawMaterialProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawMaterialProcess));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.txt_receiptNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_submit = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.custom_dataGrid1 = new System.Windows.Forms.DataGridView();
            this.cl_index5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.warehouseCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.txt_itemPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.suppCodeSearch = new System.Windows.Forms.Panel();
            this.ItemCodeSearch = new System.Windows.Forms.Panel();
            this.ItemNameSearch = new System.Windows.Forms.Panel();
            this.btnNameSearch = new System.Windows.Forms.Panel();
            this.txt_itemID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_itemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_suppID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_cmpName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.txt_receiptNum);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.btn_cancel);
            this.metroPanel1.Controls.Add(this.btn_submit);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.custom_dataGrid1);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-4, 24);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(925, 563);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(16, -5);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(188, 25);
            this.lbl_welcome.TabIndex = 50;
            this.lbl_welcome.Text = "RawMeterial Process";
            // 
            // txt_receiptNum
            // 
            // 
            // 
            // 
            this.txt_receiptNum.CustomButton.Image = null;
            this.txt_receiptNum.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_receiptNum.CustomButton.Name = "";
            this.txt_receiptNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_receiptNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_receiptNum.CustomButton.TabIndex = 1;
            this.txt_receiptNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_receiptNum.CustomButton.UseSelectable = true;
            this.txt_receiptNum.CustomButton.Visible = false;
            this.txt_receiptNum.Enabled = false;
            this.txt_receiptNum.Lines = new string[0];
            this.txt_receiptNum.Location = new System.Drawing.Point(719, 8);
            this.txt_receiptNum.MaxLength = 32767;
            this.txt_receiptNum.Name = "txt_receiptNum";
            this.txt_receiptNum.PasswordChar = '\0';
            this.txt_receiptNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_receiptNum.SelectedText = "";
            this.txt_receiptNum.SelectionLength = 0;
            this.txt_receiptNum.SelectionStart = 0;
            this.txt_receiptNum.ShortcutsEnabled = true;
            this.txt_receiptNum.Size = new System.Drawing.Size(187, 23);
            this.txt_receiptNum.TabIndex = 46;
            this.txt_receiptNum.UseSelectable = true;
            this.txt_receiptNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_receiptNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(509, 10);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(192, 19);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Generated Receipt Number";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(145, 516);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 36);
            this.btn_cancel.TabIndex = 43;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.Location = new System.Drawing.Point(16, 516);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(104, 36);
            this.btn_submit.TabIndex = 42;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_submit.UseSelectable = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(561, 248);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(345, 253);
            this.metroPanel2.TabIndex = 41;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // custom_dataGrid1
            // 
            this.custom_dataGrid1.AllowUserToAddRows = false;
            this.custom_dataGrid1.AllowUserToOrderColumns = true;
            this.custom_dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custom_dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index5,
            this.cl_index1,
            this.cl_index2,
            this.cl_index3,
            this.cl_index4,
            this.cl_warehouse});
            this.custom_dataGrid1.Location = new System.Drawing.Point(16, 248);
            this.custom_dataGrid1.Name = "custom_dataGrid1";
            this.custom_dataGrid1.Size = new System.Drawing.Size(539, 253);
            this.custom_dataGrid1.TabIndex = 40;
            // 
            // cl_index5
            // 
            this.cl_index5.HeaderText = "Receipt No";
            this.cl_index5.Name = "cl_index5";
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "Item ID";
            this.cl_index1.Name = "cl_index1";
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "ReceivedQuantity";
            this.cl_index2.Name = "cl_index2";
            // 
            // cl_index3
            // 
            this.cl_index3.HeaderText = "Item Price";
            this.cl_index3.Name = "cl_index3";
            // 
            // cl_index4
            // 
            this.cl_index4.HeaderText = "TotalPrice";
            this.cl_index4.Name = "cl_index4";
            // 
            // cl_warehouse
            // 
            this.cl_warehouse.HeaderText = "WarehouseCode";
            this.cl_warehouse.Name = "cl_warehouse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.warehouseCode);
            this.groupBox2.Controls.Add(this.metroLabel18);
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txt_qty);
            this.groupBox2.Controls.Add(this.txt_itemPrice);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Location = new System.Drawing.Point(16, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 69);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(423, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 25);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // warehouseCode
            // 
            // 
            // 
            // 
            this.warehouseCode.CustomButton.Image = null;
            this.warehouseCode.CustomButton.Location = new System.Drawing.Point(160, 1);
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
            this.warehouseCode.Location = new System.Drawing.Point(272, 26);
            this.warehouseCode.MaxLength = 32767;
            this.warehouseCode.Name = "warehouseCode";
            this.warehouseCode.PasswordChar = '\0';
            this.warehouseCode.PromptText = "Warehouse Code";
            this.warehouseCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.warehouseCode.SelectedText = "";
            this.warehouseCode.SelectionLength = 0;
            this.warehouseCode.SelectionStart = 0;
            this.warehouseCode.ShortcutsEnabled = true;
            this.warehouseCode.Size = new System.Drawing.Size(184, 25);
            this.warehouseCode.TabIndex = 85;
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
            this.metroLabel18.Location = new System.Drawing.Point(192, 28);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(74, 19);
            this.metroLabel18.TabIndex = 84;
            this.metroLabel18.Text = "Warehouse";
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(788, 21);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 33);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(691, 21);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 33);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(5, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Item Price";
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(556, 26);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(110, 23);
            this.txt_qty.TabIndex = 38;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            // 
            // txt_itemPrice
            // 
            // 
            // 
            // 
            this.txt_itemPrice.CustomButton.Image = null;
            this.txt_itemPrice.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txt_itemPrice.CustomButton.Name = "";
            this.txt_itemPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemPrice.CustomButton.TabIndex = 1;
            this.txt_itemPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemPrice.CustomButton.UseSelectable = true;
            this.txt_itemPrice.CustomButton.Visible = false;
            this.txt_itemPrice.Enabled = false;
            this.txt_itemPrice.Lines = new string[0];
            this.txt_itemPrice.Location = new System.Drawing.Point(79, 26);
            this.txt_itemPrice.MaxLength = 32767;
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.PasswordChar = '\0';
            this.txt_itemPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemPrice.SelectedText = "";
            this.txt_itemPrice.SelectionLength = 0;
            this.txt_itemPrice.SelectionStart = 0;
            this.txt_itemPrice.ShortcutsEnabled = true;
            this.txt_itemPrice.Size = new System.Drawing.Size(105, 23);
            this.txt_itemPrice.TabIndex = 36;
            this.txt_itemPrice.UseSelectable = true;
            this.txt_itemPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel7.Location = new System.Drawing.Point(474, 26);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.suppCodeSearch);
            this.groupBox1.Controls.Add(this.ItemCodeSearch);
            this.groupBox1.Controls.Add(this.ItemNameSearch);
            this.groupBox1.Controls.Add(this.btnNameSearch);
            this.groupBox1.Controls.Add(this.txt_itemID);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txt_itemName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txt_suppID);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_cmpName);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // suppCodeSearch
            // 
            this.suppCodeSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suppCodeSearch.BackgroundImage")));
            this.suppCodeSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.suppCodeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suppCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppCodeSearch.Location = new System.Drawing.Point(829, 35);
            this.suppCodeSearch.Name = "suppCodeSearch";
            this.suppCodeSearch.Size = new System.Drawing.Size(33, 23);
            this.suppCodeSearch.TabIndex = 54;
            this.suppCodeSearch.Click += new System.EventHandler(this.suppCodeSearch_Click);
            // 
            // ItemCodeSearch
            // 
            this.ItemCodeSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ItemCodeSearch.BackgroundImage")));
            this.ItemCodeSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ItemCodeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemCodeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemCodeSearch.Location = new System.Drawing.Point(423, 75);
            this.ItemCodeSearch.Name = "ItemCodeSearch";
            this.ItemCodeSearch.Size = new System.Drawing.Size(33, 23);
            this.ItemCodeSearch.TabIndex = 53;
            this.ItemCodeSearch.Click += new System.EventHandler(this.ItemCodeSearch_Click);
            // 
            // ItemNameSearch
            // 
            this.ItemNameSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ItemNameSearch.BackgroundImage")));
            this.ItemNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ItemNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemNameSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemNameSearch.Location = new System.Drawing.Point(829, 75);
            this.ItemNameSearch.Name = "ItemNameSearch";
            this.ItemNameSearch.Size = new System.Drawing.Size(33, 23);
            this.ItemNameSearch.TabIndex = 52;
            this.ItemNameSearch.Click += new System.EventHandler(this.ItemNameSearch_Click);
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNameSearch.BackgroundImage")));
            this.btnNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNameSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNameSearch.Location = new System.Drawing.Point(423, 35);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(33, 23);
            this.btnNameSearch.TabIndex = 38;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // txt_itemID
            // 
            // 
            // 
            // 
            this.txt_itemID.CustomButton.Image = null;
            this.txt_itemID.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txt_itemID.CustomButton.Name = "";
            this.txt_itemID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemID.CustomButton.TabIndex = 1;
            this.txt_itemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemID.CustomButton.UseSelectable = true;
            this.txt_itemID.CustomButton.Visible = false;
            this.txt_itemID.Lines = new string[0];
            this.txt_itemID.Location = new System.Drawing.Point(189, 75);
            this.txt_itemID.MaxLength = 32767;
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.PasswordChar = '\0';
            this.txt_itemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemID.SelectedText = "";
            this.txt_itemID.SelectionLength = 0;
            this.txt_itemID.SelectionStart = 0;
            this.txt_itemID.ShortcutsEnabled = true;
            this.txt_itemID.Size = new System.Drawing.Size(267, 23);
            this.txt_itemID.TabIndex = 37;
            this.txt_itemID.UseSelectable = true;
            this.txt_itemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemID.TextChanged += new System.EventHandler(this.txt_itemID_TextChanged);
            this.txt_itemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemID_KeyDown);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 75);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Item ID";
            // 
            // txt_itemName
            // 
            // 
            // 
            // 
            this.txt_itemName.CustomButton.Image = null;
            this.txt_itemName.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txt_itemName.CustomButton.Name = "";
            this.txt_itemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemName.CustomButton.TabIndex = 1;
            this.txt_itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemName.CustomButton.UseSelectable = true;
            this.txt_itemName.CustomButton.Visible = false;
            this.txt_itemName.Lines = new string[0];
            this.txt_itemName.Location = new System.Drawing.Point(595, 75);
            this.txt_itemName.MaxLength = 32767;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.SelectionLength = 0;
            this.txt_itemName.SelectionStart = 0;
            this.txt_itemName.ShortcutsEnabled = true;
            this.txt_itemName.Size = new System.Drawing.Size(267, 23);
            this.txt_itemName.TabIndex = 35;
            this.txt_itemName.UseSelectable = true;
            this.txt_itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemName.TextChanged += new System.EventHandler(this.txt_itemName_TextChanged);
            this.txt_itemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemName_KeyDown);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(493, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Item Name";
            // 
            // txt_suppID
            // 
            // 
            // 
            // 
            this.txt_suppID.CustomButton.Image = null;
            this.txt_suppID.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txt_suppID.CustomButton.Name = "";
            this.txt_suppID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_suppID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_suppID.CustomButton.TabIndex = 1;
            this.txt_suppID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_suppID.CustomButton.UseSelectable = true;
            this.txt_suppID.CustomButton.Visible = false;
            this.txt_suppID.Lines = new string[0];
            this.txt_suppID.Location = new System.Drawing.Point(595, 35);
            this.txt_suppID.MaxLength = 32767;
            this.txt_suppID.Name = "txt_suppID";
            this.txt_suppID.PasswordChar = '\0';
            this.txt_suppID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_suppID.SelectedText = "";
            this.txt_suppID.SelectionLength = 0;
            this.txt_suppID.SelectionStart = 0;
            this.txt_suppID.ShortcutsEnabled = true;
            this.txt_suppID.Size = new System.Drawing.Size(267, 23);
            this.txt_suppID.TabIndex = 33;
            this.txt_suppID.UseSelectable = true;
            this.txt_suppID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_suppID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_suppID.TextChanged += new System.EventHandler(this.txt_suppID_TextChanged);
            this.txt_suppID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_suppID_KeyDown);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(488, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Supplier ID";
            // 
            // txt_cmpName
            // 
            // 
            // 
            // 
            this.txt_cmpName.CustomButton.Image = null;
            this.txt_cmpName.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.txt_cmpName.CustomButton.Name = "";
            this.txt_cmpName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cmpName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cmpName.CustomButton.TabIndex = 1;
            this.txt_cmpName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cmpName.CustomButton.UseSelectable = true;
            this.txt_cmpName.CustomButton.Visible = false;
            this.txt_cmpName.Lines = new string[0];
            this.txt_cmpName.Location = new System.Drawing.Point(189, 35);
            this.txt_cmpName.MaxLength = 32767;
            this.txt_cmpName.Name = "txt_cmpName";
            this.txt_cmpName.PasswordChar = '\0';
            this.txt_cmpName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cmpName.SelectedText = "";
            this.txt_cmpName.SelectionLength = 0;
            this.txt_cmpName.SelectionStart = 0;
            this.txt_cmpName.ShortcutsEnabled = true;
            this.txt_cmpName.Size = new System.Drawing.Size(267, 23);
            this.txt_cmpName.TabIndex = 31;
            this.txt_cmpName.UseSelectable = true;
            this.txt_cmpName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cmpName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cmpName.TextChanged += new System.EventHandler(this.txt_cmpName_TextChanged);
            this.txt_cmpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cmpName_KeyDown);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(158, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Supplier Company Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(9, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Specified Keys";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // RawMaterialProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 585);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RawMaterialProcess";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.RawMaterialProcess_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custom_dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_cmpName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_suppID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_itemID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_itemName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_itemPrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.DataGridView custom_dataGrid1;
        private MetroFramework.Controls.MetroButton btn_submit;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroTextBox txt_receiptNum;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private System.Windows.Forms.Panel btnNameSearch;
        private System.Windows.Forms.Panel ItemNameSearch;
        private System.Windows.Forms.Panel ItemCodeSearch;
        private System.Windows.Forms.Panel suppCodeSearch;
        private System.Windows.Forms.Panel btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_warehouse;
        private MetroFramework.Controls.MetroTextBox warehouseCode;
    }
}