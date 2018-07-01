namespace Pastry_ManagementSystem.UI
{
    partial class UpdateItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.batchIDSearch = new System.Windows.Forms.Panel();
            this.itemIDSearch = new System.Windows.Forms.Panel();
            this.itenNameSearch = new System.Windows.Forms.Panel();
            this.txt_item_Name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txt_batch_ID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_item_ID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.btn_search = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.grp_Box_Initial_Details = new System.Windows.Forms.GroupBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_taxAmt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.txt_cashWholeSale = new MetroFramework.Controls.MetroTextBox();
            this.txt_Vat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_purchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warehouse = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtp_Date = new MetroFramework.Controls.MetroDateTime();
            this.txt_ItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_ItemType = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_netAmount = new System.Windows.Forms.TextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txt_totPurchaseQty = new System.Windows.Forms.TextBox();
            this.txt_totQty = new System.Windows.Forms.TextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.cmb_ItemType = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_ItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_Box_Initial_Details.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.btn_search);
            this.metroPanel1.Controls.Add(this.btn_update);
            this.metroPanel1.Controls.Add(this.grp_Box_Initial_Details);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1213, 624);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(873, 428);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 53);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.batchIDSearch);
            this.groupBox2.Controls.Add(this.itemIDSearch);
            this.groupBox2.Controls.Add(this.itenNameSearch);
            this.groupBox2.Controls.Add(this.txt_item_Name);
            this.groupBox2.Controls.Add(this.metroLabel18);
            this.groupBox2.Controls.Add(this.txt_batch_ID);
            this.groupBox2.Controls.Add(this.metroLabel19);
            this.groupBox2.Controls.Add(this.txt_item_ID);
            this.groupBox2.Controls.Add(this.metroLabel17);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Location = new System.Drawing.Point(7, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1190, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // batchIDSearch
            // 
            this.batchIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batchIDSearch.BackgroundImage")));
            this.batchIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.batchIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batchIDSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batchIDSearch.Location = new System.Drawing.Point(1118, 41);
            this.batchIDSearch.Name = "batchIDSearch";
            this.batchIDSearch.Size = new System.Drawing.Size(33, 23);
            this.batchIDSearch.TabIndex = 49;
            this.batchIDSearch.Click += new System.EventHandler(this.batchIDSearch_Click);
            // 
            // itemIDSearch
            // 
            this.itemIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemIDSearch.BackgroundImage")));
            this.itemIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itemIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemIDSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemIDSearch.Location = new System.Drawing.Point(296, 41);
            this.itemIDSearch.Name = "itemIDSearch";
            this.itemIDSearch.Size = new System.Drawing.Size(33, 23);
            this.itemIDSearch.TabIndex = 48;
            this.itemIDSearch.Click += new System.EventHandler(this.itemIDSearch_Click);
            // 
            // itenNameSearch
            // 
            this.itenNameSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itenNameSearch.BackgroundImage")));
            this.itenNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.itenNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itenNameSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itenNameSearch.Location = new System.Drawing.Point(702, 41);
            this.itenNameSearch.Name = "itenNameSearch";
            this.itenNameSearch.Size = new System.Drawing.Size(33, 23);
            this.itenNameSearch.TabIndex = 47;
            this.itenNameSearch.Click += new System.EventHandler(this.itenNameSearch_Click);
            // 
            // txt_item_Name
            // 
            // 
            // 
            // 
            this.txt_item_Name.CustomButton.Image = null;
            this.txt_item_Name.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txt_item_Name.CustomButton.Name = "";
            this.txt_item_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_item_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_item_Name.CustomButton.TabIndex = 1;
            this.txt_item_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_item_Name.CustomButton.UseSelectable = true;
            this.txt_item_Name.CustomButton.Visible = false;
            this.txt_item_Name.Lines = new string[0];
            this.txt_item_Name.Location = new System.Drawing.Point(515, 41);
            this.txt_item_Name.MaxLength = 32767;
            this.txt_item_Name.Name = "txt_item_Name";
            this.txt_item_Name.PasswordChar = '\0';
            this.txt_item_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_item_Name.SelectedText = "";
            this.txt_item_Name.SelectionLength = 0;
            this.txt_item_Name.SelectionStart = 0;
            this.txt_item_Name.ShortcutsEnabled = true;
            this.txt_item_Name.Size = new System.Drawing.Size(220, 23);
            this.txt_item_Name.TabIndex = 2;
            this.txt_item_Name.UseSelectable = true;
            this.txt_item_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_item_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_item_Name.TextChanged += new System.EventHandler(this.txt_item_Name_TextChanged);
            this.txt_item_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_Name_KeyDown);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(27, 41);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(51, 19);
            this.metroLabel18.TabIndex = 0;
            this.metroLabel18.Text = "Item ID";
            // 
            // txt_batch_ID
            // 
            // 
            // 
            // 
            this.txt_batch_ID.CustomButton.Image = null;
            this.txt_batch_ID.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txt_batch_ID.CustomButton.Name = "";
            this.txt_batch_ID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_batch_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_batch_ID.CustomButton.TabIndex = 1;
            this.txt_batch_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_batch_ID.CustomButton.UseSelectable = true;
            this.txt_batch_ID.CustomButton.Visible = false;
            this.txt_batch_ID.Lines = new string[0];
            this.txt_batch_ID.Location = new System.Drawing.Point(931, 41);
            this.txt_batch_ID.MaxLength = 32767;
            this.txt_batch_ID.Name = "txt_batch_ID";
            this.txt_batch_ID.PasswordChar = '\0';
            this.txt_batch_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_batch_ID.SelectedText = "";
            this.txt_batch_ID.SelectionLength = 0;
            this.txt_batch_ID.SelectionStart = 0;
            this.txt_batch_ID.ShortcutsEnabled = true;
            this.txt_batch_ID.Size = new System.Drawing.Size(220, 23);
            this.txt_batch_ID.TabIndex = 1;
            this.txt_batch_ID.UseSelectable = true;
            this.txt_batch_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_batch_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_batch_ID.TextChanged += new System.EventHandler(this.txt_batch_ID_TextChanged);
            this.txt_batch_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_batch_ID_KeyDown);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(814, 41);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(57, 19);
            this.metroLabel19.TabIndex = 46;
            this.metroLabel19.Text = "Batch ID";
            // 
            // txt_item_ID
            // 
            // 
            // 
            // 
            this.txt_item_ID.CustomButton.Image = null;
            this.txt_item_ID.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txt_item_ID.CustomButton.Name = "";
            this.txt_item_ID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_item_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_item_ID.CustomButton.TabIndex = 1;
            this.txt_item_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_item_ID.CustomButton.UseSelectable = true;
            this.txt_item_ID.CustomButton.Visible = false;
            this.txt_item_ID.Lines = new string[0];
            this.txt_item_ID.Location = new System.Drawing.Point(134, 41);
            this.txt_item_ID.MaxLength = 32767;
            this.txt_item_ID.Name = "txt_item_ID";
            this.txt_item_ID.PasswordChar = '\0';
            this.txt_item_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_item_ID.SelectedText = "";
            this.txt_item_ID.SelectionLength = 0;
            this.txt_item_ID.SelectionStart = 0;
            this.txt_item_ID.ShortcutsEnabled = true;
            this.txt_item_ID.Size = new System.Drawing.Size(195, 23);
            this.txt_item_ID.TabIndex = 0;
            this.txt_item_ID.UseSelectable = true;
            this.txt_item_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_item_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_item_ID.TextChanged += new System.EventHandler(this.txt_item_ID_TextChanged);
            this.txt_item_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_ID_KeyDown);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(381, 41);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(75, 19);
            this.metroLabel17.TabIndex = 27;
            this.metroLabel17.Text = "Item Name";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(6, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(281, 19);
            this.metroLabel16.TabIndex = 0;
            this.metroLabel16.Text = "Enter Information To Find Perticular Item";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Location = new System.Drawing.Point(736, 428);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(131, 53);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Back";
            this.btn_search.UseSelectable = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(599, 428);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 53);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update Item";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            this.btn_update.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_update_KeyDown);
            // 
            // grp_Box_Initial_Details
            // 
            this.grp_Box_Initial_Details.Controls.Add(this.metroLabel14);
            this.grp_Box_Initial_Details.Controls.Add(this.txt_taxAmt);
            this.grp_Box_Initial_Details.Controls.Add(this.metroLabel26);
            this.grp_Box_Initial_Details.Controls.Add(this.txt_cashWholeSale);
            this.grp_Box_Initial_Details.Controls.Add(this.txt_Vat);
            this.grp_Box_Initial_Details.Controls.Add(this.metroLabel11);
            this.grp_Box_Initial_Details.Controls.Add(this.txt_purchasePrice);
            this.grp_Box_Initial_Details.Controls.Add(this.metroLabel10);
            this.grp_Box_Initial_Details.Controls.Add(this.metroLabel9);
            this.grp_Box_Initial_Details.Enabled = false;
            this.grp_Box_Initial_Details.Location = new System.Drawing.Point(600, 130);
            this.grp_Box_Initial_Details.Name = "grp_Box_Initial_Details";
            this.grp_Box_Initial_Details.Size = new System.Drawing.Size(597, 264);
            this.grp_Box_Initial_Details.TabIndex = 3;
            this.grp_Box_Initial_Details.TabStop = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(36, 110);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(116, 19);
            this.metroLabel14.TabIndex = 44;
            this.metroLabel14.Text = "Price in Wholesale";
            // 
            // txt_taxAmt
            // 
            // 
            // 
            // 
            this.txt_taxAmt.CustomButton.Image = null;
            this.txt_taxAmt.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txt_taxAmt.CustomButton.Name = "";
            this.txt_taxAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_taxAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_taxAmt.CustomButton.TabIndex = 1;
            this.txt_taxAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_taxAmt.CustomButton.UseSelectable = true;
            this.txt_taxAmt.CustomButton.Visible = false;
            this.txt_taxAmt.Lines = new string[0];
            this.txt_taxAmt.Location = new System.Drawing.Point(288, 194);
            this.txt_taxAmt.MaxLength = 32767;
            this.txt_taxAmt.Name = "txt_taxAmt";
            this.txt_taxAmt.PasswordChar = '\0';
            this.txt_taxAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_taxAmt.SelectedText = "";
            this.txt_taxAmt.SelectionLength = 0;
            this.txt_taxAmt.SelectionStart = 0;
            this.txt_taxAmt.ShortcutsEnabled = true;
            this.txt_taxAmt.Size = new System.Drawing.Size(161, 23);
            this.txt_taxAmt.TabIndex = 5;
            this.txt_taxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_taxAmt.UseSelectable = true;
            this.txt_taxAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_taxAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_taxAmt.TextChanged += new System.EventHandler(this.txt_taxAmt_TextChanged);
            this.txt_taxAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_taxAmt_KeyPress);
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(36, 155);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(49, 19);
            this.metroLabel26.TabIndex = 45;
            this.metroLabel26.Text = "VAT  %";
            // 
            // txt_cashWholeSale
            // 
            // 
            // 
            // 
            this.txt_cashWholeSale.CustomButton.Image = null;
            this.txt_cashWholeSale.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txt_cashWholeSale.CustomButton.Name = "";
            this.txt_cashWholeSale.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_cashWholeSale.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cashWholeSale.CustomButton.TabIndex = 1;
            this.txt_cashWholeSale.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cashWholeSale.CustomButton.UseSelectable = true;
            this.txt_cashWholeSale.CustomButton.Visible = false;
            this.txt_cashWholeSale.Lines = new string[0];
            this.txt_cashWholeSale.Location = new System.Drawing.Point(288, 110);
            this.txt_cashWholeSale.MaxLength = 32767;
            this.txt_cashWholeSale.Name = "txt_cashWholeSale";
            this.txt_cashWholeSale.PasswordChar = '\0';
            this.txt_cashWholeSale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cashWholeSale.SelectedText = "";
            this.txt_cashWholeSale.SelectionLength = 0;
            this.txt_cashWholeSale.SelectionStart = 0;
            this.txt_cashWholeSale.ShortcutsEnabled = true;
            this.txt_cashWholeSale.Size = new System.Drawing.Size(252, 23);
            this.txt_cashWholeSale.TabIndex = 3;
            this.txt_cashWholeSale.UseSelectable = true;
            this.txt_cashWholeSale.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_cashWholeSale.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cashWholeSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cashWholeSale_KeyPress);
            // 
            // txt_Vat
            // 
            // 
            // 
            // 
            this.txt_Vat.CustomButton.Image = null;
            this.txt_Vat.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txt_Vat.CustomButton.Name = "";
            this.txt_Vat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Vat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Vat.CustomButton.TabIndex = 1;
            this.txt_Vat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Vat.CustomButton.UseSelectable = true;
            this.txt_Vat.CustomButton.Visible = false;
            this.txt_Vat.Lines = new string[0];
            this.txt_Vat.Location = new System.Drawing.Point(288, 151);
            this.txt_Vat.MaxLength = 32767;
            this.txt_Vat.Name = "txt_Vat";
            this.txt_Vat.PasswordChar = '\0';
            this.txt_Vat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Vat.SelectedText = "";
            this.txt_Vat.SelectionLength = 0;
            this.txt_Vat.SelectionStart = 0;
            this.txt_Vat.ShortcutsEnabled = true;
            this.txt_Vat.Size = new System.Drawing.Size(161, 23);
            this.txt_Vat.TabIndex = 4;
            this.txt_Vat.UseSelectable = true;
            this.txt_Vat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Vat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Vat.TextChanged += new System.EventHandler(this.txt_Vat_TextChanged);
            this.txt_Vat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Vat_KeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(36, 198);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(81, 19);
            this.metroLabel11.TabIndex = 38;
            this.metroLabel11.Text = "VAT Amount";
            // 
            // txt_purchasePrice
            // 
            // 
            // 
            // 
            this.txt_purchasePrice.CustomButton.Image = null;
            this.txt_purchasePrice.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txt_purchasePrice.CustomButton.Name = "";
            this.txt_purchasePrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_purchasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_purchasePrice.CustomButton.TabIndex = 1;
            this.txt_purchasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_purchasePrice.CustomButton.UseSelectable = true;
            this.txt_purchasePrice.CustomButton.Visible = false;
            this.txt_purchasePrice.Lines = new string[0];
            this.txt_purchasePrice.Location = new System.Drawing.Point(288, 64);
            this.txt_purchasePrice.MaxLength = 32767;
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.PasswordChar = '\0';
            this.txt_purchasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_purchasePrice.SelectedText = "";
            this.txt_purchasePrice.SelectionLength = 0;
            this.txt_purchasePrice.SelectionStart = 0;
            this.txt_purchasePrice.ShortcutsEnabled = true;
            this.txt_purchasePrice.Size = new System.Drawing.Size(252, 23);
            this.txt_purchasePrice.TabIndex = 0;
            this.txt_purchasePrice.UseSelectable = true;
            this.txt_purchasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_purchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_purchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_purchasePrice_KeyPress);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(36, 64);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(94, 19);
            this.metroLabel10.TabIndex = 36;
            this.metroLabel10.Text = "Purchase Price";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(15, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(95, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "Initial Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warehouse);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroPanel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.txt_ItemDesc);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txt_ItemType);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cmb_ItemType);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txt_ItemName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(8, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // warehouse
            // 
            // 
            // 
            // 
            this.warehouse.CustomButton.Image = null;
            this.warehouse.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.warehouse.CustomButton.Name = "";
            this.warehouse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.warehouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.warehouse.CustomButton.TabIndex = 1;
            this.warehouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.warehouse.CustomButton.UseSelectable = true;
            this.warehouse.CustomButton.Visible = false;
            this.warehouse.Lines = new string[0];
            this.warehouse.Location = new System.Drawing.Point(193, 160);
            this.warehouse.MaxLength = 32767;
            this.warehouse.Name = "warehouse";
            this.warehouse.PasswordChar = '\0';
            this.warehouse.ReadOnly = true;
            this.warehouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.warehouse.SelectedText = "";
            this.warehouse.SelectionLength = 0;
            this.warehouse.SelectionStart = 0;
            this.warehouse.ShortcutsEnabled = true;
            this.warehouse.Size = new System.Drawing.Size(188, 23);
            this.warehouse.TabIndex = 53;
            this.warehouse.UseSelectable = true;
            this.warehouse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.warehouse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "Warehouse";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel3.BackgroundImage")));
            this.metroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(13, 194);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(174, 148);
            this.metroPanel3.TabIndex = 51;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Date and Time";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(193, 122);
            this.dtp_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(188, 29);
            this.dtp_Date.TabIndex = 4;
            // 
            // txt_ItemDesc
            // 
            // 
            // 
            // 
            this.txt_ItemDesc.CustomButton.Image = null;
            this.txt_ItemDesc.CustomButton.Location = new System.Drawing.Point(346, 1);
            this.txt_ItemDesc.CustomButton.Name = "";
            this.txt_ItemDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ItemDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ItemDesc.CustomButton.TabIndex = 1;
            this.txt_ItemDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ItemDesc.CustomButton.UseSelectable = true;
            this.txt_ItemDesc.CustomButton.Visible = false;
            this.txt_ItemDesc.Lines = new string[0];
            this.txt_ItemDesc.Location = new System.Drawing.Point(193, 90);
            this.txt_ItemDesc.MaxLength = 32767;
            this.txt_ItemDesc.Name = "txt_ItemDesc";
            this.txt_ItemDesc.PasswordChar = '\0';
            this.txt_ItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ItemDesc.SelectedText = "";
            this.txt_ItemDesc.SelectionLength = 0;
            this.txt_ItemDesc.SelectionStart = 0;
            this.txt_ItemDesc.ShortcutsEnabled = true;
            this.txt_ItemDesc.Size = new System.Drawing.Size(368, 23);
            this.txt_ItemDesc.TabIndex = 3;
            this.txt_ItemDesc.UseSelectable = true;
            this.txt_ItemDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ItemDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ItemDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ItemDesc_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Item Description";
            // 
            // txt_ItemType
            // 
            // 
            // 
            // 
            this.txt_ItemType.CustomButton.Image = null;
            this.txt_ItemType.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txt_ItemType.CustomButton.Name = "";
            this.txt_ItemType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ItemType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ItemType.CustomButton.TabIndex = 1;
            this.txt_ItemType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ItemType.CustomButton.UseSelectable = true;
            this.txt_ItemType.CustomButton.Visible = false;
            this.txt_ItemType.Enabled = false;
            this.txt_ItemType.Lines = new string[0];
            this.txt_ItemType.Location = new System.Drawing.Point(403, 59);
            this.txt_ItemType.MaxLength = 32767;
            this.txt_ItemType.Name = "txt_ItemType";
            this.txt_ItemType.PasswordChar = '\0';
            this.txt_ItemType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ItemType.SelectedText = "";
            this.txt_ItemType.SelectionLength = 0;
            this.txt_ItemType.SelectionStart = 0;
            this.txt_ItemType.ShortcutsEnabled = true;
            this.txt_ItemType.Size = new System.Drawing.Size(156, 23);
            this.txt_ItemType.TabIndex = 3;
            this.txt_ItemType.UseSelectable = true;
            this.txt_ItemType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ItemType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_netAmount);
            this.groupBox4.Controls.Add(this.metroLabel20);
            this.groupBox4.Controls.Add(this.txt_totPurchaseQty);
            this.groupBox4.Controls.Add(this.txt_totQty);
            this.groupBox4.Controls.Add(this.metroLabel21);
            this.groupBox4.Controls.Add(this.metroLabel22);
            this.groupBox4.Controls.Add(this.metroLabel24);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(193, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 134);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // txt_netAmount
            // 
            this.txt_netAmount.Location = new System.Drawing.Point(278, 93);
            this.txt_netAmount.Name = "txt_netAmount";
            this.txt_netAmount.Size = new System.Drawing.Size(92, 20);
            this.txt_netAmount.TabIndex = 2;
            this.txt_netAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(0, 3);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(122, 19);
            this.metroLabel20.TabIndex = 27;
            this.metroLabel20.Text = "Grand Total Data";
            // 
            // txt_totPurchaseQty
            // 
            this.txt_totPurchaseQty.Location = new System.Drawing.Point(278, 29);
            this.txt_totPurchaseQty.Name = "txt_totPurchaseQty";
            this.txt_totPurchaseQty.Size = new System.Drawing.Size(92, 20);
            this.txt_totPurchaseQty.TabIndex = 0;
            this.txt_totPurchaseQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_totQty
            // 
            this.txt_totQty.Location = new System.Drawing.Point(278, 61);
            this.txt_totQty.Name = "txt_totQty";
            this.txt_totQty.Size = new System.Drawing.Size(92, 20);
            this.txt_totQty.TabIndex = 1;
            this.txt_totQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(78, 29);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(180, 19);
            this.metroLabel21.TabIndex = 41;
            this.metroLabel21.Text = "Total Purchasing Quantity";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.Location = new System.Drawing.Point(98, 62);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(160, 19);
            this.metroLabel22.TabIndex = 42;
            this.metroLabel22.Text = "Total Quantity Needed";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel24.Location = new System.Drawing.Point(21, 93);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(237, 19);
            this.metroLabel24.TabIndex = 44;
            this.metroLabel24.Text = "Total Purchase Amount (With VAT)";
            // 
            // cmb_ItemType
            // 
            this.cmb_ItemType.FormattingEnabled = true;
            this.cmb_ItemType.Items.AddRange(new object[] {
            "Kitchen Items",
            "Food Items",
            "Furniture Items",
            "Grocery Items",
            "perishable foods",
            "Non - perishable foods",
            "Milk",
            "Semi - perishable foods",
            "Vegetables",
            "Ingredients"});
            this.cmb_ItemType.Location = new System.Drawing.Point(193, 60);
            this.cmb_ItemType.Name = "cmb_ItemType";
            this.cmb_ItemType.Size = new System.Drawing.Size(204, 21);
            this.cmb_ItemType.TabIndex = 2;
            this.cmb_ItemType.SelectedIndexChanged += new System.EventHandler(this.cmb_ItemType_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Item Type";
            // 
            // txt_ItemName
            // 
            // 
            // 
            // 
            this.txt_ItemName.CustomButton.Image = null;
            this.txt_ItemName.CustomButton.Location = new System.Drawing.Point(344, 1);
            this.txt_ItemName.CustomButton.Name = "";
            this.txt_ItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_ItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ItemName.CustomButton.TabIndex = 1;
            this.txt_ItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ItemName.CustomButton.UseSelectable = true;
            this.txt_ItemName.CustomButton.Visible = false;
            this.txt_ItemName.Lines = new string[0];
            this.txt_ItemName.Location = new System.Drawing.Point(193, 26);
            this.txt_ItemName.MaxLength = 32767;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.PasswordChar = '\0';
            this.txt_ItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ItemName.SelectedText = "";
            this.txt_ItemName.SelectionLength = 0;
            this.txt_ItemName.SelectionStart = 0;
            this.txt_ItemName.ShortcutsEnabled = true;
            this.txt_ItemName.Size = new System.Drawing.Size(366, 23);
            this.txt_ItemName.TabIndex = 1;
            this.txt_ItemName.UseSelectable = true;
            this.txt_ItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_ItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ItemName_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Item Name";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(6, -4);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(122, 19);
            this.metroLabel15.TabIndex = 0;
            this.metroLabel15.Text = "Item Information";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(7, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(118, 25);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Update Item";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 515);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateItemForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_Box_Initial_Details.ResumeLayout(false);
            this.grp_Box_Initial_Details.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtp_Date;
        private MetroFramework.Controls.MetroTextBox txt_ItemDesc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_ItemType;
        private System.Windows.Forms.ComboBox cmb_ItemType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_ItemName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.GroupBox grp_Box_Initial_Details;
        private MetroFramework.Controls.MetroTextBox txt_taxAmt;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroTextBox txt_cashWholeSale;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txt_Vat;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_purchasePrice;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_netAmount;
        private System.Windows.Forms.TextBox txt_totQty;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroButton btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txt_batch_ID;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txt_item_Name;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton btn_update;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel batchIDSearch;
        private System.Windows.Forms.Panel itemIDSearch;
        private System.Windows.Forms.Panel itenNameSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroTextBox txt_item_ID;
        private MetroFramework.Controls.MetroTextBox warehouse;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txt_totPurchaseQty;
        private MetroFramework.Controls.MetroLabel metroLabel21;
    }
}