namespace PMS.AdminPanel.UI.ReportingModule.Reports
{
    partial class StockTransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTransactionReport));
            this.btn_load = new System.Windows.Forms.Button();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.transactionReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionObjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Location = new System.Drawing.Point(572, 13);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(78, 21);
            this.btn_load.TabIndex = 12;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_ToDate.Location = new System.Drawing.Point(345, 12);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_ToDate.TabIndex = 11;
            this.dtp_ToDate.Value = new System.DateTime(2017, 5, 10, 0, 0, 0, 0);
            this.dtp_ToDate.ValueChanged += new System.EventHandler(this.dtp_ToDate_ValueChanged);
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_FromDate.Location = new System.Drawing.Point(73, 11);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_FromDate.TabIndex = 10;
            this.dtp_FromDate.Value = new System.DateTime(2017, 5, 10, 0, 0, 0, 0);
            this.dtp_FromDate.ValueChanged += new System.EventHandler(this.dtp_FromDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionReferenceDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.warehouseCodeDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionObjectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 258);
            this.dataGridView1.TabIndex = 13;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Location = new System.Drawing.Point(103, 304);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 30);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Location = new System.Drawing.Point(10, 304);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(78, 30);
            this.btn_print.TabIndex = 16;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // transactionReferenceDataGridViewTextBoxColumn
            // 
            this.transactionReferenceDataGridViewTextBoxColumn.DataPropertyName = "TransactionReference";
            this.transactionReferenceDataGridViewTextBoxColumn.HeaderText = "TransactionReference";
            this.transactionReferenceDataGridViewTextBoxColumn.Name = "transactionReferenceDataGridViewTextBoxColumn";
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "itemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "itemCode";
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            // 
            // warehouseCodeDataGridViewTextBoxColumn
            // 
            this.warehouseCodeDataGridViewTextBoxColumn.DataPropertyName = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.HeaderText = "warehouseCode";
            this.warehouseCodeDataGridViewTextBoxColumn.Name = "warehouseCodeDataGridViewTextBoxColumn";
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // transactionObjectsBindingSource
            // 
            this.transactionObjectsBindingSource.DataSource = typeof(PMS.AdminPanel.UI.ReportingModule.MapObjects.TransactionObjects);
            // 
            // StockTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 340);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockTransactionReport";
            this.Text = "StockTransactionReport";
            this.Load += new System.EventHandler(this.StockTransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionObjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionObjectsBindingSource;
    }
}