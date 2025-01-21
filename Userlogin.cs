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
using Microsoft.IdentityModel.Tokens;

namespace Banking_management_system
{
    public partial class Userlogin : Form
    {

        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BankingAppData;Integrated Security=True;Trust Server Certificate=True";
        public Userlogin()
        {
            InitializeComponent();
        }


        // Back to welcome form
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            var firstform = new WelcomeForm();
            firstform.Closed += (s, args) => this.Close();
            firstform.Show();
        }


        //user login button
        private void button1_Click(object sender, EventArgs e)
        {

            // email and password verified using user DB

            string email = emailTextBox.Text;
            string inputpw = pwTextBox.Text;
            if (email == "" || inputpw == "")
            {
                MessageBox.Show($"Please enter User Id and Password.");
            }
            else
            {

                // Fetching user account password from DB

                string password = string.Empty; 

                string query = "SELECT Password FROM UserData WHERE EmailID = @EmailID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmailID", email);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    password = (string)reader["Password"];


                                }

                            }

                        }
                        

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"An Error occured : {ex.Message}");
                    }


                }
                if (password == inputpw)
                {
                    this.Hide();
                    var userHome = new UserHomePage();
                    userHome.Closed += (s, args) => this.Close();
                    userHome.Show();

                }

                else
                {
                    MessageBox.Show($"Incorrect EmailId/Password! Please try again.");
                }



            }
           
        }
    }
}
