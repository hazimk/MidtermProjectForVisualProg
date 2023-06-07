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
    public partial class EmployeePage : Form
    {
        internal string stdName;

        public EmployeePage()
        {
            InitializeComponent();
        }

        private void ToWarehouse_Click(object sender, EventArgs e)
        {
            string manufacturer_id = stdName;


            WarehousePage warehousePage = new WarehousePage();
            warehousePage.stdName = manufacturer_id;
            warehousePage.Show();
            this.Hide();
        }

        private void ToManufactory_Click(object sender, EventArgs e)
        {
            string manufacturer_id = stdName;

            manufacture_products manufacture_Products = new manufacture_products();
            manufacture_Products.stdName = manufacturer_id;
            manufacture_Products.Show();
            this.Hide();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            string factory_id = stdName;
            string message = null;

            string retrieveMessageQuery = "SELECT message FROM ManufacturingFactories WHERE Factory_id = @factory_id";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
            {
                SqlCommand retrieveMessageCommand = new SqlCommand(retrieveMessageQuery, connection);
                retrieveMessageCommand.Parameters.AddWithValue("@factory_id", factory_id);
                connection.Open();
                using (SqlDataReader reader = retrieveMessageCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("message")))
                        {
                            message = reader["message"].ToString();
                        }
                    }
                }
            }

            if (message != null)
            {
                MessageBox.Show(message);

                // Set the MESSAGE to NULL after displaying it to the manufacturer
                string updateMessageQuery = "UPDATE ManufacturingFactories SET message = NULL WHERE Factory_id = @factoryID";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UVHV1PR\\MSSQLSERVER01;Initial Catalog=midVSproject;Integrated Security=True"))
                {
                    SqlCommand updateMessageCommand = new SqlCommand(updateMessageQuery, connection);
                    updateMessageCommand.Parameters.AddWithValue("@factoryID", factory_id);
                    connection.Open();
                    updateMessageCommand.ExecuteNonQuery();
                }
            }
        }

    }
}
       
