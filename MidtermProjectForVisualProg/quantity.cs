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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidtermProjectForVisualProg
{
    public partial class quantity : Form
    {
        private string stdName;

        public quantity()
        {
            InitializeComponent();
        }

        private void quantity_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quantity1 = textBox1.Text;
            int quantity;

            if (!int.TryParse(quantity1, out quantity))
            {
                MessageBox.Show("Please enter an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string variable = (string)stdName;
            string[] words = variable.Split(' ');
            string customerID = words[0];
            string productID = words[1];
            int quantityInInventory = 0;

            //Checking the quantity in INVENTORY 
            string query = "SELECT quantity FROM Inventory WHERE product_id = @productID";
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@productID", productID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    object obj = reader.GetValue(0);
                    quantityInInventory = (int)obj;
                }
            }
            //Get the factory ID using product ID
            string factoryID = string.Empty;

            string retrieveFactoryIDQuery = "SELECT factory_id FROM Products WHERE Product_id = @productID";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                SqlCommand retrieveFactoryIDCommand = new SqlCommand(retrieveFactoryIDQuery, connection);
                retrieveFactoryIDCommand.Parameters.AddWithValue("@productID", productID);
                connection.Open();
                using (SqlDataReader reader = retrieveFactoryIDCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        factoryID = reader["factory_id"].ToString();
                    }
                }
            }
            //Get the PRODUCT NAME using product ID
            string productName = string.Empty;

            string retrieveProductNameQuery = "SELECT Product_name FROM Products WHERE Product_id = @productID";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                SqlCommand retrieveProductNameCommand = new SqlCommand(retrieveProductNameQuery, connection);
                retrieveProductNameCommand.Parameters.AddWithValue("@productID", productID);
                connection.Open();
                using (SqlDataReader reader = retrieveProductNameCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        productName = reader["Product_name"].ToString();
                    }
                }
            }
            //Get the LOCATION of the CUSTOMER FACTORY using customer ID
            string locationOfCustomerFactory = string.Empty;

            string retrieveLocationQuery = "SELECT CustomerFactory_location FROM CustomerFactories WHERE CustomerFactory_id = @customerID";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                SqlCommand retrieveLocationCommand = new SqlCommand(retrieveLocationQuery, connection);
                retrieveLocationCommand.Parameters.AddWithValue("@customerID", customerID);
                connection.Open();
                using (SqlDataReader reader = retrieveLocationCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        locationOfCustomerFactory = reader["CustomerFactory_location"].ToString();
                    }
                }
            }
            //If quantity SUFFICEINT, order. Else, INFORM customer and manufacturer
            if (quantityInInventory >= quantity)
            {
                // Sufficient quantity in inventory, update the Inventory table
                int newQuantity = quantityInInventory - quantity;
                string updateInventoryQuery = "UPDATE Inventory SET quantity = @newQuantity, last_update = GETDATE() WHERE product_id = @productID";
                //Updating INVENTORY
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
                {
                    SqlCommand updateCommand = new SqlCommand(updateInventoryQuery, connection);
                    updateCommand.Parameters.AddWithValue("@newQuantity", newQuantity);
                    updateCommand.Parameters.AddWithValue("@productID", productID);
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                }
                int latestOrderID = 0;
                string queryyy = "SELECT TOP 1 Order_id FROM Orders ORDER BY Order_id DESC";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
                {
                    SqlCommand commanddd = new SqlCommand(queryyy, connection);
                    connection.Open();
                    SqlDataReader readerrr = commanddd.ExecuteReader();
                    if (readerrr.Read())
                    {
                        object objj = readerrr.GetValue(0);
                        latestOrderID = (int)objj;
                        latestOrderID++;
                    }
                }
                //Inserting into ORDERS
                string insertOrdersQuery = "INSERT INTO Orders (Order_id, quantity, product_id, customerfactoryaccount_id, Order_date) VALUES (@latestOrderID, @quantity, @productID, @customerID, GETDATE())";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1HNI20Q\\SQLEXPRESS;Initial Catalog=FactoryManagement;Integrated Security=True"))
                {
                    SqlCommand insertCommand = new SqlCommand(insertOrdersQuery, connection);
                    insertCommand.Parameters.AddWithValue("@quantity", quantity);
                    insertCommand.Parameters.AddWithValue("@productID", productID);
                    insertCommand.Parameters.AddWithValue("@customerID", customerID);
                    insertCommand.Parameters.AddWithValue("@latestOrderID", latestOrderID);
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                }
            }
            else
            {
                // Insufficient quantity in inventory
                MessageBox.Show("Not enough quantity available in inventory. The manufacturer will be informed about this");
                int newQuantity = quantity - quantityInInventory;
                string message = $"A customer placed an order for {quantity} {productName.TrimEnd()} from your warehouse in {locationOfCustomerFactory.TrimEnd()} but the avaialbe quantity was only {quantityInInventory}! So you need to manufacture {newQuantity} of it more and send it to your warehouse in {locationOfCustomerFactory.TrimEnd()}";
                string updateMessageQuery = "UPDATE ManufacturingFactories SET message = @message WHERE Factory_id = @factoryID";

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
                {
                    SqlCommand updateMessageCommand = new SqlCommand(updateMessageQuery, connection);
                    updateMessageCommand.Parameters.AddWithValue("@message", message);
                    updateMessageCommand.Parameters.AddWithValue("@factoryID", factoryID);
                    connection.Open();
                    updateMessageCommand.ExecuteNonQuery();
                }
            }
        }
    } 
}



