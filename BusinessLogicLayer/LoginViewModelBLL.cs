using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject.ViewModel;
using DatabaseAccessLayer;
using System.Security.Cryptography;

namespace BusinessLogicLayer
{
    public class LoginViewModelBLL
    {
        private LoginViewModelDAL _loginViewModelDAL;

        public LoginViewModelBLL()
        {
            _loginViewModelDAL = new LoginViewModelDAL();
        }

        public bool CheckLogIn(LoginViewModel loginUser)
        {
            loginUser.Password = SetHashText(loginUser.Password);

            return _loginViewModelDAL.CheckLogIn(loginUser);
        }

        private string SetHashText(string text)
        {
            StringBuilder sb;
            byte[] result;

            using (SHA256 sha256 = SHA256.Create())
            {
                sb = new StringBuilder();
                result = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

                for (int i = 0; i < result.Length; i++)
                {
                    sb.Append(result[i].ToString("x2"));
                }
            }

            return sb.ToString();
        }
    }
}