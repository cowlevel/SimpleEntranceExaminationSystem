using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject.ViewModel;

namespace PresentationLayer
{
    public partial class UCtrlPassword : UserControl
    {
        public UCtrlPassword()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (InputsAreValid())
            {
                LoginViewModel loginUser = new LoginViewModel();
                loginUser.UserId = UserInfo.UserId;
                loginUser.Password = txtOldPassword.Text;
                loginUser.NewPassword = txtNewPassword.Text;

                LoginViewModelBLL loginViewModelBLL = new LoginViewModelBLL();

                if (loginViewModelBLL.ChangePassword(loginUser))
                {
                    txtOldPassword.Text = string.Empty;
                    txtNewPassword.Text = string.Empty;
                    txtRetypeNewPassword.Text = string.Empty;

                    lblStatus.Text = "  Successfully changed password";
                }
                else
                {
                    lblStatus.Text = "  Old password / new password entered did not match";
                }
            }
        }

        private void lblOldPassword_Click(object sender, EventArgs e)
        {
            txtOldPassword.Focus();
        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
        }

        private void lblRetypeNewPassword_Click(object sender, EventArgs e)
        {
            txtRetypeNewPassword.Focus();
        }

        private bool InputsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                lblStatus.Text = "  Please enter old password";
                txtOldPassword.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                lblStatus.Text = "  Please enter new password";
                txtNewPassword.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtRetypeNewPassword.Text))
            {
                lblStatus.Text = "  Please re-type new password";
                txtRetypeNewPassword.Focus();
                return false;
            }
            else if (txtNewPassword.Text != txtRetypeNewPassword.Text)
            {
                lblStatus.Text = "  Old password / new password entered did not match";
                return false;
            }
            else if (txtNewPassword.Text.Length < 7 || txtRetypeNewPassword.Text.Length < 7)
            {
                lblStatus.Text = "  New password entered length must be 7 characters or more";
                return false;
            }

            return true;
        }
    }
}
