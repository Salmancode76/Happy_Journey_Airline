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
    public partial class UpdateService : Form
    {
        int ServicerID;
        public UpdateService(int Servicerid)
        {
             ServicerID = Servicerid;
            Service s = Administrator.GetServiceByID(ServicerID);


            Console.WriteLine(s.ServiceName);
            InitializeComponent();
            servicetxt.Text = s.ServiceName;
            descriptiontxt.Text = s.Description;
            pricetxt.Text= s.Price.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminServices().Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate the price input
            if (double.TryParse(pricetxt.Text, out double price))
            {
                // Call the update method
                Administrator.updateService(ServicerID, servicetxt.Text, descriptiontxt.Text, price);

            }
            else
            {
                MessageBox.Show("Invalid price entered. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
