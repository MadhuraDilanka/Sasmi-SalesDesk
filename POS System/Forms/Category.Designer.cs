namespace POS_System.Forms
{
    partial class Category
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
            this.CategoryNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.AddCategoryButton = new MetroFramework.Controls.MetroButton();
            this.CategoryGridView = new MetroFramework.Controls.MetroGrid();
            this.EditCategoryButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.DeleteCategoryButton = new MetroFramework.Controls.MetroButton();
            this.CategoryIDTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryNameTextBox
            // 
            // 
            // 
            // 
            this.CategoryNameTextBox.CustomButton.Image = null;
            this.CategoryNameTextBox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.CategoryNameTextBox.CustomButton.Name = "";
            this.CategoryNameTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.CategoryNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CategoryNameTextBox.CustomButton.TabIndex = 1;
            this.CategoryNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CategoryNameTextBox.CustomButton.UseSelectable = true;
            this.CategoryNameTextBox.CustomButton.Visible = false;
            this.CategoryNameTextBox.Lines = new string[0];
            this.CategoryNameTextBox.Location = new System.Drawing.Point(210, 144);
            this.CategoryNameTextBox.MaxLength = 32767;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.PasswordChar = '\0';
            this.CategoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryNameTextBox.SelectedText = "";
            this.CategoryNameTextBox.SelectionLength = 0;
            this.CategoryNameTextBox.SelectionStart = 0;
            this.CategoryNameTextBox.ShortcutsEnabled = true;
            this.CategoryNameTextBox.Size = new System.Drawing.Size(336, 35);
            this.CategoryNameTextBox.TabIndex = 0;
            this.CategoryNameTextBox.UseSelectable = true;
            this.CategoryNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CategoryNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CategoryNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CategoryNameTextBox_KeyUp);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(79, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Category:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddCategoryButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.AddCategoryButton.Location = new System.Drawing.Point(602, 88);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(139, 40);
            this.AddCategoryButton.TabIndex = 1;
            this.AddCategoryButton.Text = "Save";
            this.AddCategoryButton.UseSelectable = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // CategoryGridView
            // 
            this.CategoryGridView.AllowUserToAddRows = false;
            this.CategoryGridView.AllowUserToDeleteRows = false;
            this.CategoryGridView.AllowUserToResizeRows = false;
            this.CategoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CategoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryGridView.EnableHeadersVisualStyles = false;
            this.CategoryGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CategoryGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CategoryGridView.Location = new System.Drawing.Point(210, 213);
            this.CategoryGridView.Name = "CategoryGridView";
            this.CategoryGridView.ReadOnly = true;
            this.CategoryGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryGridView.RowHeadersWidth = 51;
            this.CategoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CategoryGridView.RowTemplate.Height = 24;
            this.CategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoryGridView.Size = new System.Drawing.Size(336, 373);
            this.CategoryGridView.TabIndex = 5;
            this.CategoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClick);
            this.CategoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellContentClick);
            // 
            // EditCategoryButton
            // 
            this.EditCategoryButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EditCategoryButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.EditCategoryButton.Location = new System.Drawing.Point(602, 158);
            this.EditCategoryButton.Name = "EditCategoryButton";
            this.EditCategoryButton.Size = new System.Drawing.Size(139, 40);
            this.EditCategoryButton.TabIndex = 2;
            this.EditCategoryButton.Text = "Add New";
            this.EditCategoryButton.UseSelectable = true;
            this.EditCategoryButton.Click += new System.EventHandler(this.EditCategoryButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HomeButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.HomeButton.Location = new System.Drawing.Point(602, 295);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(139, 40);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseSelectable = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteCategoryButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.DeleteCategoryButton.Location = new System.Drawing.Point(602, 226);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(139, 40);
            this.DeleteCategoryButton.TabIndex = 3;
            this.DeleteCategoryButton.Text = "Delete";
            this.DeleteCategoryButton.UseSelectable = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // CategoryIDTextBox
            // 
            // 
            // 
            // 
            this.CategoryIDTextBox.CustomButton.Image = null;
            this.CategoryIDTextBox.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.CategoryIDTextBox.CustomButton.Name = "";
            this.CategoryIDTextBox.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.CategoryIDTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CategoryIDTextBox.CustomButton.TabIndex = 1;
            this.CategoryIDTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CategoryIDTextBox.CustomButton.UseSelectable = true;
            this.CategoryIDTextBox.CustomButton.Visible = false;
            this.CategoryIDTextBox.Enabled = false;
            this.CategoryIDTextBox.Lines = new string[0];
            this.CategoryIDTextBox.Location = new System.Drawing.Point(210, 88);
            this.CategoryIDTextBox.MaxLength = 32767;
            this.CategoryIDTextBox.Name = "CategoryIDTextBox";
            this.CategoryIDTextBox.PasswordChar = '\0';
            this.CategoryIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryIDTextBox.SelectedText = "";
            this.CategoryIDTextBox.SelectionLength = 0;
            this.CategoryIDTextBox.SelectionStart = 0;
            this.CategoryIDTextBox.ShortcutsEnabled = true;
            this.CategoryIDTextBox.Size = new System.Drawing.Size(336, 35);
            this.CategoryIDTextBox.TabIndex = 0;
            this.CategoryIDTextBox.UseSelectable = true;
            this.CategoryIDTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CategoryIDTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(79, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "CategoryID:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 616);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.EditCategoryButton);
            this.Controls.Add(this.CategoryGridView);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CategoryIDTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox CategoryNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton AddCategoryButton;
        private MetroFramework.Controls.MetroGrid CategoryGridView;
        private MetroFramework.Controls.MetroButton EditCategoryButton;
        private MetroFramework.Controls.MetroButton HomeButton;
        private MetroFramework.Controls.MetroButton DeleteCategoryButton;
        private MetroFramework.Controls.MetroTextBox CategoryIDTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}