using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banking_management_system
{
    public partial class AdminHomePage : Form
    {

        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BankingAppData;Integrated Security=True;Trust Server Certificate=True";
        public AdminHomePage()
        {
            InitializeComponent();
            FetchData();
        }

        private void adminLogoutButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            var adminlogin = new Adminlogin();
            adminlogin.Closed += (s, args) => this.Close();
            adminlogin.Show();
        }

        private void viewTransactionsButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            var adminTransactions = new AdminTransactions();
            adminTransactions.Closed += (s, args) => this.Close();
            adminTransactions.Show();
        }


        // User Bank account creation

        private void createAccountButton_Click(object sender, EventArgs e)
        {

            int deposit = 0;
            if (nameTextBox.Text != "" && emailTextBox.Text != "" && Int32.TryParse(depositTextBox.Text, out deposit) && deposit > 0 && accTypeTextBox.Text != "" && pwTextBox.Text != "")
            {

                // Required input fields
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;
                string accountType = accTypeTextBox.Text;
                string password = pwTextBox.Text;


                Random random = new Random();
                int AccountNo = random.Next(1, 10001); // Generate a Random number and assign to a user as their AccountNo. The Number maynot be unique while using this code. //Need to work on this later

                // Insert user data into DB
                string query = "INSERT INTO UserData (AccountNo,Name, EmailID, Password, AccountBalance,AccountType) VALUES (@AccountNo,@Name, @EmailID, @Password, @AccountBalance, @AccountType)";

                // Using ADO.Net (for DB connectivity) and SQL server backend (SQL scripts,DB Schema (3 Tables))
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@AccountNo", AccountNo);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@EmailID", email);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@AccountBalance", deposit);
                            command.Parameters.AddWithValue("@AccountType", accountType);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account created successfully!");
                                FetchData();

                            }
                            else
                            {
                                MessageBox.Show("Account creation failed! Please try again.");
                            }

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An Error occured! : {ex.Message}");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please fill all fields for A/C creation");
            }


        }

        // Fetch data of all users
        private void FetchData()
        {


            string query = "SELECT UserId,AccountNo,Name, EmailID, Password, AccountBalance,AccountType FROM UserData";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // fetch all user data from DB and lists in Datagridview like a table

                            adminUserDataView.DataSource = dt;

                            // Here we comboBox to display user names
                            // Account deletion and personal detail updation of user depend on its selected member value : user id
                            AdminComboBox1.ValueMember = "UserId";
                           
                            AdminComboBox1.DisplayMember = "Name";

                            AdminComboBox1.DataSource = dt;


                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An Error occured : {e.Message}");
                }


            }

        }

        // To update name of user
        private void nameUpdateButton_Click(object sender, EventArgs e)
        {


            int Id = 0;
            if (Int32.TryParse(AdminComboBox1.SelectedValue.ToString(), out Id) && nameTextBox.Text != "")
            {
                string name = nameTextBox.Text;


                string query = "UPDATE UserData SET Name = @Name WHERE UserId = @UserId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserId", Id);
                            cmd.Parameters.AddWithValue("@Name", name);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Name updated successfully!");
                                FetchData();

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
                MessageBox.Show("Please enter new Name.");
            }


        }

        // To update Email Id of user
        private void emailUpdateButton_Click(object sender, EventArgs e)
        {
            int Id = 0;

            if (Int32.TryParse(AdminComboBox1.SelectedValue.ToString(), out Id) && emailTextBox.Text != "")
            {
                string email = emailTextBox.Text;

                string query = "UPDATE UserData SET EmailID = @EmailID WHERE UserId = @UserId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserId", Id);
                            cmd.Parameters.AddWithValue("@EmailID", email);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Email updated successfully!");
                                FetchData();

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
                MessageBox.Show("Please enter new Email Id.");
            }

        }

        // Password updation of user
        private void passwordUpdateButton_Click(object sender, EventArgs e)
        {
            
            int Id = 0;

            if (Int32.TryParse(AdminComboBox1.SelectedValue.ToString(), out Id) && pwTextBox.Text != "")
            {
                string pw = pwTextBox.Text;


                string query = "UPDATE UserData SET Password = @Password WHERE UserId = @UserId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserId", Id);
                            cmd.Parameters.AddWithValue("@Password", pw);


                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully!");
                                FetchData();



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
                MessageBox.Show("Please enter new password.");
            }

        }

        // To Delete User bank account 
        private void accountDeleteButton_Click(object sender, EventArgs e)
        {
           

            int Id = 0;

            if (Int32.TryParse(AdminComboBox1.SelectedValue.ToString(), out Id))

            {
                string query = "DELETE FROM UserData WHERE UserId = @UserId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {

                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@UserId", Id);



                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account deleted successfully!");
                                FetchData();

                            }
                            else
                            {
                                MessageBox.Show("Del operation failed! Please try again.");
                            }


                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An Error occured : {ex.Message}");

                    }


                }
            }
        }
    }
}
