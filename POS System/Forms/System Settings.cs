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
    public partial class System_Settings : MetroFramework.Forms.MetroForm
    {
        public System_Settings()
        {
            InitializeComponent();
        }

        private void System_Settings_Load(object sender, EventArgs e)
        {

            PrintDocument prtdoc = new PrintDocument();
            //string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
            string strDefaultPrinter = PrintIndex("PrinterIndex");
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                PrinterComboBox.Items.Add(strPrinter);
                //if (strPrinter == strDefaultPrinter)
                //{
                //    PrinterComboBox.SelectedIndex = PrinterComboBox.Items.IndexOf(strPrinter);
                //}
            }
            PrinterComboBox.SelectedIndex = Convert.ToInt32(strDefaultPrinter);
            string printer = PrinterComboBox.SelectedItem.ToString();
        }

        private string PrintIndex(string key)
        {
            DataTable dataTable = new DataTable();
            dataTable = getPrintIndexFromConfig(key);
            string value = dataTable.Rows[0]["Value"].ToString();
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

        public string SetValue()
        {
            string printer = PrinterComboBox.SelectedItem.ToString();
            return printer;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = MessageBox.Show("Are you sure Change Settings?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                if (OldUserTextBox.Text.Trim().ToString() != "" || NewUserTextBox.Text.Trim().ToString() != "" || PwdTextBox.Text.Trim().ToString() != "")
                {
                    if (OldUserTextBox.Text.Trim().ToString() != "")
                    {
                        if (NewUserTextBox.Text.Trim().ToString() != "")
                        {
                            if (PwdTextBox.Text.Trim().ToString() != "")
                            {
                                if (CheckOldUserName())
                                {
                                    if (CheckOldPassword(PwdTextBox.Text.Trim().ToString()))
                                    {
                                        SaveUserName(OldUserTextBox.Text.Trim().ToString(), NewUserTextBox.Text.Trim().ToString());
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalied Password", "Worning", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalied Username", "Worning", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password is empty", "Worning", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("New Username is empty", "Worning", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old Username is empty", "Worning", MessageBoxButtons.OK);
                    }


                }

                if (OldPwdTextBox.Text.Trim().ToString() != "" || NewPwdTextBox.Text.Trim().ToString() != "" || ReEnterPwdTextBox.Text.Trim().ToString() != "")
                {
                    if (OldPwdTextBox.Text.Trim().ToString() != "")
                    {
                        if (NewPwdTextBox.Text.Trim().ToString() != "")
                        {
                            if (ReEnterPwdTextBox.Text.Trim().ToString() != "")
                            {
                                if (CheckOldPassword(OldPwdTextBox.Text.Trim().ToString()))
                                {
                                    if (NewPwdTextBox.Text.Trim().ToString() == ReEnterPwdTextBox.Text.Trim().ToString())
                                    {
                                        SavePassword(OldPwdTextBox.Text.Trim().ToString(), NewPwdTextBox.Text.Trim().ToString());
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password is do not match", "Worning", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalied Password", "Worning", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("ReEnter New Password is empty", "Worning", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("New Password is empty", "Worning", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Old Password is empty", "Worning", MessageBoxButtons.OK);
                    }


                }

                int selectPrintIndex = PrinterComboBox.SelectedIndex;
                string printerName = PrinterComboBox.SelectedItem.ToString();
                string key = "PrinterIndex";
                UpdateConfig(key, selectPrintIndex.ToString(), printerName);
                ClearTextBoxes();
            }
            else if (dr == DialogResult.No)
            {
                //Nothing to do
            }
            
        }

        private void ClearTextBoxes()
        {
            OldUserTextBox.Text = "";
            NewUserTextBox.Text = "";
            PwdTextBox.Text = "";
            OldPwdTextBox.Text = "";
            NewPwdTextBox.Text = "";
            ReEnterPwdTextBox.Text = "";
        }

        private void SavePassword(string OldPassword, string NewPassword)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SavePassword", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@oldPassword", OldPassword);
                    cmd.Parameters.AddWithValue("@newPassword", NewPassword);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();
                }
            }
        }

        private void SaveUserName(string OlduserName, string NewuserName)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("SaveUserName", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@olduserName", OlduserName);
                    cmd.Parameters.AddWithValue("@newuserName", NewuserName);

                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();
                }
            }
        }

        private bool CheckOldPassword(string pwd)
        {
            DataTable dataTable = new DataTable();
            dataTable = GetUserNameAndPassword();
            string oldpwd = dataTable.Rows[0].ItemArray[1].ToString();
            string UserEnterOldPwd = pwd;
            if(UserEnterOldPwd == oldpwd)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool CheckOldUserName()
        {
            DataTable dataTable = new DataTable();
            dataTable = GetUserNameAndPassword();
            string oldUN = dataTable.Rows[0].ItemArray[0].ToString();
            string UserEnterOldUN = OldUserTextBox.Text.Trim().ToString();
            if (UserEnterOldUN == oldUN)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private DataTable GetUserNameAndPassword()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("GetUserNameAndPassword", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                }
            }
            return dataTable;
        }

        private void UpdateConfig(string key, string value1, string value2)
        {
            using (SqlConnection con = new SqlConnection(ApplicationSettings.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateConfigTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.Parameters.AddWithValue("@value1", value1.ToString());
                    cmd.Parameters.AddWithValue("@value2", value2.ToString());
                    con.Open();
                    var sdr = cmd.ExecuteScalar();
                    con.Close();
                }
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
