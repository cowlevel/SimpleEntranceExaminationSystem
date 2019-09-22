using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {

        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}