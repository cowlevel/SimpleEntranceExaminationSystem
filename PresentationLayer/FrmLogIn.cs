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
using System.Threading;

namespace PresentationLayer
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                DoLogIn();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void OpenMainForm()
        {
            Application.Run(new FrmMain());
        }

        private bool InputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)
                || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(this, "Invalid Username or Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        private void DoLogIn()
        {
            LoginViewModel loginUser = new LoginViewModel();
            loginUser.Username = txtUsername.Text;
            loginUser.Password = txtPassword.Text;

            LoginViewModelBLL checkLoginUser = new LoginViewModelBLL();
            bool loginUserExists = checkLoginUser.CheckLogIn(loginUser);

            if (loginUserExists)
            {
                this.Close();
                //Console.WriteLine(UserInfo.CurrentUser);
                Thread thread = new Thread(() =>
                {
                    Application.Run(new FrmMain());
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                //this.Visible = false;
                //txtUsername.Text = string.Empty;
                //txtPassword.Text = string.Empty;
                //_frmMain = new FrmMain();
                //_frmMain.Show(this);
            }
            else
            {
                MessageBox.Show(this, "Invalid Username or Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}