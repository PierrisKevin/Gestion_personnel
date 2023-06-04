namespace Gestion_chambre
{
    public partial class main_views : Form
    {
        public main_views()
        {
            InitializeComponent();
            dashboard1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void client_link_Click(object sender, EventArgs e)
        {
            client_interface1.BringToFront();
        }
    }
}