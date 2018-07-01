namespace PMS.Inventory.InvMaster
{
    partial class InventoryMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt_itemDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemIDSearch = new System.Windows.Forms.Panel();
            this.txtReorderLvl = new System.Windows.Forms.TextBox();
            this.txtRequiredQty = new System.Windows.Forms.TextBox();
            this.txtPurchasedQty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_storage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_shelfLife = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_unitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WarehouseSearch = new System.Windows.Forms.Panel();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.chkBoxCon = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(142, 34);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(243, 22);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Description";
            // 
            // rtxt_itemDesc
            // 
            this.rtxt_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_itemDesc.Location = new System.Drawing.Point(142, 90);
            this.rtxt_itemDesc.Name = "rtxt_itemDesc";
            this.rtxt_itemDesc.Size = new System.Drawing.Size(482, 73);
            this.rtxt_itemDesc.TabIndex = 2;
            this.rtxt_itemDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(142, 62);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(482, 22);
            this.txt_itemName.TabIndex = 1;
            this.txt_itemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itemName_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemIDSearch);
            this.groupBox1.Controls.Add(this.txtReorderLvl);
            this.groupBox1.Controls.Add(this.txtRequiredQty);
            this.groupBox1.Controls.Add(this.txtPurchasedQty);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_storage);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_shelfLife);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_unitPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_group);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtxt_itemDesc);
            this.groupBox1.Controls.Add(this.txtItemCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_itemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 325);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // itemIDSearch
            // 
            this.itemIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemIDSearch.BackgroundImage")));
            this.itemIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itemIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemIDSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemIDSearch.Location = new System.Drawing.Point(352, 34);
            this.itemIDSearch.Name = "itemIDSearch";
            this.itemIDSearch.Size = new System.Drawing.Size(33, 22);
            this.itemIDSearch.TabIndex = 22;
            this.itemIDSearch.Click += new System.EventHandler(this.itemIDSearch_Click);
            // 
            // txtReorderLvl
            // 
            this.txtReorderLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderLvl.Location = new System.Drawing.Point(142, 283);
            this.txtReorderLvl.Name = "txtReorderLvl";
            this.txtReorderLvl.Size = new System.Drawing.Size(211, 22);
            this.txtReorderLvl.TabIndex = 9;
            // 
            // txtRequiredQty
            // 
            this.txtRequiredQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredQty.Location = new System.Drawing.Point(142, 255);
            this.txtRequiredQty.Name = "txtRequiredQty";
            this.txtRequiredQty.Size = new System.Drawing.Size(211, 22);
            this.txtRequiredQty.TabIndex = 8;
            // 
            // txtPurchasedQty
            // 
            this.txtPurchasedQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasedQty.Location = new System.Drawing.Point(142, 227);
            this.txtPurchasedQty.Name = "txtPurchasedQty";
            this.txtPurchasedQty.Size = new System.Drawing.Size(211, 22);
            this.txtPurchasedQty.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 22);
            this.label15.TabIndex = 17;
            this.label15.Text = "Purchased Qty";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 22);
            this.label14.TabIndex = 16;
            this.label14.Text = "Required Qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "Re-Order Level";
            // 
            // txt_storage
            // 
            this.txt_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storage.Location = new System.Drawing.Point(142, 199);
            this.txt_storage.Name = "txt_storage";
            this.txt_storage.Size = new System.Drawing.Size(211, 22);
            this.txt_storage.TabIndex = 5;
            this.txt_storage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_storage_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Storage";
            // 
            // txt_shelfLife
            // 
            this.txt_shelfLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shelfLife.Location = new System.Drawing.Point(460, 199);
            this.txt_shelfLife.Name = "txt_shelfLife";
            this.txt_shelfLife.Size = new System.Drawing.Size(164, 22);
            this.txt_shelfLife.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Shelf Life";
            // 
            // txt_unitPrice
            // 
            this.txt_unitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitPrice.Location = new System.Drawing.Point(460, 171);
            this.txt_unitPrice.Name = "txt_unitPrice";
            this.txt_unitPrice.Size = new System.Drawing.Size(164, 22);
            this.txt_unitPrice.TabIndex = 4;
            this.txt_unitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unitPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit Price ";
            // 
            // cmb_group
            // 
            this.cmb_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Items.AddRange(new object[] {
            "Grocery Items",
            "perishable foods",
            "Non - perishable foods",
            "Milk",
            "Semi - perishable foods",
            "Vegetables",
            "Ingredients"});
            this.cmb_group.Location = new System.Drawing.Point(142, 169);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(211, 23);
            this.cmb_group.TabIndex = 3;
            this.cmb_group.SelectedIndexChanged += new System.EventHandler(this.cmb_group_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Select Warehouse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WarehouseSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtWarehouse);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(648, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 111);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warehouse Info";
            // 
            // WarehouseSearch
            // 
            this.WarehouseSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WarehouseSearch.BackgroundImage")));
            this.WarehouseSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WarehouseSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WarehouseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WarehouseSearch.Location = new System.Drawing.Point(365, 48);
            this.WarehouseSearch.Name = "WarehouseSearch";
            this.WarehouseSearch.Size = new System.Drawing.Size(33, 22);
            this.WarehouseSearch.TabIndex = 22;
            this.WarehouseSearch.Click += new System.EventHandler(this.WarehouseSearch_Click);
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouse.Location = new System.Drawing.Point(155, 48);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.Size = new System.Drawing.Size(243, 22);
            this.txtWarehouse.TabIndex = 0;
            this.txtWarehouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWarehouse_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_todate);
            this.groupBox3.Controls.Add(this.dtp_fromdate);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(648, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 140);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage Duration";
            // 
            // dtp_todate
            // 
            this.dtp_todate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_todate.CustomFormat = "dd/MMM/yyyyy";
            this.dtp_todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_todate.Location = new System.Drawing.Point(201, 86);
            this.dtp_todate.MinDate = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(184, 22);
            this.dtp_todate.TabIndex = 1;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_fromdate.CustomFormat = "dd/MMM/yyyyy";
            this.dtp_fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fromdate.Location = new System.Drawing.Point(201, 40);
            this.dtp_fromdate.MaxDate = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            this.dtp_fromdate.MinDate = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(184, 22);
            this.dtp_fromdate.TabIndex = 0;
            this.dtp_fromdate.Value = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "To Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "From Date";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkBox);
            this.groupBox4.Controls.Add(this.chkBoxCon);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(648, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 62);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Condition Info";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBox.Location = new System.Drawing.Point(231, 27);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(15, 14);
            this.chkBox.TabIndex = 1;
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.CheckedChanged += new System.EventHandler(this.chkBox_CheckedChanged);
            // 
            // chkBoxCon
            // 
            this.chkBoxCon.AutoSize = true;
            this.chkBoxCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxCon.Location = new System.Drawing.Point(57, 27);
            this.chkBoxCon.Name = "chkBoxCon";
            this.chkBoxCon.Size = new System.Drawing.Size(15, 14);
            this.chkBoxCon.TabIndex = 0;
            this.chkBoxCon.UseVisualStyleBackColor = true;
            this.chkBoxCon.CheckedChanged += new System.EventHandler(this.chkBoxCon_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(271, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Dis -Continue";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(93, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Continue";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_submit.Location = new System.Drawing.Point(11, 343);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(88, 41);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(293, 343);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 41);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(105, 343);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 41);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Refresh.Location = new System.Drawing.Point(199, 343);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(88, 41);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Referesh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // InventoryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1062, 391);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryMaster";
            this.Text = "Inventory Master";
            this.Load += new System.EventHandler(this.InventoryMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt_itemDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_shelfLife;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_unitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_storage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_todate;
        private System.Windows.Forms.DateTimePicker dtp_fromdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.CheckBox chkBoxCon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txtReorderLvl;
        private System.Windows.Forms.TextBox txtRequiredQty;
        private System.Windows.Forms.TextBox txtPurchasedQty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel itemIDSearch;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel WarehouseSearch;
        private System.Windows.Forms.TextBox txtWarehouse;
    }
}