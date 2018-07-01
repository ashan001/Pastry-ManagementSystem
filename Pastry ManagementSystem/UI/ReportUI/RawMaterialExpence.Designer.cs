namespace Pastry_ManagementSystem.UI.ReportUI
{
    partial class RawMaterialExpence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawMaterialExpence));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.btn_load = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receiptNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapDataAndHideForRawMatExpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp_ToDate = new MetroFramework.Controls.MetroDateTime();
            this.dtp_FromDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapDataAndHideForRawMatExpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btn_cancel);
            this.metroPanel1.Controls.Add(this.btn_print);
            this.metroPanel1.Controls.Add(this.btn_load);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.dtp_ToDate);
            this.metroPanel1.Controls.Add(this.dtp_FromDate);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 53);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(949, 433);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Location = new System.Drawing.Point(87, 386);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 38);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_print.Location = new System.Drawing.Point(5, 386);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(76, 38);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "Print";
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_load.BackgroundImage")));
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_load.Location = new System.Drawing.Point(695, 16);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(86, 33);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.UseSelectable = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptNoDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.datereceivedDataGridViewTextBoxColumn,
            this.suppIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mapDataAndHideForRawMatExpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 317);
            this.dataGridView1.TabIndex = 6;
            // 
            // receiptNoDataGridViewTextBoxColumn
            // 
            this.receiptNoDataGridViewTextBoxColumn.DataPropertyName = "receipt_No";
            this.receiptNoDataGridViewTextBoxColumn.HeaderText = "receipt_No";
            this.receiptNoDataGridViewTextBoxColumn.Name = "receiptNoDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // datereceivedDataGridViewTextBoxColumn
            // 
            this.datereceivedDataGridViewTextBoxColumn.DataPropertyName = "date_received";
            this.datereceivedDataGridViewTextBoxColumn.HeaderText = "date_received";
            this.datereceivedDataGridViewTextBoxColumn.Name = "datereceivedDataGridViewTextBoxColumn";
            // 
            // suppIDDataGridViewTextBoxColumn
            // 
            this.suppIDDataGridViewTextBoxColumn.DataPropertyName = "supp_ID";
            this.suppIDDataGridViewTextBoxColumn.HeaderText = "supp_ID";
            this.suppIDDataGridViewTextBoxColumn.Name = "suppIDDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "company_Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "company_Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "item_price";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // mapDataAndHideForRawMatExpBindingSource
            // 
            this.mapDataAndHideForRawMatExpBindingSource.DataSource = typeof(Pastry_ManagementSystem.ExtraClassesToMapData.MapDataAndHideForRawMatExp);
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Location = new System.Drawing.Point(444, 17);
            this.dtp_ToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(200, 29);
            this.dtp_ToDate.TabIndex = 5;
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Location = new System.Drawing.Point(122, 17);
            this.dtp_FromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(200, 29);
            this.dtp_FromDate.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(350, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "To Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(5, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "From Date";
            // 
            // RawMaterialExpence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 482);
            this.Controls.Add(this.metroPanel1);
            this.Name = "RawMaterialExpence";
            this.Text = "Raw Material Expence";
            this.Load += new System.EventHandler(this.RawMaterialExpence_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapDataAndHideForRawMatExpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtp_FromDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroDateTime dtp_ToDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_load;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mapDataAndHideForRawMatExpBindingSource;
    }
}