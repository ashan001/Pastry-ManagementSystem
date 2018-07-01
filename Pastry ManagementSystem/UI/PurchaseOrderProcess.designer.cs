namespace Pastry_ManagementSystem.UI
{
    partial class PurchaseOrderProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderProcess));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.btn_submit = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_suppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.itemIDSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.warehouseCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_new = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.txt_Itemprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_quantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txt_itemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_totAmt = new MetroFramework.Controls.MetroTextBox();
            this.txt_itemID = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btn_exit);
            this.metroPanel1.Controls.Add(this.btn_submit);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.groupBox4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 27);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1335, 550);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(1163, 442);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(136, 50);
            this.btn_exit.TabIndex = 77;
            this.btn_exit.Text = "Close";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(1163, 380);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(136, 50);
            this.btn_submit.TabIndex = 77;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseSelectable = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(1059, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 220);
            this.panel1.TabIndex = 76;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index1,
            this.cl_suppID,
            this.cl_date,
            this.cl_index3,
            this.cl_index2,
            this.cl_index5,
            this.cl_index4,
            this.cl_index7,
            this.cl_index8,
            this.cl_warehouse});
            this.dataGridView1.Location = new System.Drawing.Point(9, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 340);
            this.dataGridView1.TabIndex = 75;
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "Receipt Num";
            this.cl_index1.Name = "cl_index1";
            // 
            // cl_suppID
            // 
            this.cl_suppID.HeaderText = "Supplier_ID";
            this.cl_suppID.Name = "cl_suppID";
            // 
            // cl_date
            // 
            this.cl_date.HeaderText = "Date_Received";
            this.cl_date.Name = "cl_date";
            // 
            // cl_index3
            // 
            this.cl_index3.HeaderText = "Item Name";
            this.cl_index3.Name = "cl_index3";
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "Item ID";
            this.cl_index2.Name = "cl_index2";
            // 
            // cl_index5
            // 
            this.cl_index5.HeaderText = "cmpName";
            this.cl_index5.Name = "cl_index5";
            // 
            // cl_index4
            // 
            this.cl_index4.HeaderText = "Quantity";
            this.cl_index4.Name = "cl_index4";
            // 
            // cl_index7
            // 
            this.cl_index7.HeaderText = "Item Price";
            this.cl_index7.Name = "cl_index7";
            // 
            // cl_index8
            // 
            this.cl_index8.HeaderText = "TotAmt";
            this.cl_index8.Name = "cl_index8";
            // 
            // cl_warehouse
            // 
            this.cl_warehouse.HeaderText = "Warehouse";
            this.cl_warehouse.Name = "cl_warehouse";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.itemIDSearch);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.warehouseCode);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.btn_new);
            this.groupBox4.Controls.Add(this.metroButton1);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Controls.Add(this.txt_Itemprice);
            this.groupBox4.Controls.Add(this.metroLabel19);
            this.groupBox4.Controls.Add(this.txt_quantity);
            this.groupBox4.Controls.Add(this.metroLabel18);
            this.groupBox4.Controls.Add(this.txt_itemName);
            this.groupBox4.Controls.Add(this.metroLabel17);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.metroLabel16);
            this.groupBox4.Controls.Add(this.metroLabel15);
            this.groupBox4.Controls.Add(this.txt_totAmt);
            this.groupBox4.Controls.Add(this.txt_itemID);
            this.groupBox4.Location = new System.Drawing.Point(9, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1290, 138);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            // 
            // itemIDSearch
            // 
            this.itemIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemIDSearch.BackgroundImage")));
            this.itemIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itemIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemIDSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemIDSearch.Location = new System.Drawing.Point(231, 44);
            this.itemIDSearch.Name = "itemIDSearch";
            this.itemIDSearch.Size = new System.Drawing.Size(33, 23);
            this.itemIDSearch.TabIndex = 86;
            this.itemIDSearch.Click += new System.EventHandler(this.itemIDSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(231, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 25);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // warehouseCode
            // 
            // 
            // 
            // 
            this.warehouseCode.CustomButton.Image = null;
            this.warehouseCode.CustomButton.Location = new System.Drawing.Point(154, 1);
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
            this.warehouseCode.Location = new System.Drawing.Point(86, 90);
            this.warehouseCode.MaxLength = 32767;
            this.warehouseCode.Name = "warehouseCode";
            this.warehouseCode.PasswordChar = '\0';
            this.warehouseCode.PromptText = "Warehouse Code";
            this.warehouseCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.warehouseCode.SelectedText = "";
            this.warehouseCode.SelectionLength = 0;
            this.warehouseCode.SelectionStart = 0;
            this.warehouseCode.ShortcutsEnabled = true;
            this.warehouseCode.Size = new System.Drawing.Size(178, 25);
            this.warehouseCode.TabIndex = 84;
            this.warehouseCode.UseCustomBackColor = true;
            this.warehouseCode.UseCustomForeColor = true;
            this.warehouseCode.UseSelectable = true;
            this.warehouseCode.UseStyleColors = true;
            this.warehouseCode.WaterMark = "Warehouse Code";
            this.warehouseCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.warehouseCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.warehouseCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.warehouseCode_KeyDown);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 83;
            this.metroLabel2.Text = "Warehouse";
            // 
            // btn_new
            // 
            this.btn_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new.BackgroundImage")));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_new.Location = new System.Drawing.Point(512, 90);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(113, 33);
            this.btn_new.TabIndex = 82;
            this.btn_new.Text = "Add New item";
            this.btn_new.UseSelectable = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_new_KeyDown);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(433, 90);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(73, 33);
            this.metroButton1.TabIndex = 81;
            this.metroButton1.Text = "Cacel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(352, 90);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 33);
            this.btn_add.TabIndex = 75;
            this.btn_add.Text = "Add";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Itemprice
            // 
            // 
            // 
            // 
            this.txt_Itemprice.CustomButton.Image = null;
            this.txt_Itemprice.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txt_Itemprice.CustomButton.Name = "";
            this.txt_Itemprice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Itemprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Itemprice.CustomButton.TabIndex = 1;
            this.txt_Itemprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Itemprice.CustomButton.UseSelectable = true;
            this.txt_Itemprice.CustomButton.Visible = false;
            this.txt_Itemprice.Enabled = false;
            this.txt_Itemprice.Lines = new string[0];
            this.txt_Itemprice.Location = new System.Drawing.Point(660, 46);
            this.txt_Itemprice.MaxLength = 32767;
            this.txt_Itemprice.Name = "txt_Itemprice";
            this.txt_Itemprice.PasswordChar = '\0';
            this.txt_Itemprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Itemprice.SelectedText = "";
            this.txt_Itemprice.SelectionLength = 0;
            this.txt_Itemprice.SelectionStart = 0;
            this.txt_Itemprice.ShortcutsEnabled = true;
            this.txt_Itemprice.Size = new System.Drawing.Size(122, 23);
            this.txt_Itemprice.TabIndex = 80;
            this.txt_Itemprice.UseSelectable = true;
            this.txt_Itemprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Itemprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(582, 50);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(72, 19);
            this.metroLabel19.TabIndex = 79;
            this.metroLabel19.Text = "Item Price ";
            // 
            // txt_quantity
            // 
            // 
            // 
            // 
            this.txt_quantity.CustomButton.Image = null;
            this.txt_quantity.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txt_quantity.CustomButton.Name = "";
            this.txt_quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantity.CustomButton.TabIndex = 1;
            this.txt_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantity.CustomButton.UseSelectable = true;
            this.txt_quantity.CustomButton.Visible = false;
            this.txt_quantity.Lines = new string[0];
            this.txt_quantity.Location = new System.Drawing.Point(896, 44);
            this.txt_quantity.MaxLength = 32767;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.ShortcutsEnabled = true;
            this.txt_quantity.Size = new System.Drawing.Size(117, 23);
            this.txt_quantity.TabIndex = 78;
            this.txt_quantity.UseSelectable = true;
            this.txt_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_KeyDown);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(824, 45);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(66, 19);
            this.metroLabel18.TabIndex = 77;
            this.metroLabel18.Text = "Quantity";
            // 
            // txt_itemName
            // 
            // 
            // 
            // 
            this.txt_itemName.CustomButton.Image = null;
            this.txt_itemName.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txt_itemName.CustomButton.Name = "";
            this.txt_itemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemName.CustomButton.TabIndex = 1;
            this.txt_itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemName.CustomButton.UseSelectable = true;
            this.txt_itemName.CustomButton.Visible = false;
            this.txt_itemName.Enabled = false;
            this.txt_itemName.Lines = new string[0];
            this.txt_itemName.Location = new System.Drawing.Point(351, 46);
            this.txt_itemName.MaxLength = 32767;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.SelectionLength = 0;
            this.txt_itemName.SelectionStart = 0;
            this.txt_itemName.ShortcutsEnabled = true;
            this.txt_itemName.Size = new System.Drawing.Size(225, 23);
            this.txt_itemName.TabIndex = 76;
            this.txt_itemName.UseSelectable = true;
            this.txt_itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(270, 45);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(75, 19);
            this.metroLabel17.TabIndex = 75;
            this.metroLabel17.Text = "Item Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1043, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 74;
            this.metroLabel1.Text = "Total Amount";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(29, 44);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(51, 19);
            this.metroLabel16.TabIndex = 74;
            this.metroLabel16.Text = "Item ID";
            this.metroLabel16.Click += new System.EventHandler(this.metroLabel16_Click);
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
            // txt_totAmt
            // 
            // 
            // 
            // 
            this.txt_totAmt.CustomButton.Image = null;
            this.txt_totAmt.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txt_totAmt.CustomButton.Name = "";
            this.txt_totAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_totAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_totAmt.CustomButton.TabIndex = 1;
            this.txt_totAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_totAmt.CustomButton.UseSelectable = true;
            this.txt_totAmt.CustomButton.Visible = false;
            this.txt_totAmt.Enabled = false;
            this.txt_totAmt.Lines = new string[0];
            this.txt_totAmt.Location = new System.Drawing.Point(1147, 47);
            this.txt_totAmt.MaxLength = 32767;
            this.txt_totAmt.Name = "txt_totAmt";
            this.txt_totAmt.PasswordChar = '\0';
            this.txt_totAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_totAmt.SelectedText = "";
            this.txt_totAmt.SelectionLength = 0;
            this.txt_totAmt.SelectionStart = 0;
            this.txt_totAmt.ShortcutsEnabled = true;
            this.txt_totAmt.Size = new System.Drawing.Size(126, 23);
            this.txt_totAmt.TabIndex = 72;
            this.txt_totAmt.UseSelectable = true;
            this.txt_totAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_totAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_totAmt.TextChanged += new System.EventHandler(this.txt_itemID_TextChanged);
            this.txt_totAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemID_KeyDown);
            // 
            // txt_itemID
            // 
            // 
            // 
            // 
            this.txt_itemID.CustomButton.Image = null;
            this.txt_itemID.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txt_itemID.CustomButton.Name = "";
            this.txt_itemID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemID.CustomButton.TabIndex = 1;
            this.txt_itemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemID.CustomButton.UseSelectable = true;
            this.txt_itemID.CustomButton.Visible = false;
            this.txt_itemID.Lines = new string[0];
            this.txt_itemID.Location = new System.Drawing.Point(86, 44);
            this.txt_itemID.MaxLength = 32767;
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.PasswordChar = '\0';
            this.txt_itemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemID.SelectedText = "";
            this.txt_itemID.SelectionLength = 0;
            this.txt_itemID.SelectionStart = 0;
            this.txt_itemID.ShortcutsEnabled = true;
            this.txt_itemID.Size = new System.Drawing.Size(178, 23);
            this.txt_itemID.TabIndex = 72;
            this.txt_itemID.UseSelectable = true;
            this.txt_itemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemID.TextChanged += new System.EventHandler(this.txt_itemID_TextChanged);
            this.txt_itemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_itemID_KeyDown);
            this.txt_itemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemID_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(9, 7);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(212, 25);
            this.lbl_welcome.TabIndex = 82;
            this.lbl_welcome.Text = "Purchase Order Process";
            // 
            // PurchaseOrderProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 529);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrderProcess";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.PurchaseOrderProcess_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        public MetroFramework.Controls.MetroTextBox txt_Itemprice;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        public MetroFramework.Controls.MetroTextBox txt_quantity;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        public MetroFramework.Controls.MetroTextBox txt_itemName;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        public MetroFramework.Controls.MetroTextBox txt_itemID;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton btn_submit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox txt_totAmt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btn_new;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroTextBox warehouseCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_suppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_warehouse;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.Panel itemIDSearch;
    }
}