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
    public partial class frmUserManagement : Form
    {
        private readonly UserManagementService _userService;

        public frmUserManagement(UserManagementService userService)
        {
            InitializeComponent();
            _userService = userService;
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = _userService.GetAllUsers();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_userService.AddUser(txtUsername.Text, txtPassword.Text))
                LoadUsers();
            else
                MessageBox.Show("User is already exist");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int id = (int)dgvUsers.CurrentRow.Cells["Id"].Value;
                _userService.DeleteUser(id);
                LoadUsers();
            }
        }
    }
}
