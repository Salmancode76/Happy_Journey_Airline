﻿using System;
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
    public partial class UpdateBooking : Form
    {
        public UpdateBooking()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnbsck_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminBookings().Show();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminBookings().Show();
        }
    }
}
