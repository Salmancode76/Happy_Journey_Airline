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
            this.Hide();
           
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

        private void AdminServices_Load(object sender, System.EventArgs e)
        {

        }
    }
}
