using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_CI_Demo.Services;

namespace WinForms_CI_Demo.Forms
{
    public partial class frmMain : Form
    {
        private readonly UserManagementService _userService;
        public frmMain(UserManagementService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void lblUserManagement_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement(_userService);
            frm.ShowDialog();
        }
    }
}
