namespace Pastry_ManagementSystem.UI
{
    partial class ProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btn_Start = new MetroFramework.Controls.MetroButton();
            this.lbl_Process = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Location = new System.Drawing.Point(20, 104);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(1150, 30);
            this.metroProgressBar.TabIndex = 0;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(535, 185);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(118, 40);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseSelectable = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Process
            // 
            this.lbl_Process.AutoSize = true;
            this.lbl_Process.Location = new System.Drawing.Point(1077, 183);
            this.lbl_Process.Name = "lbl_Process";
            this.lbl_Process.Size = new System.Drawing.Size(93, 19);
            this.lbl_Process.TabIndex = 3;
            this.lbl_Process.Text = "Processing 0%";
            this.lbl_Process.Visible = false;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 251);
            this.Controls.Add(this.lbl_Process);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.metroProgressBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProgressBar";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Please click start button to run the system";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private MetroFramework.Controls.MetroButton btn_Start;
        private MetroFramework.Controls.MetroLabel lbl_Process;
    }
}