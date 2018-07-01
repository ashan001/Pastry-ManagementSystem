namespace Pastry_ManagementSystem.UI.ReportUI
{
    partial class PrintOrderReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOrderReciept));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.toDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fromDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btn_cancel);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.btnPrint);
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.toDate);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.fromDate);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(857, 445);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(769, 408);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 29);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.cusIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNumDataGridViewTextBoxColumn,
            this.cusaddressDataGridViewTextBoxColumn,
            this.nICDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(6, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 324);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "order_No";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "order_No";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
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
            // nICDataGridViewTextBoxColumn
            // 
            this.nICDataGridViewTextBoxColumn.DataPropertyName = "NIC";
            this.nICDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nICDataGridViewTextBoxColumn.Name = "nICDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataSource = typeof(Pastry_ManagementSystem.Other.Orders);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(9, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(176, 25);
            this.lbl_welcome.TabIndex = 16;
            this.lbl_welcome.Text = "Print Order Receipt";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(672, 408);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 29);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(672, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(452, 40);
            this.toDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(200, 29);
            this.toDate.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(350, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "To Date";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(118, 40);
            this.fromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(200, 29);
            this.fromDate.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "From Date";
            // 
            // PrintOrderReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 468);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PrintOrderReciept";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime fromDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroDateTime toDate;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private MetroFramework.Controls.MetroButton btn_cancel;
    }
}