namespace PMS.AdminPanel.UI.ReportingModule.Reports
{
    partial class EmployeeRep_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRep_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_genRep = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(103, 23);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.Location = new System.Drawing.Point(430, 22);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_ToDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ToDate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.empFnameDataGridViewTextBoxColumn,
            this.empLnameDataGridViewTextBoxColumn,
            this.fixContactNoDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.empAddressDataGridViewTextBoxColumn,
            this.basicSalryDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 354);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_genRep
            // 
            this.btn_genRep.Enabled = false;
            this.btn_genRep.Location = new System.Drawing.Point(7, 412);
            this.btn_genRep.Name = "btn_genRep";
            this.btn_genRep.Size = new System.Drawing.Size(85, 41);
            this.btn_genRep.TabIndex = 5;
            this.btn_genRep.Text = "Generate Report";
            this.btn_genRep.UseVisualStyleBackColor = true;
            this.btn_genRep.Click += new System.EventHandler(this.btn_genRep_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(103, 414);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 41);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(663, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 20);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            // 
            // empFnameDataGridViewTextBoxColumn
            // 
            this.empFnameDataGridViewTextBoxColumn.DataPropertyName = "emp_Fname";
            this.empFnameDataGridViewTextBoxColumn.HeaderText = "emp_Fname";
            this.empFnameDataGridViewTextBoxColumn.Name = "empFnameDataGridViewTextBoxColumn";
            // 
            // empLnameDataGridViewTextBoxColumn
            // 
            this.empLnameDataGridViewTextBoxColumn.DataPropertyName = "emp_Lname";
            this.empLnameDataGridViewTextBoxColumn.HeaderText = "emp_Lname";
            this.empLnameDataGridViewTextBoxColumn.Name = "empLnameDataGridViewTextBoxColumn";
            // 
            // fixContactNoDataGridViewTextBoxColumn
            // 
            this.fixContactNoDataGridViewTextBoxColumn.DataPropertyName = "fix_ContactNo";
            this.fixContactNoDataGridViewTextBoxColumn.HeaderText = "fix_ContactNo";
            this.fixContactNoDataGridViewTextBoxColumn.Name = "fixContactNoDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "mobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "mobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "Nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "Nic";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // empAddressDataGridViewTextBoxColumn
            // 
            this.empAddressDataGridViewTextBoxColumn.DataPropertyName = "empAddress";
            this.empAddressDataGridViewTextBoxColumn.HeaderText = "empAddress";
            this.empAddressDataGridViewTextBoxColumn.Name = "empAddressDataGridViewTextBoxColumn";
            // 
            // basicSalryDataGridViewTextBoxColumn
            // 
            this.basicSalryDataGridViewTextBoxColumn.DataPropertyName = "basicSalry";
            this.basicSalryDataGridViewTextBoxColumn.HeaderText = "basicSalry";
            this.basicSalryDataGridViewTextBoxColumn.Name = "basicSalryDataGridViewTextBoxColumn";
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "regDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "regDate";
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataSource = typeof(PMS.AdminPanel.UI.ReportingModule.MapObjects.EmployeeDetails);
            // 
            // EmployeeRep_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1156, 459);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_genRep);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeRep_UI";
            this.Text = "EmployeeRep_UI";
            this.Load += new System.EventHandler(this.EmployeeRep_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_genRep;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private System.Windows.Forms.Button btnLoad;
    }
}