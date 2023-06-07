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
    public partial class CustomerPage : Form
    {
        internal string stdName;

        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            string id = stdName;
            string customerCompany = "";

            // create a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                // open the connection
                connection.Open();

                // create a SQL query to retrieve the name of the customer company based on the customer ID
                string query = "SELECT CustomerFactory_name FROM CustomerFactories where CustomerFactory_id = @id";
                // create a command object with the SQL query and the connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // add the customer ID parameter to the command
                    command.Parameters.AddWithValue("@id", id);

                    // execute the SQL query and get the result as a scalar value (the name of the customer company)
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        customerCompany = result.ToString();
                    }
                }
            }
            FactoryName.Text = customerCompany;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirmthecatgory_Click(object sender, EventArgs e)
        {
            if (CatgoryType.SelectedIndex != -1)
            {
                string category = CatgoryType.Text;
                CustomerOrderPage page = new CustomerOrderPage();
                page.stdName = category;
                page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }
    }
}
