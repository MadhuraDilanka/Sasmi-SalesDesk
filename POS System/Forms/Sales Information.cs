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
    public partial class Sales_Information : MetroFramework.Forms.MetroForm
    {
        public Sales_Information()
        {
            InitializeComponent();
        }

        private void Sales_Information_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetSalesInformation();
            SalesInfoGrid.DataSource = dataTable;
        }

        private DataTable GetSalesInformation()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllSalesTable", con))
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
            DataTable dataTable = new DataTable();
            string Saledate = SalesDateTime.Value.ToString("dd/MM/yyyy");
            dataTable = GetSalesInforForDate(Saledate);
            SalesInfoGrid.DataSource = dataTable;
        }

        private DataTable GetSalesInforForDate(string saledate)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetSalesInforForDate", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SalesDate", saledate);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetSalesInformation();
            SalesInfoGrid.DataSource = dataTable;
            DateTime dateTime = DateTime.Now;
            SalesDateTime.Value = dateTime;
        }

        private void PrintSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void GetProfitButton_Click(object sender, EventArgs e)
        {
            Get_Profit get_Profit = new Get_Profit();
            get_Profit.Show();
        }
    }
}
