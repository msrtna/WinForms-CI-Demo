using System;
using System.Windows.Forms;

namespace WinForms_CI_Demo
{
    public partial class frmLogin : Form
    {
        private readonly LoginViewModel _viewModel;
        public frmLogin()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel(new LoginService());
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (_viewModel.Login(username, password))
            {
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password was wrong");
            }
        }
    }
}
