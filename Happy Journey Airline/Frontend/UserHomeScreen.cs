﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Journey_Airline.Backend;
using Happy_Journey_Airline.Frontend;

namespace Happy_Journey_Airline
{
    public partial class UserHomeScreen : Form
    {
        public UserHomeScreen()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           // GlobalUser.LoggedInUser = null;
            this.Hide();
            new logincs().Show();
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBookFlight().Show();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserSubscriptionScreen().Show();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserMessage().Show();
        }

        private void UserHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchFlights().Show();
        }
    }
}
