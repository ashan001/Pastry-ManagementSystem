namespace Pastry_ManagementSystem.UI
{
    partial class BillScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.txt_subtot = new MetroFramework.Controls.MetroTextBox();
            this.txt_gst = new MetroFramework.Controls.MetroTextBox();
            this.txt_tot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.grid_infoLoad = new MetroFramework.Controls.MetroGrid();
            this.cl_index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_index5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_qty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txt_foodNo = new MetroFramework.Controls.MetroTextBox();
            this.txt_cusID = new MetroFramework.Controls.MetroTextBox();
            this.txt_lastName = new MetroFramework.Controls.MetroTextBox();
            this.txt_firstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_contact = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtp_date = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_infoLoad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.blue_gradient_wallpaper_hd_20_color;
            this.metroPanel1.Controls.Add(this.btn_exit);
            this.metroPanel1.Controls.Add(this.btn_back);
            this.metroPanel1.Controls.Add(this.btn_print);
            this.metroPanel1.Controls.Add(this.txt_subtot);
            this.metroPanel1.Controls.Add(this.txt_gst);
            this.metroPanel1.Controls.Add(this.txt_tot);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.grid_infoLoad);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-3, 29);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1328, 559);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources._1364243971_sign_out;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Location = new System.Drawing.Point(268, 504);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 37);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.UseSelectable = true;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.close;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(141, 504);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 37);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.UseSelectable = true;
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.print;
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Location = new System.Drawing.Point(14, 504);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(99, 37);
            this.btn_print.TabIndex = 24;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseSelectable = true;
            // 
            // txt_subtot
            // 
            // 
            // 
            // 
            this.txt_subtot.CustomButton.Image = null;
            this.txt_subtot.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txt_subtot.CustomButton.Name = "";
            this.txt_subtot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_subtot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_subtot.CustomButton.TabIndex = 1;
            this.txt_subtot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_subtot.CustomButton.UseSelectable = true;
            this.txt_subtot.CustomButton.Visible = false;
            this.txt_subtot.Lines = new string[0];
            this.txt_subtot.Location = new System.Drawing.Point(1098, 512);
            this.txt_subtot.MaxLength = 32767;
            this.txt_subtot.Name = "txt_subtot";
            this.txt_subtot.PasswordChar = '\0';
            this.txt_subtot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_subtot.SelectedText = "";
            this.txt_subtot.SelectionLength = 0;
            this.txt_subtot.SelectionStart = 0;
            this.txt_subtot.ShortcutsEnabled = true;
            this.txt_subtot.Size = new System.Drawing.Size(205, 23);
            this.txt_subtot.TabIndex = 23;
            this.txt_subtot.UseSelectable = true;
            this.txt_subtot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_subtot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_gst
            // 
            // 
            // 
            // 
            this.txt_gst.CustomButton.Image = null;
            this.txt_gst.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txt_gst.CustomButton.Name = "";
            this.txt_gst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_gst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_gst.CustomButton.TabIndex = 1;
            this.txt_gst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_gst.CustomButton.UseSelectable = true;
            this.txt_gst.CustomButton.Visible = false;
            this.txt_gst.Lines = new string[0];
            this.txt_gst.Location = new System.Drawing.Point(1098, 464);
            this.txt_gst.MaxLength = 32767;
            this.txt_gst.Name = "txt_gst";
            this.txt_gst.PasswordChar = '\0';
            this.txt_gst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_gst.SelectedText = "";
            this.txt_gst.SelectionLength = 0;
            this.txt_gst.SelectionStart = 0;
            this.txt_gst.ShortcutsEnabled = true;
            this.txt_gst.Size = new System.Drawing.Size(205, 23);
            this.txt_gst.TabIndex = 22;
            this.txt_gst.UseSelectable = true;
            this.txt_gst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_gst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_tot
            // 
            // 
            // 
            // 
            this.txt_tot.CustomButton.Image = null;
            this.txt_tot.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txt_tot.CustomButton.Name = "";
            this.txt_tot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_tot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_tot.CustomButton.TabIndex = 1;
            this.txt_tot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_tot.CustomButton.UseSelectable = true;
            this.txt_tot.CustomButton.Visible = false;
            this.txt_tot.Lines = new string[0];
            this.txt_tot.Location = new System.Drawing.Point(1098, 409);
            this.txt_tot.MaxLength = 32767;
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.PasswordChar = '\0';
            this.txt_tot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tot.SelectedText = "";
            this.txt_tot.SelectionLength = 0;
            this.txt_tot.SelectionStart = 0;
            this.txt_tot.ShortcutsEnabled = true;
            this.txt_tot.Size = new System.Drawing.Size(205, 23);
            this.txt_tot.TabIndex = 21;
            this.txt_tot.UseSelectable = true;
            this.txt_tot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_tot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(928, 516);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(57, 19);
            this.metroLabel12.TabIndex = 20;
            this.metroLabel12.Text = "Bill Total";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(928, 464);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(68, 19);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "GST@10%";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(928, 409);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(62, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Sub Total";
            // 
            // grid_infoLoad
            // 
            this.grid_infoLoad.AllowUserToResizeRows = false;
            this.grid_infoLoad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_infoLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_infoLoad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_infoLoad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_infoLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_infoLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_infoLoad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_index1,
            this.cl_index6,
            this.cl_index2,
            this.cl_index3,
            this.cl_index4,
            this.cl_index5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_infoLoad.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_infoLoad.EnableHeadersVisualStyles = false;
            this.grid_infoLoad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_infoLoad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_infoLoad.Location = new System.Drawing.Point(670, 53);
            this.grid_infoLoad.Name = "grid_infoLoad";
            this.grid_infoLoad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_infoLoad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_infoLoad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_infoLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_infoLoad.Size = new System.Drawing.Size(633, 338);
            this.grid_infoLoad.TabIndex = 17;
            // 
            // cl_index1
            // 
            this.cl_index1.HeaderText = "Customer ID";
            this.cl_index1.Name = "cl_index1";
            // 
            // cl_index6
            // 
            this.cl_index6.HeaderText = "Date";
            this.cl_index6.Name = "cl_index6";
            // 
            // cl_index2
            // 
            this.cl_index2.HeaderText = "Food No";
            this.cl_index2.Name = "cl_index2";
            // 
            // cl_index3
            // 
            this.cl_index3.HeaderText = "Quantity";
            this.cl_index3.Name = "cl_index3";
            // 
            // cl_index4
            // 
            this.cl_index4.HeaderText = "unit Price";
            this.cl_index4.Name = "cl_index4";
            // 
            // cl_index5
            // 
            this.cl_index5.HeaderText = "TotalPrice";
            this.cl_index5.Name = "cl_index5";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.txt_qty);
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.txt_foodNo);
            this.groupBox2.Controls.Add(this.txt_cusID);
            this.groupBox2.Controls.Add(this.txt_lastName);
            this.groupBox2.Controls.Add(this.txt_firstName);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Location = new System.Drawing.Point(14, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(650, 291);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // txt_qty
            // 
            // 
            // 
            // 
            this.txt_qty.CustomButton.Image = null;
            this.txt_qty.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txt_qty.CustomButton.Name = "";
            this.txt_qty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qty.CustomButton.TabIndex = 1;
            this.txt_qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qty.CustomButton.UseSelectable = true;
            this.txt_qty.CustomButton.Visible = false;
            this.txt_qty.Enabled = false;
            this.txt_qty.Lines = new string[0];
            this.txt_qty.Location = new System.Drawing.Point(277, 202);
            this.txt_qty.MaxLength = 32767;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qty.SelectedText = "";
            this.txt_qty.SelectionLength = 0;
            this.txt_qty.SelectionStart = 0;
            this.txt_qty.ShortcutsEnabled = true;
            this.txt_qty.Size = new System.Drawing.Size(244, 23);
            this.txt_qty.TabIndex = 13;
            this.txt_qty.UseSelectable = true;
            this.txt_qty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(14, 206);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(58, 19);
            this.metroLabel13.TabIndex = 12;
            this.metroLabel13.Text = "Quantity";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.add_icon;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(553, 252);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 33);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Add";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton1.UseSelectable = true;
            // 
            // txt_foodNo
            // 
            // 
            // 
            // 
            this.txt_foodNo.CustomButton.Image = null;
            this.txt_foodNo.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txt_foodNo.CustomButton.Name = "";
            this.txt_foodNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_foodNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_foodNo.CustomButton.TabIndex = 1;
            this.txt_foodNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_foodNo.CustomButton.UseSelectable = true;
            this.txt_foodNo.CustomButton.Visible = false;
            this.txt_foodNo.Enabled = false;
            this.txt_foodNo.Lines = new string[0];
            this.txt_foodNo.Location = new System.Drawing.Point(277, 161);
            this.txt_foodNo.MaxLength = 32767;
            this.txt_foodNo.Name = "txt_foodNo";
            this.txt_foodNo.PasswordChar = '\0';
            this.txt_foodNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_foodNo.SelectedText = "";
            this.txt_foodNo.SelectionLength = 0;
            this.txt_foodNo.SelectionStart = 0;
            this.txt_foodNo.ShortcutsEnabled = true;
            this.txt_foodNo.Size = new System.Drawing.Size(244, 23);
            this.txt_foodNo.TabIndex = 10;
            this.txt_foodNo.UseSelectable = true;
            this.txt_foodNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_foodNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_cusID
            // 
            // 
            // 
            // 
            this.txt_cusID.CustomButton.Image = null;
            this.txt_cusID.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txt_cusID.CustomButton.Name = "";
            this.txt_cusID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cusID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cusID.CustomButton.TabIndex = 1;
            this.txt_cusID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cusID.CustomButton.UseSelectable = true;
            this.txt_cusID.CustomButton.Visible = false;
            this.txt_cusID.Enabled = false;
            this.txt_cusID.Lines = new string[0];
            this.txt_cusID.Location = new System.Drawing.Point(277, 122);
            this.txt_cusID.MaxLength = 32767;
            this.txt_cusID.Name = "txt_cusID";
            this.txt_cusID.PasswordChar = '\0';
            this.txt_cusID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cusID.SelectedText = "";
            this.txt_cusID.SelectionLength = 0;
            this.txt_cusID.SelectionStart = 0;
            this.txt_cusID.ShortcutsEnabled = true;
            this.txt_cusID.Size = new System.Drawing.Size(244, 23);
            this.txt_cusID.TabIndex = 9;
            this.txt_cusID.UseSelectable = true;
            this.txt_cusID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cusID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_lastName
            // 
            // 
            // 
            // 
            this.txt_lastName.CustomButton.Image = null;
            this.txt_lastName.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txt_lastName.CustomButton.Name = "";
            this.txt_lastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_lastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_lastName.CustomButton.TabIndex = 1;
            this.txt_lastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_lastName.CustomButton.UseSelectable = true;
            this.txt_lastName.CustomButton.Visible = false;
            this.txt_lastName.Enabled = false;
            this.txt_lastName.Lines = new string[0];
            this.txt_lastName.Location = new System.Drawing.Point(277, 78);
            this.txt_lastName.MaxLength = 32767;
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.PasswordChar = '\0';
            this.txt_lastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_lastName.SelectedText = "";
            this.txt_lastName.SelectionLength = 0;
            this.txt_lastName.SelectionStart = 0;
            this.txt_lastName.ShortcutsEnabled = true;
            this.txt_lastName.Size = new System.Drawing.Size(307, 23);
            this.txt_lastName.TabIndex = 8;
            this.txt_lastName.UseSelectable = true;
            this.txt_lastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_lastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_firstName
            // 
            // 
            // 
            // 
            this.txt_firstName.CustomButton.Image = null;
            this.txt_firstName.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txt_firstName.CustomButton.Name = "";
            this.txt_firstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_firstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_firstName.CustomButton.TabIndex = 1;
            this.txt_firstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_firstName.CustomButton.UseSelectable = true;
            this.txt_firstName.CustomButton.Visible = false;
            this.txt_firstName.Enabled = false;
            this.txt_firstName.Lines = new string[0];
            this.txt_firstName.Location = new System.Drawing.Point(277, 33);
            this.txt_firstName.MaxLength = 32767;
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PasswordChar = '\0';
            this.txt_firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_firstName.SelectedText = "";
            this.txt_firstName.SelectionLength = 0;
            this.txt_firstName.SelectionStart = 0;
            this.txt_firstName.ShortcutsEnabled = true;
            this.txt_firstName.Size = new System.Drawing.Size(307, 23);
            this.txt_firstName.TabIndex = 7;
            this.txt_firstName.UseSelectable = true;
            this.txt_firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(14, 122);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Customer ID";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 78);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Customer Last Name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 161);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Food No";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 37);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(134, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Customer First Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(6, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Bill To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_contact);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txt_contact
            // 
            // 
            // 
            // 
            this.txt_contact.CustomButton.Image = null;
            this.txt_contact.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.txt_contact.CustomButton.Name = "";
            this.txt_contact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contact.CustomButton.TabIndex = 1;
            this.txt_contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contact.CustomButton.UseSelectable = true;
            this.txt_contact.CustomButton.Visible = false;
            this.txt_contact.Lines = new string[0];
            this.txt_contact.Location = new System.Drawing.Point(190, 91);
            this.txt_contact.MaxLength = 32767;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.PasswordChar = '\0';
            this.txt_contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contact.SelectedText = "";
            this.txt_contact.SelectionLength = 0;
            this.txt_contact.SelectionStart = 0;
            this.txt_contact.ShortcutsEnabled = true;
            this.txt_contact.Size = new System.Drawing.Size(266, 23);
            this.txt_contact.TabIndex = 6;
            this.txt_contact.UseSelectable = true;
            this.txt_contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(168, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Customer Contact Number";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(394, 35);
            this.dtp_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 29);
            this.dtp_date.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(343, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Date";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(127, 35);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(184, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Bill Number";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Bill Infomation";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(14, 15);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(101, 25);
            this.lbl_welcome.TabIndex = 14;
            this.lbl_welcome.Text = "Bill Screen";
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 579);
            this.Controls.Add(this.metroPanel1);
            this.Name = "BillScreen";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_infoLoad)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtp_date;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_contact;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_foodNo;
        private MetroFramework.Controls.MetroTextBox txt_cusID;
        private MetroFramework.Controls.MetroTextBox txt_lastName;
        private MetroFramework.Controls.MetroTextBox txt_firstName;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid grid_infoLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_index5;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_subtot;
        private MetroFramework.Controls.MetroTextBox txt_gst;
        private MetroFramework.Controls.MetroTextBox txt_tot;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroTextBox txt_qty;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}