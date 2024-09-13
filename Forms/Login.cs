using Book_Manager.Repositories;

namespace Book_Manager.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void MenuForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            var auth = new Auth();
            bool result = auth.AuthenticateUser(name, password);
            if (result)
            {
                MessageBox.Show("Thành công!!");
                var menuForm = new Menu();
                menuForm.Show();
                this.Hide();
                menuForm.FormClosed += MenuForm_FormClosed;
                txtName.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Thất bại~~");
            }
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
