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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewUsersScreen().Show();
        }

        private void emaillbl_Click(object sender, EventArgs e)
        {

        }

        private void passlbl_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new viewUsersScreen().Show();
        }
    }
}
