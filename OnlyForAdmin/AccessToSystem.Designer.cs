namespace OnlyForAdmin
{
    partial class AccessToSystem
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
            MetroFramework.Controls.MetroLabel txtUserName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessToSystem));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtconfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtUsrName = new MetroFramework.Controls.MetroTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            txtUserName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Location = new System.Drawing.Point(50, 97);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(75, 19);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "User Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Your Email";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(203, 67);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(303, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "New Password";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(203, 133);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(303, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // txtconfirmPassword
            // 
            // 
            // 
            // 
            this.txtconfirmPassword.CustomButton.Image = null;
            this.txtconfirmPassword.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtconfirmPassword.CustomButton.Name = "";
            this.txtconfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtconfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtconfirmPassword.CustomButton.TabIndex = 1;
            this.txtconfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtconfirmPassword.CustomButton.UseSelectable = true;
            this.txtconfirmPassword.CustomButton.Visible = false;
            this.txtconfirmPassword.Lines = new string[0];
            this.txtconfirmPassword.Location = new System.Drawing.Point(203, 168);
            this.txtconfirmPassword.MaxLength = 32767;
            this.txtconfirmPassword.Name = "txtconfirmPassword";
            this.txtconfirmPassword.PasswordChar = '\0';
            this.txtconfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtconfirmPassword.SelectedText = "";
            this.txtconfirmPassword.SelectionLength = 0;
            this.txtconfirmPassword.SelectionStart = 0;
            this.txtconfirmPassword.ShortcutsEnabled = true;
            this.txtconfirmPassword.Size = new System.Drawing.Size(303, 23);
            this.txtconfirmPassword.TabIndex = 5;
            this.txtconfirmPassword.UseSelectable = true;
            this.txtconfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtconfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtconfirmPassword.TextChanged += new System.EventHandler(this.txtconfirmPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(312, 202);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(412, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUsrName
            // 
            // 
            // 
            // 
            this.txtUsrName.CustomButton.Image = null;
            this.txtUsrName.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtUsrName.CustomButton.Name = "";
            this.txtUsrName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsrName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsrName.CustomButton.TabIndex = 1;
            this.txtUsrName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsrName.CustomButton.UseSelectable = true;
            this.txtUsrName.CustomButton.Visible = false;
            this.txtUsrName.Lines = new string[0];
            this.txtUsrName.Location = new System.Drawing.Point(203, 100);
            this.txtUsrName.MaxLength = 32767;
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.PasswordChar = '\0';
            this.txtUsrName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsrName.SelectedText = "";
            this.txtUsrName.SelectionLength = 0;
            this.txtUsrName.SelectionStart = 0;
            this.txtUsrName.ShortcutsEnabled = true;
            this.txtUsrName.Size = new System.Drawing.Size(303, 23);
            this.txtUsrName.TabIndex = 3;
            this.txtUsrName.UseSelectable = true;
            this.txtUsrName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsrName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AccessToSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 259);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtconfirmPassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUsrName);
            this.Controls.Add(txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessToSystem";
            this.Text = "Get Temporary Access To System";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtconfirmPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtUsrName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

