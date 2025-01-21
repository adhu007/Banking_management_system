using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace Banking_management_system
{
    public partial class UserTransacHistory : Form
    {

        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BankingAppData;Integrated Security=True;Trust Server Certificate=True";

        public UserTransacHistory()
        {
            InitializeComponent();
            
        }

        private string AccountNo = string.Empty;
        public string AccNum  //property used to get a value(Acct No.) from user homepage and assign to AccountNo.
        {
            get { return AccountNo; }
            set { AccountNo = value; }
        }

        private void button1_Click(object sender, EventArgs e)  //Back to user home page button
        {

            this.Hide();
            var userHome = new UserHomePage();
            userHome.Closed += (s, args) => this.Close();
            userHome.Show();
        }



        private void viewUserTransaction() //Display transaction history of user , based on user A/C No. and User Id
        {

            if (AccountNo != string.Empty)
            {
                string query1 = "SELECT UserId FROM UserData WHERE AccountNo = @AccountNo";
                string query2 = "SELECT Amount, TransactionDate, TransactionType, BeneficiaryAcctNo FROM UserTransactions WHERE UserId = @UserId";
                int uid = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query1, connection))
                        {
                            cmd.Parameters.AddWithValue("@AccountNo", AccountNo);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                //Fetch user id from user DB

                                while (reader.Read())
                                {
                                    uid = (int)reader["UserId"];

                                }


                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An Error occured : {ex.Message}");
                    }

                    try
                    {

                        //using user id to fetch user transaction data

                        using (SqlCommand cmd = new SqlCommand(query2, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserId", uid);


                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {

                                DataTable dt = new DataTable();
                                dt.Load(reader);

                                // transaction history of user listed in Datagridview

                                userDataGridView2.DataSource = dt;

                            }


                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An Error occured : {ex.Message}");
                    }



                }
            }
            else
            {
                MessageBox.Show("Please enter your A/C No.");
            }

        }

        private void UserTransacHistory_Load(object sender, EventArgs e)
        {

            viewUserTransaction();

        }
    }
}
