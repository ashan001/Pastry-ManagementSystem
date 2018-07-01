namespace PMS.Inventory.InvMaster
{
    partial class frmWarehouseHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseHelp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.warehousecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehousecodeDataGridViewTextBoxColumn,
            this.warehousedescriptionDataGridViewTextBoxColumn,
            this.warehouseStatusDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.warehouseObjBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // warehouseObjBindingSource
            // 
            this.warehouseObjBindingSource.DataSource = typeof(PMS.Inventory.InvObjects.WarehouseObj);
            // 
            // frmWarehouseHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 464);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmWarehouseHelp";
            this.Text = "frmWarehouseHelp";
            this.Load += new System.EventHandler(this.frmWarehouseHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseObjBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehousecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehousedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource warehouseObjBindingSource;
    }
}