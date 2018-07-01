namespace Pastry_ManagementSystem.UI.HelpScreens
{
    partial class InvHelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvHelpScreen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrdeLvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredlvlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invetoryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetoryInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.itemNameDataGridViewTextBoxColumn,
            this.reOrdeLvlDataGridViewTextBoxColumn,
            this.requiredlvlDataGridViewTextBoxColumn,
            this.availableQtyDataGridViewTextBoxColumn,
            this.warehouseCodeDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.invetoryInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvITemCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvITemCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // reOrdeLvlDataGridViewTextBoxColumn
            // 
            this.reOrdeLvlDataGridViewTextBoxColumn.DataPropertyName = "reOrdeLvl";
            this.reOrdeLvlDataGridViewTextBoxColumn.HeaderText = "reOrdeLvl";
            this.reOrdeLvlDataGridViewTextBoxColumn.Name = "reOrdeLvlDataGridViewTextBoxColumn";
            // 
            // requiredlvlDataGridViewTextBoxColumn
            // 
            this.requiredlvlDataGridViewTextBoxColumn.DataPropertyName = "required_lvl";
            this.requiredlvlDataGridViewTextBoxColumn.HeaderText = "required_lvl";
            this.requiredlvlDataGridViewTextBoxColumn.Name = "requiredlvlDataGridViewTextBoxColumn";
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            // 
            // warehouseCodeDataGridViewTextBoxColumn
            // 
            this.warehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.HeaderText = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.Name = "warehouseCodeDataGridViewTextBoxColumn";
            // 
            // invetoryInfoBindingSource
            // 
            this.invetoryInfoBindingSource.DataSource = typeof(Pastry_ManagementSystem.ExtraClassesToMapData.InvetoryInfo);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(4, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InvHelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 493);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvHelpScreen";
            this.Text = "Help Screen";
            this.Load += new System.EventHandler(this.InvHelpScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetoryInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn invITemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrdeLvlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredlvlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource invetoryInfoBindingSource;
    }
}