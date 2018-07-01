namespace Pastry_ManagementSystem.UI
{
    partial class CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrder));
            this.t_timer = new System.Windows.Forms.Timer(this.components);
            this.ErrorPro_1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_orderDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_Back = new MetroFramework.Controls.MetroButton();
            this.btn_order = new MetroFramework.Controls.MetroButton();
            this.lbl_Time = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotAmt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_itemPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.cmb_foodName = new System.Windows.Forms.ComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.dtp_dueDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txt_time = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.rtxt_box1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_regDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_CusID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_line1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_lName = new MetroFramework.Controls.MetroTextBox();
            this.txt_fName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_contact = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPro_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_timer
            // 
            this.t_timer.Tick += new System.EventHandler(this.t_timer_Tick);
            // 
            // ErrorPro_1
            // 
            this.ErrorPro_1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dtp_orderDate);
            this.panel1.Controls.Add(this.metroLabel17);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 594);
            this.panel1.TabIndex = 0;
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.Location = new System.Drawing.Point(496, 62);
            this.dtp_orderDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(192, 29);
            this.dtp_orderDate.TabIndex = 25;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(378, 67);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(91, 19);
            this.metroLabel17.TabIndex = 24;
            this.metroLabel17.Text = "Ordered Date";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(114, 66);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(233, 20);
            this.txt_id.TabIndex = 23;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Back.Location = new System.Drawing.Point(165, 537);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(128, 44);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseSelectable = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_order
            // 
            this.btn_order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_order.BackgroundImage")));
            this.btn_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_order.Location = new System.Drawing.Point(13, 537);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(128, 44);
            this.btn_order.TabIndex = 21;
            this.btn_order.Text = "Save Order";
            this.btn_order.UseSelectable = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Time.Location = new System.Drawing.Point(1120, 13);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(108, 19);
            this.lbl_Time.TabIndex = 20;
            this.lbl_Time.Text = "Date And Time";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(1072, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Time";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(726, 110);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(98, 19);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Order Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotAmt);
            this.groupBox2.Controls.Add(this.metroLabel19);
            this.groupBox2.Controls.Add(this.txt_itemPrice);
            this.groupBox2.Controls.Add(this.metroLabel18);
            this.groupBox2.Controls.Add(this.cmb_foodName);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.txt_qty);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.dtp_dueDate);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.txt_time);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Location = new System.Drawing.Point(704, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 419);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // txtTotAmt
            // 
            // 
            // 
            // 
            this.txtTotAmt.CustomButton.Image = null;
            this.txtTotAmt.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtTotAmt.CustomButton.Name = "";
            this.txtTotAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotAmt.CustomButton.TabIndex = 1;
            this.txtTotAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotAmt.CustomButton.UseSelectable = true;
            this.txtTotAmt.CustomButton.Visible = false;
            this.txtTotAmt.Enabled = false;
            this.txtTotAmt.Lines = new string[0];
            this.txtTotAmt.Location = new System.Drawing.Point(295, 324);
            this.txtTotAmt.MaxLength = 32767;
            this.txtTotAmt.Name = "txtTotAmt";
            this.txtTotAmt.PasswordChar = '\0';
            this.txtTotAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotAmt.SelectedText = "";
            this.txtTotAmt.SelectionLength = 0;
            this.txtTotAmt.SelectionStart = 0;
            this.txtTotAmt.ShortcutsEnabled = true;
            this.txtTotAmt.Size = new System.Drawing.Size(261, 23);
            this.txtTotAmt.TabIndex = 13;
            this.txtTotAmt.UseSelectable = true;
            this.txtTotAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotAmt.TextChanged += new System.EventHandler(this.txtTotAmt_TextChanged);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(30, 322);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(87, 19);
            this.metroLabel19.TabIndex = 12;
            this.metroLabel19.Text = "Total Amount";
            // 
            // txt_itemPrice
            // 
            // 
            // 
            // 
            this.txt_itemPrice.CustomButton.Image = null;
            this.txt_itemPrice.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_itemPrice.CustomButton.Name = "";
            this.txt_itemPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemPrice.CustomButton.TabIndex = 1;
            this.txt_itemPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemPrice.CustomButton.UseSelectable = true;
            this.txt_itemPrice.CustomButton.Visible = false;
            this.txt_itemPrice.Enabled = false;
            this.txt_itemPrice.Lines = new string[0];
            this.txt_itemPrice.Location = new System.Drawing.Point(295, 206);
            this.txt_itemPrice.MaxLength = 32767;
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.PasswordChar = '\0';
            this.txt_itemPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemPrice.SelectedText = "";
            this.txt_itemPrice.SelectionLength = 0;
            this.txt_itemPrice.SelectionStart = 0;
            this.txt_itemPrice.ShortcutsEnabled = true;
            this.txt_itemPrice.Size = new System.Drawing.Size(261, 23);
            this.txt_itemPrice.TabIndex = 11;
            this.txt_itemPrice.UseSelectable = true;
            this.txt_itemPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemPrice.TextChanged += new System.EventHandler(this.txt_itemPrice_TextChanged);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(29, 210);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(68, 19);
            this.metroLabel18.TabIndex = 10;
            this.metroLabel18.Text = "Item Price";
            // 
            // cmb_foodName
            // 
            this.cmb_foodName.FormattingEnabled = true;
            this.cmb_foodName.Location = new System.Drawing.Point(295, 158);
            this.cmb_foodName.MaxDropDownItems = 20;
            this.cmb_foodName.Name = "cmb_foodName";
            this.cmb_foodName.Size = new System.Drawing.Size(261, 21);
            this.cmb_foodName.TabIndex = 9;
            this.cmb_foodName.SelectedIndexChanged += new System.EventHandler(this.cmb_foodName_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(29, 266);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(66, 19);
            this.metroLabel15.TabIndex = 8;
            this.metroLabel15.Text = "Quantity";
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.Enabled = false;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(295, 266);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(261, 23);
            this.txt_qty.TabIndex = 6;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(29, 160);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(118, 19);
            this.metroLabel14.TabIndex = 5;
            this.metroLabel14.Text = "Select Food Name";
            // 
            // dtp_dueDate
            // 
            this.dtp_dueDate.Location = new System.Drawing.Point(295, 37);
            this.dtp_dueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_dueDate.Name = "dtp_dueDate";
            this.dtp_dueDate.Size = new System.Drawing.Size(261, 29);
            this.dtp_dueDate.TabIndex = 4;
            this.dtp_dueDate.ValueChanged += new System.EventHandler(this.dtp_dueDate_ValueChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(29, 100);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(99, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Enter Due Time";
            // 
            // txt_time
            // 
            // 
            // 
            // 
            this.txt_time.CustomButton.Image = null;
            this.txt_time.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_time.CustomButton.Name = "";
            this.txt_time.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_time.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_time.CustomButton.TabIndex = 1;
            this.txt_time.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_time.CustomButton.UseSelectable = true;
            this.txt_time.CustomButton.Visible = false;
            this.txt_time.Lines = new string[0];
            this.txt_time.Location = new System.Drawing.Point(295, 96);
            this.txt_time.MaxLength = 32767;
            this.txt_time.Name = "txt_time";
            this.txt_time.PasswordChar = '\0';
            this.txt_time.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_time.SelectedText = "";
            this.txt_time.SelectionLength = 0;
            this.txt_time.SelectionStart = 0;
            this.txt_time.ShortcutsEnabled = true;
            this.txt_time.Size = new System.Drawing.Size(261, 23);
            this.txt_time.TabIndex = 2;
            this.txt_time.UseSelectable = true;
            this.txt_time.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_time.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_time.TextChanged += new System.EventHandler(this.txt_time_TextChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(29, 37);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(90, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Pick Due Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(29, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Customer Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_nic);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.rtxt_box1);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.txt_regDate);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txt_CusID);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.txt_line1);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txt_lName);
            this.groupBox1.Controls.Add(this.txt_fName);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 421);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txt_nic
            // 
            // 
            // 
            // 
            this.txt_nic.CustomButton.Image = null;
            this.txt_nic.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_nic.CustomButton.Name = "";
            this.txt_nic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nic.CustomButton.TabIndex = 1;
            this.txt_nic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nic.CustomButton.UseSelectable = true;
            this.txt_nic.CustomButton.Visible = false;
            this.txt_nic.Enabled = false;
            this.txt_nic.Lines = new string[0];
            this.txt_nic.Location = new System.Drawing.Point(380, 220);
            this.txt_nic.MaxLength = 32767;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.PasswordChar = '\0';
            this.txt_nic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nic.SelectedText = "";
            this.txt_nic.SelectionLength = 0;
            this.txt_nic.SelectionStart = 0;
            this.txt_nic.ShortcutsEnabled = true;
            this.txt_nic.Size = new System.Drawing.Size(261, 23);
            this.txt_nic.TabIndex = 20;
            this.txt_nic.UseSelectable = true;
            this.txt_nic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(55, 220);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(31, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "NIC";
            // 
            // rtxt_box1
            // 
            this.rtxt_box1.Enabled = false;
            this.rtxt_box1.Location = new System.Drawing.Point(380, 359);
            this.rtxt_box1.Name = "rtxt_box1";
            this.rtxt_box1.Size = new System.Drawing.Size(261, 56);
            this.rtxt_box1.TabIndex = 18;
            this.rtxt_box1.Text = "";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(55, 359);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Comments";
            // 
            // txt_regDate
            // 
            // 
            // 
            // 
            this.txt_regDate.CustomButton.Image = null;
            this.txt_regDate.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_regDate.CustomButton.Name = "";
            this.txt_regDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_regDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_regDate.CustomButton.TabIndex = 1;
            this.txt_regDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_regDate.CustomButton.UseSelectable = true;
            this.txt_regDate.CustomButton.Visible = false;
            this.txt_regDate.Enabled = false;
            this.txt_regDate.Lines = new string[0];
            this.txt_regDate.Location = new System.Drawing.Point(380, 317);
            this.txt_regDate.MaxLength = 32767;
            this.txt_regDate.Name = "txt_regDate";
            this.txt_regDate.PasswordChar = '\0';
            this.txt_regDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_regDate.SelectedText = "";
            this.txt_regDate.SelectionLength = 0;
            this.txt_regDate.SelectionStart = 0;
            this.txt_regDate.ShortcutsEnabled = true;
            this.txt_regDate.Size = new System.Drawing.Size(261, 23);
            this.txt_regDate.TabIndex = 16;
            this.txt_regDate.UseSelectable = true;
            this.txt_regDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_regDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(55, 317);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Registered Date";
            // 
            // txt_CusID
            // 
            // 
            // 
            // 
            this.txt_CusID.CustomButton.Image = null;
            this.txt_CusID.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_CusID.CustomButton.Name = "";
            this.txt_CusID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_CusID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CusID.CustomButton.TabIndex = 1;
            this.txt_CusID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CusID.CustomButton.UseSelectable = true;
            this.txt_CusID.CustomButton.Visible = false;
            this.txt_CusID.Enabled = false;
            this.txt_CusID.Lines = new string[0];
            this.txt_CusID.Location = new System.Drawing.Point(380, 75);
            this.txt_CusID.MaxLength = 32767;
            this.txt_CusID.Name = "txt_CusID";
            this.txt_CusID.PasswordChar = '\0';
            this.txt_CusID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CusID.SelectedText = "";
            this.txt_CusID.SelectionLength = 0;
            this.txt_CusID.SelectionStart = 0;
            this.txt_CusID.ShortcutsEnabled = true;
            this.txt_CusID.Size = new System.Drawing.Size(261, 23);
            this.txt_CusID.TabIndex = 14;
            this.txt_CusID.UseSelectable = true;
            this.txt_CusID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CusID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(55, 79);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(82, 19);
            this.metroLabel16.TabIndex = 13;
            this.metroLabel16.Text = "Customer ID";
            // 
            // txt_line1
            // 
            // 
            // 
            // 
            this.txt_line1.CustomButton.Image = null;
            this.txt_line1.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_line1.CustomButton.Name = "";
            this.txt_line1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_line1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_line1.CustomButton.TabIndex = 1;
            this.txt_line1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_line1.CustomButton.UseSelectable = true;
            this.txt_line1.CustomButton.Visible = false;
            this.txt_line1.Enabled = false;
            this.txt_line1.Lines = new string[0];
            this.txt_line1.Location = new System.Drawing.Point(380, 272);
            this.txt_line1.MaxLength = 32767;
            this.txt_line1.Name = "txt_line1";
            this.txt_line1.PasswordChar = '\0';
            this.txt_line1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_line1.SelectedText = "";
            this.txt_line1.SelectionLength = 0;
            this.txt_line1.SelectionStart = 0;
            this.txt_line1.ShortcutsEnabled = true;
            this.txt_line1.Size = new System.Drawing.Size(261, 23);
            this.txt_line1.TabIndex = 7;
            this.txt_line1.UseSelectable = true;
            this.txt_line1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_line1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(55, 272);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Address";
            // 
            // txt_lName
            // 
            // 
            // 
            // 
            this.txt_lName.CustomButton.Image = null;
            this.txt_lName.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_lName.CustomButton.Name = "";
            this.txt_lName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lName.CustomButton.TabIndex = 1;
            this.txt_lName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lName.CustomButton.UseSelectable = true;
            this.txt_lName.CustomButton.Visible = false;
            this.txt_lName.Enabled = false;
            this.txt_lName.Lines = new string[0];
            this.txt_lName.Location = new System.Drawing.Point(380, 171);
            this.txt_lName.MaxLength = 32767;
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.PasswordChar = '\0';
            this.txt_lName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lName.SelectedText = "";
            this.txt_lName.SelectionLength = 0;
            this.txt_lName.SelectionStart = 0;
            this.txt_lName.ShortcutsEnabled = true;
            this.txt_lName.Size = new System.Drawing.Size(261, 23);
            this.txt_lName.TabIndex = 5;
            this.txt_lName.UseSelectable = true;
            this.txt_lName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fName
            // 
            // 
            // 
            // 
            this.txt_fName.CustomButton.Image = null;
            this.txt_fName.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_fName.CustomButton.Name = "";
            this.txt_fName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_fName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fName.CustomButton.TabIndex = 1;
            this.txt_fName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fName.CustomButton.UseSelectable = true;
            this.txt_fName.CustomButton.Visible = false;
            this.txt_fName.Enabled = false;
            this.txt_fName.Lines = new string[0];
            this.txt_fName.Location = new System.Drawing.Point(380, 123);
            this.txt_fName.MaxLength = 32767;
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.PasswordChar = '\0';
            this.txt_fName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fName.SelectedText = "";
            this.txt_fName.SelectionLength = 0;
            this.txt_fName.SelectionStart = 0;
            this.txt_fName.ShortcutsEnabled = true;
            this.txt_fName.Size = new System.Drawing.Size(261, 23);
            this.txt_fName.TabIndex = 4;
            this.txt_fName.UseSelectable = true;
            this.txt_fName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(55, 175);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(132, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Customer Last Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(55, 123);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Customer First Name";
            // 
            // txt_contact
            // 
            // 
            // 
            // 
            this.txt_contact.CustomButton.Image = null;
            this.txt_contact.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_contact.CustomButton.Name = "";
            this.txt_contact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contact.CustomButton.TabIndex = 1;
            this.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contact.CustomButton.UseSelectable = true;
            this.txt_contact.CustomButton.Visible = false;
            this.txt_contact.Lines = new string[0];
            this.txt_contact.Location = new System.Drawing.Point(380, 35);
            this.txt_contact.MaxLength = 32767;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.PasswordChar = '\0';
            this.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contact.SelectedText = "";
            this.txt_contact.SelectionLength = 0;
            this.txt_contact.SelectionStart = 0;
            this.txt_contact.ShortcutsEnabled = true;
            this.txt_contact.Size = new System.Drawing.Size(261, 23);
            this.txt_contact.TabIndex = 1;
            this.txt_contact.UseSelectable = true;
            this.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(55, 39);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(199, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Enter customer Contact Number";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Order ID";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(12, 13);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(195, 25);
            this.lbl_welcome.TabIndex = 12;
            this.lbl_welcome.Text = "Customer Order Form";
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 625);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerOrder";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPro_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_line1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_lName;
        private MetroFramework.Controls.MetroTextBox txt_fName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_contact;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lbl_Time;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Timer t_timer;
        private MetroFramework.Controls.MetroTextBox txt_time;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime dtp_dueDate;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton btn_order;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroButton btn_Back;
        private System.Windows.Forms.ComboBox cmb_foodName;
        private System.Windows.Forms.ErrorProvider ErrorPro_1;
        private MetroFramework.Controls.MetroTextBox txt_CusID;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.TextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroDateTime dtp_orderDate;
        private MetroFramework.Controls.MetroTextBox txt_regDate;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.RichTextBox rtxt_box1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_nic;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_itemPrice;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txtTotAmt;
    }
}