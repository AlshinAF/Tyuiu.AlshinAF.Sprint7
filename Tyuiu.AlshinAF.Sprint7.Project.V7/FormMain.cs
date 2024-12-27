using SprintReview6V16;

namespace Tyuiu.AlshinAF.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonClients_AAF_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClients fclients = new FormClients();
            fclients.ShowDialog();
        }

        private void buttonApartments_AAF_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormApartments fapart = new FormApartments();
            fapart.ShowDialog();
        }

        private void buttonInfo_AAF_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
