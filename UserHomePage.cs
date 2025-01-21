using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Banking_management_system
{
    public partial class UserHomePage : Form
    {

        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BankingAppData;Integrated Security=True;Trust Server Certificate=True";
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //User Logout Button 
        {

            this.Hide();
            Userlogin userlogin = new Userlogin();
            userlogin.Closed += (s, args) => this.Close();
            userlogin.Show();   //back to user login page
        }

        private void userTransactionButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            var userTransac = new UserTransacHistory();
            userTransac.Closed += (s, args) => this.Close();
            userTransac.AccNum = AccountNumTextBox.Text;
            userTransac.Show();
        }

        private void viewUserDetailsButton_Click(object sender, EventArgs e)
        {

            string accountNum = AccountNumTextBox.Text;  // To Access User input field

            if (AccountNumTextBox.Text != "")
            {
                //Select query to view contents of userdata
                string query = "SELECT AccountNo,Name, EmailID, Password, AccountBalance,AccountType FROM UserData WHERE AccountNo=@AccountNo";

                //using ADO.Net to connect to DB
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@AccountNo", accountNum);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                DataTable dt = new DataTable();
                                dt.Load(reader);

                                userNametTextBox.Text = dt.Rows[0]["Name"].ToString();

                                UserDataGridView1.DataSource = dt;

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Oops! Invalid A/C No. : {ex.Message}");
                    }


                }
            }
            else
            {
                MessageBox.Show("Please enter your A/C No.");
            }

        }

        private void updateTransaction(int userId, string transactionType)
        {

                int uid = userId;
                string transacType = transactionType;
                int accountNum = 0;
                int amount = 0;

                Int32.TryParse(AmountTextBox.Text, out amount);



                 if (transacType == "Transfer" || transacType == "Credited")
                 {
                     Int32.TryParse(RecipientAccNumTextBox.Text, out accountNum);
                  
                 }
                 else
                 {
                     Int32.TryParse(AccountNumTextBox.Text, out accountNum);
                
                 }


               
                DateTime transacDate = DateTime.Now;

                // insert data to UserTransactions table
                string query = "INSERT INTO UserTransactions (UserId,Amount,TransactionDate,TransactionType,BeneficiaryAcctNo) VALUES (@UserId,@Amount,@TransactionDate,@TransactionType,@BeneficiaryAcctNo)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@UserId", uid);
                            command.Parameters.AddWithValue("@Amount", amount);
                            command.Parameters.AddWithValue("@TransactionDate", transacDate);
                            command.Parameters.AddWithValue("@TransactionType", transacType);
                            command.Parameters.AddWithValue("@BeneficiaryAcctNo", accountNum);


                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {

                                // MessageBox.Show("Transaction updated successfully!");

                            }
                            else
                            {
                                MessageBox.Show("Transaction updation failed!");
                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An Error occured! : {ex.Message}");
                    }

                }
            
          

        }


        // Deposit money into user's own account
        private void depositButton_Click(object sender, EventArgs e)
        {

            int amount = 0;
            if (Int32.TryParse(AmountTextBox.Text, out amount) && amount > 0 && AccountNumTextBox.Text != "")
            {
                string transacType = "Deposit";
                string accountNum = AccountNumTextBox.Text;

                int userId = 0;
                int accountBal = 0;


                string selectQuery = "SELECT UserId, AccountBalance FROM UserData WHERE AccountNo = @AccountNo";

                string updateQuery = "UPDATE UserData SET AccountBalance = @AccountBalance WHERE UserId = @UserId";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {

                            command.Parameters.AddWithValue("@AccountNo", accountNum);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {


                                while (reader.Read())
                                {
                                    userId = (int)reader["UserId"];
                                    accountBal = (int)reader["AccountBalance"];

                                }


                            }

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error occured : {ex.Message}");
                    }




                    accountBal += amount;

                    try
                    {

                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.Parameters.AddWithValue("@AccountBalance", accountBal);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Amount deposited successfully!");
                                updateTransaction(userId, transacType);

                            }
                            else
                            {
                                MessageBox.Show("Failed! Please try again.");
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
                MessageBox.Show("Please enter your A/C No. and Deposit amount.");
            }

        }

        // Withdraw money from user's own account
        private void withdrawButton_Click(object sender, EventArgs e)
        {


            int amount = 0;

            if (Int32.TryParse(AmountTextBox.Text, out amount) && amount > 0 && AccountNumTextBox.Text != "")
            {
                string transacType = "Withdraw";
                string accountNum = AccountNumTextBox.Text;

                int userId = 0;
                int accountBal = 0;

                string selectQuery = "SELECT UserId, AccountBalance FROM UserData WHERE AccountNo = @AccountNo";

                string updateQuery = "UPDATE UserData SET AccountBalance = @AccountBalance WHERE UserId = @UserId";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {

                            command.Parameters.AddWithValue("@AccountNo", accountNum);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {


                                while (reader.Read())
                                {
                                    userId = (int)reader["UserId"];
                                    accountBal = (int)reader["AccountBalance"];

                                }


                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error occured : {ex.Message}");
                    }

                    if (accountBal > amount)
                    {
                        accountBal -= amount;


                        try
                        {

                            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@UserId", userId);
                                cmd.Parameters.AddWithValue("@AccountBalance", accountBal);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Amount withdraw successfully!");
                                    updateTransaction(userId, transacType);

                                }
                                else
                                {
                                    MessageBox.Show("Failed! Please try again.");
                                }
                            }

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show($"An Error occured : {ex.Message}");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient A/C balance");
                    }

                }

            }
            else
            {
                MessageBox.Show("Please enter your A/C No. and Withdraw amount.");
            }
        }

        // Transfer money from one user(1) account to another user(2) account
        private void transferButton_Click(object sender, EventArgs e)
        {


            int amount = 0;
            if (Int32.TryParse(AmountTextBox.Text, out amount) && amount > 0 && AccountNumTextBox.Text != "" && RecipientAccNumTextBox.Text != "")
            {
                string transacType1 = "Transfer";
                string transacType2 = "Credited";
                string user1_accountNum = AccountNumTextBox.Text;
                string user2_accountNum = RecipientAccNumTextBox.Text;

                int user1_Id = 0;
                int user1_accountBal = 0;

                int user2_Id = 0;
                int user2_accountBal = 0;

                string selectQuery = "SELECT UserId, AccountBalance FROM UserData WHERE AccountNo = @AccountNo";

                string updateQuery = "UPDATE UserData SET AccountBalance = @AccountBalance WHERE UserId = @UserId";


                //user 1
                // fetching user 1 data and updating balance (debited) / money transfer

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {

                            command.Parameters.AddWithValue("@AccountNo", user1_accountNum);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {


                                while (reader.Read())
                                {
                                    user1_Id = (int)reader["UserId"];
                                    user1_accountBal = (int)reader["AccountBalance"];

                                }


                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error occured : {ex.Message}");
                    }

                    if (user1_accountBal > amount)
                    {
                        user1_accountBal -= amount;


                        try
                        {

                            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@UserId", user1_Id);
                                cmd.Parameters.AddWithValue("@AccountBalance", user1_accountBal);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Amount transfered successfully!");
                                    updateTransaction(user1_Id, transacType1);

                                }
                                else
                                {
                                    MessageBox.Show("Failed! Please try again.");
                                }
                            }

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show($"An Error occured : {ex.Message}");

                        }


                        //user2  
                        // fetching user 2 data and updating balance (credited)


                        try
                        {

                            using (SqlCommand command = new SqlCommand(selectQuery, connection))
                            {

                                command.Parameters.AddWithValue("@AccountNo", user2_accountNum);
                                using (SqlDataReader reader = command.ExecuteReader())
                                {


                                    while (reader.Read())
                                    {
                                        user2_Id = (int)reader["UserId"];
                                        user2_accountBal = (int)reader["AccountBalance"];

                                    }


                                }

                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An Error occured : {ex.Message}");
                        }

                        user2_accountBal += amount;



                        try
                        {

                            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@UserId", user2_Id);
                                cmd.Parameters.AddWithValue("@AccountBalance", user2_accountBal);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {

                                    updateTransaction(user2_Id, transacType2);

                                }
                                else
                                {
                                    MessageBox.Show("Failed! Please try again.");
                                }
                            }


                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show($"An Error occured : {ex.Message}");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient A/C balance.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter A/C No's and amount to be transferred.");
            }

        }


        //To update user's personal details 
        // Email & Password
        private void emailUpdateButton_Click(object sender, EventArgs e) //email updation by user
        {

            if (emailTextBox.Text != "" && AccountNumTextBox.Text != "")
            {
                string email = emailTextBox.Text;
                string accountNum = AccountNumTextBox.Text;


                string query = "UPDATE UserData SET EmailID = @EmailID WHERE AccountNo = @AccountNo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@AccountNo", accountNum);
                            cmd.Parameters.AddWithValue("@EmailID", email);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Email updated successfully!");


                            }
                            else
                            {
                                MessageBox.Show("Updation failed! Please try again.");
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
                MessageBox.Show("Please enter your A/C No and New Email ID.");
            }

        }

        private void pwUpdateButton_Click(object sender, EventArgs e) //password updation by user
        {


            if (pwTextBox.Text != "" && AccountNumTextBox.Text != "")
            {
                string pw = pwTextBox.Text;
                string accountNum = AccountNumTextBox.Text;


                string query = "UPDATE UserData SET Password = @Password WHERE AccountNo = @AccountNo";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@AccountNo", accountNum);
                            cmd.Parameters.AddWithValue("@Password", pw);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully!");


                            }
                            else
                            {
                                MessageBox.Show("Updation failed! Please try again.");
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
                MessageBox.Show("Please enter your A/C No and New Password.");
            }
        }
    }
}
