namespace Pastry_ManagementSystem.UI
{
    partial class Changepassword
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_verification = new MetroFramework.Controls.MetroTextBox();
            this.txt_newPassword = new MetroFramework.Controls.MetroTextBox();
            this.txt_confirmPass = new MetroFramework.Controls.MetroTextBox();
            this.lbl_pass_status = new System.Windows.Forms.Label();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.btn_change = new MetroFramework.Controls.MetroButton();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.error_verfication = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.Error_confirm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_verfication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(289, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Please enter your email address or Employee Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "New Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 251);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // txt_verification
            // 
            // 
            // 
            // 
            this.txt_verification.CustomButton.Image = null;
            this.txt_verification.CustomButton.Location = new System.Drawing.Point(388, 1);
            this.txt_verification.CustomButton.Name = "";
            this.txt_verification.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_verification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_verification.CustomButton.TabIndex = 1;
            this.txt_verification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_verification.CustomButton.UseSelectable = true;
            this.txt_verification.CustomButton.Visible = false;
            this.txt_verification.Lines = new string[0];
            this.txt_verification.Location = new System.Drawing.Point(439, 115);
            this.txt_verification.MaxLength = 32767;
            this.txt_verification.Name = "txt_verification";
            this.txt_verification.PasswordChar = '\0';
            this.txt_verification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_verification.SelectedText = "";
            this.txt_verification.SelectionLength = 0;
            this.txt_verification.SelectionStart = 0;
            this.txt_verification.ShortcutsEnabled = true;
            this.txt_verification.Size = new System.Drawing.Size(410, 23);
            this.txt_verification.TabIndex = 4;
            this.txt_verification.UseSelectable = true;
            this.txt_verification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_verification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_verification.TextChanged += new System.EventHandler(this.txt_verification_TextChanged);
            // 
            // txt_newPassword
            // 
            // 
            // 
            // 
            this.txt_newPassword.CustomButton.Image = null;
            this.txt_newPassword.CustomButton.Location = new System.Drawing.Point(388, 1);
            this.txt_newPassword.CustomButton.Name = "";
            this.txt_newPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_newPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_newPassword.CustomButton.TabIndex = 1;
            this.txt_newPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_newPassword.CustomButton.UseSelectable = true;
            this.txt_newPassword.CustomButton.Visible = false;
            this.txt_newPassword.Lines = new string[0];
            this.txt_newPassword.Location = new System.Drawing.Point(439, 186);
            this.txt_newPassword.MaxLength = 32767;
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.PasswordChar = '*';
            this.txt_newPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_newPassword.SelectedText = "";
            this.txt_newPassword.SelectionLength = 0;
            this.txt_newPassword.SelectionStart = 0;
            this.txt_newPassword.ShortcutsEnabled = true;
            this.txt_newPassword.Size = new System.Drawing.Size(410, 23);
            this.txt_newPassword.TabIndex = 5;
            this.txt_newPassword.UseSelectable = true;
            this.txt_newPassword.Visible = false;
            this.txt_newPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_newPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_newPassword.TextChanged += new System.EventHandler(this.txt_newPassword_TextChanged);
            // 
            // txt_confirmPass
            // 
            // 
            // 
            // 
            this.txt_confirmPass.CustomButton.Image = null;
            this.txt_confirmPass.CustomButton.Location = new System.Drawing.Point(388, 1);
            this.txt_confirmPass.CustomButton.Name = "";
            this.txt_confirmPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_confirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_confirmPass.CustomButton.TabIndex = 1;
            this.txt_confirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_confirmPass.CustomButton.UseSelectable = true;
            this.txt_confirmPass.CustomButton.Visible = false;
            this.txt_confirmPass.Lines = new string[0];
            this.txt_confirmPass.Location = new System.Drawing.Point(439, 252);
            this.txt_confirmPass.MaxLength = 32767;
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.PasswordChar = '*';
            this.txt_confirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_confirmPass.SelectedText = "";
            this.txt_confirmPass.SelectionLength = 0;
            this.txt_confirmPass.SelectionStart = 0;
            this.txt_confirmPass.ShortcutsEnabled = true;
            this.txt_confirmPass.Size = new System.Drawing.Size(410, 23);
            this.txt_confirmPass.TabIndex = 6;
            this.txt_confirmPass.UseSelectable = true;
            this.txt_confirmPass.Visible = false;
            this.txt_confirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_confirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_confirmPass.TextChanged += new System.EventHandler(this.txt_confirmPass_TextChanged);
            // 
            // lbl_pass_status
            // 
            this.lbl_pass_status.AutoSize = true;
            this.lbl_pass_status.Location = new System.Drawing.Point(910, 196);
            this.lbl_pass_status.Name = "lbl_pass_status";
            this.lbl_pass_status.Size = new System.Drawing.Size(35, 13);
            this.lbl_pass_status.TabIndex = 9;
            this.lbl_pass_status.Text = "label1";
            this.lbl_pass_status.Visible = false;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Location = new System.Drawing.Point(910, 262);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(35, 13);
            this.lbl_confirm.TabIndex = 10;
            this.lbl_confirm.Text = "label1";
            this.lbl_confirm.Visible = false;
            // 
            // btn_change
            // 
            this.btn_change.Enabled = false;
            this.btn_change.Location = new System.Drawing.Point(439, 341);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(148, 41);
            this.btn_change.TabIndex = 11;
            this.btn_change.Text = "Change password";
            this.btn_change.UseSelectable = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(702, 341);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(147, 41);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // error_verfication
            // 
            this.error_verfication.ContainerControl = this;
            // 
            // error_password
            // 
            this.error_password.ContainerControl = this;
            // 
            // Error_confirm
            // 
            this.Error_confirm.ContainerControl = this;
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 418);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.lbl_pass_status);
            this.Controls.Add(this.txt_confirmPass);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.txt_verification);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Changepassword";
            this.Text = "Change password";
            ((System.ComponentModel.ISupportInitialize)(this.error_verfication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_verification;
        private MetroFramework.Controls.MetroTextBox txt_newPassword;
        private MetroFramework.Controls.MetroTextBox txt_confirmPass;
        private System.Windows.Forms.Label lbl_pass_status;
        private System.Windows.Forms.Label lbl_confirm;
        private MetroFramework.Controls.MetroButton btn_change;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.ErrorProvider error_verfication;
        private System.Windows.Forms.ErrorProvider error_password;
        private System.Windows.Forms.ErrorProvider Error_confirm;
    }
}