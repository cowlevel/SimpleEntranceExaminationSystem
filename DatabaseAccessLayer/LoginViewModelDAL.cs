using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using ValueObject.ViewModel;
using System.Data.Entity;

namespace DatabaseAccessLayer
{
    public class LoginViewModelDAL
    {
        private ExaminationContext _context;

        public LoginViewModelDAL()
        {

        }

        public bool ChangePassword(LoginViewModel loginUser)
        {
            using (_context = new ExaminationContext())
            {
                SystemUser user = _context.SystemUser.Where(u => u.UserId == loginUser.UserId 
                                                              && u.Pword == loginUser.Password)
                                                              .SingleOrDefault();

                if (user != null)
                {
                    user.Pword = loginUser.NewPassword;
                    _context.Entry(user).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckLogIn(LoginViewModel loginUser)
        {
            SystemUserViewModel userViewModel;

            using (_context = new ExaminationContext())
            {
                userViewModel = _context.SystemUser.Where(u => u.Username == loginUser.Username
                    && u.Pword == loginUser.Password
                    && u.AccountStatus == true)
                        .Select(u => new SystemUserViewModel
                        {
                            UserId = u.UserId,
                            LastName = u.LastName,
                            FirstName = u.FirstName,
                            MiddleName = u.MiddleName,
                            UserLevel = u.UserLevel
                        })
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