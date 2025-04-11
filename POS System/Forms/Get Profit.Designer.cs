namespace POS_System.Forms
{
    partial class Get_Profit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get_Profit));
            this.FromDateTime = new MetroFramework.Controls.MetroDateTime();
            this.ToDateTime = new MetroFramework.Controls.MetroDateTime();
            this.ProfitBetweetnGrid = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBetweenProfit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CancelGetProfitButton = new MetroFramework.Controls.MetroButton();
            this.ProfitBetweenSearchButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitBetweetnGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FromDateTime
            // 
            this.FromDateTime.Location = new System.Drawing.Point(232, 112);
            this.FromDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Size = new System.Drawing.Size(278, 30);
            this.FromDateTime.TabIndex = 0;
            // 
            // ToDateTime
            // 
            this.ToDateTime.Location = new System.Drawing.Point(624, 112);
            this.ToDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(278, 30);
            this.ToDateTime.TabIndex = 1;
            // 
            // ProfitBetweetnGrid
            // 
            this.ProfitBetweetnGrid.AllowUserToAddRows = false;
            this.ProfitBetweetnGrid.AllowUserToDeleteRows = false;
            this.ProfitBetweetnGrid.AllowUserToResizeRows = false;
            this.ProfitBetweetnGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProfitBetweetnGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfitBetweetnGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProfitBetweetnGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfitBetweetnGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProfitBetweetnGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfitBetweetnGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProfitBetweetnGrid.EnableHeadersVisualStyles = false;
            this.ProfitBetweetnGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProfitBetweetnGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProfitBetweetnGrid.Location = new System.Drawing.Point(150, 217);
            this.ProfitBetweetnGrid.Name = "ProfitBetweetnGrid";
            this.ProfitBetweetnGrid.ReadOnly = true;
            this.ProfitBetweetnGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfitBetweetnGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProfitBetweetnGrid.RowHeadersWidth = 51;
            this.ProfitBetweetnGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProfitBetweetnGrid.RowTemplate.Height = 24;
            this.ProfitBetweetnGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProfitBetweetnGrid.Size = new System.Drawing.Size(1008, 295);
            this.ProfitBetweetnGrid.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total Profit:";
            // 
            // labelBetweenProfit
            // 
            this.labelBetweenProfit.AutoSize = true;
            this.labelBetweenProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetweenProfit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelBetweenProfit.Location = new System.Drawing.Point(403, 596);
            this.labelBetweenProfit.Name = "labelBetweenProfit";
            this.labelBetweenProfit.Size = new System.Drawing.Size(86, 46);
            this.labelBetweenProfit.TabIndex = 22;
            this.labelBetweenProfit.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "From:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "To:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1106, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 144);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // CancelGetProfitButton
            // 
            this.CancelGetProfitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelGetProfitButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.CancelGetProfitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelGetProfitButton.Location = new System.Drawing.Point(1065, 599);
            this.CancelGetProfitButton.Name = "CancelGetProfitButton";
            this.CancelGetProfitButton.Size = new System.Drawing.Size(146, 43);
            this.CancelGetProfitButton.TabIndex = 4;
            this.CancelGetProfitButton.Text = "Cancel";
            this.CancelGetProfitButton.UseSelectable = true;
            this.CancelGetProfitButton.Click += new System.EventHandler(this.CancelGetProfitButton_Click);
            // 
            // ProfitBetweenSearchButton
            // 
            this.ProfitBetweenSearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.ProfitBetweenSearchButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.ProfitBetweenSearchButton.Location = new System.Drawing.Point(956, 114);
            this.ProfitBetweenSearchButton.Name = "ProfitBetweenSearchButton";
            this.ProfitBetweenSearchButton.Size = new System.Drawing.Size(100, 31);
            this.ProfitBetweenSearchButton.TabIndex = 2;
            this.ProfitBetweenSearchButton.Text = "Search";
            this.ProfitBetweenSearchButton.UseSelectable = true;
            this.ProfitBetweenSearchButton.Click += new System.EventHandler(this.ProfitBetweenSearchButton_Click);
            // 
            // Get_Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 715);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelGetProfitButton);
            this.Controls.Add(this.labelBetweenProfit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProfitBetweetnGrid);
            this.Controls.Add(this.ProfitBetweenSearchButton);
            this.Controls.Add(this.ToDateTime);
            this.Controls.Add(this.FromDateTime);
            this.Name = "Get_Profit";
            this.Text = "Get_Profit";
            ((System.ComponentModel.ISupportInitialize)(this.ProfitBetweetnGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime FromDateTime;
        private MetroFramework.Controls.MetroDateTime ToDateTime;
        private MetroFramework.Controls.MetroButton ProfitBetweenSearchButton;
        private MetroFramework.Controls.MetroGrid ProfitBetweetnGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBetweenProfit;
        private MetroFramework.Controls.MetroButton CancelGetProfitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}