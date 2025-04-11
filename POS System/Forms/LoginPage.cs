using POS_System.Forms;
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

namespace POS_System
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginPageExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (IsValied())
            {
                using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("loginVerificationDetails", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", UserNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text.Trim());

                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            this.Hide();
                            Dashboard db = new Dashboard();
                            db.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalied Username or password", "Form invalied message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool IsValied()
        {
            if(UserNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Insert User Name", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Insert Password", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void UserNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
