namespace PMS.AdminPanel.UI.User
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.btn_chngPass = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_userName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Enabled = false;
            this.txt_newPassword.Location = new System.Drawing.Point(179, 48);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(225, 20);
            this.txt_newPassword.TabIndex = 2;
            this.txt_newPassword.UseSystemPasswordChar = true;
            this.txt_newPassword.TextChanged += new System.EventHandler(this.txt_newPassword_TextChanged);
            this.txt_newPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_newPassword_KeyDown);
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Enabled = false;
            this.txt_confirmPassword.Location = new System.Drawing.Point(179, 87);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(225, 20);
            this.txt_confirmPassword.TabIndex = 3;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.txt_confirmPassword_TextChanged);
            this.txt_confirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confirmPassword_KeyDown);
            // 
            // btn_chngPass
            // 
            this.btn_chngPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chngPass.Enabled = false;
            this.btn_chngPass.Location = new System.Drawing.Point(179, 136);
            this.btn_chngPass.Name = "btn_chngPass";
            this.btn_chngPass.Size = new System.Drawing.Size(114, 23);
            this.btn_chngPass.TabIndex = 4;
            this.btn_chngPass.Text = "Change Password";
            this.btn_chngPass.UseVisualStyleBackColor = true;
            this.btn_chngPass.Click += new System.EventHandler(this.btn_chngPass_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(299, 136);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(179, 12);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(225, 20);
            this.txt_userName.TabIndex = 1;
            this.txt_userName.TextChanged += new System.EventHandler(this.txt_userName_TextChanged);
            this.txt_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_userName_KeyDown);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 176);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_chngPass);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_newPassword);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Button btn_chngPass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_userName;
    }
}