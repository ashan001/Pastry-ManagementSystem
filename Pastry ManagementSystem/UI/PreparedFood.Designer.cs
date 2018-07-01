namespace Pastry_ManagementSystem.UI
{
    partial class PreparedFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreparedFood));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFoodName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FoodSearch = new System.Windows.Forms.Panel();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_contactNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_empID = new MetroFramework.Controls.MetroTextBox();
            this.grid_foodMasterInfo = new System.Windows.Forms.DataGridView();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_cancle = new MetroFramework.Controls.MetroButton();
            this.btn_ok = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_foodMasterInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFoodName);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.FoodSearch);
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
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(14, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtFoodName
            // 
            // 
            // 
            // 
            this.txtFoodName.CustomButton.Image = null;
            this.txtFoodName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtFoodName.CustomButton.Name = "";
            this.txtFoodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFoodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFoodName.CustomButton.TabIndex = 1;
            this.txtFoodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFoodName.CustomButton.UseSelectable = true;
            this.txtFoodName.CustomButton.Visible = false;
            this.txtFoodName.Lines = new string[0];
            this.txtFoodName.Location = new System.Drawing.Point(473, 64);
            this.txtFoodName.MaxLength = 32767;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.PasswordChar = '\0';
            this.txtFoodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFoodName.SelectedText = "";
            this.txtFoodName.SelectionLength = 0;
            this.txtFoodName.SelectionStart = 0;
            this.txtFoodName.ShortcutsEnabled = true;
            this.txtFoodName.Size = new System.Drawing.Size(182, 23);
            this.txtFoodName.TabIndex = 24;
            this.txtFoodName.UseSelectable = true;
            this.txtFoodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFoodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(366, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Food Name";
            // 
            // FoodSearch
            // 
            this.FoodSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FoodSearch.BackgroundImage")));
            this.FoodSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FoodSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodSearch.Location = new System.Drawing.Point(616, 28);
            this.FoodSearch.Name = "FoodSearch";
            this.FoodSearch.Size = new System.Drawing.Size(39, 23);
            this.FoodSearch.TabIndex = 22;
            this.FoodSearch.Click += new System.EventHandler(this.FoodSearch_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(384, 24);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Food No";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.BackgroundImage")));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Location = new System.Drawing.Point(545, 127);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(64, 28);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.BackgroundImage")));
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Location = new System.Drawing.Point(473, 127);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 28);
            this.btn_Add.TabIndex = 5;
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
            this.txt_quantity.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txt_quantity.CustomButton.Name = "";
            this.txt_quantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantity.CustomButton.TabIndex = 1;
            this.txt_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantity.CustomButton.UseSelectable = true;
            this.txt_quantity.CustomButton.Visible = false;
            this.txt_quantity.Lines = new string[0];
            this.txt_quantity.Location = new System.Drawing.Point(473, 96);
            this.txt_quantity.MaxLength = 32767;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.ShortcutsEnabled = true;
            this.txt_quantity.Size = new System.Drawing.Size(182, 23);
            this.txt_quantity.TabIndex = 4;
            this.txt_quantity.UseSelectable = true;
            this.txt_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_KeyDown);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(388, 95);
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
            this.txt_foodNo.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txt_foodNo.CustomButton.Name = "";
            this.txt_foodNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_foodNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_foodNo.CustomButton.TabIndex = 1;
            this.txt_foodNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_foodNo.CustomButton.UseSelectable = true;
            this.txt_foodNo.CustomButton.Visible = false;
            this.txt_foodNo.Lines = new string[0];
            this.txt_foodNo.Location = new System.Drawing.Point(473, 28);
            this.txt_foodNo.MaxLength = 32767;
            this.txt_foodNo.Name = "txt_foodNo";
            this.txt_foodNo.PasswordChar = '\0';
            this.txt_foodNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_foodNo.SelectedText = "";
            this.txt_foodNo.SelectionLength = 0;
            this.txt_foodNo.SelectionStart = 0;
            this.txt_foodNo.ShortcutsEnabled = true;
            this.txt_foodNo.Size = new System.Drawing.Size(182, 23);
            this.txt_foodNo.TabIndex = 3;
            this.txt_foodNo.UseSelectable = true;
            this.txt_foodNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_foodNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_foodNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_foodNo_KeyDown);
            // 
            // txt_Desig
            // 
            // 
            // 
            // 
            this.txt_Desig.CustomButton.Image = null;
            this.txt_Desig.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txt_Desig.CustomButton.Name = "";
            this.txt_Desig.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Desig.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Desig.CustomButton.TabIndex = 1;
            this.txt_Desig.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Desig.CustomButton.UseSelectable = true;
            this.txt_Desig.CustomButton.Visible = false;
            this.txt_Desig.Enabled = false;
            this.txt_Desig.Lines = new string[0];
            this.txt_Desig.Location = new System.Drawing.Point(154, 95);
            this.txt_Desig.MaxLength = 32767;
            this.txt_Desig.Name = "txt_Desig";
            this.txt_Desig.PasswordChar = '\0';
            this.txt_Desig.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Desig.SelectedText = "";
            this.txt_Desig.SelectionLength = 0;
            this.txt_Desig.SelectionStart = 0;
            this.txt_Desig.ShortcutsEnabled = true;
            this.txt_Desig.Size = new System.Drawing.Size(204, 23);
            this.txt_Desig.TabIndex = 2;
            this.txt_Desig.UseSelectable = true;
            this.txt_Desig.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Desig.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(69, 96);
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
            this.txt_empLName.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txt_empLName.CustomButton.Name = "";
            this.txt_empLName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empLName.CustomButton.TabIndex = 1;
            this.txt_empLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empLName.CustomButton.UseSelectable = true;
            this.txt_empLName.CustomButton.Visible = false;
            this.txt_empLName.Enabled = false;
            this.txt_empLName.Lines = new string[0];
            this.txt_empLName.Location = new System.Drawing.Point(154, 63);
            this.txt_empLName.MaxLength = 32767;
            this.txt_empLName.Name = "txt_empLName";
            this.txt_empLName.PasswordChar = '\0';
            this.txt_empLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empLName.SelectedText = "";
            this.txt_empLName.SelectionLength = 0;
            this.txt_empLName.SelectionStart = 0;
            this.txt_empLName.ShortcutsEnabled = true;
            this.txt_empLName.Size = new System.Drawing.Size(204, 23);
            this.txt_empLName.TabIndex = 1;
            this.txt_empLName.UseSelectable = true;
            this.txt_empLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 59);
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
            this.txt_empFName.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txt_empFName.CustomButton.Name = "";
            this.txt_empFName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empFName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empFName.CustomButton.TabIndex = 1;
            this.txt_empFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empFName.CustomButton.UseSelectable = true;
            this.txt_empFName.CustomButton.Visible = false;
            this.txt_empFName.Enabled = false;
            this.txt_empFName.Lines = new string[0];
            this.txt_empFName.Location = new System.Drawing.Point(154, 23);
            this.txt_empFName.MaxLength = 32767;
            this.txt_empFName.Name = "txt_empFName";
            this.txt_empFName.PasswordChar = '\0';
            this.txt_empFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empFName.SelectedText = "";
            this.txt_empFName.SelectionLength = 0;
            this.txt_empFName.SelectionStart = 0;
            this.txt_empFName.ShortcutsEnabled = true;
            this.txt_empFName.Size = new System.Drawing.Size(204, 23);
            this.txt_empFName.TabIndex = 0;
            this.txt_empFName.UseSelectable = true;
            this.txt_empFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Employee Name     :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_contactNum);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.txt_empID);
            this.groupBox3.Location = new System.Drawing.Point(14, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 58);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txt_contactNum
            // 
            // 
            // 
            // 
            this.txt_contactNum.CustomButton.Image = null;
            this.txt_contactNum.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txt_contactNum.CustomButton.Name = "";
            this.txt_contactNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contactNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contactNum.CustomButton.TabIndex = 1;
            this.txt_contactNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contactNum.CustomButton.UseSelectable = true;
            this.txt_contactNum.CustomButton.Visible = false;
            this.txt_contactNum.Lines = new string[0];
            this.txt_contactNum.Location = new System.Drawing.Point(473, 20);
            this.txt_contactNum.MaxLength = 20;
            this.txt_contactNum.Name = "txt_contactNum";
            this.txt_contactNum.PasswordChar = '\0';
            this.txt_contactNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contactNum.SelectedText = "";
            this.txt_contactNum.SelectionLength = 0;
            this.txt_contactNum.SelectionStart = 0;
            this.txt_contactNum.ShortcutsEnabled = true;
            this.txt_contactNum.Size = new System.Drawing.Size(182, 23);
            this.txt_contactNum.TabIndex = 1;
            this.txt_contactNum.UseSelectable = true;
            this.txt_contactNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contactNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contactNum.TextChanged += new System.EventHandler(this.txt_contactNum_TextChanged);
            this.txt_contactNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contactNum_KeyDown);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(367, 20);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 19);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Contact Num";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Employee ID";
            // 
            // txt_empID
            // 
            // 
            // 
            // 
            this.txt_empID.CustomButton.Image = null;
            this.txt_empID.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txt_empID.CustomButton.Name = "";
            this.txt_empID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empID.CustomButton.TabIndex = 1;
            this.txt_empID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empID.CustomButton.UseSelectable = true;
            this.txt_empID.CustomButton.Visible = false;
            this.txt_empID.Lines = new string[0];
            this.txt_empID.Location = new System.Drawing.Point(154, 19);
            this.txt_empID.MaxLength = 32767;
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.PasswordChar = '\0';
            this.txt_empID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empID.SelectedText = "";
            this.txt_empID.SelectionLength = 0;
            this.txt_empID.SelectionStart = 0;
            this.txt_empID.ShortcutsEnabled = true;
            this.txt_empID.Size = new System.Drawing.Size(204, 23);
            this.txt_empID.TabIndex = 0;
            this.txt_empID.UseSelectable = true;
            this.txt_empID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empID.TextChanged += new System.EventHandler(this.txt_empID_TextChanged);
            this.txt_empID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_empID_KeyDown);
            // 
            // grid_foodMasterInfo
            // 
            this.grid_foodMasterInfo.AllowUserToAddRows = false;
            this.grid_foodMasterInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_foodMasterInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_foodMasterInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index1,
            this.cl_foodName,
            this.cl_index2});
            this.grid_foodMasterInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_foodMasterInfo.Location = new System.Drawing.Point(681, 60);
            this.grid_foodMasterInfo.Name = "grid_foodMasterInfo";
            this.grid_foodMasterInfo.Size = new System.Drawing.Size(396, 221);
            this.grid_foodMasterInfo.TabIndex = 21;
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "Food No";
            this.cl_index1.Name = "cl_index1";
            this.cl_index1.Width = 135;
            // 
            // cl_foodName
            // 
            this.cl_foodName.HeaderText = "Food Name";
            this.cl_foodName.Name = "cl_foodName";
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "Quantity";
            this.cl_index2.Name = "cl_index2";
            this.cl_index2.Width = 135;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(299, 287);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 39);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancle.BackgroundImage")));
            this.btn_cancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancle.Location = new System.Drawing.Point(154, 287);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(139, 39);
            this.btn_cancle.TabIndex = 2;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseSelectable = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ok.Location = new System.Drawing.Point(14, 287);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(134, 39);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseSelectable = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // PreparedFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 334);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grid_foodMasterInfo);
            this.Controls.Add(this.groupBox2);
            this.Movable = false;
            this.Name = "PreparedFood";
            this.Text = "Prepared Food";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_foodMasterInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel FoodSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txt_contactNum;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btn_Clear;
        private MetroFramework.Controls.MetroButton btn_Add;
        private MetroFramework.Controls.MetroTextBox txt_quantity;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_foodNo;
        private MetroFramework.Controls.MetroTextBox txt_Desig;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_empLName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_empFName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView grid_foodMasterInfo;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_cancle;
        private MetroFramework.Controls.MetroButton btn_ok;
        private MetroFramework.Controls.MetroTextBox txt_empID;
        private MetroFramework.Controls.MetroTextBox txtFoodName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_foodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
    }
}