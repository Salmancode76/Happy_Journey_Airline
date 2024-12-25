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
    public partial class UpdateAirport : Form
    {
        int IDa;
        public UpdateAirport(int id, string name)
        {

            this.IDa = id;


            InitializeComponent();

            txtAirport.Text = name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewAirports().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string name = txtAirport.Text.Trim();
             Administrator.updateAirport(IDa, name);
        }

        private void lblAddAirport_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAirport_Load(object sender, EventArgs e)
        {

        }
    }
}
