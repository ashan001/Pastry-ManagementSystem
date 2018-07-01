namespace Pastry_ManagementSystem.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.txt_uerName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_cancel);
            this.metroPanel1.Controls.Add(this.btn_login);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.txt_password);
            this.metroPanel1.Controls.Add(this.txt_uerName);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-6, -2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(436, 253);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btn_cancel.Location = new System.Drawing.Point(325, 198);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 36);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.ForeColor = System.Drawing.Color.Teal;
            this.btn_login.Location = new System.Drawing.Point(219, 198);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(93, 36);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.White;
            this.metroPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel3.BackgroundImage")));
            this.metroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(157, 5);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(173, 64);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.DisplayIcon = true;
            this.txt_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_password.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_password.Icon = ((System.Drawing.Image)(resources.GetObject("txt_password.Icon")));
            this.txt_password.IconRight = true;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(219, 142);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.PromptText = "Enter Your Password";
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(199, 28);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseCustomBackColor = true;
            this.txt_password.UseCustomForeColor = true;
            this.txt_password.UseSelectable = true;
            this.txt_password.UseStyleColors = true;
            this.txt_password.WaterMark = "Enter Your Password";
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // txt_uerName
            // 
            // 
            // 
            // 
            this.txt_uerName.CustomButton.Image = null;
            this.txt_uerName.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.txt_uerName.CustomButton.Name = "";
            this.txt_uerName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_uerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_uerName.CustomButton.TabIndex = 1;
            this.txt_uerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_uerName.CustomButton.UseSelectable = true;
            this.txt_uerName.CustomButton.Visible = false;
            this.txt_uerName.DisplayIcon = true;
            this.txt_uerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_uerName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_uerName.Icon = ((System.Drawing.Image)(resources.GetObject("txt_uerName.Icon")));
            this.txt_uerName.IconRight = true;
            this.txt_uerName.Lines = new string[0];
            this.txt_uerName.Location = new System.Drawing.Point(219, 95);
            this.txt_uerName.MaxLength = 32767;
            this.txt_uerName.Name = "txt_uerName";
            this.txt_uerName.PasswordChar = '\0';
            this.txt_uerName.PromptText = "Enter Your User Name";
            this.txt_uerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_uerName.SelectedText = "";
            this.txt_uerName.SelectionLength = 0;
            this.txt_uerName.SelectionStart = 0;
            this.txt_uerName.ShortcutsEnabled = true;
            this.txt_uerName.Size = new System.Drawing.Size(199, 28);
            this.txt_uerName.TabIndex = 3;
            this.txt_uerName.UseCustomBackColor = true;
            this.txt_uerName.UseCustomForeColor = true;
            this.txt_uerName.UseSelectable = true;
            this.txt_uerName.UseStyleColors = true;
            this.txt_uerName.WaterMark = "Enter Your User Name";
            this.txt_uerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_uerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_uerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_uerName_KeyDown);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 48);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(213, 186);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 242);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Movable = false;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroTextBox txt_uerName;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private MetroFramework.Controls.MetroPanel metroPanel3;
    }
}