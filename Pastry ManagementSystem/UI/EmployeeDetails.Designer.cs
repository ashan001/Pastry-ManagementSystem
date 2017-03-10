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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_firstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.gridValueEmp = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_empPosition = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValueEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.blue_gradient_wallpaper_hd_20_color;
            this.metroPanel1.Controls.Add(this.txt_empPosition);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txt_firstName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.gridValueEmp);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1183, 417);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(659, 20);
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
            this.txt_firstName.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.txt_firstName.CustomButton.Name = "";
            this.txt_firstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_firstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_firstName.CustomButton.TabIndex = 1;
            this.txt_firstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_firstName.CustomButton.UseSelectable = true;
            this.txt_firstName.CustomButton.Visible = false;
            this.txt_firstName.Lines = new string[0];
            this.txt_firstName.Location = new System.Drawing.Point(262, 20);
            this.txt_firstName.MaxLength = 32767;
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PasswordChar = '\0';
            this.txt_firstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_firstName.SelectedText = "";
            this.txt_firstName.SelectionLength = 0;
            this.txt_firstName.SelectionStart = 0;
            this.txt_firstName.ShortcutsEnabled = true;
            this.txt_firstName.Size = new System.Drawing.Size(287, 23);
            this.txt_firstName.TabIndex = 8;
            this.txt_firstName.UseSelectable = true;
            this.txt_firstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_firstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(90, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Employee First Name";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(546, 358);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(130, 35);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Back";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(378, 358);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(130, 35);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Delete";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(209, 358);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(130, 35);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Refresh";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(36, 358);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(130, 35);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            // 
            // gridValueEmp
            // 
            this.gridValueEmp.AllowUserToResizeRows = false;
            this.gridValueEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridValueEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridValueEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridValueEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridValueEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridValueEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridValueEmp.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridValueEmp.EnableHeadersVisualStyles = false;
            this.gridValueEmp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridValueEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridValueEmp.Location = new System.Drawing.Point(36, 59);
            this.gridValueEmp.Name = "gridValueEmp";
            this.gridValueEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridValueEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridValueEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridValueEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridValueEmp.Size = new System.Drawing.Size(1114, 264);
            this.gridValueEmp.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_empPosition
            // 
            // 
            // 
            // 
            this.txt_empPosition.CustomButton.Image = null;
            this.txt_empPosition.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txt_empPosition.CustomButton.Name = "";
            this.txt_empPosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_empPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_empPosition.CustomButton.TabIndex = 1;
            this.txt_empPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_empPosition.CustomButton.UseSelectable = true;
            this.txt_empPosition.CustomButton.Visible = false;
            this.txt_empPosition.Lines = new string[0];
            this.txt_empPosition.Location = new System.Drawing.Point(796, 20);
            this.txt_empPosition.MaxLength = 32767;
            this.txt_empPosition.Name = "txt_empPosition";
            this.txt_empPosition.PasswordChar = '\0';
            this.txt_empPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_empPosition.SelectedText = "";
            this.txt_empPosition.SelectionLength = 0;
            this.txt_empPosition.SelectionStart = 0;
            this.txt_empPosition.ShortcutsEnabled = true;
            this.txt_empPosition.Size = new System.Drawing.Size(298, 23);
            this.txt_empPosition.TabIndex = 10;
            this.txt_empPosition.UseSelectable = true;
            this.txt_empPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_empPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_empPosition.TextChanged += new System.EventHandler(this.txt_empPosition_TextChanged);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 444);
            this.Controls.Add(this.metroPanel1);
            this.Name = "EmployeeDetails";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridValueEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid gridValueEmp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_firstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_empPosition;
    }
}