namespace Pastry_ManagementSystem.UI
{
    partial class UpdateEmployee
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
            this.Open_picture = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.txt_empID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_empNIC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_contactNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.emp_picture = new System.Windows.Forms.PictureBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_address = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_salary = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_Age = new MetroFramework.Controls.MetroTextBox();
            this.cmb_desigType = new System.Windows.Forms.ComboBox();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_nic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_mobile = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_contact = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_lastName = new MetroFramework.Controls.MetroTextBox();
            this.txt_empName = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_picture)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_picture
            // 
            this.Open_picture.FileName = "openFileDialog1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.blue_gradient_wallpaper_hd_20_color2;
            this.metroPanel1.Controls.Add(this.btn_back);
            this.metroPanel1.Controls.Add(this.btn_update);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.groupBox3);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1284, 531);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources._1364243971_sign_out4;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(163, 478);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(143, 47);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources._1364243914_config;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_update.Location = new System.Drawing.Point(11, 478);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(143, 47);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update Employee";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(6, 11);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(252, 25);
            this.lbl_welcome.TabIndex = 18;
            this.lbl_welcome.Text = "Employee Registration Form";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.txt_empID);
            this.groupBox3.Controls.Add(this.metroLabel16);
            this.groupBox3.Controls.Add(this.txt_empNIC);
            this.groupBox3.Controls.Add(this.metroLabel14);
            this.groupBox3.Controls.Add(this.txt_contactNum);
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.metroLabel12);
            this.groupBox3.Location = new System.Drawing.Point(10, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1252, 117);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.Start_Menu_Search_icon;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(1166, 64);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 47);
            this.btn_search.TabIndex = 32;
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_empID
            // 
            // 
            // 
            // 
            this.txt_empID.CustomButton.Image = null;
            this.txt_empID.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txt_empID.CustomButton.Name = "";
            this.txt_empID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empID.CustomButton.TabIndex = 1;
            this.txt_empID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empID.CustomButton.UseSelectable = true;
            this.txt_empID.CustomButton.Visible = false;
            this.txt_empID.Lines = new string[0];
            this.txt_empID.Location = new System.Drawing.Point(980, 35);
            this.txt_empID.MaxLength = 32767;
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.PasswordChar = '\0';
            this.txt_empID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empID.SelectedText = "";
            this.txt_empID.SelectionLength = 0;
            this.txt_empID.SelectionStart = 0;
            this.txt_empID.ShortcutsEnabled = true;
            this.txt_empID.Size = new System.Drawing.Size(261, 23);
            this.txt_empID.TabIndex = 31;
            this.txt_empID.UseSelectable = true;
            this.txt_empID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(857, 35);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(83, 19);
            this.metroLabel16.TabIndex = 30;
            this.metroLabel16.Text = "Employee ID";
            // 
            // txt_empNIC
            // 
            // 
            // 
            // 
            this.txt_empNIC.CustomButton.Image = null;
            this.txt_empNIC.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txt_empNIC.CustomButton.Name = "";
            this.txt_empNIC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empNIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empNIC.CustomButton.TabIndex = 1;
            this.txt_empNIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empNIC.CustomButton.UseSelectable = true;
            this.txt_empNIC.CustomButton.Visible = false;
            this.txt_empNIC.Lines = new string[0];
            this.txt_empNIC.Location = new System.Drawing.Point(554, 35);
            this.txt_empNIC.MaxLength = 32767;
            this.txt_empNIC.Name = "txt_empNIC";
            this.txt_empNIC.PasswordChar = '\0';
            this.txt_empNIC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empNIC.SelectedText = "";
            this.txt_empNIC.SelectionLength = 0;
            this.txt_empNIC.SelectionStart = 0;
            this.txt_empNIC.ShortcutsEnabled = true;
            this.txt_empNIC.Size = new System.Drawing.Size(254, 23);
            this.txt_empNIC.TabIndex = 29;
            this.txt_empNIC.UseSelectable = true;
            this.txt_empNIC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empNIC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empNIC_KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(455, 35);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(93, 19);
            this.metroLabel14.TabIndex = 28;
            this.metroLabel14.Text = "Employee NIC";
            // 
            // txt_contactNum
            // 
            // 
            // 
            // 
            this.txt_contactNum.CustomButton.Image = null;
            this.txt_contactNum.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txt_contactNum.CustomButton.Name = "";
            this.txt_contactNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contactNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contactNum.CustomButton.TabIndex = 1;
            this.txt_contactNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contactNum.CustomButton.UseSelectable = true;
            this.txt_contactNum.CustomButton.Visible = false;
            this.txt_contactNum.Lines = new string[0];
            this.txt_contactNum.Location = new System.Drawing.Point(184, 35);
            this.txt_contactNum.MaxLength = 32767;
            this.txt_contactNum.Name = "txt_contactNum";
            this.txt_contactNum.PasswordChar = '\0';
            this.txt_contactNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contactNum.SelectedText = "";
            this.txt_contactNum.SelectionLength = 0;
            this.txt_contactNum.SelectionStart = 0;
            this.txt_contactNum.ShortcutsEnabled = true;
            this.txt_contactNum.Size = new System.Drawing.Size(251, 23);
            this.txt_contactNum.TabIndex = 27;
            this.txt_contactNum.UseSelectable = true;
            this.txt_contactNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contactNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contactNum_KeyPress);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(9, 35);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(169, 19);
            this.metroLabel13.TabIndex = 26;
            this.metroLabel13.Text = "Employee Contact Number";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(9, -3);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(54, 19);
            this.metroLabel12.TabIndex = 25;
            this.metroLabel12.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.emp_picture);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Location = new System.Drawing.Point(974, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 302);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources._1488538476_icontexto_aurora_folders_pictures;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(93, 239);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 57);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Add Photo";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // emp_picture
            // 
            this.emp_picture.BackColor = System.Drawing.Color.White;
            this.emp_picture.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.EmptyProfile;
            this.emp_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emp_picture.Location = new System.Drawing.Point(47, 22);
            this.emp_picture.Name = "emp_picture";
            this.emp_picture.Size = new System.Drawing.Size(204, 193);
            this.emp_picture.TabIndex = 17;
            this.emp_picture.TabStop = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(0, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(110, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Change Picture";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.metroLabel20);
            this.groupBox2.Controls.Add(this.dtp_dob);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.txt_salary);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txt_Age);
            this.groupBox2.Controls.Add(this.cmb_desigType);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.txt_nic);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txt_mobile);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txt_contact);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.txt_lastName);
            this.groupBox2.Controls.Add(this.txt_empName);
            this.groupBox2.Location = new System.Drawing.Point(11, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 302);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txt_address
            // 
            // 
            // 
            // 
            this.txt_address.CustomButton.Image = null;
            this.txt_address.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_address.CustomButton.Name = "";
            this.txt_address.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_address.CustomButton.TabIndex = 1;
            this.txt_address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_address.CustomButton.UseSelectable = true;
            this.txt_address.CustomButton.Visible = false;
            this.txt_address.Lines = new string[0];
            this.txt_address.Location = new System.Drawing.Point(666, 221);
            this.txt_address.MaxLength = 32767;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_address.SelectedText = "";
            this.txt_address.SelectionLength = 0;
            this.txt_address.SelectionStart = 0;
            this.txt_address.ShortcutsEnabled = true;
            this.txt_address.Size = new System.Drawing.Size(262, 23);
            this.txt_address.TabIndex = 10;
            this.txt_address.UseSelectable = true;
            this.txt_address.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_address.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(518, 225);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(56, 19);
            this.metroLabel20.TabIndex = 26;
            this.metroLabel20.Text = "Address";
            // 
            // dtp_dob
            // 
            this.dtp_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Location = new System.Drawing.Point(666, 131);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(262, 22);
            this.dtp_dob.TabIndex = 8;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(14, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(124, 19);
            this.metroLabel15.TabIndex = 24;
            this.metroLabel15.Text = "Employee Details";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Employee First Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Employee Last Name";
            // 
            // txt_salary
            // 
            // 
            // 
            // 
            this.txt_salary.CustomButton.Image = null;
            this.txt_salary.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_salary.CustomButton.Name = "";
            this.txt_salary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_salary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_salary.CustomButton.TabIndex = 1;
            this.txt_salary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_salary.CustomButton.UseSelectable = true;
            this.txt_salary.CustomButton.Visible = false;
            this.txt_salary.Lines = new string[0];
            this.txt_salary.Location = new System.Drawing.Point(173, 257);
            this.txt_salary.MaxLength = 32767;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.PasswordChar = '\0';
            this.txt_salary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_salary.SelectedText = "";
            this.txt_salary.SelectionLength = 0;
            this.txt_salary.SelectionStart = 0;
            this.txt_salary.ShortcutsEnabled = true;
            this.txt_salary.Size = new System.Drawing.Size(262, 23);
            this.txt_salary.TabIndex = 11;
            this.txt_salary.UseSelectable = true;
            this.txt_salary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_salary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 127);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Fix Contact Number";
            // 
            // txt_Age
            // 
            // 
            // 
            // 
            this.txt_Age.CustomButton.Image = null;
            this.txt_Age.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_Age.CustomButton.Name = "";
            this.txt_Age.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Age.CustomButton.TabIndex = 1;
            this.txt_Age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Age.CustomButton.UseSelectable = true;
            this.txt_Age.CustomButton.Visible = false;
            this.txt_Age.Enabled = false;
            this.txt_Age.Lines = new string[0];
            this.txt_Age.Location = new System.Drawing.Point(666, 174);
            this.txt_Age.MaxLength = 32767;
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.PasswordChar = '\0';
            this.txt_Age.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Age.SelectedText = "";
            this.txt_Age.SelectionLength = 0;
            this.txt_Age.SelectionStart = 0;
            this.txt_Age.ShortcutsEnabled = true;
            this.txt_Age.Size = new System.Drawing.Size(262, 23);
            this.txt_Age.TabIndex = 9;
            this.txt_Age.UseSelectable = true;
            this.txt_Age.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Age.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmb_desigType
            // 
            this.cmb_desigType.FormattingEnabled = true;
            this.cmb_desigType.Items.AddRange(new object[] {
            "Guest Services Manager",
            "Housekeeping Supervisor",
            "Food and Beverage Manager",
            "Executive Meeting Manager",
            "Catering Manager",
            "Catering Sales Manager",
            "Cafe Manager",
            "Back Office Assistant",
            "Room Service Worker",
            "Director of Operations",
            "Director of Maintenance",
            "Executive Housekeeper",
            "Restaurant Manager",
            "Chef"});
            this.cmb_desigType.Location = new System.Drawing.Point(666, 39);
            this.cmb_desigType.Name = "cmb_desigType";
            this.cmb_desigType.Size = new System.Drawing.Size(262, 21);
            this.cmb_desigType.TabIndex = 5;
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(666, 87);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(262, 23);
            this.txt_email.TabIndex = 7;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 261);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(76, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "Basic salary";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Mobile Number";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 221);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "NIC";
            // 
            // txt_nic
            // 
            // 
            // 
            // 
            this.txt_nic.CustomButton.Image = null;
            this.txt_nic.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_nic.CustomButton.Name = "";
            this.txt_nic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nic.CustomButton.TabIndex = 1;
            this.txt_nic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nic.CustomButton.UseSelectable = true;
            this.txt_nic.CustomButton.Visible = false;
            this.txt_nic.Lines = new string[0];
            this.txt_nic.Location = new System.Drawing.Point(173, 217);
            this.txt_nic.MaxLength = 32767;
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.PasswordChar = '\0';
            this.txt_nic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nic.SelectedText = "";
            this.txt_nic.SelectionLength = 0;
            this.txt_nic.SelectionStart = 0;
            this.txt_nic.ShortcutsEnabled = true;
            this.txt_nic.Size = new System.Drawing.Size(262, 23);
            this.txt_nic.TabIndex = 4;
            this.txt_nic.UseSelectable = true;
            this.txt_nic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(518, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Designation Type";
            // 
            // txt_mobile
            // 
            // 
            // 
            // 
            this.txt_mobile.CustomButton.Image = null;
            this.txt_mobile.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_mobile.CustomButton.Name = "";
            this.txt_mobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_mobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_mobile.CustomButton.TabIndex = 1;
            this.txt_mobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_mobile.CustomButton.UseSelectable = true;
            this.txt_mobile.CustomButton.Visible = false;
            this.txt_mobile.Lines = new string[0];
            this.txt_mobile.Location = new System.Drawing.Point(173, 174);
            this.txt_mobile.MaxLength = 32767;
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.PasswordChar = '\0';
            this.txt_mobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mobile.SelectedText = "";
            this.txt_mobile.SelectionLength = 0;
            this.txt_mobile.SelectionStart = 0;
            this.txt_mobile.ShortcutsEnabled = true;
            this.txt_mobile.Size = new System.Drawing.Size(262, 23);
            this.txt_mobile.TabIndex = 3;
            this.txt_mobile.UseSelectable = true;
            this.txt_mobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_mobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_mobile.TextChanged += new System.EventHandler(this.txt_mobile_TextChanged);
            this.txt_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobile_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(518, 87);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Email";
            // 
            // txt_contact
            // 
            // 
            // 
            // 
            this.txt_contact.CustomButton.Image = null;
            this.txt_contact.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_contact.CustomButton.Name = "";
            this.txt_contact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contact.CustomButton.TabIndex = 1;
            this.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contact.CustomButton.UseSelectable = true;
            this.txt_contact.CustomButton.Visible = false;
            this.txt_contact.Lines = new string[0];
            this.txt_contact.Location = new System.Drawing.Point(173, 127);
            this.txt_contact.MaxLength = 32767;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.PasswordChar = '\0';
            this.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contact.SelectedText = "";
            this.txt_contact.SelectionLength = 0;
            this.txt_contact.SelectionStart = 0;
            this.txt_contact.ShortcutsEnabled = true;
            this.txt_contact.Size = new System.Drawing.Size(262, 23);
            this.txt_contact.TabIndex = 2;
            this.txt_contact.UseSelectable = true;
            this.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            this.txt_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contact_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(518, 131);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Date of Birth";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(518, 178);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Age";
            // 
            // txt_lastName
            // 
            // 
            // 
            // 
            this.txt_lastName.CustomButton.Image = null;
            this.txt_lastName.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_lastName.CustomButton.Name = "";
            this.txt_lastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lastName.CustomButton.TabIndex = 1;
            this.txt_lastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lastName.CustomButton.UseSelectable = true;
            this.txt_lastName.CustomButton.Visible = false;
            this.txt_lastName.Lines = new string[0];
            this.txt_lastName.Location = new System.Drawing.Point(173, 83);
            this.txt_lastName.MaxLength = 32767;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.PasswordChar = '\0';
            this.txt_lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lastName.SelectedText = "";
            this.txt_lastName.SelectionLength = 0;
            this.txt_lastName.SelectionStart = 0;
            this.txt_lastName.ShortcutsEnabled = true;
            this.txt_lastName.Size = new System.Drawing.Size(262, 23);
            this.txt_lastName.TabIndex = 1;
            this.txt_lastName.UseSelectable = true;
            this.txt_lastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lastName_KeyPress);
            // 
            // txt_empName
            // 
            // 
            // 
            // 
            this.txt_empName.CustomButton.Image = null;
            this.txt_empName.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_empName.CustomButton.Name = "";
            this.txt_empName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empName.CustomButton.TabIndex = 1;
            this.txt_empName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empName.CustomButton.UseSelectable = true;
            this.txt_empName.CustomButton.Visible = false;
            this.txt_empName.Lines = new string[0];
            this.txt_empName.Location = new System.Drawing.Point(173, 39);
            this.txt_empName.MaxLength = 32767;
            this.txt_empName.Name = "txt_empName";
            this.txt_empName.PasswordChar = '\0';
            this.txt_empName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empName.SelectedText = "";
            this.txt_empName.SelectionLength = 0;
            this.txt_empName.SelectionStart = 0;
            this.txt_empName.ShortcutsEnabled = true;
            this.txt_empName.Size = new System.Drawing.Size(262, 23);
            this.txt_empName.TabIndex = 0;
            this.txt_empName.UseSelectable = true;
            this.txt_empName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empName_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 553);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UpdateEmployee";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_picture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txt_address;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_salary;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_Age;
        private System.Windows.Forms.ComboBox cmb_desigType;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_nic;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_mobile;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_contact;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_lastName;
        private MetroFramework.Controls.MetroTextBox txt_empName;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox emp_picture;
        private MetroFramework.Controls.MetroButton btn_add;
        private System.Windows.Forms.OpenFileDialog Open_picture;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btn_search;
        private MetroFramework.Controls.MetroTextBox txt_empID;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txt_empNIC;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txt_contactNum;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}