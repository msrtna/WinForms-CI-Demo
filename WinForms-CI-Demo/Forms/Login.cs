using System;
using System.Windows.Forms;
using WinForms_CI_Demo.Applications;

namespace WinForms_CI_Demo.Forms
{
    public partial class frmLogin : Form
    {
        private ILoginService _loginService;
        public frmLogin(ILoginService loginService)
        {
            InitializeComponent();
            _loginService = loginService;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = _loginService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password was wrong");
            }
        }
    }
}
