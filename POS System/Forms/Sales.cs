using POS_System.Classes;
using POS_System.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class Sales : MetroFramework.Forms.MetroForm
    {
        public Sales()
        {
            InitializeComponent();
        }
        public System_Settings System_Settings;
        //private readonly System_Settings system_Settings;

        public Sales(System_Settings System_Settings)
        {
            this.System_Settings = System_Settings;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = LoadCategory();
            CategorySearchComboBox.DataSource = dataTable;
            CategorySearchComboBox.DisplayMember = "Category Name";
            CategorySearchComboBox.ValueMember = "CategoryID";
            //SearchProductFromCategory();
            LoadProductForSales();
            dataTable = GetTempSales();
            SalesGridView.DataSource = dataTable;
            string TotalAmount = GetTotalAmount();
            TotalAmountSaleTextBox.Text = TotalAmount;
            labelTotal.Text = TotalAmount;
            LoadAllCustomer();
        }

        private void LoadAllCustomer()
        {
            List<CategoryList> categoryLists = new List<CategoryList>();
            categoryLists = GetFullCustomerNameAndId();
            CustomerComboBox.Items.Clear();
            //CustomerComboBox.Items.Add("-Select-");
            CustomerComboBox.DataSource = categoryLists;
            CustomerComboBox.DisplayMember = "CustomerName";
            CustomerComboBox.ValueMember = "CustomerID";
            CustomerComboBox.SelectedIndex = 0;
        }

        private List<CategoryList> GetFullCustomerNameAndId()
        {
            List<CategoryList> categoryLists = new List<CategoryList>();
            CategoryList firstUser = new CategoryList() { CustomerID = 0, CustomerName = "--select--" };
            categoryLists.Add(firstUser);
            try
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand("GetFullCustomerNameAndId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object id = reader["CustomerID"];
                            if (id == DBNull.Value)
                            {
                                id = 0;
                            }

                            object name = reader["Name"];
                            if (name == DBNull.Value)
                            {
                                name = "";
                            }
                            CategoryList Customer = new CategoryList();
                            Customer.CustomerID = Convert.ToInt64(id);
                            Customer.CustomerName = name.ToString();
                            categoryLists.Add(Customer);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;

            }

            return categoryLists;
        }

        private DataTable GetAllCustomer()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void LoadProductForSales()
        {
            DataTable dataTable = new DataTable();
            dataTable = GetProductForSale();
            ProductSearchGrid.DataSource = dataTable;
        }

        private DataTable GetProductForSale()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetProductsForSales", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private DataTable LoadCategory()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetCategories", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;

        }

        private void CategorySearchButton_Click(object sender, EventArgs e)
        {
            SearchProductFromCategory();
        }

        private void SearchProductFromCategory()
        {
            DataTable dataTable = new DataTable();
            int CategoryID = Int32.Parse(((DataRowView)CategorySearchComboBox.Items[CategorySearchComboBox.SelectedIndex]).Row.ItemArray[0].ToString());
            dataTable = GetSearchProductsByCategory(CategoryID);
            ProductSearchGrid.DataSource = dataTable;
            
            
        }

        private DataTable GetSearchProductsByCategory(int CategoryID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetSearchProductsByCategory", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void ProductSearchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QuantitySalesTextBox.Focus();
        }

        private void AddSalesButton_Click(object sender, EventArgs e)
        {
            AddSaleData();
        }

        private void AddSaleData()
        {
            DataGridViewRow row = ProductSearchGrid.Rows[ProductSearchGrid.CurrentCell.RowIndex];
            int ProductID = Int32.Parse(row.Cells[0].Value.ToString());
            DataTable dataTable = new DataTable();
            dataTable = GetProductByID(ProductID);

            string ProductName = dataTable.Rows[0]["Product Name"].ToString();
            string Cost = dataTable.Rows[0]["ProductPrice"].ToString();
            if (Cost == "")
            {
                Cost = "0";
            }
            string SellingPrice = dataTable.Rows[0]["Selling Price"].ToString();
            if (SellingPrice == "")
            {
                SellingPrice = "0";
            }
            string Discount = dataTable.Rows[0]["Discount"].ToString();
            if (Discount == "")
            {
                Discount = "0";
            }

            double NewSellingPrice = Convert.ToDouble(SellingPrice) - Convert.ToDouble(Discount);


            string Quantity = QuantitySalesTextBox.Text.Trim().ToString();
            if (Quantity == "")
            {
                Quantity = "0";
            }
            double TotalCost = Convert.ToDouble(Cost) * Convert.ToDouble(Quantity);
            double Amount = NewSellingPrice * Convert.ToDouble(Quantity);
            double SaleProfit = Amount - TotalCost;
            SaveSalesItems(ProductID, ProductName, Convert.ToDouble(Cost), Convert.ToDouble(SellingPrice), Convert.ToDouble(Discount), Convert.ToDouble(Quantity), TotalCost, Amount, SaleProfit);
            dataTable = GetTempSales();
            SalesGridView.DataSource = dataTable;
            string TotalAmount = GetTotalAmount();
            TotalAmountSaleTextBox.Text = TotalAmount;
            labelTotal.Text = TotalAmount;
            QuantitySalesTextBox.Text = "";
        }

        private string GetTotalAmount()
        {
            string Amount = "0";
            double TotalAmount = 0;
            DataTable dataTable = new DataTable();
            dataTable = GetAmountFromTempTable();
            foreach (DataRow row in dataTable.Rows)
            {
                Amount = row["Amount"].ToString();
                TotalAmount += Convert.ToDouble(Amount);
            }

            return TotalAmount.ToString();
        }

        private DataTable GetAmountFromTempTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAmountFromSalesTempTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private DataTable GetTempSales()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetTempareySalesData", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void SaveSalesItems(int productID, string productName, double Cost, double price, double Discount, double Quantity, double TotalCost, double amount, double SaleProfit)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertSalesToTempTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", productID);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@cost", Cost);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@Discount", Discount);
                    cmd.Parameters.AddWithValue("@qty", Quantity);
                    cmd.Parameters.AddWithValue("@totalCost", TotalCost);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@saleProfit", SaleProfit);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private DataTable GetProductByID(int productID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetProductsByProductID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", productID);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void NewSaleButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DeleteSaleItems();
            dataTable = GetTempSales();
            SalesGridView.DataSource = dataTable;
            string TotalAmount = GetTotalAmount();
            TotalAmountSaleTextBox.Text = TotalAmount;
            QuantitySalesTextBox.Text = "";
            CashTextBox.Text = "";
            BalanceTextBox.Text = "";
            labelTotal.Text = TotalAmount;
            CustomerComboBox.SelectedIndex = 0;
            CashradioButton.Checked = true;
            //LoadAllCustomer();
        }

        private void DeleteSaleItems()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteSalesItems", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void KeywordButton_Click(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //string KeyWord = KeyWordSearchTextBox.Text.Trim().ToString();
            //dataTable = GetProductByKeyWord("%" + KeyWord + "%");
            //ProductSearchGrid.DataSource = dataTable;
        }

        private DataTable GetProductByKeyWord(string keyWord)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("KeywordSearchProductsData", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Keyword", keyWord);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void KeyWordSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //string KeyWord = KeyWordSearchTextBox.Text.Trim().ToString();
            //dataTable = GetProductByKeyWord("%" + KeyWord + "%");
            //ProductSearchGrid.DataSource = dataTable;
        }

        private void KeyWordSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dataTable = new DataTable();
            string KeyWord = KeyWordSearchTextBox.Text.Trim().ToString();
            dataTable = GetProductByKeyWord(KeyWord + "%");
            ProductSearchGrid.DataSource = dataTable;
        }

        private void SalesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RemoveSalesButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataGridViewRow row = SalesGridView.Rows[SalesGridView.CurrentCell.RowIndex];
            int SaleID = Int32.Parse(row.Cells[0].Value.ToString());
            RemoveSaleItem(SaleID);
            dataTable = GetTempSales();
            SalesGridView.DataSource = dataTable;
            string TotalAmount = GetTotalAmount();
            TotalAmountSaleTextBox.Text = TotalAmount;
            labelTotal.Text = TotalAmount;
        }

        private void RemoveSaleItem(int saleID)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("RemoveSaleItemFromID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@saleID", saleID);
                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(CashTextBox.Text.Trim().ToString() != "")
            {
                

                DialogResult dr = MessageBox.Show("Are you sure to Submit?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if(LoanradioButton.Checked == true && CustomerComboBox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select Customer", "Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SetBill();
                        string SaleName = SaleNameTextBox.Text.Trim().ToString();
                        if (SaleName == "")
                        {
                            SaleName = "No Sale Name";
                        }
                        DateTime dateTime = DateTime.Now;
                        string Date = dateTime.ToString("dd/MM/yyyy");
                        string NDate = dateTime.ToString("yyyy-MM-dd");
                        string Time = dateTime.ToString("h:mm:ss tt");
                        double CostAmount = Convert.ToDouble(GetTotalCost().ToString());
                        //string TotalAmount = TotalAmountSaleTextBox.Text.Trim().ToString();
                        string TotalAmount = labelTotal.Text.Trim().ToString();
                        string CustomerName = "";
                        if (CustomerComboBox.SelectedIndex == 0)
                        {
                            CustomerName = "No Customer Selected";
                        }
                        else
                        {
                            CustomerName = CustomerComboBox.Text.ToString();
                        }

                        string CustomerID = CustomerComboBox.SelectedValue.ToString();
                        if (CustomerID == "" || CustomerID == null)
                        {
                            CustomerID = "0";
                        }
                        if (TotalAmount == "")
                        {
                            TotalAmount = "0";
                        }
                        double Profit = Convert.ToDouble(TotalAmount.ToString()) - CostAmount;
                        SetSaleRecords(SaleName, Date, Time, CostAmount, TotalAmount, Profit, NDate);
                        CashTextBox.Text = "";
                        BalanceTextBox.Text = "";
                        SaleNameTextBox.Text = "";
                        SetAvailbleQuntitiy();
                        if (LoanradioButton.Checked == true)
                        {
                            setLoan(Convert.ToDouble(CustomerID.ToString()), CustomerName, SaleName, Date, Time, CostAmount, TotalAmount, Profit, NDate);
                        }
                    }
                    
                }
                else if (dr == DialogResult.No)
                {
                    //Nothing to do
                }
            }
            else
            {
                MessageBox.Show("Please Enter Cashe", "Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void setLoan(double CustomerID, string CustomerName, string SaleName, string Date, string Time, double CostAmount, string TotalAmount, double Profit, string NDate)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertLoan", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@SaleName", SaleName);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Time", Time);
                    cmd.Parameters.AddWithValue("@CostAmount", CostAmount);
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    cmd.Parameters.AddWithValue("@Profit", Profit);
                    cmd.Parameters.AddWithValue("@NDate", NDate);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void SetAvailbleQuntitiy()
        {
            DataTable dataTable = new DataTable();
            dataTable = GetAllTempSales();
            foreach (DataRow row in dataTable.Rows)
            {
                string ProductID = row["ProductID"].ToString();
                string Qty = row["Qty"].ToString();
                UpdateAvailableQuantity(Int32.Parse(ProductID), float.Parse(Qty));
                
            }
        }

        private DataTable GetAllTempSales()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllTempSales", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void UpdateAvailableQuantity(int ProductID, float Qty)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateAvailableQuantity", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", ProductID);
                    cmd.Parameters.AddWithValue("@qty", Qty);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void SetSaleRecords(string saleName, string date, string time, double costAmount, string totalAmount, double profit, string NDate)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SetSaleRecords", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@saleName", saleName);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@costAmount", costAmount);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@profit", profit);
                    cmd.Parameters.AddWithValue("@Ndate", NDate);
                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private string GetTotalCost()
        {
            string Cost = "0";
            double TotalCost = 0;
            DataTable dataTable = new DataTable();
            dataTable = GetTotalCostFromTempTable();
            foreach (DataRow row in dataTable.Rows)
            {
                Cost = row["Cost"].ToString();
                if(Cost == "")
                {
                    Cost = "0";
                }
                TotalCost += Convert.ToDouble(Cost);
            }

            return TotalCost.ToString();
        }

        private DataTable GetTotalCostFromTempTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetTotalCostFromSalesTempTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void SetBill()
        {
            DataTable dataTable = new DataTable();
            dataTable = GetTempSales();
            // Set the output dir and file name
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file = "CreatedByCSharp.pdf";
            string printer = GetPrinterName("PrinterIndex");
            PrintDocument pDoc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    //PrinterName = "Microsoft Print to PDF",
                    //PrinterName = "Two Pilots Demo Printer",
                    PrinterName = printer,
                    PrintToFile = true,
                    PrintFileName = System.IO.Path.Combine(directory, file),
                }
            };

            pDoc.PrintPage += new PrintPageEventHandler(Print_Page);
            pDoc.Print();
        }

        void Print_Page(object sender, PrintPageEventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetTempSales();
            // Here you can play with the font style 
            // (and much much more, this is just an ultra-basic example)
            Font font1 = new Font("Courier New", 10);
            Font font2 = new Font("Courier New", 10, FontStyle.Bold);
            Font font3 = new Font("Courier New", 15, FontStyle.Bold);

            // Insert the desired text into the PDF file
            string productlist = "";
            string Head1 = "Sasmi Stores\n".PadLeft(18);
            string Head2 = "Samagama Ullinduwawa\n".PadLeft(27);
            string Head3 = "077-8636938 | 077-8521376\n".PadLeft(30);
            string line1 = "\n---------------------------------\n";
            string line2 = "---------------------------------\n";

            double TotalDiscount = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string pname = row["Product Name"].ToString();
                if (pname.Length > 8)
                    pname = pname.Substring(0, 8);

                string Price = row["Price"].ToString();
                Price = String.Format("{0:F2}", Convert.ToDouble(Price));
                string Qty = row["Qty"].ToString();
                string Discount = row["Discount"].ToString();
                TotalDiscount = TotalDiscount + Convert.ToDouble(Discount);
                string Amount = row["Amount"].ToString();
                //if (!Amount.Contains("."))
                //    Amount = Amount + ".0";
                Amount = String.Format("{0:F2}", Convert.ToDouble(Amount));

                productlist += pname.PadRight(10) + Price.PadLeft(6) + Qty.PadLeft(3) + Discount.PadLeft(5) + Amount.PadLeft(9) + "\n";
            }

            string line3 = "\n---------------------------------\n";
            string header = "Item".PadRight(10) + "Rate".PadLeft(5) + "Qty".PadLeft(5) + "Dis".PadLeft(5) + "Amount".PadLeft(8) + "\n";
            //string total = TotalAmountSaleTextBox.Text.Trim().ToString();
            string total = labelTotal.Text.Trim().ToString();
            string tot = String.Format("{0:F2}", Convert.ToDouble(total));
            total = "Total".PadLeft(23) + tot.PadLeft(10) + "\n";
            
            string line4 = "---------------------------------\n\n";

            //string CashText = TotalAmountSaleTextBox.Text.Trim().ToString();
            string CashText = labelTotal.Text.Trim().ToString();
            //if (!TotalAmountSaleTextBox.Text.Trim().ToString().Contains("."))
            //    CashText = CashText + ".0";
            string cas = String.Format("{0:F2}", Convert.ToDouble(CashText));
            string Cash= "Cash ".PadRight(10) + ":".PadLeft(6) + cas.PadLeft(10) + "\n";

            string td = String.Format("{0:F2}", Convert.ToDouble(TotalDiscount));
            string TotDis = "Total Discount ".PadRight(10) + ":".PadLeft(1) + td.PadLeft(10) + "\n";

            string CashTenderedText = CashTextBox.Text.Trim().ToString();
            //if (!CashTextBox.Text.Trim().ToString().Contains("."))
            //    CashTenderedText = CashTenderedText + ".0";
            if (CashTenderedText == "")
                CashTenderedText = "0";
            string casT = String.Format("{0:F2}", Convert.ToDouble(CashTenderedText));
            string CashTendered = "Cash Tendered ".PadRight(10) + ":".PadLeft(2) + casT.PadLeft(10) + "\n";

            string BalanceText = BalanceTextBox.Text.Trim();
            //if (!BalanceText.Contains("."))
            //    BalanceText = BalanceText + ".0";
            if (BalanceText == "")
                BalanceText = "0";
            string bal = String.Format("{0:F2}", Convert.ToDouble(BalanceText));
            string Balance = "Balance ".PadRight(10) + ":".PadLeft(6) + bal.ToString().PadLeft(10) + "\n\n";

            string ThankYouText = "Thank You\n".PadLeft(21);
            string VisitAgainText = "Visit Again".PadLeft(21);

            string headerData = "\n" + "\n" + "\n" + "\n\n" + header;
            string PrintDataSet = "\n" + Head2 + Head3 + line1 + "\n"+ line2 + productlist + line3 + total + line4 + TotDis + Cash + CashTendered + Balance + ThankYouText + VisitAgainText;

            e.Graphics.DrawString
              (Head1, font3, System.Drawing.Brushes.Black, 8, 15);
            e.Graphics.DrawString
              (headerData, font2, System.Drawing.Brushes.Black, 8, 20);
            e.Graphics.DrawString
              (PrintDataSet, font1, System.Drawing.Brushes.Black, 8, 20);
        }

        private string GetPrinterName(string key)
        {
            DataTable dataTable = new DataTable();
            dataTable = getPrintIndexFromConfig(key);
            string value = dataTable.Rows[0]["Value2"].ToString();
            return value;
        }

        private DataTable getPrintIndexFromConfig(string key)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetValueByKeyFromConfig", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@key", key);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void CashTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            double Balance = GetBalance();
            BalanceTextBox.Text = Balance.ToString();
        }

        private double GetBalance()
        {
            string TotalAmount = TotalAmountSaleTextBox.Text.Trim().ToString();
            if(TotalAmount == "")
            {
                TotalAmount = "0";
            }
            string Cash = CashTextBox.Text.Trim().ToString();
            if (Cash == "")
            {
                Cash = "0";
            }
            double Balance = Convert.ToDouble(Cash) - Convert.ToDouble(TotalAmount);

            return Balance;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuantitySalesTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddSaleData();
            }
            
        }

        private void QuantitySalesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CashTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
