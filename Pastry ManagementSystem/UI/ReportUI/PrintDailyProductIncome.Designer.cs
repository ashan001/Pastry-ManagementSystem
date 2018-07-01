namespace Pastry_ManagementSystem.UI.ReportUI
{
    partial class PrintDailyProductIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDailyProductIncome));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtp_toDate = new MetroFramework.Controls.MetroDateTime();
            this.dtp_FromDate = new MetroFramework.Controls.MetroDateTime();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.referenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_print = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.txt_prodName = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.dtp_toDate);
            this.metroPanel1.Controls.Add(this.dtp_FromDate);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.btn_print);
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.txt_prodName);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 24);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(866, 503);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_toDate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtp_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_toDate.Location = new System.Drawing.Point(639, 59);
            this.dtp_toDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.Size = new System.Drawing.Size(120, 25);
            this.dtp_toDate.TabIndex = 23;
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtp_FromDate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FromDate.Location = new System.Drawing.Point(426, 60);
            this.dtp_FromDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(120, 25);
            this.dtp_FromDate.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(762, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceNoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.productDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 342);
            this.dataGridView1.TabIndex = 21;
            // 
            // referenceNoDataGridViewTextBoxColumn
            // 
            this.referenceNoDataGridViewTextBoxColumn.DataPropertyName = "reference_No";
            this.referenceNoDataGridViewTextBoxColumn.HeaderText = "reference_No";
            this.referenceNoDataGridViewTextBoxColumn.Name = "referenceNoDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cus_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "cus_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ord_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "ord_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "food_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "food_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrdDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrdDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tot_Amt";
            this.dataGridViewTextBoxColumn7.HeaderText = "tot_Amt";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // productDataBindingSource
            // 
            this.productDataBindingSource.DataSource = typeof(Pastry_ManagementSystem.Other.ProductData);
            // 
            // btn_print
            // 
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Location = new System.Drawing.Point(666, 452);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(90, 35);
            this.btn_print.TabIndex = 20;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.UseSelectable = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(779, 59);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(71, 28);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txt_prodName
            // 
            // 
            // 
            // 
            this.txt_prodName.CustomButton.Image = null;
            this.txt_prodName.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txt_prodName.CustomButton.Name = "";
            this.txt_prodName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_prodName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_prodName.CustomButton.TabIndex = 1;
            this.txt_prodName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_prodName.CustomButton.UseSelectable = true;
            this.txt_prodName.CustomButton.Visible = false;
            this.txt_prodName.Lines = new string[0];
            this.txt_prodName.Location = new System.Drawing.Point(124, 61);
            this.txt_prodName.MaxLength = 32767;
            this.txt_prodName.Name = "txt_prodName";
            this.txt_prodName.PasswordChar = '\0';
            this.txt_prodName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_prodName.SelectedText = "";
            this.txt_prodName.SelectionLength = 0;
            this.txt_prodName.SelectionStart = 0;
            this.txt_prodName.ShortcutsEnabled = true;
            this.txt_prodName.Size = new System.Drawing.Size(193, 23);
            this.txt_prodName.TabIndex = 18;
            this.txt_prodName.UseSelectable = true;
            this.txt_prodName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_prodName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_prodName.TextChanged += new System.EventHandler(this.txt_prodName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "To Date";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(3, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(195, 25);
            this.lbl_welcome.TabIndex = 17;
            this.lbl_welcome.Text = "Daily Product Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // PrintDailyProductIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 520);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PrintDailyProductIncome";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txt_prodName;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btn_print;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource productDataBindingSource;
        private MetroFramework.Controls.MetroDateTime dtp_toDate;
        private MetroFramework.Controls.MetroDateTime dtp_FromDate;
        private System.Windows.Forms.Label label3;
    }
}