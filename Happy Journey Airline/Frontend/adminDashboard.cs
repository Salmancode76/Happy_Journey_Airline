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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBookFlight().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GlobalUser.LoggedInUser = null;

            this.Hide();
            new logincs().Show();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewUsersScreen().Show();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMessage().Show();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminSubscriptionsScreen().Show();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminFlights().Show(); 
        }

        private void btnservices_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminServices().Show();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            this.Hide();
           new viewAirports().Show();

        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewCountries().Show();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewCities().Show();
        }

        private void subscribersScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminSubscribersSubscription().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Administrator ad = new Administrator();
            ad.performDbBackup(); 
            //create a file to save all the db in it and copy its path - eg: backupFilePath = @"C:\Backups\YourDatabaseBackup.bak"
            ;
        }
    }
}
