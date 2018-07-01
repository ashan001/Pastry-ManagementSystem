namespace PMS.AdminPanel.UI
{
    partial class frmMainForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForAdmin));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWarehouseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmployeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeIDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLoginToolStripMenuItem,
            this.saveWarehouseInformationToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // createLoginToolStripMenuItem
            // 
            this.createLoginToolStripMenuItem.Name = "createLoginToolStripMenuItem";
            this.createLoginToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.createLoginToolStripMenuItem.Text = "Create Login";
            this.createLoginToolStripMenuItem.Click += new System.EventHandler(this.createLoginToolStripMenuItem_Click);
            // 
            // saveWarehouseInformationToolStripMenuItem
            // 
            this.saveWarehouseInformationToolStripMenuItem.Name = "saveWarehouseInformationToolStripMenuItem";
            this.saveWarehouseInformationToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveWarehouseInformationToolStripMenuItem.Text = "Save Warehouse Information";
            this.saveWarehouseInformationToolStripMenuItem.Click += new System.EventHandler(this.saveWarehouseInformationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmployeeReportToolStripMenuItem,
            this.createCustomerReportToolStripMenuItem,
            this.transactionReportToolStripMenuItem,
            this.customerServiceToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // createEmployeeReportToolStripMenuItem
            // 
            this.createEmployeeReportToolStripMenuItem.Name = "createEmployeeReportToolStripMenuItem";
            this.createEmployeeReportToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.createEmployeeReportToolStripMenuItem.Text = "Create Employee Report";
            this.createEmployeeReportToolStripMenuItem.Click += new System.EventHandler(this.createEmployeeReportToolStripMenuItem_Click);
            // 
            // createCustomerReportToolStripMenuItem
            // 
            this.createCustomerReportToolStripMenuItem.Name = "createCustomerReportToolStripMenuItem";
            this.createCustomerReportToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.createCustomerReportToolStripMenuItem.Text = "Create Customer Report";
            this.createCustomerReportToolStripMenuItem.Click += new System.EventHandler(this.createCustomerReportToolStripMenuItem_Click);
            // 
            // transactionReportToolStripMenuItem
            // 
            this.transactionReportToolStripMenuItem.Name = "transactionReportToolStripMenuItem";
            this.transactionReportToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.transactionReportToolStripMenuItem.Text = "Transaction Report";
            this.transactionReportToolStripMenuItem.Click += new System.EventHandler(this.transactionReportToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryMasterToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // inventoryMasterToolStripMenuItem
            // 
            this.inventoryMasterToolStripMenuItem.Name = "inventoryMasterToolStripMenuItem";
            this.inventoryMasterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.inventoryMasterToolStripMenuItem.Text = "Inventory Master";
            this.inventoryMasterToolStripMenuItem.Click += new System.EventHandler(this.inventoryMasterToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeIDsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // employeeIDsToolStripMenuItem
            // 
            this.employeeIDsToolStripMenuItem.Name = "employeeIDsToolStripMenuItem";
            this.employeeIDsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.employeeIDsToolStripMenuItem.Text = "Employee ID\'s";
            this.employeeIDsToolStripMenuItem.Click += new System.EventHandler(this.employeeIDsToolStripMenuItem_Click);
            // 
            // customerServiceToolStripMenuItem
            // 
            this.customerServiceToolStripMenuItem.Name = "customerServiceToolStripMenuItem";
            this.customerServiceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.customerServiceToolStripMenuItem.Text = "Customer Service";
            this.customerServiceToolStripMenuItem.Click += new System.EventHandler(this.customerServiceToolStripMenuItem_Click);
            // 
            // frmMainForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1194, 521);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainForAdmin";
            this.Text = "Pastry Management Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmployeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryMasterToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeIDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWarehouseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerServiceToolStripMenuItem;
    }
}