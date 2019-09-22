using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject.ViewModel;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class FrmLogIn : Form
    {
        private FrmMain _frmMain;

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DoLogIn();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogIn();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogIn();
                e.SuppressKeyPress = true;
            }
        }

        private void DoLogIn()
        {
            LoginViewModel loginUser = new LoginViewModel();
            loginUser.Username = txtUsername.Text;
            loginUser.Password = txtPassword.Text;

            LoginViewModelBLL checkLoginUser = new LoginViewModelBLL();
            bool isLoginUserExist = checkLoginUser.CheckLogIn(loginUser);

            if (isLoginUserExist)
            {
                this.Visible = false;
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;

                _frmMain = new FrmMain();
                _frmMain.Show(this);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmLogIn_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.CenterToScreen();
            }
        }
    }
}