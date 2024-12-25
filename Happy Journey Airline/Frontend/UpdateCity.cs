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
        int IDc;
        string City;
        public UpdateCity(int ID, string name)
        {
            InitializeComponent();
            this.IDc = ID;
            this.City = name;
            Citytxt.Text = name;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewCities().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String cityname = Citytxt.Text.Trim();
            new Administrator().updateCity(IDc, cityname);



        }

        private void UpdateCity_Load(object sender, EventArgs e)
        {

        }
    }
}
