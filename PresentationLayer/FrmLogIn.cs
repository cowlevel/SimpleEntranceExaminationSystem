using BusinessLogicLayer;
using System;
using System.Threading;
using System.Windows.Forms;
using ValueObject;
using ValueObject.ViewModel;

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
            }
            else
            {
                MessageBox.Show(this, "Invalid Username or Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            SystemUserBLL userBLL = new SystemUserBLL();
            int userCount = userBLL.GetUserCount();

            if (userCount == 0)
            {
                SystemUser examinee = new SystemUser
                {
                    LastName = "Admin",
                    FirstName = "Admin",
                    Username = "admin001",
                    UserLevel = "Administrator",
                    Pword = "admin001",
                    AccountStatus = true
                };

                userBLL.InsertUser(examinee);

                MessageBox.Show("There is no user account in this software.\n\nThe software created an Administrator account.\nUsername: admin001\nPassword: admin001\n\nPlease change its information after this log in.\nThank you", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsername.Text = "admin001";
                txtPassword.Text = "admin001";

                DoLogIn();
            }
        }
    }
}