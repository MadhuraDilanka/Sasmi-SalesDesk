namespace POS_System.Forms
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.KeyWordSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CategorySearchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ProductSearchGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.QuantitySalesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.TotalAmountSaleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BalanceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CashTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.SaleNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.HomeButton = new MetroFramework.Controls.MetroButton();
            this.NewSaleButton = new MetroFramework.Controls.MetroButton();
            this.RemoveSalesButton = new MetroFramework.Controls.MetroButton();
            this.AddSalesButton = new MetroFramework.Controls.MetroButton();
            this.CategorySearchButton = new MetroFramework.Controls.MetroButton();
            this.CustomerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.CashradioButton = new System.Windows.Forms.RadioButton();
            this.LoanradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(156, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "KeyWord Search:";
            // 
            // KeyWordSearchTextBox
            // 
            // 
            // 
            // 
            this.KeyWordSearchTextBox.CustomButton.Image = null;
            this.KeyWordSearchTextBox.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.KeyWordSearchTextBox.CustomButton.Name = "";
            this.KeyWordSearchTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.KeyWordSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.KeyWordSearchTextBox.CustomButton.TabIndex = 1;
            this.KeyWordSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KeyWordSearchTextBox.CustomButton.UseSelectable = true;
            this.KeyWordSearchTextBox.CustomButton.Visible = false;
            this.KeyWordSearchTextBox.Lines = new string[0];
            this.KeyWordSearchTextBox.Location = new System.Drawing.Point(318, 75);
            this.KeyWordSearchTextBox.MaxLength = 32767;
            this.KeyWordSearchTextBox.Name = "KeyWordSearchTextBox";
            this.KeyWordSearchTextBox.PasswordChar = '\0';
            this.KeyWordSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KeyWordSearchTextBox.SelectedText = "";
            this.KeyWordSearchTextBox.SelectionLength = 0;
            this.KeyWordSearchTextBox.SelectionStart = 0;
            this.KeyWordSearchTextBox.ShortcutsEnabled = true;
            this.KeyWordSearchTextBox.Size = new System.Drawing.Size(256, 30);
            this.KeyWordSearchTextBox.TabIndex = 1;
            this.KeyWordSearchTextBox.UseSelectable = true;
            this.KeyWordSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.KeyWordSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.KeyWordSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyWordSearchTextBox_KeyPress);
            this.KeyWordSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyWordSearchTextBox_KeyUp);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(650, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Category Search:";
            // 
            // CategorySearchComboBox
            // 
            this.CategorySearchComboBox.FormattingEnabled = true;
            this.CategorySearchComboBox.ItemHeight = 24;
            this.CategorySearchComboBox.Location = new System.Drawing.Point(813, 75);
            this.CategorySearchComboBox.Name = "CategorySearchComboBox";
            this.CategorySearchComboBox.Size = new System.Drawing.Size(256, 30);
            this.CategorySearchComboBox.TabIndex = 11;
            this.CategorySearchComboBox.UseSelectable = true;
            // 
            // ProductSearchGrid
            // 
            this.ProductSearchGrid.AllowUserToAddRows = false;
            this.ProductSearchGrid.AllowUserToDeleteRows = false;
            this.ProductSearchGrid.AllowUserToResizeRows = false;
            this.ProductSearchGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductSearchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductSearchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductSearchGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductSearchGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductSearchGrid.EnableHeadersVisualStyles = false;
            this.ProductSearchGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductSearchGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductSearchGrid.Location = new System.Drawing.Point(88, 131);
            this.ProductSearchGrid.Name = "ProductSearchGrid";
            this.ProductSearchGrid.ReadOnly = true;
            this.ProductSearchGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSearchGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductSearchGrid.RowHeadersWidth = 51;
            this.ProductSearchGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductSearchGrid.RowTemplate.Height = 24;
            this.ProductSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductSearchGrid.Size = new System.Drawing.Size(784, 205);
            this.ProductSearchGrid.TabIndex = 12;
            this.ProductSearchGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductSearchGrid_CellClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(269, 367);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Quantity:";
            // 
            // QuantitySalesTextBox
            // 
            // 
            // 
            // 
            this.QuantitySalesTextBox.CustomButton.Image = null;
            this.QuantitySalesTextBox.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.QuantitySalesTextBox.CustomButton.Name = "";
            this.QuantitySalesTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.QuantitySalesTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantitySalesTextBox.CustomButton.TabIndex = 1;
            this.QuantitySalesTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantitySalesTextBox.CustomButton.UseSelectable = true;
            this.QuantitySalesTextBox.CustomButton.Visible = false;
            this.QuantitySalesTextBox.Lines = new string[0];
            this.QuantitySalesTextBox.Location = new System.Drawing.Point(388, 367);
            this.QuantitySalesTextBox.MaxLength = 32767;
            this.QuantitySalesTextBox.Name = "QuantitySalesTextBox";
            this.QuantitySalesTextBox.PasswordChar = '\0';
            this.QuantitySalesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantitySalesTextBox.SelectedText = "";
            this.QuantitySalesTextBox.SelectionLength = 0;
            this.QuantitySalesTextBox.SelectionStart = 0;
            this.QuantitySalesTextBox.ShortcutsEnabled = true;
            this.QuantitySalesTextBox.Size = new System.Drawing.Size(256, 30);
            this.QuantitySalesTextBox.TabIndex = 1;
            this.QuantitySalesTextBox.UseSelectable = true;
            this.QuantitySalesTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantitySalesTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QuantitySalesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantitySalesTextBox_KeyPress);
            this.QuantitySalesTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantitySalesTextBox_KeyUp);
            // 
            // SalesGridView
            // 
            this.SalesGridView.AllowUserToAddRows = false;
            this.SalesGridView.AllowUserToDeleteRows = false;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Location = new System.Drawing.Point(88, 418);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.ReadOnly = true;
            this.SalesGridView.RowHeadersWidth = 51;
            this.SalesGridView.RowTemplate.Height = 24;
            this.SalesGridView.Size = new System.Drawing.Size(860, 236);
            this.SalesGridView.TabIndex = 15;
            this.SalesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellClick);
            // 
            // TotalAmountSaleTextBox
            // 
            // 
            // 
            // 
            this.TotalAmountSaleTextBox.CustomButton.Image = null;
            this.TotalAmountSaleTextBox.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.TotalAmountSaleTextBox.CustomButton.Name = "";
            this.TotalAmountSaleTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TotalAmountSaleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalAmountSaleTextBox.CustomButton.TabIndex = 1;
            this.TotalAmountSaleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalAmountSaleTextBox.CustomButton.UseSelectable = true;
            this.TotalAmountSaleTextBox.CustomButton.Visible = false;
            this.TotalAmountSaleTextBox.Enabled = false;
            this.TotalAmountSaleTextBox.Lines = new string[0];
            this.TotalAmountSaleTextBox.Location = new System.Drawing.Point(1152, 418);
            this.TotalAmountSaleTextBox.MaxLength = 32767;
            this.TotalAmountSaleTextBox.Name = "TotalAmountSaleTextBox";
            this.TotalAmountSaleTextBox.PasswordChar = '\0';
            this.TotalAmountSaleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalAmountSaleTextBox.SelectedText = "";
            this.TotalAmountSaleTextBox.SelectionLength = 0;
            this.TotalAmountSaleTextBox.SelectionStart = 0;
            this.TotalAmountSaleTextBox.ShortcutsEnabled = true;
            this.TotalAmountSaleTextBox.Size = new System.Drawing.Size(256, 30);
            this.TotalAmountSaleTextBox.TabIndex = 1;
            this.TotalAmountSaleTextBox.UseSelectable = true;
            this.TotalAmountSaleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalAmountSaleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(990, 511);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Balance:";
            // 
            // BalanceTextBox
            // 
            // 
            // 
            // 
            this.BalanceTextBox.CustomButton.Image = null;
            this.BalanceTextBox.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.BalanceTextBox.CustomButton.Name = "";
            this.BalanceTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.BalanceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BalanceTextBox.CustomButton.TabIndex = 1;
            this.BalanceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BalanceTextBox.CustomButton.UseSelectable = true;
            this.BalanceTextBox.CustomButton.Visible = false;
            this.BalanceTextBox.Enabled = false;
            this.BalanceTextBox.Lines = new string[0];
            this.BalanceTextBox.Location = new System.Drawing.Point(1152, 511);
            this.BalanceTextBox.MaxLength = 32767;
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.PasswordChar = '\0';
            this.BalanceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BalanceTextBox.SelectedText = "";
            this.BalanceTextBox.SelectionLength = 0;
            this.BalanceTextBox.SelectionStart = 0;
            this.BalanceTextBox.ShortcutsEnabled = true;
            this.BalanceTextBox.Size = new System.Drawing.Size(256, 30);
            this.BalanceTextBox.TabIndex = 1;
            this.BalanceTextBox.UseSelectable = true;
            this.BalanceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BalanceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(990, 466);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Cash:";
            // 
            // CashTextBox
            // 
            // 
            // 
            // 
            this.CashTextBox.CustomButton.Image = null;
            this.CashTextBox.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.CashTextBox.CustomButton.Name = "";
            this.CashTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.CashTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CashTextBox.CustomButton.TabIndex = 1;
            this.CashTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CashTextBox.CustomButton.UseSelectable = true;
            this.CashTextBox.CustomButton.Visible = false;
            this.CashTextBox.Lines = new string[0];
            this.CashTextBox.Location = new System.Drawing.Point(1152, 466);
            this.CashTextBox.MaxLength = 32767;
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.PasswordChar = '\0';
            this.CashTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CashTextBox.SelectedText = "";
            this.CashTextBox.SelectionLength = 0;
            this.CashTextBox.SelectionStart = 0;
            this.CashTextBox.ShortcutsEnabled = true;
            this.CashTextBox.Size = new System.Drawing.Size(256, 30);
            this.CashTextBox.TabIndex = 1;
            this.CashTextBox.UseSelectable = true;
            this.CashTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CashTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CashTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTextBox_KeyPress);
            this.CashTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CashTextBox_KeyUp);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(990, 557);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Sale Name:";
            // 
            // SaleNameTextBox
            // 
            // 
            // 
            // 
            this.SaleNameTextBox.CustomButton.Image = null;
            this.SaleNameTextBox.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.SaleNameTextBox.CustomButton.Name = "";
            this.SaleNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.SaleNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SaleNameTextBox.CustomButton.TabIndex = 1;
            this.SaleNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SaleNameTextBox.CustomButton.UseSelectable = true;
            this.SaleNameTextBox.CustomButton.Visible = false;
            this.SaleNameTextBox.Lines = new string[0];
            this.SaleNameTextBox.Location = new System.Drawing.Point(1152, 557);
            this.SaleNameTextBox.MaxLength = 32767;
            this.SaleNameTextBox.Name = "SaleNameTextBox";
            this.SaleNameTextBox.PasswordChar = '\0';
            this.SaleNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SaleNameTextBox.SelectedText = "";
            this.SaleNameTextBox.SelectionLength = 0;
            this.SaleNameTextBox.SelectionStart = 0;
            this.SaleNameTextBox.ShortcutsEnabled = true;
            this.SaleNameTextBox.Size = new System.Drawing.Size(256, 30);
            this.SaleNameTextBox.TabIndex = 1;
            this.SaleNameTextBox.UseSelectable = true;
            this.SaleNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SaleNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotal.Location = new System.Drawing.Point(357, 27);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(86, 46);
            this.labelTotal.TabIndex = 17;
            this.labelTotal.Text = "000";
            this.labelTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(990, 418);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 20);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Total Amount:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(885, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 100);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1233, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 193);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SubmitButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SubmitButton.Location = new System.Drawing.Point(1152, 692);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(256, 37);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HomeButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeButton.Location = new System.Drawing.Point(632, 686);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(146, 43);
            this.HomeButton.TabIndex = 16;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseSelectable = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // NewSaleButton
            // 
            this.NewSaleButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NewSaleButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.NewSaleButton.Location = new System.Drawing.Point(254, 686);
            this.NewSaleButton.Name = "NewSaleButton";
            this.NewSaleButton.Size = new System.Drawing.Size(146, 43);
            this.NewSaleButton.TabIndex = 16;
            this.NewSaleButton.Text = "New Sale";
            this.NewSaleButton.UseSelectable = true;
            this.NewSaleButton.Click += new System.EventHandler(this.NewSaleButton_Click);
            // 
            // RemoveSalesButton
            // 
            this.RemoveSalesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RemoveSalesButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.RemoveSalesButton.Location = new System.Drawing.Point(443, 686);
            this.RemoveSalesButton.Name = "RemoveSalesButton";
            this.RemoveSalesButton.Size = new System.Drawing.Size(145, 43);
            this.RemoveSalesButton.TabIndex = 16;
            this.RemoveSalesButton.Text = "Remove";
            this.RemoveSalesButton.UseSelectable = true;
            this.RemoveSalesButton.Click += new System.EventHandler(this.RemoveSalesButton_Click);
            // 
            // AddSalesButton
            // 
            this.AddSalesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddSalesButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.AddSalesButton.Location = new System.Drawing.Point(667, 367);
            this.AddSalesButton.Name = "AddSalesButton";
            this.AddSalesButton.Size = new System.Drawing.Size(98, 30);
            this.AddSalesButton.TabIndex = 16;
            this.AddSalesButton.Text = "ADD";
            this.AddSalesButton.UseSelectable = true;
            this.AddSalesButton.Click += new System.EventHandler(this.AddSalesButton_Click);
            // 
            // CategorySearchButton
            // 
            this.CategorySearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.CategorySearchButton.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.CategorySearchButton.Location = new System.Drawing.Point(1096, 75);
            this.CategorySearchButton.Name = "CategorySearchButton";
            this.CategorySearchButton.Size = new System.Drawing.Size(100, 31);
            this.CategorySearchButton.TabIndex = 10;
            this.CategorySearchButton.Text = "Search";
            this.CategorySearchButton.UseSelectable = true;
            this.CategorySearchButton.Click += new System.EventHandler(this.CategorySearchButton_Click);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.ItemHeight = 24;
            this.CustomerComboBox.Location = new System.Drawing.Point(1152, 606);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(256, 30);
            this.CustomerComboBox.TabIndex = 11;
            this.CustomerComboBox.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroButton1.BackgroundImage = global::POS_System.Properties.Resources.uranus;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(1491, 1223);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(256, 37);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Submit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(990, 616);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 20);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Customer:";
            // 
            // CashradioButton
            // 
            this.CashradioButton.AutoSize = true;
            this.CashradioButton.Checked = true;
            this.CashradioButton.Location = new System.Drawing.Point(1152, 655);
            this.CashradioButton.Name = "CashradioButton";
            this.CashradioButton.Size = new System.Drawing.Size(61, 21);
            this.CashradioButton.TabIndex = 20;
            this.CashradioButton.TabStop = true;
            this.CashradioButton.Text = "Cash";
            this.CashradioButton.UseVisualStyleBackColor = true;
            // 
            // LoanradioButton
            // 
            this.LoanradioButton.AutoSize = true;
            this.LoanradioButton.Location = new System.Drawing.Point(1233, 655);
            this.LoanradioButton.Name = "LoanradioButton";
            this.LoanradioButton.Size = new System.Drawing.Size(61, 21);
            this.LoanradioButton.TabIndex = 21;
            this.LoanradioButton.Text = "Loan";
            this.LoanradioButton.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 770);
            this.Controls.Add(this.LoanradioButton);
            this.Controls.Add(this.CashradioButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.NewSaleButton);
            this.Controls.Add(this.RemoveSalesButton);
            this.Controls.Add(this.AddSalesButton);
            this.Controls.Add(this.SalesGridView);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.ProductSearchGrid);
            this.Controls.Add(this.CategorySearchComboBox);
            this.Controls.Add(this.CategorySearchButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.QuantitySalesTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.TotalAmountSaleTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.SaleNameTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.KeyWordSearchTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox KeyWordSearchTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton CategorySearchButton;
        private MetroFramework.Controls.MetroComboBox CategorySearchComboBox;
        private MetroFramework.Controls.MetroGrid ProductSearchGrid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox QuantitySalesTextBox;
        private System.Windows.Forms.DataGridView SalesGridView;
        private MetroFramework.Controls.MetroButton AddSalesButton;
        private MetroFramework.Controls.MetroButton NewSaleButton;
        private MetroFramework.Controls.MetroButton HomeButton;
        private MetroFramework.Controls.MetroButton RemoveSalesButton;
        private MetroFramework.Controls.MetroTextBox TotalAmountSaleTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox BalanceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox CashTextBox;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox SaleNameTextBox;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CustomerComboBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.RadioButton CashradioButton;
        private System.Windows.Forms.RadioButton LoanradioButton;
    }
}