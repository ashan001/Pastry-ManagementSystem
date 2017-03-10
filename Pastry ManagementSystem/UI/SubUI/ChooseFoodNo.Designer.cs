namespace Pastry_ManagementSystem.UI.SubUI
{
    partial class ChooseFoodNo
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.foodInfo = new System.Windows.Forms.DataGridView();
            this.btn_close = new MetroFramework.Controls.MetroButton();
            this.btn_select = new MetroFramework.Controls.MetroButton();
            this.lbl_welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::Pastry_ManagementSystem.Properties.Resources.blue_gradient_wallpaper_hd_20_color;
            this.metroPanel1.Controls.Add(this.foodInfo);
            this.metroPanel1.Controls.Add(this.btn_close);
            this.metroPanel1.Controls.Add(this.btn_select);
            this.metroPanel1.Controls.Add(this.lbl_welcome);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-3, 29);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(460, 297);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // foodInfo
            // 
            this.foodInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.foodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.foodInfo.Location = new System.Drawing.Point(15, 62);
            this.foodInfo.Name = "foodInfo";
            this.foodInfo.Size = new System.Drawing.Size(427, 183);
            this.foodInfo.TabIndex = 19;
            this.foodInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodInfo_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(358, 251);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(84, 31);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Close";
            this.btn_close.UseSelectable = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(252, 251);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(84, 31);
            this.btn_select.TabIndex = 17;
            this.btn_select.Text = "Select";
            this.btn_select.UseSelectable = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_welcome.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Location = new System.Drawing.Point(15, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(161, 25);
            this.lbl_welcome.TabIndex = 16;
            this.lbl_welcome.Text = "Food Information";
            // 
            // ChooseFoodNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 325);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ChooseFoodNo";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.ChooseFoodNo_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbl_welcome;
        private MetroFramework.Controls.MetroButton btn_close;
        private MetroFramework.Controls.MetroButton btn_select;
        private System.Windows.Forms.DataGridView foodInfo;
    }
}