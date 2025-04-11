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
    public partial class Customers : MetroFramework.Forms.MetroForm
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
            GridViewBindData();
        }

        private void CustomerSaveButton_Click(object sender, EventArgs e)
        {
            string CustomerID = CustomerIDTextBox.Text.Trim().ToString();
            string CustomerName = CustomerNameTextBox.Text.Trim().ToString();
            string CustomerAddress = CustomerAddressTextBox.Text.Trim().ToString();
            string CustomerMail = CustomerMailTextBox.Text.Trim().ToString();
            string CustomerPhone = CustomerPhoneTextBox.Text.Trim().ToString();
            string CustomerNIC = CustomerNICTextBox.Text.Trim().ToString();

            if (CustomerID == "")
            {
                if(CustomerName != "")
                {
                    AddCustomers(CustomerName, CustomerAddress, CustomerMail, CustomerPhone, CustomerNIC);
                    ClearTextBoxes();
                    GridViewBindData();
                    MessageBox.Show("Saved", "Successfully");
                }
                else
                {
                    MessageBox.Show("Please Enter Customer Name", "Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CustomerName != "")
                {
                    UpdateCustomers(Int32.Parse(CustomerID), CustomerName, CustomerAddress, CustomerMail, CustomerPhone, CustomerNIC);
                    ClearTextBoxes();
                    GridViewBindData();
                    MessageBox.Show("Changed", "Successfully");
                }
                else
                {
                    MessageBox.Show("Please Enter Customer Name", "Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void GridViewBindData()
        {
            CustomerGrid.DataSource = GetAllCustomers();
        }

        private DataTable GetAllCustomers()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void AddCustomers(string CustomerName, string CustomerAddress, string CustomerMail, string CustomerPhone, string CustomerNIC)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("AddCustomers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                    cmd.Parameters.AddWithValue("@CustomerMail", CustomerMail);
                    cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhone);
                    cmd.Parameters.AddWithValue("@CustomerNIC", CustomerNIC);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void UpdateCustomers(int CustomerID, string CustomerName, string CustomerAddress, string CustomerMail, string CustomerPhone, string CustomerNIC)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateCustomers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                    cmd.Parameters.AddWithValue("@CustomerMail", CustomerMail);
                    cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhone);
                    cmd.Parameters.AddWithValue("@CustomerNIC", CustomerNIC);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void CustomerAddNewButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            CustomerIDTextBox.Text = "";
            CustomerNameTextBox.Text = "";
            CustomerAddressTextBox.Text = "";
            CustomerMailTextBox.Text = "";
            CustomerPhoneTextBox.Text = "";
            CustomerNICTextBox.Text = "";
        }

        private void CustomerDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete Customer?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DataGridViewRow row = CustomerGrid.Rows[CustomerGrid.CurrentCell.RowIndex];
                int CustomerID = Int32.Parse(row.Cells[0].Value.ToString());
                DeleteCustomer(CustomerID);
                GridViewBindData();
                ClearTextBoxes();
                MessageBox.Show("Deleted", "Successfully");
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void DeleteCustomer(int CustomerID)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", CustomerID);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIDTextBox.Text = CustomerGrid.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTextBox.Text = CustomerGrid.SelectedRows[0].Cells[1].Value.ToString();
            CustomerAddressTextBox.Text = CustomerGrid.SelectedRows[0].Cells[2].Value.ToString();
            CustomerMailTextBox.Text = CustomerGrid.SelectedRows[0].Cells[3].Value.ToString();
            CustomerPhoneTextBox.Text = CustomerGrid.SelectedRows[0].Cells[4].Value.ToString();
            CustomerNICTextBox.Text = CustomerGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
