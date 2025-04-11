using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.Forms;


namespace POS_System.Forms
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void InventoryManagementButton_Click(object sender, EventArgs e)
        {
            ProductList productList = new ProductList();
            productList.Show();
            this.Hide();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void ExitApplicationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }

        private void SalesInformationButton_Click(object sender, EventArgs e)
        {
            Sales_Information sales_Information = new Sales_Information();
            sales_Information.Show();
            this.Hide();
        }

        private void SystemSettingsButton_Click(object sender, EventArgs e)
        {
            System_Settings system_Settings = new System_Settings();
            system_Settings.Show();
            this.Hide();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.Show();
            this.Hide();
        }
    }
}
