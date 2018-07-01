namespace Pastry_ManagementSystem.UI
{
    partial class BillProcessScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillProcessScreen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this._txt_empName = new MetroFramework.Controls.MetroTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this._generateBill = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._txtBillAmt = new MetroFramework.Controls.MetroTextBox();
            this._txtGst = new MetroFramework.Controls.MetroTextBox();
            this._txtSub = new MetroFramework.Controls.MetroTextBox();
            this._lblBill = new MetroFramework.Controls.MetroLabel();
            this._lblGst = new MetroFramework.Controls.MetroLabel();
            this._lblSub = new MetroFramework.Controls.MetroLabel();
            this.btn_generate = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cl_index5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_omdex4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fooSearch = new System.Windows.Forms.Panel();
            this._btnAddNew = new MetroFramework.Controls.MetroButton();
            this._btn_orderNew = new MetroFramework.Controls.MetroButton();
            this._txtTotAmt = new MetroFramework.Controls.MetroTextBox();
            this._txtOrderedTimes = new MetroFramework.Controls.MetroTextBox();
            this._txtQty = new MetroFramework.Controls.MetroTextBox();
            this._txtFoodPrice = new MetroFramework.Controls.MetroTextBox();
            this._txtFoodName = new MetroFramework.Controls.MetroTextBox();
            this._txtFoodNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.cusDetailGroupBox = new System.Windows.Forms.GroupBox();
            this._txtContact = new MetroFramework.Controls.MetroTextBox();
            this._txtAdd = new MetroFramework.Controls.MetroTextBox();
            this._txtNIC = new MetroFramework.Controls.MetroTextBox();
            this._txtName = new MetroFramework.Controls.MetroTextBox();
            this._txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this._txtOrderID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._dateTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._lableBillNo = new MetroFramework.Controls.MetroLabel();
            this._generatedBillNo = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cusDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.Search);
            this.metroPanel1.Controls.Add(this.btn_exit);
            this.metroPanel1.Controls.Add(this.btn_clear);
            this.metroPanel1.Controls.Add(this.btn_print);
            this.metroPanel1.Controls.Add(this._generateBill);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.btn_add);
            this.metroPanel1.Controls.Add(this.cusDetailGroupBox);
            this.metroPanel1.Controls.Add(this._txtOrderID);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 54);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1236, 566);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.metroLabel15);
            this.panel1.Controls.Add(this._txt_empName);
            this.panel1.Location = new System.Drawing.Point(10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 47);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(6, 12);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(107, 19);
            this.metroLabel15.TabIndex = 1;
            this.metroLabel15.Text = "Employee Name";
            // 
            // _txt_empName
            // 
            // 
            // 
            // 
            this._txt_empName.CustomButton.Image = null;
            this._txt_empName.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txt_empName.CustomButton.Name = "";
            this._txt_empName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txt_empName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txt_empName.CustomButton.TabIndex = 1;
            this._txt_empName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txt_empName.CustomButton.UseSelectable = true;
            this._txt_empName.CustomButton.Visible = false;
            this._txt_empName.Lines = new string[0];
            this._txt_empName.Location = new System.Drawing.Point(153, 12);
            this._txt_empName.MaxLength = 32767;
            this._txt_empName.Name = "_txt_empName";
            this._txt_empName.PasswordChar = '\0';
            this._txt_empName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txt_empName.SelectedText = "";
            this._txt_empName.SelectionLength = 0;
            this._txt_empName.SelectionStart = 0;
            this._txt_empName.ShortcutsEnabled = true;
            this._txt_empName.Size = new System.Drawing.Size(250, 23);
            this._txt_empName.TabIndex = 0;
            this._txt_empName.UseSelectable = true;
            this._txt_empName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txt_empName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txt_empName.TextChanged += new System.EventHandler(this._txt_empName_TextChanged);
            this._txt_empName.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txt_empName_KeyDown);
            this._txt_empName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txt_empName_KeyPress);
            // 
            // Search
            // 
            this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search.Location = new System.Drawing.Point(345, 18);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(30, 24);
            this.Search.TabIndex = 14;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Location = new System.Drawing.Point(1125, 496);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 49);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(1020, 496);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(99, 49);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Location = new System.Drawing.Point(915, 496);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(99, 49);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "Print";
            this.btn_print.UseSelectable = true;
            this.btn_print.Visible = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // _generateBill
            // 
            this._generateBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_generateBill.BackgroundImage")));
            this._generateBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._generateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this._generateBill.Location = new System.Drawing.Point(811, 496);
            this._generateBill.Name = "_generateBill";
            this._generateBill.Size = new System.Drawing.Size(98, 49);
            this._generateBill.TabIndex = 10;
            this._generateBill.Text = "Submit";
            this._generateBill.UseSelectable = true;
            this._generateBill.Visible = false;
            this._generateBill.Click += new System.EventHandler(this._generateBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._txtBillAmt);
            this.groupBox2.Controls.Add(this._txtGst);
            this.groupBox2.Controls.Add(this._txtSub);
            this.groupBox2.Controls.Add(this._lblBill);
            this.groupBox2.Controls.Add(this._lblGst);
            this.groupBox2.Controls.Add(this._lblSub);
            this.groupBox2.Controls.Add(this.btn_generate);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(568, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 436);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // _txtBillAmt
            // 
            // 
            // 
            // 
            this._txtBillAmt.CustomButton.Image = null;
            this._txtBillAmt.CustomButton.Location = new System.Drawing.Point(161, 1);
            this._txtBillAmt.CustomButton.Name = "";
            this._txtBillAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtBillAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtBillAmt.CustomButton.TabIndex = 1;
            this._txtBillAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtBillAmt.CustomButton.UseSelectable = true;
            this._txtBillAmt.CustomButton.Visible = false;
            this._txtBillAmt.Enabled = false;
            this._txtBillAmt.Lines = new string[0];
            this._txtBillAmt.Location = new System.Drawing.Point(467, 407);
            this._txtBillAmt.MaxLength = 32767;
            this._txtBillAmt.Name = "_txtBillAmt";
            this._txtBillAmt.PasswordChar = '\0';
            this._txtBillAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtBillAmt.SelectedText = "";
            this._txtBillAmt.SelectionLength = 0;
            this._txtBillAmt.SelectionStart = 0;
            this._txtBillAmt.ShortcutsEnabled = true;
            this._txtBillAmt.Size = new System.Drawing.Size(183, 23);
            this._txtBillAmt.TabIndex = 21;
            this._txtBillAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtBillAmt.UseSelectable = true;
            this._txtBillAmt.Visible = false;
            this._txtBillAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtBillAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtGst
            // 
            // 
            // 
            // 
            this._txtGst.CustomButton.Image = null;
            this._txtGst.CustomButton.Location = new System.Drawing.Point(161, 1);
            this._txtGst.CustomButton.Name = "";
            this._txtGst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtGst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtGst.CustomButton.TabIndex = 1;
            this._txtGst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtGst.CustomButton.UseSelectable = true;
            this._txtGst.CustomButton.Visible = false;
            this._txtGst.Enabled = false;
            this._txtGst.Lines = new string[0];
            this._txtGst.Location = new System.Drawing.Point(467, 378);
            this._txtGst.MaxLength = 32767;
            this._txtGst.Name = "_txtGst";
            this._txtGst.PasswordChar = '\0';
            this._txtGst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtGst.SelectedText = "";
            this._txtGst.SelectionLength = 0;
            this._txtGst.SelectionStart = 0;
            this._txtGst.ShortcutsEnabled = true;
            this._txtGst.Size = new System.Drawing.Size(183, 23);
            this._txtGst.TabIndex = 21;
            this._txtGst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtGst.UseSelectable = true;
            this._txtGst.Visible = false;
            this._txtGst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtGst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtSub
            // 
            // 
            // 
            // 
            this._txtSub.CustomButton.Image = null;
            this._txtSub.CustomButton.Location = new System.Drawing.Point(161, 1);
            this._txtSub.CustomButton.Name = "";
            this._txtSub.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtSub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtSub.CustomButton.TabIndex = 1;
            this._txtSub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtSub.CustomButton.UseSelectable = true;
            this._txtSub.CustomButton.Visible = false;
            this._txtSub.Enabled = false;
            this._txtSub.Lines = new string[0];
            this._txtSub.Location = new System.Drawing.Point(467, 352);
            this._txtSub.MaxLength = 32767;
            this._txtSub.Name = "_txtSub";
            this._txtSub.PasswordChar = '\0';
            this._txtSub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtSub.SelectedText = "";
            this._txtSub.SelectionLength = 0;
            this._txtSub.SelectionStart = 0;
            this._txtSub.ShortcutsEnabled = true;
            this._txtSub.Size = new System.Drawing.Size(183, 23);
            this._txtSub.TabIndex = 21;
            this._txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtSub.UseSelectable = true;
            this._txtSub.Visible = false;
            this._txtSub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtSub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _lblBill
            // 
            this._lblBill.AutoSize = true;
            this._lblBill.Location = new System.Drawing.Point(187, 407);
            this._lblBill.Name = "_lblBill";
            this._lblBill.Size = new System.Drawing.Size(57, 19);
            this._lblBill.TabIndex = 20;
            this._lblBill.Text = "Bill Total";
            this._lblBill.Visible = false;
            // 
            // _lblGst
            // 
            this._lblGst.AutoSize = true;
            this._lblGst.Location = new System.Drawing.Point(187, 382);
            this._lblGst.Name = "_lblGst";
            this._lblGst.Size = new System.Drawing.Size(68, 19);
            this._lblGst.TabIndex = 20;
            this._lblGst.Text = "GST@10%";
            this._lblGst.Visible = false;
            // 
            // _lblSub
            // 
            this._lblSub.AutoSize = true;
            this._lblSub.Location = new System.Drawing.Point(187, 352);
            this._lblSub.Name = "_lblSub";
            this._lblSub.Size = new System.Drawing.Size(62, 19);
            this._lblSub.TabIndex = 20;
            this._lblSub.Text = "Sub Total";
            this._lblSub.Visible = false;
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.White;
            this.btn_generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate.Location = new System.Drawing.Point(6, 371);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(147, 30);
            this.btn_generate.TabIndex = 19;
            this.btn_generate.Text = "Generate Billing Amount";
            this.btn_generate.UseSelectable = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index5,
            this.cl_index1,
            this.cl_index6,
            this.cl_index2,
            this.cl_index3,
            this.cl_omdex4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 341);
            this.dataGridView1.TabIndex = 18;
            // 
            // cl_index5
            // 
            this.cl_index5.HeaderText = "CustomerID";
            this.cl_index5.Name = "cl_index5";
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "FoodNo";
            this.cl_index1.Name = "cl_index1";
            // 
            // cl_index6
            // 
            this.cl_index6.HeaderText = "FoodName";
            this.cl_index6.Name = "cl_index6";
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "Quantity";
            this.cl_index2.Name = "cl_index2";
            // 
            // cl_index3
            // 
            this.cl_index3.HeaderText = "Unit Price";
            this.cl_index3.Name = "cl_index3";
            // 
            // cl_omdex4
            // 
            this.cl_omdex4.HeaderText = "Total_Price";
            this.cl_omdex4.Name = "cl_omdex4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fooSearch);
            this.groupBox1.Controls.Add(this._btnAddNew);
            this.groupBox1.Controls.Add(this._btn_orderNew);
            this.groupBox1.Controls.Add(this._txtTotAmt);
            this.groupBox1.Controls.Add(this._txtOrderedTimes);
            this.groupBox1.Controls.Add(this._txtQty);
            this.groupBox1.Controls.Add(this._txtFoodPrice);
            this.groupBox1.Controls.Add(this._txtFoodName);
            this.groupBox1.Controls.Add(this._txtFoodNo);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Location = new System.Drawing.Point(10, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 246);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // fooSearch
            // 
            this.fooSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fooSearch.BackgroundImage")));
            this.fooSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fooSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fooSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fooSearch.Location = new System.Drawing.Point(475, 25);
            this.fooSearch.Name = "fooSearch";
            this.fooSearch.Size = new System.Drawing.Size(38, 23);
            this.fooSearch.TabIndex = 21;
            this.fooSearch.Click += new System.EventHandler(this.fooSearch_Click);
            // 
            // _btnAddNew
            // 
            this._btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnAddNew.BackgroundImage")));
            this._btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAddNew.Location = new System.Drawing.Point(356, 205);
            this._btnAddNew.Name = "_btnAddNew";
            this._btnAddNew.Size = new System.Drawing.Size(77, 35);
            this._btnAddNew.TabIndex = 8;
            this._btnAddNew.Text = "Add";
            this._btnAddNew.UseSelectable = true;
            this._btnAddNew.Visible = false;
            this._btnAddNew.Click += new System.EventHandler(this._btnAddNew_Click);
            this._btnAddNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this._btnAddNew_KeyDown);
            // 
            // _btn_orderNew
            // 
            this._btn_orderNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btn_orderNew.BackgroundImage")));
            this._btn_orderNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._btn_orderNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btn_orderNew.Location = new System.Drawing.Point(263, 205);
            this._btn_orderNew.Name = "_btn_orderNew";
            this._btn_orderNew.Size = new System.Drawing.Size(77, 35);
            this._btn_orderNew.TabIndex = 7;
            this._btn_orderNew.Text = "Order New";
            this._btn_orderNew.UseSelectable = true;
            this._btn_orderNew.Click += new System.EventHandler(this._btn_orderNew_Click);
            this._btn_orderNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this._btn_orderNew_KeyDown);
            // 
            // _txtTotAmt
            // 
            // 
            // 
            // 
            this._txtTotAmt.CustomButton.Image = null;
            this._txtTotAmt.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtTotAmt.CustomButton.Name = "";
            this._txtTotAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtTotAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtTotAmt.CustomButton.TabIndex = 1;
            this._txtTotAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtTotAmt.CustomButton.UseSelectable = true;
            this._txtTotAmt.CustomButton.Visible = false;
            this._txtTotAmt.Enabled = false;
            this._txtTotAmt.Lines = new string[0];
            this._txtTotAmt.Location = new System.Drawing.Point(263, 144);
            this._txtTotAmt.MaxLength = 32767;
            this._txtTotAmt.Name = "_txtTotAmt";
            this._txtTotAmt.PasswordChar = '\0';
            this._txtTotAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtTotAmt.SelectedText = "";
            this._txtTotAmt.SelectionLength = 0;
            this._txtTotAmt.SelectionStart = 0;
            this._txtTotAmt.ShortcutsEnabled = true;
            this._txtTotAmt.Size = new System.Drawing.Size(250, 23);
            this._txtTotAmt.TabIndex = 5;
            this._txtTotAmt.UseSelectable = true;
            this._txtTotAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtTotAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtTotAmt.TextChanged += new System.EventHandler(this._txtTotAmt_TextChanged);
            // 
            // _txtOrderedTimes
            // 
            // 
            // 
            // 
            this._txtOrderedTimes.CustomButton.Image = null;
            this._txtOrderedTimes.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtOrderedTimes.CustomButton.Name = "";
            this._txtOrderedTimes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtOrderedTimes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtOrderedTimes.CustomButton.TabIndex = 1;
            this._txtOrderedTimes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtOrderedTimes.CustomButton.UseSelectable = true;
            this._txtOrderedTimes.CustomButton.Visible = false;
            this._txtOrderedTimes.Enabled = false;
            this._txtOrderedTimes.Lines = new string[0];
            this._txtOrderedTimes.Location = new System.Drawing.Point(263, 176);
            this._txtOrderedTimes.MaxLength = 32767;
            this._txtOrderedTimes.Name = "_txtOrderedTimes";
            this._txtOrderedTimes.PasswordChar = '\0';
            this._txtOrderedTimes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtOrderedTimes.SelectedText = "";
            this._txtOrderedTimes.SelectionLength = 0;
            this._txtOrderedTimes.SelectionStart = 0;
            this._txtOrderedTimes.ShortcutsEnabled = true;
            this._txtOrderedTimes.Size = new System.Drawing.Size(250, 23);
            this._txtOrderedTimes.TabIndex = 6;
            this._txtOrderedTimes.UseSelectable = true;
            this._txtOrderedTimes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtOrderedTimes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtOrderedTimes.TextChanged += new System.EventHandler(this._txtOrderedTimes_TextChanged);
            // 
            // _txtQty
            // 
            // 
            // 
            // 
            this._txtQty.CustomButton.Image = null;
            this._txtQty.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtQty.CustomButton.Name = "";
            this._txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtQty.CustomButton.TabIndex = 1;
            this._txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtQty.CustomButton.UseSelectable = true;
            this._txtQty.CustomButton.Visible = false;
            this._txtQty.Enabled = false;
            this._txtQty.Lines = new string[0];
            this._txtQty.Location = new System.Drawing.Point(263, 114);
            this._txtQty.MaxLength = 32767;
            this._txtQty.Name = "_txtQty";
            this._txtQty.PasswordChar = '\0';
            this._txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtQty.SelectedText = "";
            this._txtQty.SelectionLength = 0;
            this._txtQty.SelectionStart = 0;
            this._txtQty.ShortcutsEnabled = true;
            this._txtQty.Size = new System.Drawing.Size(250, 23);
            this._txtQty.TabIndex = 4;
            this._txtQty.UseSelectable = true;
            this._txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtQty.TextChanged += new System.EventHandler(this._txtQty_TextChanged);
            this._txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtQty_KeyDown);
            this._txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtQty_KeyPress);
            // 
            // _txtFoodPrice
            // 
            // 
            // 
            // 
            this._txtFoodPrice.CustomButton.Image = null;
            this._txtFoodPrice.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtFoodPrice.CustomButton.Name = "";
            this._txtFoodPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtFoodPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtFoodPrice.CustomButton.TabIndex = 1;
            this._txtFoodPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtFoodPrice.CustomButton.UseSelectable = true;
            this._txtFoodPrice.CustomButton.Visible = false;
            this._txtFoodPrice.Enabled = false;
            this._txtFoodPrice.Lines = new string[0];
            this._txtFoodPrice.Location = new System.Drawing.Point(263, 85);
            this._txtFoodPrice.MaxLength = 32767;
            this._txtFoodPrice.Name = "_txtFoodPrice";
            this._txtFoodPrice.PasswordChar = '\0';
            this._txtFoodPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtFoodPrice.SelectedText = "";
            this._txtFoodPrice.SelectionLength = 0;
            this._txtFoodPrice.SelectionStart = 0;
            this._txtFoodPrice.ShortcutsEnabled = true;
            this._txtFoodPrice.Size = new System.Drawing.Size(250, 23);
            this._txtFoodPrice.TabIndex = 3;
            this._txtFoodPrice.UseSelectable = true;
            this._txtFoodPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtFoodPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtFoodName
            // 
            // 
            // 
            // 
            this._txtFoodName.CustomButton.Image = null;
            this._txtFoodName.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtFoodName.CustomButton.Name = "";
            this._txtFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtFoodName.CustomButton.TabIndex = 1;
            this._txtFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtFoodName.CustomButton.UseSelectable = true;
            this._txtFoodName.CustomButton.Visible = false;
            this._txtFoodName.Enabled = false;
            this._txtFoodName.Lines = new string[0];
            this._txtFoodName.Location = new System.Drawing.Point(263, 56);
            this._txtFoodName.MaxLength = 32767;
            this._txtFoodName.Name = "_txtFoodName";
            this._txtFoodName.PasswordChar = '\0';
            this._txtFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtFoodName.SelectedText = "";
            this._txtFoodName.SelectionLength = 0;
            this._txtFoodName.SelectionStart = 0;
            this._txtFoodName.ShortcutsEnabled = true;
            this._txtFoodName.Size = new System.Drawing.Size(250, 23);
            this._txtFoodName.TabIndex = 2;
            this._txtFoodName.UseSelectable = true;
            this._txtFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtFoodNo
            // 
            // 
            // 
            // 
            this._txtFoodNo.CustomButton.Image = null;
            this._txtFoodNo.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtFoodNo.CustomButton.Name = "";
            this._txtFoodNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtFoodNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtFoodNo.CustomButton.TabIndex = 1;
            this._txtFoodNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtFoodNo.CustomButton.UseSelectable = true;
            this._txtFoodNo.CustomButton.Visible = false;
            this._txtFoodNo.Enabled = false;
            this._txtFoodNo.Lines = new string[0];
            this._txtFoodNo.Location = new System.Drawing.Point(263, 25);
            this._txtFoodNo.MaxLength = 32767;
            this._txtFoodNo.Name = "_txtFoodNo";
            this._txtFoodNo.PasswordChar = '\0';
            this._txtFoodNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtFoodNo.SelectedText = "";
            this._txtFoodNo.SelectionLength = 0;
            this._txtFoodNo.SelectionStart = 0;
            this._txtFoodNo.ShortcutsEnabled = true;
            this._txtFoodNo.Size = new System.Drawing.Size(250, 23);
            this._txtFoodNo.TabIndex = 1;
            this._txtFoodNo.UseSelectable = true;
            this._txtFoodNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtFoodNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtFoodNo.TextChanged += new System.EventHandler(this._txtFoodNo_TextChanged);
            this._txtFoodNo.Click += new System.EventHandler(this._txtFoodNo_Click);
            this._txtFoodNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtFoodNo_KeyDown);
            this._txtFoodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtFoodNo_KeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(36, 148);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(87, 19);
            this.metroLabel11.TabIndex = 9;
            this.metroLabel11.Text = "Total Amount";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Food No";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(36, 118);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(58, 19);
            this.metroLabel16.TabIndex = 9;
            this.metroLabel16.Text = "Quantity";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(36, 176);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(98, 19);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Ordered Times";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(36, 89);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(73, 19);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "Food Price";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(36, 60);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(80, 19);
            this.metroLabel13.TabIndex = 8;
            this.metroLabel13.Text = "Food Name";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(6, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(92, 19);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "Food Details";
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(419, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_add_KeyDown);
            // 
            // cusDetailGroupBox
            // 
            this.cusDetailGroupBox.Controls.Add(this._txtContact);
            this.cusDetailGroupBox.Controls.Add(this._txtAdd);
            this.cusDetailGroupBox.Controls.Add(this._txtNIC);
            this.cusDetailGroupBox.Controls.Add(this._txtName);
            this.cusDetailGroupBox.Controls.Add(this._txtID);
            this.cusDetailGroupBox.Controls.Add(this.metroLabel9);
            this.cusDetailGroupBox.Controls.Add(this.metroLabel8);
            this.cusDetailGroupBox.Controls.Add(this.metroLabel7);
            this.cusDetailGroupBox.Controls.Add(this.metroLabel6);
            this.cusDetailGroupBox.Controls.Add(this.metroLabel4);
            this.cusDetailGroupBox.Controls.Add(this.metroLabel3);
            this.cusDetailGroupBox.Enabled = false;
            this.cusDetailGroupBox.Location = new System.Drawing.Point(10, 54);
            this.cusDetailGroupBox.Name = "cusDetailGroupBox";
            this.cusDetailGroupBox.Size = new System.Drawing.Size(552, 239);
            this.cusDetailGroupBox.TabIndex = 6;
            this.cusDetailGroupBox.TabStop = false;
            this.cusDetailGroupBox.Visible = false;
            // 
            // _txtContact
            // 
            // 
            // 
            // 
            this._txtContact.CustomButton.Image = null;
            this._txtContact.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtContact.CustomButton.Name = "";
            this._txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtContact.CustomButton.TabIndex = 1;
            this._txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtContact.CustomButton.UseSelectable = true;
            this._txtContact.CustomButton.Visible = false;
            this._txtContact.Lines = new string[0];
            this._txtContact.Location = new System.Drawing.Point(263, 201);
            this._txtContact.MaxLength = 32767;
            this._txtContact.Name = "_txtContact";
            this._txtContact.PasswordChar = '\0';
            this._txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtContact.SelectedText = "";
            this._txtContact.SelectionLength = 0;
            this._txtContact.SelectionStart = 0;
            this._txtContact.ShortcutsEnabled = true;
            this._txtContact.Size = new System.Drawing.Size(250, 23);
            this._txtContact.TabIndex = 17;
            this._txtContact.UseSelectable = true;
            this._txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtAdd
            // 
            // 
            // 
            // 
            this._txtAdd.CustomButton.Image = null;
            this._txtAdd.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtAdd.CustomButton.Name = "";
            this._txtAdd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtAdd.CustomButton.TabIndex = 1;
            this._txtAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtAdd.CustomButton.UseSelectable = true;
            this._txtAdd.CustomButton.Visible = false;
            this._txtAdd.Lines = new string[0];
            this._txtAdd.Location = new System.Drawing.Point(263, 157);
            this._txtAdd.MaxLength = 32767;
            this._txtAdd.Name = "_txtAdd";
            this._txtAdd.PasswordChar = '\0';
            this._txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtAdd.SelectedText = "";
            this._txtAdd.SelectionLength = 0;
            this._txtAdd.SelectionStart = 0;
            this._txtAdd.ShortcutsEnabled = true;
            this._txtAdd.Size = new System.Drawing.Size(250, 23);
            this._txtAdd.TabIndex = 16;
            this._txtAdd.UseSelectable = true;
            this._txtAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtNIC
            // 
            // 
            // 
            // 
            this._txtNIC.CustomButton.Image = null;
            this._txtNIC.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtNIC.CustomButton.Name = "";
            this._txtNIC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtNIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtNIC.CustomButton.TabIndex = 1;
            this._txtNIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtNIC.CustomButton.UseSelectable = true;
            this._txtNIC.CustomButton.Visible = false;
            this._txtNIC.Lines = new string[0];
            this._txtNIC.Location = new System.Drawing.Point(263, 112);
            this._txtNIC.MaxLength = 32767;
            this._txtNIC.Name = "_txtNIC";
            this._txtNIC.PasswordChar = '\0';
            this._txtNIC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtNIC.SelectedText = "";
            this._txtNIC.SelectionLength = 0;
            this._txtNIC.SelectionStart = 0;
            this._txtNIC.ShortcutsEnabled = true;
            this._txtNIC.Size = new System.Drawing.Size(250, 23);
            this._txtNIC.TabIndex = 15;
            this._txtNIC.UseSelectable = true;
            this._txtNIC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtNIC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtName
            // 
            // 
            // 
            // 
            this._txtName.CustomButton.Image = null;
            this._txtName.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtName.CustomButton.Name = "";
            this._txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtName.CustomButton.TabIndex = 1;
            this._txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtName.CustomButton.UseSelectable = true;
            this._txtName.CustomButton.Visible = false;
            this._txtName.Lines = new string[0];
            this._txtName.Location = new System.Drawing.Point(263, 68);
            this._txtName.MaxLength = 32767;
            this._txtName.Name = "_txtName";
            this._txtName.PasswordChar = '\0';
            this._txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtName.SelectedText = "";
            this._txtName.SelectionLength = 0;
            this._txtName.SelectionStart = 0;
            this._txtName.ShortcutsEnabled = true;
            this._txtName.Size = new System.Drawing.Size(250, 23);
            this._txtName.TabIndex = 14;
            this._txtName.UseSelectable = true;
            this._txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtID
            // 
            // 
            // 
            // 
            this._txtID.CustomButton.Image = null;
            this._txtID.CustomButton.Location = new System.Drawing.Point(228, 1);
            this._txtID.CustomButton.Name = "";
            this._txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtID.CustomButton.TabIndex = 1;
            this._txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtID.CustomButton.UseSelectable = true;
            this._txtID.CustomButton.Visible = false;
            this._txtID.Lines = new string[0];
            this._txtID.Location = new System.Drawing.Point(263, 24);
            this._txtID.MaxLength = 32767;
            this._txtID.Name = "_txtID";
            this._txtID.PasswordChar = '\0';
            this._txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtID.SelectedText = "";
            this._txtID.SelectionLength = 0;
            this._txtID.SelectionStart = 0;
            this._txtID.ShortcutsEnabled = true;
            this._txtID.Size = new System.Drawing.Size(250, 23);
            this._txtID.TabIndex = 13;
            this._txtID.UseSelectable = true;
            this._txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(36, 24);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Customer ID";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(36, 201);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(168, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Customer Contact Number";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(36, 161);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Customer Address";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(36, 116);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(92, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Customer NIC";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Customer Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(6, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Bill To";
            // 
            // _txtOrderID
            // 
            // 
            // 
            // 
            this._txtOrderID.CustomButton.Image = null;
            this._txtOrderID.CustomButton.Location = new System.Drawing.Point(224, 1);
            this._txtOrderID.CustomButton.Name = "";
            this._txtOrderID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtOrderID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtOrderID.CustomButton.TabIndex = 1;
            this._txtOrderID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtOrderID.CustomButton.UseSelectable = true;
            this._txtOrderID.CustomButton.Visible = false;
            this._txtOrderID.Lines = new string[0];
            this._txtOrderID.Location = new System.Drawing.Point(129, 19);
            this._txtOrderID.MaxLength = 32767;
            this._txtOrderID.Name = "_txtOrderID";
            this._txtOrderID.PasswordChar = '\0';
            this._txtOrderID.PromptText = "Food Order Identification";
            this._txtOrderID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtOrderID.SelectedText = "";
            this._txtOrderID.SelectionLength = 0;
            this._txtOrderID.SelectionStart = 0;
            this._txtOrderID.ShortcutsEnabled = true;
            this._txtOrderID.Size = new System.Drawing.Size(246, 23);
            this._txtOrderID.TabIndex = 0;
            this._txtOrderID.UseCustomBackColor = true;
            this._txtOrderID.UseCustomForeColor = true;
            this._txtOrderID.UseSelectable = true;
            this._txtOrderID.UseStyleColors = true;
            this._txtOrderID.WaterMark = "Food Order Identification";
            this._txtOrderID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtOrderID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtOrderID.TextChanged += new System.EventHandler(this._txtOrderID_TextChanged);
            this._txtOrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtOrderID_KeyDown);
            this._txtOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtOrderID_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Food Order ID";
            // 
            // _dateTime
            // 
            this._dateTime.AutoSize = true;
            this._dateTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this._dateTime.Location = new System.Drawing.Point(1045, 32);
            this._dateTime.Name = "_dateTime";
            this._dateTime.Size = new System.Drawing.Size(50, 19);
            this._dateTime.TabIndex = 5;
            this._dateTime.Text = "Bill To";
            this._dateTime.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(906, 32);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "System Date & Time";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // _lableBillNo
            // 
            this._lableBillNo.AutoSize = true;
            this._lableBillNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._lableBillNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this._lableBillNo.Location = new System.Drawing.Point(371, 8);
            this._lableBillNo.Name = "_lableBillNo";
            this._lableBillNo.Size = new System.Drawing.Size(227, 25);
            this._lableBillNo.TabIndex = 4;
            this._lableBillNo.Text = "Generated Bill Number   :";
            this._lableBillNo.Visible = false;
            // 
            // _generatedBillNo
            // 
            this._generatedBillNo.AutoSize = true;
            this._generatedBillNo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._generatedBillNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this._generatedBillNo.Location = new System.Drawing.Point(604, 8);
            this._generatedBillNo.Name = "_generatedBillNo";
            this._generatedBillNo.Size = new System.Drawing.Size(212, 25);
            this._generatedBillNo.TabIndex = 5;
            this._generatedBillNo.Text = "Generated Bill Number ";
            this._generatedBillNo.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BillProcessScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 606);
            this.Controls.Add(this._generatedBillNo);
            this.Controls.Add(this._lableBillNo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this._dateTime);
            this.Controls.Add(this.metroLabel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillProcessScreen";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Billing Process";
            this.Load += new System.EventHandler(this.BillProcessScreen_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cusDetailGroupBox.ResumeLayout(false);
            this.cusDetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox _txtOrderID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel _generatedBillNo;
        private MetroFramework.Controls.MetroLabel _lableBillNo;
        private MetroFramework.Controls.MetroLabel _dateTime;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox cusDetailGroupBox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox _txtContact;
        private MetroFramework.Controls.MetroTextBox _txtAdd;
        private MetroFramework.Controls.MetroTextBox _txtNIC;
        private MetroFramework.Controls.MetroTextBox _txtName;
        private MetroFramework.Controls.MetroTextBox _txtID;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox _txtFoodPrice;
        private MetroFramework.Controls.MetroTextBox _txtFoodNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox _txtOrderedTimes;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox _txtTotAmt;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox _txt_empName;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_omdex4;
        private MetroFramework.Controls.MetroTextBox _txtFoodName;
        private MetroFramework.Controls.MetroButton _btn_orderNew;
        private MetroFramework.Controls.MetroTextBox _txtQty;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton _btnAddNew;
        private MetroFramework.Controls.MetroTextBox _txtBillAmt;
        private MetroFramework.Controls.MetroTextBox _txtGst;
        private MetroFramework.Controls.MetroTextBox _txtSub;
        private MetroFramework.Controls.MetroLabel _lblBill;
        private MetroFramework.Controls.MetroLabel _lblGst;
        private MetroFramework.Controls.MetroLabel _lblSub;
        private MetroFramework.Controls.MetroButton btn_generate;
        private MetroFramework.Controls.MetroButton _generateBill;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_exit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel fooSearch;
    }
}