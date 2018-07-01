namespace AdminObjectsHide.View
{
    partial class RegisterSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterSys));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtProductID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtProductKey = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product ID";
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.CustomButton.Image = null;
            this.txtProductID.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.txtProductID.CustomButton.Name = "";
            this.txtProductID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductID.CustomButton.TabIndex = 1;
            this.txtProductID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductID.CustomButton.UseSelectable = true;
            this.txtProductID.CustomButton.Visible = false;
            this.txtProductID.Lines = new string[0];
            this.txtProductID.Location = new System.Drawing.Point(133, 78);
            this.txtProductID.MaxLength = 32767;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.ReadOnly = true;
            this.txtProductID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductID.SelectedText = "";
            this.txtProductID.SelectionLength = 0;
            this.txtProductID.SelectionStart = 0;
            this.txtProductID.ShortcutsEnabled = true;
            this.txtProductID.Size = new System.Drawing.Size(358, 23);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.UseSelectable = true;
            this.txtProductID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Product Key";
            // 
            // txtProductKey
            // 
            // 
            // 
            // 
            this.txtProductKey.CustomButton.Image = null;
            this.txtProductKey.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.txtProductKey.CustomButton.Name = "";
            this.txtProductKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductKey.CustomButton.TabIndex = 1;
            this.txtProductKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductKey.CustomButton.UseSelectable = true;
            this.txtProductKey.CustomButton.Visible = false;
            this.txtProductKey.Lines = new string[0];
            this.txtProductKey.Location = new System.Drawing.Point(133, 107);
            this.txtProductKey.MaxLength = 32767;
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.PasswordChar = '\0';
            this.txtProductKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductKey.SelectedText = "";
            this.txtProductKey.SelectionLength = 0;
            this.txtProductKey.SelectionStart = 0;
            this.txtProductKey.ShortcutsEnabled = true;
            this.txtProductKey.Size = new System.Drawing.Size(358, 23);
            this.txtProductKey.TabIndex = 3;
            this.txtProductKey.UseSelectable = true;
            this.txtProductKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(416, 137);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 34);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "OK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // RegisterSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 179);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "RegisterSys";
            this.Resizable = false;
            this.Text = "Register System";
            this.Load += new System.EventHandler(this.RegisterSys_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtProductID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtProductKey;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}