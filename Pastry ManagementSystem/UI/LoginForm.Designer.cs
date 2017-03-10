namespace Pastry_ManagementSystem.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_userName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmb_empRole = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(504, 455);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 0;
            this.metroUserControl1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(128, 147);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "User Name ";
            // 
            // txt_userName
            // 
            // 
            // 
            // 
            this.txt_userName.CustomButton.Image = null;
            this.txt_userName.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.txt_userName.CustomButton.Name = "";
            this.txt_userName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_userName.CustomButton.TabIndex = 1;
            this.txt_userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_userName.CustomButton.UseSelectable = true;
            this.txt_userName.CustomButton.Visible = false;
            this.txt_userName.Enabled = false;
            this.txt_userName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_userName.Lines = new string[0];
            this.txt_userName.Location = new System.Drawing.Point(393, 143);
            this.txt_userName.MaxLength = 32767;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.PasswordChar = '\0';
            this.txt_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userName.SelectedText = "";
            this.txt_userName.SelectionLength = 0;
            this.txt_userName.SelectionStart = 0;
            this.txt_userName.ShortcutsEnabled = true;
            this.txt_userName.Size = new System.Drawing.Size(370, 23);
            this.txt_userName.TabIndex = 2;
            this.txt_userName.UseSelectable = true;
            this.txt_userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_userName.TextChanged += new System.EventHandler(this.txt_userName_TextChanged_1);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(128, 203);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.Enabled = false;
            this.txt_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(393, 203);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(370, 23);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.Location = new System.Drawing.Point(393, 273);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(154, 22);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "Forgot password ?";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // btn_login
            // 
            this.btn_login.Enabled = false;
            this.btn_login.Location = new System.Drawing.Point(393, 348);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(143, 40);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(630, 348);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(143, 40);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Exit";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(128, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Employee Role";
            // 
            // cmb_empRole
            // 
            this.cmb_empRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empRole.FormattingEnabled = true;
            this.cmb_empRole.Items.AddRange(new object[] {
            "Manager",
            "Cashier"});
            this.cmb_empRole.Location = new System.Drawing.Point(393, 71);
            this.cmb_empRole.Name = "cmb_empRole";
            this.cmb_empRole.Size = new System.Drawing.Size(370, 24);
            this.cmb_empRole.TabIndex = 10;
            this.cmb_empRole.SelectedIndexChanged += new System.EventHandler(this.cmb_empRole_SelectedIndexChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.secure;
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cmb_empRole);
            this.metroPanel1.Controls.Add(this.btn_login);
            this.metroPanel1.Controls.Add(this.txt_userName);
            this.metroPanel1.Controls.Add(this.txt_password);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 54);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1089, 423);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(1087, 476);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "LoginForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_userName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cmb_empRole;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}