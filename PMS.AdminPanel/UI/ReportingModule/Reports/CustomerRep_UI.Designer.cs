namespace PMS.AdminPanel.UI.ReportingModule.Reports
{
    partial class CustomerRep_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRep_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedTimesFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Location = new System.Drawing.Point(85, 24);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_FromDate.TabIndex = 2;
            this.dtp_FromDate.Value = new System.DateTime(2017, 4, 29, 0, 0, 0, 0);
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Location = new System.Drawing.Point(392, 24);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_ToDate.TabIndex = 3;
            this.dtp_ToDate.Value = new System.DateTime(2017, 4, 29, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNumDataGridViewTextBoxColumn,
            this.cusaddressDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totAmtDataGridViewTextBoxColumn,
            this.orderedTimesFlagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 343);
            this.dataGridView1.TabIndex = 4;
            // 
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "cusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "cusID";
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // contactNumDataGridViewTextBoxColumn
            // 
            this.contactNumDataGridViewTextBoxColumn.DataPropertyName = "ContactNum";
            this.contactNumDataGridViewTextBoxColumn.HeaderText = "ContactNum";
            this.contactNumDataGridViewTextBoxColumn.Name = "contactNumDataGridViewTextBoxColumn";
            // 
            // cusaddressDataGridViewTextBoxColumn
            // 
            this.cusaddressDataGridViewTextBoxColumn.DataPropertyName = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.HeaderText = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.Name = "cusaddressDataGridViewTextBoxColumn";
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "regDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "regDate";
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totAmtDataGridViewTextBoxColumn
            // 
            this.totAmtDataGridViewTextBoxColumn.DataPropertyName = "totAmt";
            this.totAmtDataGridViewTextBoxColumn.HeaderText = "totAmt";
            this.totAmtDataGridViewTextBoxColumn.Name = "totAmtDataGridViewTextBoxColumn";
            // 
            // orderedTimesFlagDataGridViewTextBoxColumn
            // 
            this.orderedTimesFlagDataGridViewTextBoxColumn.DataPropertyName = "OrderedTimes_Flag";
            this.orderedTimesFlagDataGridViewTextBoxColumn.HeaderText = "OrderedTimes_Flag";
            this.orderedTimesFlagDataGridViewTextBoxColumn.Name = "orderedTimesFlagDataGridViewTextBoxColumn";
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataSource = typeof(MapObjects.CustomerDetails);
            // 
            // btn_print
            // 
            this.btn_print.Enabled = false;
            this.btn_print.Location = new System.Drawing.Point(7, 403);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(78, 40);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(91, 403);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(78, 40);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(660, 27);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(78, 21);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // CustomerRep_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerRep_UI";
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.CustomerRep_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedTimesFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_load;
    }
}