namespace PMS.AdminPanel.UI.Admin
{
    partial class ViewEmployeeID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployeeID));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt_empNum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixContactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetaObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetaObjBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Employee Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Employee Contact Number";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(179, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txt_empNum
            // 
            this.txt_empNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empNum.Location = new System.Drawing.Point(662, 20);
            this.txt_empNum.Name = "txt_empNum";
            this.txt_empNum.Size = new System.Drawing.Size(211, 22);
            this.txt_empNum.TabIndex = 12;
            this.txt_empNum.TextChanged += new System.EventHandler(this.txt_empNum_TextChanged);
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
            this.dobDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDetaObjBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 309);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // employeeDetaObjBindingSource
            // 
            this.employeeDetaObjBindingSource.DataSource = typeof(PMS.AdminPanel.AdminObj.EmployeeDetaObj);
            // 
            // ViewEmployeeID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1063, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_empNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "ViewEmployeeID";
            this.Text = "ViewEmployeeID";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetaObjBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt_empNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixContactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeDetaObjBindingSource;
    }
}