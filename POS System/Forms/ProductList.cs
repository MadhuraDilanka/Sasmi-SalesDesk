using POS_System.Classes;
using POS_System.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class ProductList : MetroFramework.Forms.MetroForm
    {
        public ProductList()
        {
            InitializeComponent();
        }
        private void ProductList_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = LoadCategory();
            
            //List<CategoryList> CategoryListist = new List<CategoryList>();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    CategoryList category = new CategoryList();
            //    category.CategoryName = row["Category Name"].ToString();
            //    CategoryListist.Add(category);
            //}
            CategoryComboBox.DataSource = dataTable;
            CategoryComboBox.DisplayMember = "Category Name";
            CategoryComboBox.ValueMember = "CategoryID";
            GridViewBindData();
        }

        private void GridViewBindData()
        {
            ProductGrid.DataSource = GetAllProductForTableView();
        }

        private DataTable GetAllProducts()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllProduct", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private DataTable GetAllProductForTableView()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllProductForTableView", con))
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string ProductID = ProductIDTextBox.Text.Trim().ToString();
            
            string ProductName = ProductNameTextBox.Text.Trim();

            double ProductPrice = 0;
            if (ProductPriceTextBox.Text.Trim() != "")
            {
                ProductPrice = Convert.ToDouble(ProductPriceTextBox.Text.Trim().ToString());
            }

            double Quantity = 0;
            if (QuantityTextBox.Text.Trim().ToString() != "")
            {
                Quantity = Convert.ToDouble(QuantityTextBox.Text.Trim().ToString());
            }

            double SellingPrice = 0;
            if(SellingPriceTextBox.Text.Trim() != "")
            {
                SellingPrice = Convert.ToDouble(SellingPriceTextBox.Text.Trim());
            }

            double Discount = 0;
            if (DiscountTextBox.Text.Trim().ToString() != "")
            {
                Discount = Convert.ToDouble(DiscountTextBox.Text.Trim().ToString());
            }

            double NewSellingPrice = SellingPrice - Discount;
            double ItemProfit = NewSellingPrice - ProductPrice;
            double TotalPrice = 0;
            if (TotalPriceTextBox.Text.Trim().ToString() != "")
            {
                TotalPrice = Convert.ToDouble(TotalPriceTextBox.Text.Trim());
            }

            double TotalSellingPrice = Quantity * NewSellingPrice;

            double TotalProfit = TotalSellingPrice - TotalPrice;

            int CategoryID = Int32.Parse(((DataRowView)CategoryComboBox.Items[CategoryComboBox.SelectedIndex]).Row.ItemArray[0].ToString());

            string Category = CategoryComboBox.Text;

            string Description = DescriptionTextBox.Text.Trim();
            if(Description == "")
            {
                Description = "No Descriptions";
            }

            if (ProductID == "")
            {
                if(ProductNameTextBox.Text.Trim() != "" && ProductPriceTextBox.Text.Trim() != "" && QuantityTextBox.Text.Trim().ToString() != "" && SellingPriceTextBox.Text.Trim().ToString() !="")
                {
                    InsertAllProducts(ProductName, ProductPrice, Quantity, SellingPrice, Discount, NewSellingPrice, ItemProfit, TotalPrice, TotalSellingPrice, TotalProfit, CategoryID, Category, Description);
                    ClearTextBoxes();
                    GridViewBindData();
                    MessageBox.Show("Saved", "Successfully");
                }
                else
                {
                    MessageBox.Show("Please Enter Values", "Null Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.ForeColor = Color.Red;
                    QuantityTextBox.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                if (ProductNameTextBox.Text.Trim() != "" && ProductPriceTextBox.Text.Trim() != "" && QuantityTextBox.Text.Trim().ToString() != "")
                {
                    DialogResult dr = MessageBox.Show("Are you sure to Update Product?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        UpdateProducts(Int32.Parse(ProductID), ProductName, ProductPrice, Quantity, SellingPrice, Discount, NewSellingPrice, ItemProfit, TotalPrice, TotalSellingPrice, TotalProfit, CategoryID, Category, Description);
                        ClearTextBoxes();
                        GridViewBindData();
                        MessageBox.Show("Changed", "Successfully");
                    }
                    else if (dr == DialogResult.No)
                    {
                        //Nothing to do
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter Values", "Null Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void UpdateProducts(int ProductID, string ProductName, double ProductPrice, double Quantity, double SellingPrice, double Discount, double NewSellingPrice, double ItemProfit, double TotalPrice, double TotalSellingPrice, double TotalProfit, int CategoryID, string Category, string Description)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateProduct", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@SellingPrice", SellingPrice);
                    cmd.Parameters.AddWithValue("@Discount", Discount);
                    cmd.Parameters.AddWithValue("@NewSellingPrice", NewSellingPrice);
                    cmd.Parameters.AddWithValue("@ItemProfit", ItemProfit);
                    cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                    cmd.Parameters.AddWithValue("@TotalSellingPrice", TotalSellingPrice);
                    cmd.Parameters.AddWithValue("@TotalProfit", TotalProfit);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    cmd.Parameters.AddWithValue("@Category", Category);
                    cmd.Parameters.AddWithValue("@Description", Description);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void InsertAllProducts(string ProductName, double ProductPrice, double Quantity, double SellingPrice, double Discount, double NewSellingPrice, double ItemProfit, double TotalPrice, double TotalSellingPrice, double TotalProfit, int CategoryID, string Category, string Description)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertProduct", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@SellingPrice", SellingPrice);
                    cmd.Parameters.AddWithValue("@Discount", Discount);
                    cmd.Parameters.AddWithValue("@NewSellingPrice", NewSellingPrice);
                    cmd.Parameters.AddWithValue("@ItemProfit", ItemProfit);
                    cmd.Parameters.AddWithValue("@TotalPrice", TotalPrice);
                    cmd.Parameters.AddWithValue("@TotalSellingPrice", TotalSellingPrice);
                    cmd.Parameters.AddWithValue("@TotalProfit", TotalProfit);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                    cmd.Parameters.AddWithValue("@Category", Category);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@AvailableQty", Quantity);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void QuantityTextBox_Click(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void ProductPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void QuantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (QuantityTextBox.Text.Trim().ToString() != "" && ProductPriceTextBox.Text.Trim() != "")
            {
                double ProductPrice = Convert.ToDouble(ProductPriceTextBox.Text.Trim());
                double Quantity = Convert.ToDouble(QuantityTextBox.Text.Trim().ToString());
                double TotalPrice = ProductPrice * Quantity;
                TotalPriceTextBox.Text = TotalPrice.ToString();
            }
        }

        private void ProductGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ProductIDTextBox.Text = ProductGrid.SelectedRows[0].Cells[0].Value.ToString();
            //ProductNameTextBox.Text = ProductGrid.SelectedRows[0].Cells[1].Value.ToString();
            //ProductPriceTextBox.Text = ProductGrid.SelectedRows[0].Cells[2].Value.ToString();
            //QuantityTextBox.Text = ProductGrid.SelectedRows[0].Cells[3].Value.ToString();
            //TotalPriceTextBox.Text = ProductGrid.SelectedRows[0].Cells[4].Value.ToString();
            //DescriptionTextBox.Text = ProductGrid.SelectedRows[0].Cells[5].Value.ToString();
            //CategoryComboBox.Text = ProductGrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete Product?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DataGridViewRow row = ProductGrid.Rows[ProductGrid.CurrentCell.RowIndex];
                int ProductID = Int32.Parse(row.Cells[0].Value.ToString());
                DeleteProduct(ProductID);
                GridViewBindData();
                ClearTextBoxes();
                MessageBox.Show("Deleted", "Successfully");
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void DeleteProduct(int ProductID)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteProduct", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", ProductID);

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

        private void ProductGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIDTextBox.Text = ProductGrid.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTextBox.Text = ProductGrid.SelectedRows[0].Cells[1].Value.ToString();
            ProductPriceTextBox.Text = ProductGrid.SelectedRows[0].Cells[2].Value.ToString();
            QuantityTextBox.Text = ProductGrid.SelectedRows[0].Cells[3].Value.ToString();
            SellingPriceTextBox.Text = ProductGrid.SelectedRows[0].Cells[6].Value.ToString();
            DiscountTextBox.Text = ProductGrid.SelectedRows[0].Cells[7].Value.ToString();
            TotalPriceTextBox.Text = ProductGrid.SelectedRows[0].Cells[5].Value.ToString();
            DescriptionTextBox.Text = ProductGrid.SelectedRows[0].Cells[10].Value.ToString();
            CategoryComboBox.Text = ProductGrid.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            ProductIDTextBox.Text = "";
            ProductNameTextBox.Text = "";
            ProductPriceTextBox.Text = "";
            QuantityTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CategoryComboBox.SelectedIndex = 0;
            DiscountTextBox.Text = "0";
            SellingPriceTextBox.Text = "";
        }

        private void ProductPriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (QuantityTextBox.Text.Trim().ToString() != "" && ProductPriceTextBox.Text.Trim() != "")
            {
                double ProductPrice = Convert.ToDouble(ProductPriceTextBox.Text.Trim());
                double Quantity = Convert.ToDouble(QuantityTextBox.Text.Trim().ToString());
                double TotalPrice = ProductPrice * Quantity;
                TotalPriceTextBox.Text = TotalPrice.ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
