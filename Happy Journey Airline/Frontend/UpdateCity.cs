using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Journey_Airline.Frontend
{
    public partial class UpdateCity : Form
    {
        public UpdateCity()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewCities().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



            MessageBox.Show("City Successfully Updated!");
        }
    }
}
