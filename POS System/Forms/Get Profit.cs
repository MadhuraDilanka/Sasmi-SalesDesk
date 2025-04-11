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
    public partial class Get_Profit : MetroFramework.Forms.MetroForm
    {
        public Get_Profit()
        {
            InitializeComponent();
        }

        private void ProfitBetweenSearchButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetDateBetweenSaleData();
            ProfitBetweetnGrid.DataSource = dataTable;
            labelBetweenProfit.Text = GetTotalBetweenProfit().ToString();
        }

        private double GetTotalBetweenProfit()
        {
            string profit = "0";
            double TotalBetweenProfit = 0;
            DataTable dataTable = new DataTable();
            dataTable = GetDateBetweenSaleData();

            foreach (DataRow row in dataTable.Rows)
            {
                profit = row["Profit"].ToString();
                TotalBetweenProfit += Convert.ToDouble(profit);
            }

            return TotalBetweenProfit;
        }

        private DataTable GetDateBetweenSaleData()
        {
            DataTable dataTable = new DataTable();

            string from = FromDateTime.Value.ToString("yyyy-MM-dd");
            string to = ToDateTime.Value.ToString("yyyy-MM-dd");
            dataTable = GetSalesByDateBetween(from, to);
            
            return dataTable;

        }

        private DataTable GetSalesByDateBetween(string from, string to)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetSalesByDateBetween", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@from", from);
                    cmd.Parameters.AddWithValue("@to", to);

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrintSelectedButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelGetProfitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
