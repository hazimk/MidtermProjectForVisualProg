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
    public partial class EmployeeLogin : Form
    {
        private SqlConnection connection;

        public EmployeeLogin()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True");
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void loginConfirm_Click(object sender, EventArgs e)
        {
            string username = usernameemployee.Text;
            string password = passwordemployee.Text;

            if (ValidateLogin(username, password))
            {
                string manufacturerId = "";
                using (SqlCommand cmd = new SqlCommand("SELECT factory_id FROM ManufacturerAccounts WHERE ManufacturerAccounts_username = @username AND ManufacturerAccounts_password = @password", connection))
                {
                    cmd.Parameters.AddWithValue("@username", usernameemployee.Text);
                    cmd.Parameters.AddWithValue("@password", passwordemployee.Text);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            manufacturerId = reader.GetString(0);
                        }
                    }
                    connection.Close();
                }
                // Open the main form and hide the login form
                EmployeePage employeePage = new EmployeePage();
                employeePage.stdName = manufacturerId;
                employeePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            // Query the database to check if the username and password are valid
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ManufacturerAccounts WHERE ManufacturerAccounts_username = @username AND ManufacturerAccounts_password = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            int result = (int)command.ExecuteScalar();
            connection.Close();

            return result == 1;
        }






    }

}
