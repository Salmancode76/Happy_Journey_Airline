﻿using System;
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
        public UpdateAirport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewAirports().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Airport Successfully Updated!");
        }

        private void lblAddAirport_Click(object sender, EventArgs e)
        {

        }
    }
}
