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
    public partial class Loan : MetroFramework.Forms.MetroForm
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            GetAllLoans();
            LoadAllCustomer();
        }

        private void GetAllLoans()
        {
            DataTable dataTable = new DataTable();
            dataTable = GetAllLoansInTable();
            LoanGrid.DataSource = dataTable;
        }

        private DataTable GetAllLoansInTable()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllLoans", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void LoadAllCustomer()
        {
            List<CategoryList> categoryLists = new List<CategoryList>();
            categoryLists = GetFullCustomerNameAndId();
            CustomerLoanComboBox.Items.Clear();
            //CustomerComboBox.Items.Add("-Select-");
            CustomerLoanComboBox.DataSource = categoryLists;
            CustomerLoanComboBox.DisplayMember = "CustomerName";
            CustomerLoanComboBox.ValueMember = "CustomerID";
            CustomerLoanComboBox.SelectedIndex = 0;
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

        private void GetLoansByCustomer(int custmerID)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetLoanByCustomerID(custmerID);
            LoanGrid.DataSource = dataTable;
        }

        private DataTable GetLoanByCustomerID(int customerID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetLoanByCustomerID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", customerID);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void SelectedIndex_Change(object sender, EventArgs e)
        {
            //string custmerID = CustomerLoanComboBox.SelectedValue.ToString();
            //GetLoansByCustomer(Int32.Parse(custmerID));
        }

        private void LoanComboSelectedIValue_Change(object sender, EventArgs e)
        {
            if(CustomerLoanComboBox.SelectedIndex != 0)
            {
                string customerID = CustomerLoanComboBox.SelectedValue.ToString();
                GetLoansByCustomer(Int32.Parse(customerID));
                double TotalLoanForCustomer = GetTotalLoan(Int32.Parse(CustomerLoanComboBox.SelectedValue.ToString()));
                labelLotalLoan.Text = TotalLoanForCustomer.ToString();
                double availablePayment = GetTotalLoan(Int32.Parse(CustomerLoanComboBox.SelectedValue.ToString())) - GetPayment(Int32.Parse(customerID));
                if (availablePayment > 0)
                {
                    labelLotalLoan.Text = availablePayment.ToString();
                }
                else
                {
                    labelLotalLoan.Text = "0";
                }
            }
            
        }

        private double GetTotalLoan(int customerID)
        {
            string TotalLoan = "0";
            double TotalBetweenProfit = 0;
            DataTable dataTable = new DataTable();
            dataTable = GetLoanByCustomerID(customerID);

            foreach (DataRow row in dataTable.Rows)
            {
                TotalLoan = row["Amount"].ToString();
                TotalBetweenProfit += Convert.ToDouble(TotalLoan);
            }

            return TotalBetweenProfit;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void PayLoanButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure this Payment?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (CustomerLoanComboBox.SelectedIndex != 0 && PayLoanTextBox.Text != "")
                {
                    string customerID = CustomerLoanComboBox.SelectedValue.ToString();
                    string Payment = PayLoanTextBox.Text.Trim().ToString();
                    SaveLoanPayment(Int32.Parse(customerID), Convert.ToDouble(Payment));
                    double availablePayment = GetTotalLoan(Int32.Parse(CustomerLoanComboBox.SelectedValue.ToString())) - GetPayment(Int32.Parse(customerID));
                    if (availablePayment > 0)
                    {
                        labelLotalLoan.Text = availablePayment.ToString();
                    }
                    else
                    {
                        deleteLoan(Int32.Parse(customerID));
                    }
                    PayLoanTextBox.Text = "";
                    CustomerLoanComboBox.SelectedIndex = 0;
                    GetAllLoans();
                }
                else
                {
                    if (PayLoanTextBox.Text == "")
                    {
                        MessageBox.Show("Enter Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Select Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void deleteLoan(int customerID)
        {
            deleteLoanByCustomer(customerID);
            deletePaymentByCustomer(customerID);
        }

        private void deletePaymentByCustomer(int customerID)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("deletePaymentByCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", customerID);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void deleteLoanByCustomer(int customerID)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("deleteLoanByCustomer", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", customerID);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private double GetPayment(int customerID)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetAvailablePaymentBycustomerID(customerID);
            string payment = "";
            double tolalePaymnet = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                payment = row["Payment"].ToString();
                tolalePaymnet += Convert.ToDouble(payment);
            }

            return tolalePaymnet;
        }

        private DataTable GetAvailablePaymentBycustomerID(int customerID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAvailablePaymentBycustomerID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", customerID);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void SaveLoanPayment(int customerID, double Payment)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SaveLoanPayment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@Payment", Payment);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void ResetLoanButton_Click(object sender, EventArgs e)
        {
            GetAllLoans();
            CustomerLoanComboBox.SelectedIndex = 0;
            PayLoanTextBox.Text = "";
        }
    }
}
