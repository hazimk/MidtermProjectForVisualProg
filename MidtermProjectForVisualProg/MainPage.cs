using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermProjectForVisualProg
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CustomerToLogin_Click(object sender, EventArgs e)
        {
            CustomerLogin customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void EmployeeToLogin_Click(object sender, EventArgs e)
        {
            EmployeeLogin EmployeeLogin = new EmployeeLogin();
            EmployeeLogin.Show();
            this.Hide();
        }
    }
}
