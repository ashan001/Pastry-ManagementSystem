namespace Pastry_ManagementSystem.UI
{
    partial class CpuMonitor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closeFromRam = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(106, 73);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(822, 21);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "RAM";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(106, 116);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(822, 21);
            this.metroProgressBarRAM.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(958, 75);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(27, 19);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "0%";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(958, 116);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(27, 19);
            this.lblRAM.TabIndex = 0;
            this.lblRAM.Text = "0%";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(65, 161);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(981, 285);
            this.chart1.TabIndex = 2;
            // 
            // closeFromRam
            // 
            this.closeFromRam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeFromRam.Location = new System.Drawing.Point(849, 19);
            this.closeFromRam.Name = "closeFromRam";
            this.closeFromRam.Size = new System.Drawing.Size(136, 33);
            this.closeFromRam.TabIndex = 3;
            this.closeFromRam.Text = "Take Action";
            this.closeFromRam.UseSelectable = true;
            this.closeFromRam.Click += new System.EventHandler(this.closeFromRam_Click);
            // 
            // CpuMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 469);
            this.Controls.Add(this.closeFromRam);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CpuMonitor";
            this.Text = "CPU AND RAM MONITOR";
            this.Load += new System.EventHandler(this.CpuMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton closeFromRam;
    }
}