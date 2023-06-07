﻿using System;
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
    public partial class warehouse_inventory : Form
    {
        internal string stdName;
        private object connection;

        public warehouse_inventory()
        {
            InitializeComponent();
        }

        private void warehouse_inventory_Load(object sender, EventArgs e)
        {
            string warehouseName = stdName;
            string connectionString = "Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Warehouse_id FROM Warehouses WHERE Warehouse_name = @warehouseName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@warehouseName", warehouseName);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    warehouseName = reader.GetString(0);
                }
                reader.Close();
                connection.Close();

                connection.Open();
                string queryy = "SELECT product_id FROM Inventory WHERE warehouse_id = @warehouseName";
                SqlCommand commandd = new SqlCommand(queryy, connection);
                commandd.Parameters.AddWithValue("@warehouseName", warehouseName);

                string[] productIdArray = new string[5];
                string[] productNameArray = new string[5];
                int[] quantityArray = new int[5];

                int i = 0;
                SqlDataReader readerr = commandd.ExecuteReader();
                while (readerr.Read())
                {
                    warehouseName = readerr.GetString(0);
                    productIdArray[i] = warehouseName;
                    i++;
                }
                readerr.Close();
                connection.Close();
                int j = 0;
                while (j < productIdArray.Length)
                {
                    warehouseName = productIdArray[j];
                    connection.Open();
                    string queryyy = "SELECT Product_name FROM Products WHERE Product_id = @warehouseName";
                    SqlCommand commanddd = new SqlCommand(queryyy, connection);
                    commanddd.Parameters.AddWithValue("@warehouseName", warehouseName);

                    SqlDataReader readerrr = commanddd.ExecuteReader();
                    if (readerrr.Read())
                    {
                        warehouseName = readerrr.GetString(0);
                        productNameArray[j] = warehouseName;
                    }
                    readerrr.Close();
                    connection.Close();
                    j++;
                }
                int k = 0;
                while (k < productIdArray.Length)
                {
                    warehouseName = productIdArray[k];
                    connection.Open();
                    string queryyy = "SELECT quantity FROM Inventory WHERE product_id = @warehouseName";
                    SqlCommand commanddd = new SqlCommand(queryyy, connection);
                    commanddd.Parameters.AddWithValue("@warehouseName", warehouseName);

                    SqlDataReader readerrr = commanddd.ExecuteReader();
                    if (readerrr.Read())
                    {
                        int quantity = readerrr.GetInt32(0);
                        quantityArray[k] = quantity;
                    }
                    readerrr.Close();
                    connection.Close();
                    k++;
                }
                listBox1.Items.Add($"     Product              Quantity");
                int l = 0;
                while (l < productNameArray.Length)
                {
                    listBox1.Items.Add($"{l + 1}    {productNameArray[l]}{quantityArray[l]}");
                    l++;
                }
            }
        }
}    }
