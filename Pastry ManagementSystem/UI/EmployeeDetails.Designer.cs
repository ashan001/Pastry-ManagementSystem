namespace Pastry_ManagementSystem.UI
{
    partial class EmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.txt_empPosition = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_firstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_refrsh = new MetroFramework.Controls.MetroButton();
            this.gridValueEmp = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValueEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.Controls.Add(this.txt_empPosition);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txt_firstName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btn_back);
            this.metroPanel1.Controls.Add(this.btn_delete);
            this.metroPanel1.Controls.Add(this.btn_refrsh);
            this.metroPanel1.Controls.Add(this.gridValueEmp);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-3, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1184, 399);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(16, 8);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(158, 25);
            this.lbl_welcome.TabIndex = 15;
            this.lbl_welcome.Text = "Employee Details";
            // 
            // txt_empPosition
            // 
            // 
            // 
            // 
            this.txt_empPosition.CustomButton.Image = null;
            this.txt_empPosition.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txt_empPosition.CustomButton.Name = "";
            this.txt_empPosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empPosition.CustomButton.TabIndex = 1;
            this.txt_empPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empPosition.CustomButton.UseSelectable = true;
            this.txt_empPosition.CustomButton.Visible = false;
            this.txt_empPosition.Lines = new string[0];
            this.txt_empPosition.Location = new System.Drawing.Point(542, 45);
            this.txt_empPosition.MaxLength = 32767;
            this.txt_empPosition.Name = "txt_empPosition";
            this.txt_empPosition.PasswordChar = '\0';
            this.txt_empPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empPosition.SelectedText = "";
            this.txt_empPosition.SelectionLength = 0;
            this.txt_empPosition.SelectionStart = 0;
            this.txt_empPosition.ShortcutsEnabled = true;
            this.txt_empPosition.Size = new System.Drawing.Size(262, 23);
            this.txt_empPosition.TabIndex = 10;
            this.txt_empPosition.UseSelectable = true;
            this.txt_empPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empPosition.TextChanged += new System.EventHandler(this.txt_empPosition_TextChanged);
            this.txt_empPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empPosition_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(419, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Employee Position";
            // 
            // txt_firstName
            // 
            // 
            // 
            // 
            this.txt_firstName.CustomButton.Image = null;
            this.txt_firstName.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txt_firstName.CustomButton.Name = "";
            this.txt_firstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_firstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_firstName.CustomButton.TabIndex = 1;
            this.txt_firstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_firstName.CustomButton.UseSelectable = true;
            this.txt_firstName.CustomButton.Visible = false;
            this.txt_firstName.Lines = new string[0];
            this.txt_firstName.Location = new System.Drawing.Point(129, 45);
            this.txt_firstName.MaxLength = 32767;
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PasswordChar = '\0';
            this.txt_firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_firstName.SelectedText = "";
            this.txt_firstName.SelectionLength = 0;
            this.txt_firstName.SelectionStart = 0;
            this.txt_firstName.ShortcutsEnabled = true;
            this.txt_firstName.Size = new System.Drawing.Size(248, 23);
            this.txt_firstName.TabIndex = 8;
            this.txt_firstName.UseSelectable = true;
            this.txt_firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            this.txt_firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_firstName_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Employee Name";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Location = new System.Drawing.Point(300, 353);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 35);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delete.Location = new System.Drawing.Point(158, 353);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 35);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refrsh
            // 
            this.btn_refrsh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refrsh.BackgroundImage")));
            this.btn_refrsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refrsh.Location = new System.Drawing.Point(14, 352);
            this.btn_refrsh.Name = "btn_refrsh";
            this.btn_refrsh.Size = new System.Drawing.Size(130, 35);
            this.btn_refrsh.TabIndex = 4;
            this.btn_refrsh.Text = "Refresh";
            this.btn_refrsh.UseSelectable = true;
            this.btn_refrsh.Click += new System.EventHandler(this.btn_refrsh_Click);
            // 
            // gridValueEmp
            // 
            this.gridValueEmp.AllowUserToResizeRows = false;
            this.gridValueEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridValueEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridValueEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridValueEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridValueEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridValueEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridValueEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridValueEmp.EnableHeadersVisualStyles = false;
            this.gridValueEmp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridValueEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridValueEmp.Location = new System.Drawing.Point(15, 75);
            this.gridValueEmp.Name = "gridValueEmp";
            this.gridValueEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridValueEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridValueEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridValueEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridValueEmp.Size = new System.Drawing.Size(1146, 264);
            this.gridValueEmp.TabIndex = 2;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 426);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeDetails";
            this.Style = MetroFramework.MetroColorStyle.Black;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValueEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_refrsh;
        private MetroFramework.Controls.MetroGrid gridValueEmp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_firstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_empPosition;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
    }
}