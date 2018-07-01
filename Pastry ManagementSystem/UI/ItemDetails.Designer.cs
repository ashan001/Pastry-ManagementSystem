namespace Pastry_ManagementSystem.UI
{
    partial class ItemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetails));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txt_itemName = new MetroFramework.Controls.MetroTextBox();
            this.txt_itemType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btn_delete);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.txt_itemName);
            this.metroPanel1.Controls.Add(this.txt_itemType);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-2, 49);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1338, 473);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(775, 25);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(246, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(718, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Item ID";
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delete.Location = new System.Drawing.Point(16, 414);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 35);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseSelectable = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(194, 414);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(83, 35);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txt_itemName
            // 
            // 
            // 
            // 
            this.txt_itemName.CustomButton.Image = null;
            this.txt_itemName.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txt_itemName.CustomButton.Name = "";
            this.txt_itemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemName.CustomButton.TabIndex = 1;
            this.txt_itemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemName.CustomButton.UseSelectable = true;
            this.txt_itemName.CustomButton.Visible = false;
            this.txt_itemName.Lines = new string[0];
            this.txt_itemName.Location = new System.Drawing.Point(446, 25);
            this.txt_itemName.MaxLength = 32767;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.PasswordChar = '\0';
            this.txt_itemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemName.SelectedText = "";
            this.txt_itemName.SelectionLength = 0;
            this.txt_itemName.SelectionStart = 0;
            this.txt_itemName.ShortcutsEnabled = true;
            this.txt_itemName.Size = new System.Drawing.Size(246, 23);
            this.txt_itemName.TabIndex = 4;
            this.txt_itemName.UseSelectable = true;
            this.txt_itemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemName.TextChanged += new System.EventHandler(this.txt_itemName_TextChanged);
            // 
            // txt_itemType
            // 
            // 
            // 
            // 
            this.txt_itemType.CustomButton.Image = null;
            this.txt_itemType.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.txt_itemType.CustomButton.Name = "";
            this.txt_itemType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_itemType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_itemType.CustomButton.TabIndex = 1;
            this.txt_itemType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_itemType.CustomButton.UseSelectable = true;
            this.txt_itemType.CustomButton.Visible = false;
            this.txt_itemType.Lines = new string[0];
            this.txt_itemType.Location = new System.Drawing.Point(90, 25);
            this.txt_itemType.MaxLength = 32767;
            this.txt_itemType.Name = "txt_itemType";
            this.txt_itemType.PasswordChar = '\0';
            this.txt_itemType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_itemType.SelectedText = "";
            this.txt_itemType.SelectionLength = 0;
            this.txt_itemType.SelectionStart = 0;
            this.txt_itemType.ShortcutsEnabled = true;
            this.txt_itemType.Size = new System.Drawing.Size(246, 23);
            this.txt_itemType.TabIndex = 4;
            this.txt_itemType.UseSelectable = true;
            this.txt_itemType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_itemType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_itemType.TextChanged += new System.EventHandler(this.txt_itemType_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(361, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Item Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Item Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1297, 352);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(105, 414);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 35);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 506);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemDetails";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "ItemDetails";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txt_itemName;
        private MetroFramework.Controls.MetroTextBox txt_itemType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}