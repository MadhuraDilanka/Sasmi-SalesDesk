namespace POS_System.Forms
{
    partial class Sales_Information
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Information));
            this.SalesDateTime = new MetroFramework.Controls.MetroDateTime();
            this.SalesInfoGrid = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintSelectedButton = new MetroFramework.Controls.MetroButton();
            this.GetProfitButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.ResetButton = new MetroFramework.Controls.MetroButton();
            this.CategorySearchButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalesInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesDateTime
            // 
            this.SalesDateTime.Location = new System.Drawing.Point(407, 126);
            this.SalesDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.SalesDateTime.Name = "SalesDateTime";
            this.SalesDateTime.Size = new System.Drawing.Size(335, 30);
            this.SalesDateTime.TabIndex = 0;
            // 
            // SalesInfoGrid
            // 
            this.SalesInfoGrid.AllowUserToAddRows = false;
            this.SalesInfoGrid.AllowUserToDeleteRows = false;
            this.SalesInfoGrid.AllowUserToResizeRows = false;
            this.SalesInfoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesInfoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalesInfoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SalesInfoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesInfoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesInfoGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesInfoGrid.EnableHeadersVisualStyles = false;
            this.SalesInfoGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SalesInfoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalesInfoGrid.Location = new System.Drawing.Point(185, 229);
            this.SalesInfoGrid.Name = "SalesInfoGrid";
            this.SalesInfoGrid.ReadOnly = true;
            this.SalesInfoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesInfoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SalesInfoGrid.RowHeadersWidth = 51;
            this.SalesInfoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SalesInfoGrid.RowTemplate.Height = 24;
            this.SalesInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesInfoGrid.Size = new System.Drawing.Size(1025, 385);
            this.SalesInfoGrid.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1183, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 144);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // PrintSelectedButton
            // 
            this.PrintSelectedButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PrintSelectedButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.PrintSelectedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PrintSelectedButton.Location = new System.Drawing.Point(461, 631);
            this.PrintSelectedButton.Name = "PrintSelectedButton";
            this.PrintSelectedButton.Size = new System.Drawing.Size(146, 43);
            this.PrintSelectedButton.TabIndex = 17;
            this.PrintSelectedButton.Text = "Print Selected";
            this.PrintSelectedButton.UseSelectable = true;
            this.PrintSelectedButton.Click += new System.EventHandler(this.PrintSelectedButton_Click);
            // 
            // GetProfitButton
            // 
            this.GetProfitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GetProfitButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.GetProfitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GetProfitButton.Location = new System.Drawing.Point(628, 631);
            this.GetProfitButton.Name = "GetProfitButton";
            this.GetProfitButton.Size = new System.Drawing.Size(146, 43);
            this.GetProfitButton.TabIndex = 17;
            this.GetProfitButton.Text = "Get Profit";
            this.GetProfitButton.UseSelectable = true;
            this.GetProfitButton.Click += new System.EventHandler(this.GetProfitButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HomeButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeButton.Location = new System.Drawing.Point(797, 631);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(146, 43);
            this.HomeButton.TabIndex = 17;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseSelectable = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.ResetButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.ResetButton.Location = new System.Drawing.Point(899, 125);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 31);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseSelectable = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CategorySearchButton
            // 
            this.CategorySearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.CategorySearchButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.CategorySearchButton.Location = new System.Drawing.Point(776, 125);
            this.CategorySearchButton.Name = "CategorySearchButton";
            this.CategorySearchButton.Size = new System.Drawing.Size(100, 31);
            this.CategorySearchButton.TabIndex = 11;
            this.CategorySearchButton.Text = "Search";
            this.CategorySearchButton.UseSelectable = true;
            this.CategorySearchButton.Click += new System.EventHandler(this.CategorySearchButton_Click);
            // 
            // Sales_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 738);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrintSelectedButton);
            this.Controls.Add(this.GetProfitButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.SalesInfoGrid);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CategorySearchButton);
            this.Controls.Add(this.SalesDateTime);
            this.Name = "Sales_Information";
            this.Text = "Sales_Information";
            this.Load += new System.EventHandler(this.Sales_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime SalesDateTime;
        private MetroFramework.Controls.MetroButton CategorySearchButton;
        private MetroFramework.Controls.MetroGrid SalesInfoGrid;
        private MetroFramework.Controls.MetroButton HomeButton;
        private MetroFramework.Controls.MetroButton ResetButton;
        private MetroFramework.Controls.MetroButton PrintSelectedButton;
        private MetroFramework.Controls.MetroButton GetProfitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}