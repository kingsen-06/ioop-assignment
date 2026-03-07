namespace assignment
{
    public partial class main_loginPage : Form
    {
        public main_loginPage()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            main_registerPage register = new main_registerPage();
            register.Show();
            this.Hide();
        }
    }
}
