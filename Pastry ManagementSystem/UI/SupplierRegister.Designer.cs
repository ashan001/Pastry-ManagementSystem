namespace Pastry_ManagementSystem.UI
{
    partial class SupplierRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierRegister));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FormValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error_empInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.FormValidator2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.formValidator3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Search = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_comments = new System.Windows.Forms.RichTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_siteName = new MetroFramework.Controls.MetroTextBox();
            this.txt_faxNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.dtp_regDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_nic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_contactNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_city = new MetroFramework.Controls.MetroTextBox();
            this.txt_line2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_line1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_companyName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_lastName = new MetroFramework.Controls.MetroTextBox();
            this.txt_firstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_suppID = new MetroFramework.Controls.MetroTextBox();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.FormValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_empInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormValidator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValidator3)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormValidator
            // 
            this.FormValidator.ContainerControl = this;
            // 
            // Error_empInfo
            // 
            this.Error_empInfo.ContainerControl = this;
            // 
            // FormValidator2
            // 
            this.FormValidator2.ContainerControl = this;
            // 
            // formValidator3
            // 
            this.formValidator3.ContainerControl = this;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btn_Search);
            this.metroPanel1.Controls.Add(this.btn_back);
            this.metroPanel1.Controls.Add(this.btn_update);
            this.metroPanel1.Controls.Add(this.btn_save);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.txt_suppID);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1113, 587);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Location = new System.Drawing.Point(337, 509);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 32);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseSelectable = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(500, 509);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(129, 32);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Location = new System.Drawing.Point(169, 509);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 32);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update Supplier Detials";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(7, 509);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 32);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save Supplier details";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxt_comments);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.txt_siteName);
            this.groupBox2.Controls.Add(this.txt_faxNum);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.dtp_regDate);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Location = new System.Drawing.Point(580, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 436);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // rtxt_comments
            // 
            this.rtxt_comments.Location = new System.Drawing.Point(179, 227);
            this.rtxt_comments.Name = "rtxt_comments";
            this.rtxt_comments.Size = new System.Drawing.Size(272, 78);
            this.rtxt_comments.TabIndex = 12;
            this.rtxt_comments.Text = "";
            this.rtxt_comments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxt_comments_KeyPress);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(7, 226);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(73, 19);
            this.metroLabel16.TabIndex = 11;
            this.metroLabel16.Text = "Comments";
            // 
            // txt_siteName
            // 
            // 
            // 
            // 
            this.txt_siteName.CustomButton.Image = null;
            this.txt_siteName.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_siteName.CustomButton.Name = "";
            this.txt_siteName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_siteName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_siteName.CustomButton.TabIndex = 1;
            this.txt_siteName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_siteName.CustomButton.UseSelectable = true;
            this.txt_siteName.CustomButton.Visible = false;
            this.txt_siteName.Lines = new string[0];
            this.txt_siteName.Location = new System.Drawing.Point(179, 162);
            this.txt_siteName.MaxLength = 32767;
            this.txt_siteName.Name = "txt_siteName";
            this.txt_siteName.PasswordChar = '\0';
            this.txt_siteName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_siteName.SelectedText = "";
            this.txt_siteName.SelectionLength = 0;
            this.txt_siteName.SelectionStart = 0;
            this.txt_siteName.ShortcutsEnabled = true;
            this.txt_siteName.Size = new System.Drawing.Size(272, 23);
            this.txt_siteName.TabIndex = 10;
            this.txt_siteName.UseSelectable = true;
            this.txt_siteName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_siteName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_siteName.TextChanged += new System.EventHandler(this.txt_siteName_TextChanged);
            // 
            // txt_faxNum
            // 
            // 
            // 
            // 
            this.txt_faxNum.CustomButton.Image = null;
            this.txt_faxNum.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_faxNum.CustomButton.Name = "";
            this.txt_faxNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_faxNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_faxNum.CustomButton.TabIndex = 1;
            this.txt_faxNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_faxNum.CustomButton.UseSelectable = true;
            this.txt_faxNum.CustomButton.Visible = false;
            this.txt_faxNum.Lines = new string[0];
            this.txt_faxNum.Location = new System.Drawing.Point(179, 109);
            this.txt_faxNum.MaxLength = 10;
            this.txt_faxNum.Name = "txt_faxNum";
            this.txt_faxNum.PasswordChar = '\0';
            this.txt_faxNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_faxNum.SelectedText = "";
            this.txt_faxNum.SelectionLength = 0;
            this.txt_faxNum.SelectionStart = 0;
            this.txt_faxNum.ShortcutsEnabled = true;
            this.txt_faxNum.Size = new System.Drawing.Size(272, 23);
            this.txt_faxNum.TabIndex = 9;
            this.txt_faxNum.UseSelectable = true;
            this.txt_faxNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_faxNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_faxNum.TextChanged += new System.EventHandler(this.txt_faxNum_TextChanged);
            this.txt_faxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_faxNum_KeyPress);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(6, 162);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(101, 19);
            this.metroLabel15.TabIndex = 8;
            this.metroLabel15.Text = "Web Site Name";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(6, 113);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 19);
            this.metroLabel14.TabIndex = 7;
            this.metroLabel14.Text = "Fax Number";
            // 
            // dtp_regDate
            // 
            this.dtp_regDate.Location = new System.Drawing.Point(179, 45);
            this.dtp_regDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_regDate.Name = "dtp_regDate";
            this.dtp_regDate.Size = new System.Drawing.Size(272, 29);
            this.dtp_regDate.TabIndex = 6;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(6, 51);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(102, 19);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Registered Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.txt_nic);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.txt_contactNum);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txt_city);
            this.groupBox1.Controls.Add(this.txt_line2);
            this.groupBox1.Controls.Add(this.txt_line1);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txt_companyName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txt_lastName);
            this.groupBox1.Controls.Add(this.txt_firstName);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 436);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(253, 390);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(272, 23);
            this.txt_email.TabIndex = 19;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(12, 394);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(98, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "E-Mail Address";
            // 
            // txt_nic
            // 
            // 
            // 
            // 
            this.txt_nic.CustomButton.Image = null;
            this.txt_nic.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_nic.CustomButton.Name = "";
            this.txt_nic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nic.CustomButton.TabIndex = 1;
            this.txt_nic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nic.CustomButton.UseSelectable = true;
            this.txt_nic.CustomButton.Visible = false;
            this.txt_nic.Lines = new string[0];
            this.txt_nic.Location = new System.Drawing.Point(253, 345);
            this.txt_nic.MaxLength = 10;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.PasswordChar = '\0';
            this.txt_nic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nic.SelectedText = "";
            this.txt_nic.SelectionLength = 0;
            this.txt_nic.SelectionStart = 0;
            this.txt_nic.ShortcutsEnabled = true;
            this.txt_nic.Size = new System.Drawing.Size(272, 23);
            this.txt_nic.TabIndex = 17;
            this.txt_nic.UseSelectable = true;
            this.txt_nic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nic.TextChanged += new System.EventHandler(this.txt_nic_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(12, 349);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(74, 19);
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Person NIC";
            // 
            // txt_contactNum
            // 
            // 
            // 
            // 
            this.txt_contactNum.CustomButton.Image = null;
            this.txt_contactNum.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_contactNum.CustomButton.Name = "";
            this.txt_contactNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contactNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contactNum.CustomButton.TabIndex = 1;
            this.txt_contactNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contactNum.CustomButton.UseSelectable = true;
            this.txt_contactNum.CustomButton.Visible = false;
            this.txt_contactNum.Lines = new string[0];
            this.txt_contactNum.Location = new System.Drawing.Point(253, 300);
            this.txt_contactNum.MaxLength = 10;
            this.txt_contactNum.Name = "txt_contactNum";
            this.txt_contactNum.PasswordChar = '\0';
            this.txt_contactNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contactNum.SelectedText = "";
            this.txt_contactNum.SelectionLength = 0;
            this.txt_contactNum.SelectionStart = 0;
            this.txt_contactNum.ShortcutsEnabled = true;
            this.txt_contactNum.Size = new System.Drawing.Size(272, 23);
            this.txt_contactNum.TabIndex = 15;
            this.txt_contactNum.UseSelectable = true;
            this.txt_contactNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contactNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contactNum.TextChanged += new System.EventHandler(this.txt_contactNum_TextChanged);
            this.txt_contactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactNum_KeyPress);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 300);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Contact Number";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(174, 255);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(28, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "city";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(174, 226);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "line 2";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(174, 197);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "line 1";
            // 
            // txt_city
            // 
            // 
            // 
            // 
            this.txt_city.CustomButton.Image = null;
            this.txt_city.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_city.CustomButton.Name = "";
            this.txt_city.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_city.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_city.CustomButton.TabIndex = 1;
            this.txt_city.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_city.CustomButton.UseSelectable = true;
            this.txt_city.CustomButton.Visible = false;
            this.txt_city.Lines = new string[0];
            this.txt_city.Location = new System.Drawing.Point(253, 251);
            this.txt_city.MaxLength = 32767;
            this.txt_city.Name = "txt_city";
            this.txt_city.PasswordChar = '\0';
            this.txt_city.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_city.SelectedText = "";
            this.txt_city.SelectionLength = 0;
            this.txt_city.SelectionStart = 0;
            this.txt_city.ShortcutsEnabled = true;
            this.txt_city.Size = new System.Drawing.Size(272, 23);
            this.txt_city.TabIndex = 10;
            this.txt_city.UseSelectable = true;
            this.txt_city.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_city.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_city.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            // 
            // txt_line2
            // 
            // 
            // 
            // 
            this.txt_line2.CustomButton.Image = null;
            this.txt_line2.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_line2.CustomButton.Name = "";
            this.txt_line2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_line2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_line2.CustomButton.TabIndex = 1;
            this.txt_line2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_line2.CustomButton.UseSelectable = true;
            this.txt_line2.CustomButton.Visible = false;
            this.txt_line2.Lines = new string[0];
            this.txt_line2.Location = new System.Drawing.Point(253, 222);
            this.txt_line2.MaxLength = 32767;
            this.txt_line2.Name = "txt_line2";
            this.txt_line2.PasswordChar = '\0';
            this.txt_line2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_line2.SelectedText = "";
            this.txt_line2.SelectionLength = 0;
            this.txt_line2.SelectionStart = 0;
            this.txt_line2.ShortcutsEnabled = true;
            this.txt_line2.Size = new System.Drawing.Size(272, 23);
            this.txt_line2.TabIndex = 9;
            this.txt_line2.UseSelectable = true;
            this.txt_line2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_line2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_line2.TextChanged += new System.EventHandler(this.txt_line2_TextChanged);
            // 
            // txt_line1
            // 
            // 
            // 
            // 
            this.txt_line1.CustomButton.Image = null;
            this.txt_line1.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_line1.CustomButton.Name = "";
            this.txt_line1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_line1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_line1.CustomButton.TabIndex = 1;
            this.txt_line1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_line1.CustomButton.UseSelectable = true;
            this.txt_line1.CustomButton.Visible = false;
            this.txt_line1.Lines = new string[0];
            this.txt_line1.Location = new System.Drawing.Point(253, 193);
            this.txt_line1.MaxLength = 32767;
            this.txt_line1.Name = "txt_line1";
            this.txt_line1.PasswordChar = '\0';
            this.txt_line1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_line1.SelectedText = "";
            this.txt_line1.SelectionLength = 0;
            this.txt_line1.SelectionStart = 0;
            this.txt_line1.ShortcutsEnabled = true;
            this.txt_line1.Size = new System.Drawing.Size(272, 23);
            this.txt_line1.TabIndex = 8;
            this.txt_line1.UseSelectable = true;
            this.txt_line1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_line1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_line1.TextChanged += new System.EventHandler(this.txt_line1_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 197);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(127, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Company Address -";
            // 
            // txt_companyName
            // 
            // 
            // 
            // 
            this.txt_companyName.CustomButton.Image = null;
            this.txt_companyName.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_companyName.CustomButton.Name = "";
            this.txt_companyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_companyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_companyName.CustomButton.TabIndex = 1;
            this.txt_companyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_companyName.CustomButton.UseSelectable = true;
            this.txt_companyName.CustomButton.Visible = false;
            this.txt_companyName.Lines = new string[0];
            this.txt_companyName.Location = new System.Drawing.Point(253, 142);
            this.txt_companyName.MaxLength = 32767;
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.PasswordChar = '\0';
            this.txt_companyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_companyName.SelectedText = "";
            this.txt_companyName.SelectionLength = 0;
            this.txt_companyName.SelectionStart = 0;
            this.txt_companyName.ShortcutsEnabled = true;
            this.txt_companyName.Size = new System.Drawing.Size(272, 23);
            this.txt_companyName.TabIndex = 6;
            this.txt_companyName.UseSelectable = true;
            this.txt_companyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_companyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_companyName.TextChanged += new System.EventHandler(this.txt_companyName_TextChanged);
            this.txt_companyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_companyName_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Company Name";
            // 
            // txt_lastName
            // 
            // 
            // 
            // 
            this.txt_lastName.CustomButton.Image = null;
            this.txt_lastName.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_lastName.CustomButton.Name = "";
            this.txt_lastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lastName.CustomButton.TabIndex = 1;
            this.txt_lastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lastName.CustomButton.UseSelectable = true;
            this.txt_lastName.CustomButton.Visible = false;
            this.txt_lastName.Lines = new string[0];
            this.txt_lastName.Location = new System.Drawing.Point(253, 97);
            this.txt_lastName.MaxLength = 32767;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.PasswordChar = '\0';
            this.txt_lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lastName.SelectedText = "";
            this.txt_lastName.SelectionLength = 0;
            this.txt_lastName.SelectionStart = 0;
            this.txt_lastName.ShortcutsEnabled = true;
            this.txt_lastName.Size = new System.Drawing.Size(272, 23);
            this.txt_lastName.TabIndex = 4;
            this.txt_lastName.UseSelectable = true;
            this.txt_lastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            this.txt_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lastName_KeyPress);
            // 
            // txt_firstName
            // 
            // 
            // 
            // 
            this.txt_firstName.CustomButton.Image = null;
            this.txt_firstName.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_firstName.CustomButton.Name = "";
            this.txt_firstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_firstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_firstName.CustomButton.TabIndex = 1;
            this.txt_firstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_firstName.CustomButton.UseSelectable = true;
            this.txt_firstName.CustomButton.Visible = false;
            this.txt_firstName.Lines = new string[0];
            this.txt_firstName.Location = new System.Drawing.Point(253, 51);
            this.txt_firstName.MaxLength = 32767;
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PasswordChar = '\0';
            this.txt_firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_firstName.SelectedText = "";
            this.txt_firstName.SelectionLength = 0;
            this.txt_firstName.SelectionStart = 0;
            this.txt_firstName.ShortcutsEnabled = true;
            this.txt_firstName.Size = new System.Drawing.Size(272, 23);
            this.txt_firstName.TabIndex = 3;
            this.txt_firstName.UseSelectable = true;
            this.txt_firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            this.txt_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_firstName_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Supplier Last Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Supplier FIrst Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(12, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Supplier Details";
            // 
            // txt_suppID
            // 
            // 
            // 
            // 
            this.txt_suppID.CustomButton.Image = null;
            this.txt_suppID.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txt_suppID.CustomButton.Name = "";
            this.txt_suppID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_suppID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_suppID.CustomButton.TabIndex = 1;
            this.txt_suppID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_suppID.CustomButton.UseSelectable = true;
            this.txt_suppID.CustomButton.Visible = false;
            this.txt_suppID.Enabled = false;
            this.txt_suppID.Lines = new string[0];
            this.txt_suppID.Location = new System.Drawing.Point(780, 37);
            this.txt_suppID.MaxLength = 32767;
            this.txt_suppID.Name = "txt_suppID";
            this.txt_suppID.PasswordChar = '\0';
            this.txt_suppID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_suppID.SelectedText = "";
            this.txt_suppID.SelectionLength = 0;
            this.txt_suppID.SelectionStart = 0;
            this.txt_suppID.ShortcutsEnabled = true;
            this.txt_suppID.Size = new System.Drawing.Size(292, 23);
            this.txt_suppID.TabIndex = 4;
            this.txt_suppID.UseSelectable = true;
            this.txt_suppID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_suppID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(11, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(239, 25);
            this.lbl_welcome.TabIndex = 14;
            this.lbl_welcome.Text = "Supplier Registration Form";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(580, 37);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(138, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Genarated Supplier ID";
            // 
            // SupplierRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 574);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierRegister";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SupplierRegister";
            this.Load += new System.EventHandler(this.SupplierRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_empInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormValidator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formValidator3)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_city;
        private MetroFramework.Controls.MetroTextBox txt_line2;
        private MetroFramework.Controls.MetroTextBox txt_line1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_companyName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_lastName;
        private MetroFramework.Controls.MetroTextBox txt_firstName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_nic;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_contactNum;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txt_suppID;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txt_siteName;
        private MetroFramework.Controls.MetroTextBox txt_faxNum;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroDateTime dtp_regDate;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.RichTextBox rtxt_comments;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider FormValidator;
        private System.Windows.Forms.ErrorProvider Error_empInfo;
        private System.Windows.Forms.ErrorProvider FormValidator2;
        private System.Windows.Forms.ErrorProvider formValidator3;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_Search;
    }
}