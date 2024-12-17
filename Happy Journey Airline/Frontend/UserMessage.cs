﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Journey_Airline.Frontend;

namespace Happy_Journey_Airline
{
    public partial class UserMessage : Form
    {
        public UserMessage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserHomeScreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TravellerRecievedMsg().Show();

        }
    }
}
