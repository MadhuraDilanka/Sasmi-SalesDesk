namespace POS_System.Forms
{
    partial class System_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Settings));
            this.PrinterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SaveSettingsButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.OldPwdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReEnterPwdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NewPwdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PwdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NewUserTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OldUserTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PrinterComboBox
            // 
            this.PrinterComboBox.FormattingEnabled = true;
            this.PrinterComboBox.ItemHeight = 24;
            this.PrinterComboBox.Location = new System.Drawing.Point(202, 195);
            this.PrinterComboBox.Name = "PrinterComboBox";
            this.PrinterComboBox.Size = new System.Drawing.Size(257, 30);
            this.PrinterComboBox.TabIndex = 0;
            this.PrinterComboBox.UseSelectable = true;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveSettingsButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.SaveSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveSettingsButton.Location = new System.Drawing.Point(899, 603);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(146, 43);
            this.SaveSettingsButton.TabIndex = 7;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseSelectable = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HomeButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeButton.Location = new System.Drawing.Point(1060, 603);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(146, 43);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseSelectable = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Select Printer:";
            // 
            // OldPwdTextBox
            // 
            // 
            // 
            // 
            this.OldPwdTextBox.CustomButton.Image = null;
            this.OldPwdTextBox.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.OldPwdTextBox.CustomButton.Name = "";
            this.OldPwdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.OldPwdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OldPwdTextBox.CustomButton.TabIndex = 1;
            this.OldPwdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OldPwdTextBox.CustomButton.UseSelectable = true;
            this.OldPwdTextBox.CustomButton.Visible = false;
            this.OldPwdTextBox.Lines = new string[0];
            this.OldPwdTextBox.Location = new System.Drawing.Point(239, 86);
            this.OldPwdTextBox.MaxLength = 32767;
            this.OldPwdTextBox.Name = "OldPwdTextBox";
            this.OldPwdTextBox.PasswordChar = '●';
            this.OldPwdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OldPwdTextBox.SelectedText = "";
            this.OldPwdTextBox.SelectionLength = 0;
            this.OldPwdTextBox.SelectionStart = 0;
            this.OldPwdTextBox.ShortcutsEnabled = true;
            this.OldPwdTextBox.Size = new System.Drawing.Size(257, 30);
            this.OldPwdTextBox.TabIndex = 4;
            this.OldPwdTextBox.UseSelectable = true;
            this.OldPwdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OldPwdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.OldPwdTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ReEnterPwdTextBox);
            this.panel1.Controls.Add(this.NewPwdTextBox);
            this.panel1.Controls.Add(this.OldPwdTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(653, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 270);
            this.panel1.TabIndex = 27;
            // 
            // ReEnterPwdTextBox
            // 
            // 
            // 
            // 
            this.ReEnterPwdTextBox.CustomButton.Image = null;
            this.ReEnterPwdTextBox.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.ReEnterPwdTextBox.CustomButton.Name = "";
            this.ReEnterPwdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ReEnterPwdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ReEnterPwdTextBox.CustomButton.TabIndex = 1;
            this.ReEnterPwdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ReEnterPwdTextBox.CustomButton.UseSelectable = true;
            this.ReEnterPwdTextBox.CustomButton.Visible = false;
            this.ReEnterPwdTextBox.Lines = new string[0];
            this.ReEnterPwdTextBox.Location = new System.Drawing.Point(239, 194);
            this.ReEnterPwdTextBox.MaxLength = 32767;
            this.ReEnterPwdTextBox.Name = "ReEnterPwdTextBox";
            this.ReEnterPwdTextBox.PasswordChar = '●';
            this.ReEnterPwdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ReEnterPwdTextBox.SelectedText = "";
            this.ReEnterPwdTextBox.SelectionLength = 0;
            this.ReEnterPwdTextBox.SelectionStart = 0;
            this.ReEnterPwdTextBox.ShortcutsEnabled = true;
            this.ReEnterPwdTextBox.Size = new System.Drawing.Size(257, 30);
            this.ReEnterPwdTextBox.TabIndex = 6;
            this.ReEnterPwdTextBox.UseSelectable = true;
            this.ReEnterPwdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ReEnterPwdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ReEnterPwdTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // NewPwdTextBox
            // 
            // 
            // 
            // 
            this.NewPwdTextBox.CustomButton.Image = null;
            this.NewPwdTextBox.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.NewPwdTextBox.CustomButton.Name = "";
            this.NewPwdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.NewPwdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewPwdTextBox.CustomButton.TabIndex = 1;
            this.NewPwdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewPwdTextBox.CustomButton.UseSelectable = true;
            this.NewPwdTextBox.CustomButton.Visible = false;
            this.NewPwdTextBox.Lines = new string[0];
            this.NewPwdTextBox.Location = new System.Drawing.Point(239, 140);
            this.NewPwdTextBox.MaxLength = 32767;
            this.NewPwdTextBox.Name = "NewPwdTextBox";
            this.NewPwdTextBox.PasswordChar = '●';
            this.NewPwdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewPwdTextBox.SelectedText = "";
            this.NewPwdTextBox.SelectionLength = 0;
            this.NewPwdTextBox.SelectionStart = 0;
            this.NewPwdTextBox.ShortcutsEnabled = true;
            this.NewPwdTextBox.Size = new System.Drawing.Size(257, 30);
            this.NewPwdTextBox.TabIndex = 5;
            this.NewPwdTextBox.UseSelectable = true;
            this.NewPwdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewPwdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NewPwdTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "ReEnter Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Old Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Change Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.PwdTextBox);
            this.panel2.Controls.Add(this.NewUserTextBox);
            this.panel2.Controls.Add(this.OldUserTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(55, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 270);
            this.panel2.TabIndex = 27;
            // 
            // PwdTextBox
            // 
            // 
            // 
            // 
            this.PwdTextBox.CustomButton.Image = null;
            this.PwdTextBox.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.PwdTextBox.CustomButton.Name = "";
            this.PwdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PwdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PwdTextBox.CustomButton.TabIndex = 1;
            this.PwdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PwdTextBox.CustomButton.UseSelectable = true;
            this.PwdTextBox.CustomButton.Visible = false;
            this.PwdTextBox.Lines = new string[0];
            this.PwdTextBox.Location = new System.Drawing.Point(231, 194);
            this.PwdTextBox.MaxLength = 32767;
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.PasswordChar = '●';
            this.PwdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PwdTextBox.SelectedText = "";
            this.PwdTextBox.SelectionLength = 0;
            this.PwdTextBox.SelectionStart = 0;
            this.PwdTextBox.ShortcutsEnabled = true;
            this.PwdTextBox.Size = new System.Drawing.Size(257, 30);
            this.PwdTextBox.TabIndex = 3;
            this.PwdTextBox.UseSelectable = true;
            this.PwdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PwdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PwdTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // NewUserTextBox
            // 
            // 
            // 
            // 
            this.NewUserTextBox.CustomButton.Image = null;
            this.NewUserTextBox.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.NewUserTextBox.CustomButton.Name = "";
            this.NewUserTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.NewUserTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewUserTextBox.CustomButton.TabIndex = 1;
            this.NewUserTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewUserTextBox.CustomButton.UseSelectable = true;
            this.NewUserTextBox.CustomButton.Visible = false;
            this.NewUserTextBox.Lines = new string[0];
            this.NewUserTextBox.Location = new System.Drawing.Point(231, 140);
            this.NewUserTextBox.MaxLength = 32767;
            this.NewUserTextBox.Name = "NewUserTextBox";
            this.NewUserTextBox.PasswordChar = '\0';
            this.NewUserTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewUserTextBox.SelectedText = "";
            this.NewUserTextBox.SelectionLength = 0;
            this.NewUserTextBox.SelectionStart = 0;
            this.NewUserTextBox.ShortcutsEnabled = true;
            this.NewUserTextBox.Size = new System.Drawing.Size(257, 30);
            this.NewUserTextBox.TabIndex = 2;
            this.NewUserTextBox.UseSelectable = true;
            this.NewUserTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewUserTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NewUserTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // OldUserTextBox
            // 
            // 
            // 
            // 
            this.OldUserTextBox.CustomButton.Image = null;
            this.OldUserTextBox.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.OldUserTextBox.CustomButton.Name = "";
            this.OldUserTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.OldUserTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OldUserTextBox.CustomButton.TabIndex = 1;
            this.OldUserTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OldUserTextBox.CustomButton.UseSelectable = true;
            this.OldUserTextBox.CustomButton.Visible = false;
            this.OldUserTextBox.Lines = new string[0];
            this.OldUserTextBox.Location = new System.Drawing.Point(231, 86);
            this.OldUserTextBox.MaxLength = 32767;
            this.OldUserTextBox.Name = "OldUserTextBox";
            this.OldUserTextBox.PasswordChar = '\0';
            this.OldUserTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OldUserTextBox.SelectedText = "";
            this.OldUserTextBox.SelectionLength = 0;
            this.OldUserTextBox.SelectionStart = 0;
            this.OldUserTextBox.ShortcutsEnabled = true;
            this.OldUserTextBox.Size = new System.Drawing.Size(257, 30);
            this.OldUserTextBox.TabIndex = 1;
            this.OldUserTextBox.UseSelectable = true;
            this.OldUserTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OldUserTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.OldUserTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "New UserName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Old UserName:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Change UserName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.Location = new System.Drawing.Point(434, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(385, 55);
            this.label10.TabIndex = 28;
            this.label10.Text = "System Settings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1040, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 144);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // System_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 710);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PrinterComboBox);
            this.Name = "System_Settings";
            this.Text = "System_Settings";
            this.Load += new System.EventHandler(this.System_Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox PrinterComboBox;
        private MetroFramework.Controls.MetroButton HomeButton;
        private MetroFramework.Controls.MetroButton SaveSettingsButton;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox OldPwdTextBox;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox ReEnterPwdTextBox;
        private MetroFramework.Controls.MetroTextBox NewPwdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox PwdTextBox;
        private MetroFramework.Controls.MetroTextBox NewUserTextBox;
        private MetroFramework.Controls.MetroTextBox OldUserTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}