namespace Banking_management_system
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminlogin = new Adminlogin();
            adminlogin.Closed += (s, args) => this.Close();
            adminlogin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var userlogin = new Userlogin();
            userlogin.Closed += (s, args) => this.Close();
            userlogin.Show();
        }
    }
}
