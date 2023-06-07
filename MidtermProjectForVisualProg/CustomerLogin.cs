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

namespace MidtermProjectForVisualProg
{
    public partial class CustomerLogin : Form
    {
        private SqlConnection connection;

        public CustomerLogin()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = usernametextbox.Text;
            string password = passwordtextbox.Text;
            string customerId = "";

            if (ValidateLogin(username, password))
            {
                // Query the database for the customerId
                string query = "SELECT customerfactory_id FROM CustomerFactoryAccount WHERE CustomerFactoryAccount_username=@username AND CustomerFactoryAccount_password=@password";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        customerId = reader["customerfactory_id"].ToString();
                    }
                    reader.Close();
                }
                // Open the customer form and pass the customerId
                CustomerPage customerPage = new CustomerPage();
                customerPage.stdName = customerId;
                customerPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR username or password are wrong. Please try again.");
            }

        }
        private bool ValidateLogin(string username, string password)
        {
            // Query the database to check if the username and password are valid
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM CustomerFactoryAccount WHERE CustomerFactoryAccount_username = @username AND CustomerFactoryAccount_password = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            int result = (int)command.ExecuteScalar();
            connection.Close();

            return result == 1;
        }
    }
}
