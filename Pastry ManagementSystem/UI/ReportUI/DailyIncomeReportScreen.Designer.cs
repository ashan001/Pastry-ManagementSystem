namespace Pastry_ManagementSystem.UI.ReportUI
{
    partial class DailyIncomeReportScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyIncomeReportScreen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dtp_Date = new MetroFramework.Controls.MetroDateTime();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billgstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billtotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyIncomeClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyIncomeClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.dtp_Date);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 54);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(663, 444);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Enabled = false;
            this.metroButton2.Location = new System.Drawing.Point(471, 404);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(78, 31);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Print";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(571, 404);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(78, 31);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_Date.Location = new System.Drawing.Point(304, 19);
            this.dtp_Date.MaxDate = new System.DateTime(2109, 11, 28, 0, 0, 0, 0);
            this.dtp_Date.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(168, 25);
            this.dtp_Date.TabIndex = 5;
            this.dtp_Date.Value = new System.DateTime(2017, 5, 25, 0, 0, 0, 0);
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billnoDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.foodnoDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.billgstDataGridViewTextBoxColumn,
            this.billtotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dailyIncomeClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 347);
            this.dataGridView1.TabIndex = 4;
            // 
            // billnoDataGridViewTextBoxColumn
            // 
            this.billnoDataGridViewTextBoxColumn.DataPropertyName = "bill_no";
            this.billnoDataGridViewTextBoxColumn.HeaderText = "bill_no";
            this.billnoDataGridViewTextBoxColumn.Name = "billnoDataGridViewTextBoxColumn";
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "_empID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "_empID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            // 
            // foodnoDataGridViewTextBoxColumn
            // 
            this.foodnoDataGridViewTextBoxColumn.DataPropertyName = "food_no";
            this.foodnoDataGridViewTextBoxColumn.HeaderText = "food_no";
            this.foodnoDataGridViewTextBoxColumn.Name = "foodnoDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // billgstDataGridViewTextBoxColumn
            // 
            this.billgstDataGridViewTextBoxColumn.DataPropertyName = "bill_gst";
            this.billgstDataGridViewTextBoxColumn.HeaderText = "bill_gst";
            this.billgstDataGridViewTextBoxColumn.Name = "billgstDataGridViewTextBoxColumn";
            // 
            // billtotDataGridViewTextBoxColumn
            // 
            this.billtotDataGridViewTextBoxColumn.DataPropertyName = "bill_tot";
            this.billtotDataGridViewTextBoxColumn.HeaderText = "bill_tot";
            this.billtotDataGridViewTextBoxColumn.Name = "billtotDataGridViewTextBoxColumn";
            // 
            // dailyIncomeClassBindingSource
            // 
            this.dailyIncomeClassBindingSource.DataSource = typeof(Pastry_ManagementSystem.Other.DailyIncomeClass);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(274, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Please select Today\'s Date or Day before date";
            // 
            // DailyIncomeReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 494);
            this.Controls.Add(this.metroPanel1);
            this.Name = "DailyIncomeReportScreen";
            this.Text = "Daily Income Report";
            this.Load += new System.EventHandler(this.DailyIncomeReportScreen_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyIncomeClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billgstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billtotDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dailyIncomeClassBindingSource;
        private MetroFramework.Controls.MetroDateTime dtp_Date;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}