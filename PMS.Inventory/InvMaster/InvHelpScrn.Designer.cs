namespace PMS.Inventory.InvMaster
{
    partial class InvHelpScrn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvHelpScrn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.helpObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invITemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invITemCodeDataGridViewTextBoxColumn,
            this.warehouseCodeDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescDataGridViewTextBoxColumn,
            this.itemGroupDataGridViewTextBoxColumn,
            this.storageDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.helpObjBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // helpObjBindingSource
            // 
            this.helpObjBindingSource.DataSource = typeof(PMS.Inventory.InvObjects.HelpObj);
            // 
            // invITemCodeDataGridViewTextBoxColumn
            // 
            this.invITemCodeDataGridViewTextBoxColumn.DataPropertyName = "InvITemCode";
            this.invITemCodeDataGridViewTextBoxColumn.HeaderText = "InvITemCode";
            this.invITemCodeDataGridViewTextBoxColumn.Name = "invITemCodeDataGridViewTextBoxColumn";
            // 
            // warehouseCodeDataGridViewTextBoxColumn
            // 
            this.warehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.HeaderText = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.Name = "warehouseCodeDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemDescDataGridViewTextBoxColumn
            // 
            this.itemDescDataGridViewTextBoxColumn.DataPropertyName = "itemDesc";
            this.itemDescDataGridViewTextBoxColumn.HeaderText = "itemDesc";
            this.itemDescDataGridViewTextBoxColumn.Name = "itemDescDataGridViewTextBoxColumn";
            // 
            // itemGroupDataGridViewTextBoxColumn
            // 
            this.itemGroupDataGridViewTextBoxColumn.DataPropertyName = "itemGroup";
            this.itemGroupDataGridViewTextBoxColumn.HeaderText = "itemGroup";
            this.itemGroupDataGridViewTextBoxColumn.Name = "itemGroupDataGridViewTextBoxColumn";
            // 
            // storageDataGridViewTextBoxColumn
            // 
            this.storageDataGridViewTextBoxColumn.DataPropertyName = "Storage";
            this.storageDataGridViewTextBoxColumn.HeaderText = "Storage";
            this.storageDataGridViewTextBoxColumn.Name = "storageDataGridViewTextBoxColumn";
            // 
            // InvHelpScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 436);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InvHelpScrn";
            this.Text = "InvHelpScrn";
            this.Load += new System.EventHandler(this.InvHelpScrn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpObjBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn invITemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource helpObjBindingSource;
    }
}