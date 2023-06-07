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
    public partial class CustomerOrderPage : Form
    {
        public string stdName;


        public CustomerOrderPage()
        {
            InitializeComponent();
        }

        private void CustomerOrderPage_Load(object sender, EventArgs e)
        {
            // retrieve category ID from Categories table
            string categoryName = stdName; // category variable has the selected category name
            string categoryId = "";
            string connectionString = "Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Category_id FROM Categories WHERE Category_name = @CategoryName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CategoryName", categoryName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    categoryId = reader.GetString(0);
                }
                reader.Close();
            }

            // retrieve matching products from Products table using category ID
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Product_name FROM Products WHERE category_id = @category_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@category_id", categoryId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            productlistBox.Items.Add(productName);
                        }
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT product_price FROM products WHERE category_id = @category_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@category_id", categoryId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double productprice = reader.GetDouble(0);
                            string productprice2 = productprice.ToString();
                            pricelistBox.Items.Add("$" + productprice2);
                        }
                    }
                }
            }


        }

        private void productlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productName = productlistBox.SelectedItem.ToString();
            float productPrice = 0;

            string query = "SELECT product_price FROM Products WHERE product_name = @ProductName";
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    object obj = reader.GetValue(0);
                    productPrice = (float)Convert.ToDouble(obj);
                }
            }

            quantity quantity1 = new quantity();
            quantity1.Show();

        }

    }
}
