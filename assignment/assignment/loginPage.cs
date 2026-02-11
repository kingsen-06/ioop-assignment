namespace assignment
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerPage register = new registerPage();
            register.Show();
            this.Hide();
        }
    }
}
