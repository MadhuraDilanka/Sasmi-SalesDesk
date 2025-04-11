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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace POS_System.Forms
{
    public partial class Category : MetroFramework.Forms.MetroForm
    {
        public Category()
        {
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
            BindDataDridView();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            Addcategory();
        }

        private void Addcategory()
        {
            if (CategoryNameTextBox.Text.Trim() != "")
            {
                if (CategoryIDTextBox.Text.Trim() == "")
                {
                    InsertCategory();
                }
                else
                {
                    UpdateCategory(Int32.Parse(CategoryIDTextBox.Text.Trim().ToString()), CategoryNameTextBox.Text.Trim());
                }

            }
            else
            {
                MessageBox.Show("Please Enter Values", "Null Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindDataDridView();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            CategoryIDTextBox.Text = "";
            CategoryNameTextBox.Text = "";
        }

        private void InsertCategory()
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("InsertCategory", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@categoryName", CategoryNameTextBox.Text.Trim());

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void BindDataDridView()
        {
            CategoryGridView.DataSource = GetCategories();
        }

        private DataTable GetCategories()
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

        private void EditCategoryButton_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = CategoryGridView.Rows[CategoryGridView.CurrentCell.RowIndex];
            //int catId = Int32.Parse(row.Cells[0].Value.ToString());
            //string categoryName = row.Cells[1].Value.ToString();
            //UpdateCategory(catId, categoryName);
            BindDataDridView();
            ClearTextBoxes();
        }

        private void UpdateCategory(int catId, string categoryName)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateCategories", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryID", catId);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = MessageBox.Show("Are you sure to delete Category?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DataGridViewRow row = CategoryGridView.Rows[CategoryGridView.CurrentCell.RowIndex];
                int catId = Int32.Parse(row.Cells[0].Value.ToString());
                DeleteCatecory(catId);
                ClearTextBoxes();
                BindDataDridView();
                MessageBox.Show("Deleted", "Successfully");
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
        }

        private void DeleteCatecory(int catId)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteInsertCategory", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryID", catId);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();

                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryIDTextBox.Text = CategoryGridView.SelectedRows[0].Cells[0].Value.ToString();
            CategoryNameTextBox.Text = CategoryGridView.SelectedRows[0].Cells[1].Value.ToString();
        }


        private void CategoryNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Addcategory();
            }
        }
    }
}
