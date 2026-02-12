using System;
using System.Windows.Forms;

namespace WinForms_CI_Demo
{
    public partial class frmLogin : Form
    {
        private IAuthenticator _authenticator;
        public frmLogin(IAuthenticator authenticator)
        {
            InitializeComponent();
            _authenticator = authenticator;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = _authenticator.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (result)
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
