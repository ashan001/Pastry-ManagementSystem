namespace Pastry_ManagementSystem.UI.ReportUI
{
    partial class DailyItemReportScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyItemReportScreen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.dtp_date = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totpurchasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.btn_print);
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.dtp_date);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.txt_itemName);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 52);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(865, 474);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(760, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Enabled = false;
            this.btn_print.Location = new System.Drawing.Point(664, 400);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(90, 35);
            this.btn_print.TabIndex = 27;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(579, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(77, 28);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_date.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtp_date.Location = new System.Drawing.Point(386, 21);
            this.dtp_date.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(154, 25);
            this.dtp_date.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date";
            // 
            // txt_itemName
            // 
            // 
            // 
            // 
            this.txt_itemName.CustomButton.Image = null;
            this.txt_itemName.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txt_itemName.CustomButton.Name = "";
            this.txt_itemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemName.CustomButton.TabIndex = 1;
            this.txt_itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemName.CustomButton.UseSelectable = true;
            this.txt_itemName.CustomButton.Visible = false;
            this.txt_itemName.Lines = new string[0];
            this.txt_itemName.Location = new System.Drawing.Point(126, 24);
            this.txt_itemName.MaxLength = 32767;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.SelectionLength = 0;
            this.txt_itemName.SelectionStart = 0;
            this.txt_itemName.ShortcutsEnabled = true;
            this.txt_itemName.Size = new System.Drawing.Size(182, 23);
            this.txt_itemName.TabIndex = 20;
            this.txt_itemName.UseSelectable = true;
            this.txt_itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemName.TextChanged += new System.EventHandler(this.txt_itemName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.warehouseCodeDataGridViewTextBoxColumn,
            this.availableQtyDataGridViewTextBoxColumn,
            this.purchasepriceDataGridViewTextBoxColumn,
            this.vatAmtDataGridViewTextBoxColumn,
            this.totpurchasesDataGridViewTextBoxColumn,
            this.netAmtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 331);
            this.dataGridView1.TabIndex = 2;
            // 
            // itemClassBindingSource
            // 
            this.itemClassBindingSource.DataSource = typeof(Pastry_ManagementSystem.Other.ItemClass);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "empID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "empID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // warehouseCodeDataGridViewTextBoxColumn
            // 
            this.warehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.HeaderText = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.Name = "warehouseCodeDataGridViewTextBoxColumn";
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            // 
            // purchasepriceDataGridViewTextBoxColumn
            // 
            this.purchasepriceDataGridViewTextBoxColumn.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.Name = "purchasepriceDataGridViewTextBoxColumn";
            // 
            // vatAmtDataGridViewTextBoxColumn
            // 
            this.vatAmtDataGridViewTextBoxColumn.DataPropertyName = "Vat_Amt";
            this.vatAmtDataGridViewTextBoxColumn.HeaderText = "Vat_Amt";
            this.vatAmtDataGridViewTextBoxColumn.Name = "vatAmtDataGridViewTextBoxColumn";
            // 
            // totpurchasesDataGridViewTextBoxColumn
            // 
            this.totpurchasesDataGridViewTextBoxColumn.DataPropertyName = "tot_purchases";
            this.totpurchasesDataGridViewTextBoxColumn.HeaderText = "tot_purchases";
            this.totpurchasesDataGridViewTextBoxColumn.Name = "totpurchasesDataGridViewTextBoxColumn";
            // 
            // netAmtDataGridViewTextBoxColumn
            // 
            this.netAmtDataGridViewTextBoxColumn.DataPropertyName = "net_Amt";
            this.netAmtDataGridViewTextBoxColumn.HeaderText = "net_Amt";
            this.netAmtDataGridViewTextBoxColumn.Name = "netAmtDataGridViewTextBoxColumn";
            // 
            // DailyItemReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 497);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DailyItemReportScreen";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "DailyItemReport";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txt_itemName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dtp_date;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btn_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totpurchasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemClassBindingSource;
    }
}