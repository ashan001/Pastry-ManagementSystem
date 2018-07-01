namespace Pastry_ManagementSystem.UI.HelpScreens
{
    partial class WarehouseHelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseHelpScreen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.warehousecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehousecodeDataGridViewTextBoxColumn,
            this.warehousedescriptionDataGridViewTextBoxColumn,
            this.warehouseStatusDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.warehouseInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // warehousecodeDataGridViewTextBoxColumn
            // 
            this.warehousecodeDataGridViewTextBoxColumn.DataPropertyName = "warehouse_code";
            this.warehousecodeDataGridViewTextBoxColumn.HeaderText = "warehouse_code";
            this.warehousecodeDataGridViewTextBoxColumn.Name = "warehousecodeDataGridViewTextBoxColumn";
            // 
            // warehousedescriptionDataGridViewTextBoxColumn
            // 
            this.warehousedescriptionDataGridViewTextBoxColumn.DataPropertyName = "Warehouse_description";
            this.warehousedescriptionDataGridViewTextBoxColumn.HeaderText = "Warehouse_description";
            this.warehousedescriptionDataGridViewTextBoxColumn.Name = "warehousedescriptionDataGridViewTextBoxColumn";
            // 
            // warehouseStatusDataGridViewTextBoxColumn
            // 
            this.warehouseStatusDataGridViewTextBoxColumn.DataPropertyName = "warehouseStatus";
            this.warehouseStatusDataGridViewTextBoxColumn.HeaderText = "warehouseStatus";
            this.warehouseStatusDataGridViewTextBoxColumn.Name = "warehouseStatusDataGridViewTextBoxColumn";
            // 
            // warehouseInfoBindingSource
            // 
            this.warehouseInfoBindingSource.DataSource = typeof(Pastry_ManagementSystem.ExtraClassesToMapData.WarehouseInfo);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(5, 428);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 33);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // WarehouseHelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 466);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarehouseHelpScreen";
            this.Text = "Warehouse Help Screen";
            this.Load += new System.EventHandler(this.WarehouseHelpScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_cancel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehousecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehousedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource warehouseInfoBindingSource;
    }
}