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

namespace Banking_management_system
{
    public partial class Adminlogin : Form
    {

        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BankingAppData;Integrated Security=True;Trust Server Certificate=True";
        public Adminlogin()
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


        //Admin login button 

        // password and email id verified using admin credentials DB
        private void button1_Click(object sender, EventArgs e)
        {

            string email = emailTextBox.Text;
            string inputpw = pwTextBox.Text;
            if (email == "" || inputpw == "")
            {
                MessageBox.Show($"Please enter Admin Id and Password.");
            }
            else
            {


                string password = string.Empty; 

                // fetching admin password from DB

                string query = "SELECT Password FROM AdminCredentials WHERE EmailID = @EmailID";

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
                    var adminHome = new AdminHomePage();
                    adminHome.Closed += (s, args) => this.Close();
                    adminHome.Show();

                }

                else
                {
                    MessageBox.Show($"Incorrect Id/Password! Please try again.");
                }



            }


        }
    }
}
