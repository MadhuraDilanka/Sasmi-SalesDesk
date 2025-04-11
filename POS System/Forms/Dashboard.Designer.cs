namespace POS_System.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CategoryButton = new MetroFramework.Controls.MetroButton();
            this.SalesButton = new MetroFramework.Controls.MetroButton();
            this.OrdersButton = new MetroFramework.Controls.MetroButton();
            this.ExitApplicationButton = new MetroFramework.Controls.MetroButton();
            this.SalesInformationButton = new MetroFramework.Controls.MetroButton();
            this.SystemSettingsButton = new MetroFramework.Controls.MetroButton();
            this.CustomersButton = new MetroFramework.Controls.MetroButton();
            this.ProductsButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(569, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sasmi SalesDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(482, 627);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "© IdoDil All rights reserved.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(719, 627);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "0712783163 / agmdsampath@gmail.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CategoryButton
            // 
            this.CategoryButton.BackColor = System.Drawing.Color.Green;
            this.CategoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryButton.BackgroundImage")));
            this.CategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CategoryButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CategoryButton.Location = new System.Drawing.Point(258, 75);
            this.CategoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(164, 121);
            this.CategoryButton.TabIndex = 1;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CategoryButton.UseSelectable = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SalesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalesButton.BackgroundImage")));
            this.SalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalesButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SalesButton.Location = new System.Drawing.Point(79, 210);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(164, 121);
            this.SalesButton.TabIndex = 2;
            this.SalesButton.Text = "Sales";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalesButton.UseSelectable = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.OrdersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrdersButton.BackgroundImage")));
            this.OrdersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OrdersButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.OrdersButton.Location = new System.Drawing.Point(79, 348);
            this.OrdersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(164, 121);
            this.OrdersButton.TabIndex = 4;
            this.OrdersButton.Text = "Loan";
            this.OrdersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OrdersButton.UseSelectable = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.BackColor = System.Drawing.Color.Brown;
            this.ExitApplicationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitApplicationButton.BackgroundImage")));
            this.ExitApplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitApplicationButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ExitApplicationButton.Location = new System.Drawing.Point(258, 484);
            this.ExitApplicationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(164, 121);
            this.ExitApplicationButton.TabIndex = 7;
            this.ExitApplicationButton.Text = "Exit Application";
            this.ExitApplicationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitApplicationButton.UseSelectable = true;
            this.ExitApplicationButton.Click += new System.EventHandler(this.ExitApplicationButton_Click);
            // 
            // SalesInformationButton
            // 
            this.SalesInformationButton.BackColor = System.Drawing.Color.Pink;
            this.SalesInformationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalesInformationButton.BackgroundImage")));
            this.SalesInformationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalesInformationButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SalesInformationButton.Location = new System.Drawing.Point(258, 210);
            this.SalesInformationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalesInformationButton.Name = "SalesInformationButton";
            this.SalesInformationButton.Size = new System.Drawing.Size(164, 121);
            this.SalesInformationButton.TabIndex = 3;
            this.SalesInformationButton.Text = "Sales Information";
            this.SalesInformationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalesInformationButton.UseSelectable = true;
            this.SalesInformationButton.Click += new System.EventHandler(this.SalesInformationButton_Click);
            // 
            // SystemSettingsButton
            // 
            this.SystemSettingsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SystemSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SystemSettingsButton.BackgroundImage")));
            this.SystemSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SystemSettingsButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SystemSettingsButton.Location = new System.Drawing.Point(79, 484);
            this.SystemSettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SystemSettingsButton.Name = "SystemSettingsButton";
            this.SystemSettingsButton.Size = new System.Drawing.Size(164, 121);
            this.SystemSettingsButton.TabIndex = 6;
            this.SystemSettingsButton.Text = "System Settings";
            this.SystemSettingsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SystemSettingsButton.UseSelectable = true;
            this.SystemSettingsButton.Click += new System.EventHandler(this.SystemSettingsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.Yellow;
            this.CustomersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomersButton.BackgroundImage")));
            this.CustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomersButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CustomersButton.Location = new System.Drawing.Point(258, 348);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(164, 121);
            this.CustomersButton.TabIndex = 5;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustomersButton.UseSelectable = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ProductsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductsButton.BackgroundImage")));
            this.ProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProductsButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ProductsButton.Location = new System.Drawing.Point(79, 75);
            this.ProductsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(164, 121);
            this.ProductsButton.TabIndex = 0;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProductsButton.UseSelectable = true;
            this.ProductsButton.Click += new System.EventHandler(this.InventoryManagementButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.ExitApplicationButton);
            this.Controls.Add(this.SalesInformationButton);
            this.Controls.Add(this.SystemSettingsButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ProductsButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ProductsButton;
        private MetroFramework.Controls.MetroButton CustomersButton;
        private MetroFramework.Controls.MetroButton SalesInformationButton;
        private MetroFramework.Controls.MetroButton CategoryButton;
        private MetroFramework.Controls.MetroButton OrdersButton;
        private MetroFramework.Controls.MetroButton ExitApplicationButton;
        private MetroFramework.Controls.MetroButton SalesButton;
        private MetroFramework.Controls.MetroButton SystemSettingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}