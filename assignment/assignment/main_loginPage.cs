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
            registerPage1 register = new registerPage1();
            register.Show();
            this.Hide();
        }
    }
}
