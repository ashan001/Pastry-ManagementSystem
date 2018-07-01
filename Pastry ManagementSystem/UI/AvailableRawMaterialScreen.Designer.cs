namespace Pastry_ManagementSystem.UI
{
    partial class AvailableRawMaterialScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableRawMaterialScreen));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.btn_OK = new MetroFramework.Controls.MetroButton();
            this.grid_InfoThrowData = new System.Windows.Forms.DataGridView();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWarehouse = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.itemIDSearch = new System.Windows.Forms.Panel();
            this.txtItemID = new MetroFramework.Controls.MetroTextBox();
            this.txt_itemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txt_qtyrequired = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_availableQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_itemNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_date = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_time = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_empID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_designation = new MetroFramework.Controls.MetroTextBox();
            this.txt_lName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_empFName = new MetroFramework.Controls.MetroTextBox();
            this.cmb_purchID = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_InfoThrowData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_welcome.Location = new System.Drawing.Point(7, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(262, 25);
            this.lbl_welcome.TabIndex = 26;
            this.lbl_welcome.Text = "Available raw material screen";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroButton5);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.btn_OK);
            this.metroPanel1.Controls.Add(this.grid_InfoThrowData);
            this.metroPanel1.Controls.Add(this.groupBox3);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1015, 569);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(548, 81);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(450, 204);
            this.metroPanel2.TabIndex = 25;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton5.BackgroundImage")));
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton5.Location = new System.Drawing.Point(785, 510);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(99, 41);
            this.metroButton5.TabIndex = 24;
            this.metroButton5.Text = "Clear";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton4.Location = new System.Drawing.Point(900, 510);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(98, 41);
            this.metroButton4.TabIndex = 23;
            this.metroButton4.Text = "Exit";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OK.BackgroundImage")));
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OK.Location = new System.Drawing.Point(666, 510);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(98, 41);
            this.btn_OK.TabIndex = 22;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseSelectable = true;
            this.btn_OK.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // grid_InfoThrowData
            // 
            this.grid_InfoThrowData.AllowUserToAddRows = false;
            this.grid_InfoThrowData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_InfoThrowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_InfoThrowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index1,
            this.cl_itemName,
            this.cl_warehouse,
            this.cl_index2,
            this.cl_index3});
            this.grid_InfoThrowData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_InfoThrowData.Location = new System.Drawing.Point(7, 396);
            this.grid_InfoThrowData.Name = "grid_InfoThrowData";
            this.grid_InfoThrowData.Size = new System.Drawing.Size(646, 155);
            this.grid_InfoThrowData.TabIndex = 21;
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "Item ID";
            this.cl_index1.Name = "cl_index1";
            this.cl_index1.Width = 135;
            // 
            // cl_itemName
            // 
            this.cl_itemName.HeaderText = "Item Name";
            this.cl_itemName.Name = "cl_itemName";
            // 
            // cl_warehouse
            // 
            this.cl_warehouse.HeaderText = "Warehouse";
            this.cl_warehouse.Name = "cl_warehouse";
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "Quantity Required";
            this.cl_index2.Name = "cl_index2";
            this.cl_index2.Width = 135;
            // 
            // cl_index3
            // 
            this.cl_index3.HeaderText = "Available Quantity";
            this.cl_index3.Name = "cl_index3";
            this.cl_index3.Width = 135;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWarehouse);
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.itemIDSearch);
            this.groupBox3.Controls.Add(this.txtItemID);
            this.groupBox3.Controls.Add(this.txt_itemName);
            this.groupBox3.Controls.Add(this.metroLabel12);
            this.groupBox3.Controls.Add(this.txt_qtyrequired);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.metroButton2);
            this.groupBox3.Controls.Add(this.metroButton1);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.txt_availableQty);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Location = new System.Drawing.Point(7, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(991, 99);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtWarehouse
            // 
            // 
            // 
            // 
            this.txtWarehouse.CustomButton.Image = null;
            this.txtWarehouse.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtWarehouse.CustomButton.Name = "";
            this.txtWarehouse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWarehouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWarehouse.CustomButton.TabIndex = 1;
            this.txtWarehouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWarehouse.CustomButton.UseSelectable = true;
            this.txtWarehouse.CustomButton.Visible = false;
            this.txtWarehouse.Lines = new string[0];
            this.txtWarehouse.Location = new System.Drawing.Point(584, 19);
            this.txtWarehouse.MaxLength = 32767;
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.PasswordChar = '\0';
            this.txtWarehouse.ReadOnly = true;
            this.txtWarehouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWarehouse.SelectedText = "";
            this.txtWarehouse.SelectionLength = 0;
            this.txtWarehouse.SelectionStart = 0;
            this.txtWarehouse.ShortcutsEnabled = true;
            this.txtWarehouse.Size = new System.Drawing.Size(149, 23);
            this.txtWarehouse.TabIndex = 30;
            this.txtWarehouse.UseSelectable = true;
            this.txtWarehouse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWarehouse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(504, 19);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(74, 19);
            this.metroLabel13.TabIndex = 29;
            this.metroLabel13.Text = "Warehouse";
            // 
            // itemIDSearch
            // 
            this.itemIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemIDSearch.BackgroundImage")));
            this.itemIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itemIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemIDSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemIDSearch.Location = new System.Drawing.Point(199, 17);
            this.itemIDSearch.Name = "itemIDSearch";
            this.itemIDSearch.Size = new System.Drawing.Size(44, 25);
            this.itemIDSearch.TabIndex = 28;
            this.itemIDSearch.Click += new System.EventHandler(this.itemIDSearch_Click);
            // 
            // txtItemID
            // 
            // 
            // 
            // 
            this.txtItemID.CustomButton.Image = null;
            this.txtItemID.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtItemID.CustomButton.Name = "";
            this.txtItemID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtItemID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemID.CustomButton.TabIndex = 1;
            this.txtItemID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemID.CustomButton.UseSelectable = true;
            this.txtItemID.Lines = new string[0];
            this.txtItemID.Location = new System.Drawing.Point(78, 17);
            this.txtItemID.MaxLength = 32767;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.PasswordChar = '\0';
            this.txtItemID.PromptText = "Item Code";
            this.txtItemID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemID.SelectedText = "";
            this.txtItemID.SelectionLength = 0;
            this.txtItemID.SelectionStart = 0;
            this.txtItemID.ShortcutsEnabled = true;
            this.txtItemID.ShowButton = true;
            this.txtItemID.Size = new System.Drawing.Size(165, 25);
            this.txtItemID.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemID.TabIndex = 27;
            this.txtItemID.UseCustomBackColor = true;
            this.txtItemID.UseCustomForeColor = true;
            this.txtItemID.UseSelectable = true;
            this.txtItemID.UseStyleColors = true;
            this.txtItemID.WaterMark = "Item Code";
            this.txtItemID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemID_KeyDown);
            // 
            // txt_itemName
            // 
            // 
            // 
            // 
            this.txt_itemName.CustomButton.Image = null;
            this.txt_itemName.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txt_itemName.CustomButton.Name = "";
            this.txt_itemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemName.CustomButton.TabIndex = 1;
            this.txt_itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemName.CustomButton.UseSelectable = true;
            this.txt_itemName.CustomButton.Visible = false;
            this.txt_itemName.Lines = new string[0];
            this.txt_itemName.Location = new System.Drawing.Point(330, 19);
            this.txt_itemName.MaxLength = 32767;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.ReadOnly = true;
            this.txt_itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.SelectionLength = 0;
            this.txt_itemName.SelectionStart = 0;
            this.txt_itemName.ShortcutsEnabled = true;
            this.txt_itemName.Size = new System.Drawing.Size(168, 23);
            this.txt_itemName.TabIndex = 26;
            this.txt_itemName.UseSelectable = true;
            this.txt_itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(249, 19);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(75, 19);
            this.metroLabel12.TabIndex = 25;
            this.metroLabel12.Text = "Item Name";
            // 
            // txt_qtyrequired
            // 
            // 
            // 
            // 
            this.txt_qtyrequired.CustomButton.Image = null;
            this.txt_qtyrequired.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txt_qtyrequired.CustomButton.Name = "";
            this.txt_qtyrequired.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qtyrequired.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qtyrequired.CustomButton.TabIndex = 1;
            this.txt_qtyrequired.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qtyrequired.CustomButton.UseSelectable = true;
            this.txt_qtyrequired.CustomButton.Visible = false;
            this.txt_qtyrequired.Lines = new string[0];
            this.txt_qtyrequired.Location = new System.Drawing.Point(875, 19);
            this.txt_qtyrequired.MaxLength = 32767;
            this.txt_qtyrequired.Name = "txt_qtyrequired";
            this.txt_qtyrequired.PasswordChar = '\0';
            this.txt_qtyrequired.ReadOnly = true;
            this.txt_qtyrequired.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qtyrequired.SelectedText = "";
            this.txt_qtyrequired.SelectionLength = 0;
            this.txt_qtyrequired.SelectionStart = 0;
            this.txt_qtyrequired.ShortcutsEnabled = true;
            this.txt_qtyrequired.Size = new System.Drawing.Size(100, 23);
            this.txt_qtyrequired.TabIndex = 24;
            this.txt_qtyrequired.UseSelectable = true;
            this.txt_qtyrequired.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qtyrequired.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qtyrequired.TextChanged += new System.EventHandler(this.txt_qtyrequired_TextChanged);
            this.txt_qtyrequired.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qtyrequired_KeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(743, 19);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(112, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Quantity required";
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(875, 61);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 23);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "Clear";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(737, 61);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 23);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 19);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Item ID";
            // 
            // txt_availableQty
            // 
            // 
            // 
            // 
            this.txt_availableQty.CustomButton.Image = null;
            this.txt_availableQty.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txt_availableQty.CustomButton.Name = "";
            this.txt_availableQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_availableQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_availableQty.CustomButton.TabIndex = 1;
            this.txt_availableQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_availableQty.CustomButton.UseSelectable = true;
            this.txt_availableQty.CustomButton.Visible = false;
            this.txt_availableQty.Lines = new string[0];
            this.txt_availableQty.Location = new System.Drawing.Point(143, 61);
            this.txt_availableQty.MaxLength = 32767;
            this.txt_availableQty.Name = "txt_availableQty";
            this.txt_availableQty.PasswordChar = '\0';
            this.txt_availableQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_availableQty.SelectedText = "";
            this.txt_availableQty.SelectionLength = 0;
            this.txt_availableQty.SelectionStart = 0;
            this.txt_availableQty.ShortcutsEnabled = true;
            this.txt_availableQty.Size = new System.Drawing.Size(100, 23);
            this.txt_availableQty.TabIndex = 18;
            this.txt_availableQty.UseSelectable = true;
            this.txt_availableQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_availableQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_availableQty.TextChanged += new System.EventHandler(this.txt_availableQty_TextChanged);
            this.txt_availableQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_availableQty_KeyDown);
            this.txt_availableQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_availableQty_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(5, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Available Quantity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.txt_itemNo);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.txt_date);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txt_time);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 63);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Item ID";
            // 
            // txt_itemNo
            // 
            // 
            // 
            // 
            this.txt_itemNo.CustomButton.Image = null;
            this.txt_itemNo.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txt_itemNo.CustomButton.Name = "";
            this.txt_itemNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemNo.CustomButton.TabIndex = 1;
            this.txt_itemNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemNo.CustomButton.UseSelectable = true;
            this.txt_itemNo.CustomButton.Visible = false;
            this.txt_itemNo.Enabled = false;
            this.txt_itemNo.Lines = new string[0];
            this.txt_itemNo.Location = new System.Drawing.Point(70, 23);
            this.txt_itemNo.MaxLength = 32767;
            this.txt_itemNo.Name = "txt_itemNo";
            this.txt_itemNo.PasswordChar = '\0';
            this.txt_itemNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemNo.SelectedText = "";
            this.txt_itemNo.SelectionLength = 0;
            this.txt_itemNo.SelectionStart = 0;
            this.txt_itemNo.ShortcutsEnabled = true;
            this.txt_itemNo.Size = new System.Drawing.Size(247, 23);
            this.txt_itemNo.TabIndex = 6;
            this.txt_itemNo.UseSelectable = true;
            this.txt_itemNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(323, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Date ";
            // 
            // txt_date
            // 
            // 
            // 
            // 
            this.txt_date.CustomButton.Image = null;
            this.txt_date.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_date.CustomButton.Name = "";
            this.txt_date.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_date.CustomButton.TabIndex = 1;
            this.txt_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_date.CustomButton.UseSelectable = true;
            this.txt_date.CustomButton.Visible = false;
            this.txt_date.Enabled = false;
            this.txt_date.Lines = new string[0];
            this.txt_date.Location = new System.Drawing.Point(385, 23);
            this.txt_date.MaxLength = 32767;
            this.txt_date.Name = "txt_date";
            this.txt_date.PasswordChar = '\0';
            this.txt_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_date.SelectedText = "";
            this.txt_date.SelectionLength = 0;
            this.txt_date.SelectionStart = 0;
            this.txt_date.ShortcutsEnabled = true;
            this.txt_date.Size = new System.Drawing.Size(261, 23);
            this.txt_date.TabIndex = 7;
            this.txt_date.UseSelectable = true;
            this.txt_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(659, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Time";
            // 
            // txt_time
            // 
            // 
            // 
            // 
            this.txt_time.CustomButton.Image = null;
            this.txt_time.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txt_time.CustomButton.Name = "";
            this.txt_time.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_time.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_time.CustomButton.TabIndex = 1;
            this.txt_time.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_time.CustomButton.UseSelectable = true;
            this.txt_time.CustomButton.Visible = false;
            this.txt_time.Enabled = false;
            this.txt_time.Lines = new string[0];
            this.txt_time.Location = new System.Drawing.Point(740, 23);
            this.txt_time.MaxLength = 32767;
            this.txt_time.Name = "txt_time";
            this.txt_time.PasswordChar = '\0';
            this.txt_time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_time.SelectedText = "";
            this.txt_time.SelectionLength = 0;
            this.txt_time.SelectionStart = 0;
            this.txt_time.ShortcutsEnabled = true;
            this.txt_time.Size = new System.Drawing.Size(235, 23);
            this.txt_time.TabIndex = 8;
            this.txt_time.UseSelectable = true;
            this.txt_time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_time.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_empID);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txt_designation);
            this.groupBox1.Controls.Add(this.txt_lName);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.txt_empFName);
            this.groupBox1.Controls.Add(this.cmb_purchID);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(7, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 204);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txt_empID
            // 
            // 
            // 
            // 
            this.txt_empID.CustomButton.Image = null;
            this.txt_empID.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txt_empID.CustomButton.Name = "";
            this.txt_empID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empID.CustomButton.TabIndex = 1;
            this.txt_empID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empID.CustomButton.UseSelectable = true;
            this.txt_empID.CustomButton.Visible = false;
            this.txt_empID.Enabled = false;
            this.txt_empID.Lines = new string[0];
            this.txt_empID.Location = new System.Drawing.Point(235, 55);
            this.txt_empID.MaxLength = 32767;
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.PasswordChar = '\0';
            this.txt_empID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empID.SelectedText = "";
            this.txt_empID.SelectionLength = 0;
            this.txt_empID.SelectionStart = 0;
            this.txt_empID.ShortcutsEnabled = true;
            this.txt_empID.Size = new System.Drawing.Size(215, 23);
            this.txt_empID.TabIndex = 19;
            this.txt_empID.UseSelectable = true;
            this.txt_empID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empID.TextChanged += new System.EventHandler(this.txt_empID_TextChanged);
            this.txt_empID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_empID_KeyDown);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(25, 55);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Employee ID";
            // 
            // txt_designation
            // 
            // 
            // 
            // 
            this.txt_designation.CustomButton.Image = null;
            this.txt_designation.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.txt_designation.CustomButton.Name = "";
            this.txt_designation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_designation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_designation.CustomButton.TabIndex = 1;
            this.txt_designation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_designation.CustomButton.UseSelectable = true;
            this.txt_designation.CustomButton.Visible = false;
            this.txt_designation.Enabled = false;
            this.txt_designation.Lines = new string[0];
            this.txt_designation.Location = new System.Drawing.Point(235, 158);
            this.txt_designation.MaxLength = 32767;
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.PasswordChar = '\0';
            this.txt_designation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_designation.SelectedText = "";
            this.txt_designation.SelectionLength = 0;
            this.txt_designation.SelectionStart = 0;
            this.txt_designation.ShortcutsEnabled = true;
            this.txt_designation.Size = new System.Drawing.Size(280, 23);
            this.txt_designation.TabIndex = 17;
            this.txt_designation.UseSelectable = true;
            this.txt_designation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_designation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_designation.TextChanged += new System.EventHandler(this.txt_designation_TextChanged);
            // 
            // txt_lName
            // 
            // 
            // 
            // 
            this.txt_lName.CustomButton.Image = null;
            this.txt_lName.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.txt_lName.CustomButton.Name = "";
            this.txt_lName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lName.CustomButton.TabIndex = 1;
            this.txt_lName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lName.CustomButton.UseSelectable = true;
            this.txt_lName.CustomButton.Visible = false;
            this.txt_lName.Enabled = false;
            this.txt_lName.Lines = new string[0];
            this.txt_lName.Location = new System.Drawing.Point(235, 119);
            this.txt_lName.MaxLength = 32767;
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.PasswordChar = '\0';
            this.txt_lName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lName.SelectedText = "";
            this.txt_lName.SelectionLength = 0;
            this.txt_lName.SelectionStart = 0;
            this.txt_lName.ShortcutsEnabled = true;
            this.txt_lName.Size = new System.Drawing.Size(280, 23);
            this.txt_lName.TabIndex = 16;
            this.txt_lName.UseSelectable = true;
            this.txt_lName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(25, 162);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(77, 19);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Designation";
            // 
            // txt_empFName
            // 
            // 
            // 
            // 
            this.txt_empFName.CustomButton.Image = null;
            this.txt_empFName.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.txt_empFName.CustomButton.Name = "";
            this.txt_empFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empFName.CustomButton.TabIndex = 1;
            this.txt_empFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empFName.CustomButton.UseSelectable = true;
            this.txt_empFName.CustomButton.Visible = false;
            this.txt_empFName.Enabled = false;
            this.txt_empFName.Lines = new string[0];
            this.txt_empFName.Location = new System.Drawing.Point(235, 90);
            this.txt_empFName.MaxLength = 32767;
            this.txt_empFName.Name = "txt_empFName";
            this.txt_empFName.PasswordChar = '\0';
            this.txt_empFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empFName.SelectedText = "";
            this.txt_empFName.SelectionLength = 0;
            this.txt_empFName.SelectionStart = 0;
            this.txt_empFName.ShortcutsEnabled = true;
            this.txt_empFName.Size = new System.Drawing.Size(280, 23);
            this.txt_empFName.TabIndex = 15;
            this.txt_empFName.UseSelectable = true;
            this.txt_empFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empFName.TextChanged += new System.EventHandler(this.txt_empFName_TextChanged);
            // 
            // cmb_purchID
            // 
            this.cmb_purchID.FormattingEnabled = true;
            this.cmb_purchID.Location = new System.Drawing.Point(235, 14);
            this.cmb_purchID.Name = "cmb_purchID";
            this.cmb_purchID.Size = new System.Drawing.Size(215, 21);
            this.cmb_purchID.TabIndex = 14;
            this.cmb_purchID.SelectedIndexChanged += new System.EventHandler(this.cmb_purchID_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(27, 119);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(136, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "                               :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Purchase ID";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(138, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Employee Name       :";
            // 
            // AvailableRawMaterialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 586);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvailableRawMaterialScreen";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.AvailableRawMaterialScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_InfoThrowData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_time;
        private MetroFramework.Controls.MetroTextBox txt_date;
        private MetroFramework.Controls.MetroTextBox txt_itemNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txt_lName;
        private MetroFramework.Controls.MetroTextBox txt_empFName;
        private System.Windows.Forms.ComboBox cmb_purchID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_designation;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txt_availableQty;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView grid_InfoThrowData;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton btn_OK;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_empID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroTextBox txt_qtyrequired;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroTextBox txt_itemName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.Panel itemIDSearch;
        private MetroFramework.Controls.MetroTextBox txtItemID;
        private MetroFramework.Controls.MetroTextBox txtWarehouse;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index3;
    }
}