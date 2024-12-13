using System.Windows.Forms;

namespace Happy_Journey_Airline
{
    public partial class AdminServices : Form
    {
        public AdminServices()
        {
            InitializeComponent();
        }

        private void Deletebtn_Click(object sender, System.EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
=======
           
>>>>>>> 6b25619f8944d954116e49676f328f2d5add6133
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new adminDashboard().Show();
        }

        private void btncreate_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new CreateService().Show();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new UpdateService().Show();
        }
    }
}
