using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Microsoft.Data.SqlClient;
using ClosedXML.Excel;

namespace Banking_management_system
{
    public partial class AdminTransactions : Form
    {

        string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=BankingAppData;Integrated Security=True;Trust Server Certificate=True";
        public AdminTransactions()
        {
            InitializeComponent();

            FetchData();   // Fetch userdata to combobox 
        }

        private void button1_Click(object sender, EventArgs e)  //Back to Admin HomePage Button
        {

            this.Hide();
            var adminHome = new AdminHomePage();
            adminHome.Closed += (s, args) => this.Close();
            adminHome.Show();
        }


        private void viewAllTransactions()   //View Transactions of all users
        {

            string query = "SELECT * FROM UserTransactions";

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

                            // All transactions are listed in datagridview

                            adminDataGridView2.DataSource = dt;


                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An Error occured : {e.Message}");
                }


            }



        }


        private void FetchData() // Fetch user id and name from user DB and showed in combobox  & later used this to view individual user transaction history
        {


            string query = "SELECT UserId, Name FROM UserData";


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


                            
                            // To view each user transaction separately later we use selected member of comboBox : User Id
                            adminComboBox2.ValueMember = "UserId";
                          
                            adminComboBox2.DisplayMember = "Name";

                            adminComboBox2.DataSource = dt;


                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error occured : {ex.Message}");
                }


            }

        }










        private void viewUserTransacButton_Click(object sender, EventArgs e)  //Shows transaction history of each user listed in comboBox
        {

            string query = "SELECT * FROM UserTransactions WHERE UserId = @UserId";

            int uid = 0;
            if (Int32.TryParse(adminComboBox2.SelectedValue.ToString(), out uid))

            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@UserId", uid);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                DataTable dt = new DataTable();
                                dt.Load(reader);
                                adminDataGridView3.DataSource = dt;


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

        private void exportDataGridButton_Click(object sender, EventArgs e)  //Export user data with transaction history into an excel file 
        {

            

            string folderPath = @"C:\Users\adars\Downloads\BankingAppData\";  //Export file location

            string query = "SELECT  Name, AccountNo , AccountType, Amount, TransactionDate, TransactionType, BeneficiaryAcctNo From UserData inner join UserTransactions ON UserData.UserId = UserTransactions.UserId";

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


                            

                            using (XLWorkbook wb = new XLWorkbook())  //using ClosedXML.Excel
                            {

                                wb.Worksheets.Add(dt, "UserTransactions");


                                wb.Worksheet(1).Columns().AdjustToContents();

                                wb.SaveAs(folderPath + "UserDataExport.xlsx");

                                MessageBox.Show(@"Exported as Excel file in Downloads\BankingAppData folder.");
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An Error occured : {ex.Message}");
                }


            }


        }

        private void AdminTransactions_Load(object sender, EventArgs e)
        {
            this.viewAllTransactions();  //function call to shown data in datagridview while this form loads
        }
    }
}
