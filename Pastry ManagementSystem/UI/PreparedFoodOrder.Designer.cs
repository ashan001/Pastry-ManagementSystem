namespace Pastry_ManagementSystem.UI
{
    partial class PreparedFoodOrder
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.grid_foodMasterInfo = new System.Windows.Forms.DataGridView();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancle = new MetroFramework.Controls.MetroButton();
            this.btn_ok = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btn_Clear = new MetroFramework.Controls.MetroButton();
            this.btn_Add = new MetroFramework.Controls.MetroButton();
            this.txt_quantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_foodNo = new MetroFramework.Controls.MetroTextBox();
            this.txt_Desig = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_empLName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_empFName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_empID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_date = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_orderID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_foodMasterInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.blue_gradient_wallpaper_hd_20_color;
            this.metroPanel1.Controls.Add(this.btn_back);
            this.metroPanel1.Controls.Add(this.grid_foodMasterInfo);
            this.metroPanel1.Controls.Add(this.btn_cancle);
            this.metroPanel1.Controls.Add(this.btn_ok);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-3, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1198, 433);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1083, 384);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(106, 36);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            // 
            // grid_foodMasterInfo
            // 
            this.grid_foodMasterInfo.AllowUserToAddRows = false;
            this.grid_foodMasterInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_foodMasterInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_foodMasterInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index1,
            this.cl_index2});
            this.grid_foodMasterInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_foodMasterInfo.Location = new System.Drawing.Point(762, 52);
            this.grid_foodMasterInfo.Name = "grid_foodMasterInfo";
            this.grid_foodMasterInfo.Size = new System.Drawing.Size(315, 368);
            this.grid_foodMasterInfo.TabIndex = 20;
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "Food No";
            this.cl_index1.Name = "cl_index1";
            this.cl_index1.Width = 135;
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "Quantity";
            this.cl_index2.Name = "cl_index2";
            this.cl_index2.Width = 135;
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(1083, 326);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(106, 36);
            this.btn_cancle.TabIndex = 19;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseSelectable = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(1083, 264);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(106, 39);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseSelectable = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.txt_quantity);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txt_foodNo);
            this.groupBox2.Controls.Add(this.txt_Desig);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.txt_empLName);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.txt_empFName);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txt_empID);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(13, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 278);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 204);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Food No";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Location = new System.Drawing.Point(642, 236);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(95, 36);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Location = new System.Drawing.Point(642, 194);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 36);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseSelectable = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_quantity
            // 
            // 
            // 
            // 
            this.txt_quantity.CustomButton.Image = null;
            this.txt_quantity.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txt_quantity.CustomButton.Name = "";
            this.txt_quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantity.CustomButton.TabIndex = 1;
            this.txt_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantity.CustomButton.UseSelectable = true;
            this.txt_quantity.CustomButton.Visible = false;
            this.txt_quantity.Enabled = false;
            this.txt_quantity.Lines = new string[0];
            this.txt_quantity.Location = new System.Drawing.Point(224, 242);
            this.txt_quantity.MaxLength = 32767;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.ShortcutsEnabled = true;
            this.txt_quantity.Size = new System.Drawing.Size(282, 23);
            this.txt_quantity.TabIndex = 15;
            this.txt_quantity.UseSelectable = true;
            this.txt_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(19, 246);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Quantity";
            // 
            // txt_foodNo
            // 
            // 
            // 
            // 
            this.txt_foodNo.CustomButton.Image = null;
            this.txt_foodNo.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txt_foodNo.CustomButton.Name = "";
            this.txt_foodNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_foodNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_foodNo.CustomButton.TabIndex = 1;
            this.txt_foodNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_foodNo.CustomButton.UseSelectable = true;
            this.txt_foodNo.CustomButton.Visible = false;
            this.txt_foodNo.Lines = new string[0];
            this.txt_foodNo.Location = new System.Drawing.Point(224, 197);
            this.txt_foodNo.MaxLength = 32767;
            this.txt_foodNo.Name = "txt_foodNo";
            this.txt_foodNo.PasswordChar = '\0';
            this.txt_foodNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_foodNo.SelectedText = "";
            this.txt_foodNo.SelectionLength = 0;
            this.txt_foodNo.SelectionStart = 0;
            this.txt_foodNo.ShortcutsEnabled = true;
            this.txt_foodNo.Size = new System.Drawing.Size(282, 23);
            this.txt_foodNo.TabIndex = 13;
            this.txt_foodNo.UseSelectable = true;
            this.txt_foodNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_foodNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_foodNo.TextChanged += new System.EventHandler(this.txt_foodNo_TextChanged);
            // 
            // txt_Desig
            // 
            // 
            // 
            // 
            this.txt_Desig.CustomButton.Image = null;
            this.txt_Desig.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txt_Desig.CustomButton.Name = "";
            this.txt_Desig.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Desig.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Desig.CustomButton.TabIndex = 1;
            this.txt_Desig.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Desig.CustomButton.UseSelectable = true;
            this.txt_Desig.CustomButton.Visible = false;
            this.txt_Desig.Enabled = false;
            this.txt_Desig.Lines = new string[0];
            this.txt_Desig.Location = new System.Drawing.Point(224, 154);
            this.txt_Desig.MaxLength = 32767;
            this.txt_Desig.Name = "txt_Desig";
            this.txt_Desig.PasswordChar = '\0';
            this.txt_Desig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Desig.SelectedText = "";
            this.txt_Desig.SelectionLength = 0;
            this.txt_Desig.SelectionStart = 0;
            this.txt_Desig.ShortcutsEnabled = true;
            this.txt_Desig.Size = new System.Drawing.Size(282, 23);
            this.txt_Desig.TabIndex = 11;
            this.txt_Desig.UseSelectable = true;
            this.txt_Desig.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Desig.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 154);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Designation";
            // 
            // txt_empLName
            // 
            // 
            // 
            // 
            this.txt_empLName.CustomButton.Image = null;
            this.txt_empLName.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txt_empLName.CustomButton.Name = "";
            this.txt_empLName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empLName.CustomButton.TabIndex = 1;
            this.txt_empLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empLName.CustomButton.UseSelectable = true;
            this.txt_empLName.CustomButton.Visible = false;
            this.txt_empLName.Enabled = false;
            this.txt_empLName.Lines = new string[0];
            this.txt_empLName.Location = new System.Drawing.Point(224, 110);
            this.txt_empLName.MaxLength = 32767;
            this.txt_empLName.Name = "txt_empLName";
            this.txt_empLName.PasswordChar = '\0';
            this.txt_empLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empLName.SelectedText = "";
            this.txt_empLName.SelectionLength = 0;
            this.txt_empLName.SelectionStart = 0;
            this.txt_empLName.ShortcutsEnabled = true;
            this.txt_empLName.Size = new System.Drawing.Size(282, 23);
            this.txt_empLName.TabIndex = 9;
            this.txt_empLName.UseSelectable = true;
            this.txt_empLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "                            :";
            // 
            // txt_empFName
            // 
            // 
            // 
            // 
            this.txt_empFName.CustomButton.Image = null;
            this.txt_empFName.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.txt_empFName.CustomButton.Name = "";
            this.txt_empFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empFName.CustomButton.TabIndex = 1;
            this.txt_empFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empFName.CustomButton.UseSelectable = true;
            this.txt_empFName.CustomButton.Visible = false;
            this.txt_empFName.Enabled = false;
            this.txt_empFName.Lines = new string[0];
            this.txt_empFName.Location = new System.Drawing.Point(224, 70);
            this.txt_empFName.MaxLength = 32767;
            this.txt_empFName.Name = "txt_empFName";
            this.txt_empFName.PasswordChar = '\0';
            this.txt_empFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empFName.SelectedText = "";
            this.txt_empFName.SelectionLength = 0;
            this.txt_empFName.SelectionStart = 0;
            this.txt_empFName.ShortcutsEnabled = true;
            this.txt_empFName.Size = new System.Drawing.Size(282, 23);
            this.txt_empFName.TabIndex = 7;
            this.txt_empFName.UseSelectable = true;
            this.txt_empFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Employee Name     :";
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
            this.txt_empID.Lines = new string[0];
            this.txt_empID.Location = new System.Drawing.Point(224, 19);
            this.txt_empID.MaxLength = 32767;
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.PasswordChar = '\0';
            this.txt_empID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empID.SelectedText = "";
            this.txt_empID.SelectionLength = 0;
            this.txt_empID.SelectionStart = 0;
            this.txt_empID.ShortcutsEnabled = true;
            this.txt_empID.Size = new System.Drawing.Size(215, 23);
            this.txt_empID.TabIndex = 5;
            this.txt_empID.UseSelectable = true;
            this.txt_empID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empID.TextChanged += new System.EventHandler(this.txt_empID_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Employee ID";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(13, 12);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(252, 25);
            this.lbl_welcome.TabIndex = 15;
            this.lbl_welcome.Text = "Prepared Food Order Screen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txt_orderID);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_date
            // 
            // 
            // 
            // 
            this.txt_date.CustomButton.Image = null;
            this.txt_date.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txt_date.CustomButton.Name = "";
            this.txt_date.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_date.CustomButton.TabIndex = 1;
            this.txt_date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_date.CustomButton.UseSelectable = true;
            this.txt_date.CustomButton.Visible = false;
            this.txt_date.Enabled = false;
            this.txt_date.Lines = new string[0];
            this.txt_date.Location = new System.Drawing.Point(479, 30);
            this.txt_date.MaxLength = 32767;
            this.txt_date.Name = "txt_date";
            this.txt_date.PasswordChar = '\0';
            this.txt_date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_date.SelectedText = "";
            this.txt_date.SelectionLength = 0;
            this.txt_date.SelectionStart = 0;
            this.txt_date.ShortcutsEnabled = true;
            this.txt_date.Size = new System.Drawing.Size(215, 23);
            this.txt_date.TabIndex = 6;
            this.txt_date.UseSelectable = true;
            this.txt_date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(390, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Date";
            // 
            // txt_orderID
            // 
            // 
            // 
            // 
            this.txt_orderID.CustomButton.Image = null;
            this.txt_orderID.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txt_orderID.CustomButton.Name = "";
            this.txt_orderID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_orderID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_orderID.CustomButton.TabIndex = 1;
            this.txt_orderID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_orderID.CustomButton.UseSelectable = true;
            this.txt_orderID.CustomButton.Visible = false;
            this.txt_orderID.Lines = new string[0];
            this.txt_orderID.Location = new System.Drawing.Point(122, 26);
            this.txt_orderID.MaxLength = 32767;
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.PasswordChar = '\0';
            this.txt_orderID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_orderID.SelectedText = "";
            this.txt_orderID.SelectionLength = 0;
            this.txt_orderID.SelectionStart = 0;
            this.txt_orderID.ShortcutsEnabled = true;
            this.txt_orderID.Size = new System.Drawing.Size(215, 23);
            this.txt_orderID.TabIndex = 4;
            this.txt_orderID.UseSelectable = true;
            this.txt_orderID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_orderID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Order ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // PreparedFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 457);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PreparedFoodOrder";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.PreparedFoodOrder_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_foodMasterInfo)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txt_empID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_date;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_empLName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_empFName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_Desig;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_foodNo;
        private MetroFramework.Controls.MetroTextBox txt_quantity;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btn_Clear;
        private MetroFramework.Controls.MetroButton btn_Add;
        private MetroFramework.Controls.MetroButton btn_cancle;
        private MetroFramework.Controls.MetroButton btn_ok;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridView grid_foodMasterInfo;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroTextBox txt_orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}