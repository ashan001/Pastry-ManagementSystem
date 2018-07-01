namespace Pastry_ManagementSystem.UI.HelpScreens
{
    partial class ItemHelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemHelpScreen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totpurchasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.grid1);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-3, 31);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(772, 512);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AutoGenerateColumns = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescDataGridViewTextBoxColumn,
            this.batchNoDataGridViewTextBoxColumn,
            this.purchasepriceDataGridViewTextBoxColumn,
            this.warehouseCodeDataGridViewTextBoxColumn,
            this.totpurchasesDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn});
            this.grid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grid1.DataSource = this.itemInfoBindingSource;
            this.grid1.Location = new System.Drawing.Point(9, 5);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(741, 453);
            this.grid1.TabIndex = 5;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            this.grid1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentDoubleClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemDescDataGridViewTextBoxColumn
            // 
            this.itemDescDataGridViewTextBoxColumn.DataPropertyName = "item_Desc";
            this.itemDescDataGridViewTextBoxColumn.HeaderText = "item_Desc";
            this.itemDescDataGridViewTextBoxColumn.Name = "itemDescDataGridViewTextBoxColumn";
            // 
            // batchNoDataGridViewTextBoxColumn
            // 
            this.batchNoDataGridViewTextBoxColumn.DataPropertyName = "batch_No";
            this.batchNoDataGridViewTextBoxColumn.HeaderText = "batch_No";
            this.batchNoDataGridViewTextBoxColumn.Name = "batchNoDataGridViewTextBoxColumn";
            // 
            // purchasepriceDataGridViewTextBoxColumn
            // 
            this.purchasepriceDataGridViewTextBoxColumn.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.Name = "purchasepriceDataGridViewTextBoxColumn";
            // 
            // warehouseCodeDataGridViewTextBoxColumn
            // 
            this.warehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.HeaderText = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.Name = "warehouseCodeDataGridViewTextBoxColumn";
            // 
            // totpurchasesDataGridViewTextBoxColumn
            // 
            this.totpurchasesDataGridViewTextBoxColumn.DataPropertyName = "tot_purchases";
            this.totpurchasesDataGridViewTextBoxColumn.HeaderText = "tot_purchases";
            this.totpurchasesDataGridViewTextBoxColumn.Name = "totpurchasesDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemInfoBindingSource
            // 
            this.itemInfoBindingSource.DataSource = typeof(Pastry_ManagementSystem.ExtraClassesToMapData.ItemInfo);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(13, 468);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(72, 32);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Close";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Item Help Screen";
            // 
            // ItemHelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 539);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemHelpScreen";
            this.Load += new System.EventHandler(this.ItemHelpScreen_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.DataGridView grid1;
        public MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totpurchasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemInfoBindingSource;
    }
}