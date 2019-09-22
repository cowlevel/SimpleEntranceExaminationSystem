using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class LoginViewModelDAL
    {
        private ExaminationContext _context;

        public LoginViewModelDAL()
        {

        }

        public bool CheckLogIn(LoginViewModel loginUser)
        {
            SystemUserViewModel userViewModel;

            using (_context = new ExaminationContext())
            {
                userViewModel = _context.SystemUser.Where(u => u.Username == loginUser.Username
                    && u.Pword == loginUser.Password)
                        .Select(u => new SystemUserViewModel
                        {
                            UserId = u.UserId,
                            LastName = u.LastName,
                            FirstName = u.FirstName,
                            MiddleName = u.MiddleName,
                            UserLevel = u.UserLevel
                        } )
                        .SingleOrDefault();
            }

            if (userViewModel != null)  //  user exists
            {
                UserInfo.UserId = userViewModel.UserId;
                UserInfo.CurrentUser = string.Format("{0} {1}", userViewModel.FirstName, userViewModel.LastName);
                UserInfo.UserLevel = userViewModel.UserLevel;

                return true;
            }

            UserInfo.UserId = 0;
            UserInfo.CurrentUser = string.Empty;
            UserInfo.UserLevel = string.Empty;

            return false;
        }
    }
}