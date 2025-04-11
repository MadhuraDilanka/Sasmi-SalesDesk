namespace POS_System
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.UserNameLable = new MetroFramework.Controls.MetroLabel();
            this.UserNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserLoginButton = new MetroFramework.Controls.MetroButton();
            this.PasswordLable = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPageExitButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(190, 71);
            this.UserNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(78, 19);
            this.UserNameLable.TabIndex = 0;
            this.UserNameLable.Text = "User Name:";
            // 
            // UserNameTextBox
            // 
            // 
            // 
            // 
            this.UserNameTextBox.CustomButton.Image = null;
            this.UserNameTextBox.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.UserNameTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameTextBox.CustomButton.Name = "";
            this.UserNameTextBox.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.UserNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.CustomButton.TabIndex = 1;
            this.UserNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameTextBox.CustomButton.UseSelectable = true;
            this.UserNameTextBox.CustomButton.Visible = false;
            this.UserNameTextBox.Lines = new string[0];
            this.UserNameTextBox.Location = new System.Drawing.Point(270, 71);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameTextBox.MaxLength = 32767;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.SelectionLength = 0;
            this.UserNameTextBox.SelectionStart = 0;
            this.UserNameTextBox.ShortcutsEnabled = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(188, 23);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.UseSelectable = true;
            this.UserNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UserNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyUp);
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UserLoginButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.UserLoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.UserLoginButton.Location = new System.Drawing.Point(270, 159);
            this.UserLoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.Size = new System.Drawing.Size(188, 26);
            this.UserLoginButton.TabIndex = 3;
            this.UserLoginButton.Text = "LogIn";
            this.UserLoginButton.UseSelectable = true;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(190, 115);
            this.PasswordLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(66, 19);
            this.PasswordLable.TabIndex = 0;
            this.PasswordLable.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.PasswordTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(270, 115);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_System.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(32, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPageExitButton
            // 
            this.LoginPageExitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginPageExitButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.LoginPageExitButton.Location = new System.Drawing.Point(270, 195);
            this.LoginPageExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPageExitButton.Name = "LoginPageExitButton";
            this.LoginPageExitButton.Size = new System.Drawing.Size(188, 26);
            this.LoginPageExitButton.TabIndex = 4;
            this.LoginPageExitButton.Text = "Exit Application";
            this.LoginPageExitButton.UseSelectable = true;
            this.LoginPageExitButton.Click += new System.EventHandler(this.LoginPageExitButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 269);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginPageExitButton);
            this.Controls.Add(this.UserLoginButton);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel UserNameLable;
        private MetroFramework.Controls.MetroTextBox UserNameTextBox;
        private MetroFramework.Controls.MetroButton UserLoginButton;
        private MetroFramework.Controls.MetroLabel PasswordLable;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton LoginPageExitButton;
    }
}

