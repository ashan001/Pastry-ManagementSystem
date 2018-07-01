namespace Pastry_ManagementSystem.UI.ReportUI
{
    partial class PurchasedRawMaterialReportScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasedRawMaterialReportScreen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtpFromDate = new MetroFramework.Controls.MetroLabel();
            this.dtpToDate = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this._dtpFrmDate = new MetroFramework.Controls.MetroDateTime();
            this._dtpToDate = new MetroFramework.Controls.MetroDateTime();
            this.puridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplliercompanynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this._dtpToDate);
            this.metroPanel1.Controls.Add(this._dtpFrmDate);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.btn_print);
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.dtpToDate);
            this.metroPanel1.Controls.Add(this.dtpFromDate);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 58);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(773, 394);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.AutoSize = true;
            this.dtpFromDate.Location = new System.Drawing.Point(25, 23);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(72, 19);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.Text = "From Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.AutoSize = true;
            this.dtpToDate.Location = new System.Drawing.Point(304, 23);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(53, 19);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.Text = "To Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.puridDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn,
            this.supplliercompanynameDataGridViewTextBoxColumn,
            this.vdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.orderqtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 280);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(603, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Enabled = false;
            this.btn_print.Location = new System.Drawing.Point(11, 339);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(91, 41);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(113, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // _dtpFrmDate
            // 
            this._dtpFrmDate.Location = new System.Drawing.Point(107, 19);
            this._dtpFrmDate.MinimumSize = new System.Drawing.Size(0, 29);
            this._dtpFrmDate.Name = "_dtpFrmDate";
            this._dtpFrmDate.Size = new System.Drawing.Size(170, 29);
            this._dtpFrmDate.TabIndex = 10;
            // 
            // _dtpToDate
            // 
            this._dtpToDate.Location = new System.Drawing.Point(382, 19);
            this._dtpToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this._dtpToDate.Name = "_dtpToDate";
            this._dtpToDate.Size = new System.Drawing.Size(170, 29);
            this._dtpToDate.TabIndex = 11;
            // 
            // puridDataGridViewTextBoxColumn
            // 
            this.puridDataGridViewTextBoxColumn.DataPropertyName = "pur_id";
            this.puridDataGridViewTextBoxColumn.HeaderText = "pur_id";
            this.puridDataGridViewTextBoxColumn.Name = "puridDataGridViewTextBoxColumn";
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // supplliercompanynameDataGridViewTextBoxColumn
            // 
            this.supplliercompanynameDataGridViewTextBoxColumn.DataPropertyName = "Suppllier_company_name";
            this.supplliercompanynameDataGridViewTextBoxColumn.HeaderText = "Suppllier_company_name";
            this.supplliercompanynameDataGridViewTextBoxColumn.Name = "supplliercompanynameDataGridViewTextBoxColumn";
            // 
            // vdateDataGridViewTextBoxColumn
            // 
            this.vdateDataGridViewTextBoxColumn.DataPropertyName = "v_date";
            this.vdateDataGridViewTextBoxColumn.HeaderText = "v_date";
            this.vdateDataGridViewTextBoxColumn.Name = "vdateDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // orderqtyDataGridViewTextBoxColumn
            // 
            this.orderqtyDataGridViewTextBoxColumn.DataPropertyName = "order_qty";
            this.orderqtyDataGridViewTextBoxColumn.HeaderText = "order_qty";
            this.orderqtyDataGridViewTextBoxColumn.Name = "orderqtyDataGridViewTextBoxColumn";
            // 
            // purchaseDetailsBindingSource
            // 
            this.purchaseDetailsBindingSource.DataSource = typeof(Pastry_ManagementSystem.ExtraClassesToMapData.PurchaseDetails);
            // 
            // PurchasedRawMaterialReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 446);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PurchasedRawMaterialReportScreen";
            this.Text = "Purchased Raw Material Report Screen";
            this.Load += new System.EventHandler(this.PurchasedRawMaterialReportScreen_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel dtpToDate;
        private MetroFramework.Controls.MetroLabel dtpFromDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn puridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplliercompanynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseDetailsBindingSource;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroDateTime _dtpFrmDate;
        private MetroFramework.Controls.MetroDateTime _dtpToDate;
    }
}