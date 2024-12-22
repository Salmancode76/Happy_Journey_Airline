using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public partial class CreateService : Form
    {
        public CreateService()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminServices().Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(servicetxt.Text) || string.IsNullOrWhiteSpace(descriptiontxt.Text) || string.IsNullOrWhiteSpace(pricetxt.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(pricetxt.Text, out double price))
            {
                Administrator.addService(servicetxt.Text, descriptiontxt.Text, price);
            }
            else
            {
                MessageBox.Show("Invalid price entered. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
