using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ValueObject;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class SystemUserDAL
    {
        private ExaminationContext _context;

        public SystemUserDAL()
        {
            //_context = new ExaminationContext();
        }

        public void InsertUser(SystemUser user)
        {
            using (_context = new ExaminationContext())
            {
                _context.SystemUser.Add(user); //_context.Entry(user).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void UpdateUser(SystemUser user)
        {
            using (_context = new ExaminationContext())
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        //public void DeleteUser(SystemUser user)
        //{
        //    using (_context = new ExaminationContext())
        //    {
        //        _context.Entry(user).State = EntityState.Deleted;
        //        _context.SaveChanges();
        //    }
        //}

        public List<SystemUserViewModel> GetUserListByNameViewModel(string namePart)
        {
            List<SystemUserViewModel> userListViewModel;

            using (_context = new ExaminationContext())
            {
                userListViewModel = _context.SystemUser
                    .Where(u => u.LastName.Contains(namePart) ||
                                u.FirstName.Contains(namePart) ||
                                u.MiddleName.Contains(namePart))
                        .Select(u => new SystemUserViewModel
                        {
                            UserId = u.UserId,
                            LastName = u.LastName,
                            FirstName = u.FirstName,
                            MiddleName = u.MiddleName,
                            Username = u.Username,
                            UserLevel = u.UserLevel,
                            AccountStatus = u.AccountStatus
                        })
                        .ToList();
            }

            return userListViewModel;
        }

        public List<SystemUserViewModel> GetUserListViewModel()
        {
            List<SystemUserViewModel> userListViewModel;

            using (_context = new ExaminationContext())
            {
                userListViewModel = _context.SystemUser
                    .Select(u => new SystemUserViewModel {
                        UserId = u.UserId,
                        LastName = u.LastName,
                        FirstName = u.FirstName,
                        MiddleName = u.MiddleName,
                        Username = u.Username,
                        UserLevel = u.UserLevel,
                        AccountStatus = u.AccountStatus
                    })
                    .ToList();
            }

            return userListViewModel;
        }

        public int GetUserCount()
        {
            int userCount;

            using (_context = new ExaminationContext())
            {
                userCount = _context.SystemUser.Count();
            }

            return userCount;
        }

        //public User GetUserById(int userId)
        //{
        //    User user;

        //    using (_context = new ExaminationContext())
        //    {
        //        user = _context.User.Where(u => u.UserId == userId)
        //            .SingleOrDefault();
        //    }

        //    return user;
        //}

        //public List<User> GetUserList()
        //{
        //    List<User> userList;

        //    using (_context = new ExaminationContext())
        //    {
        //        userList = _context.User.ToList();
        //    }

        //    return userList;
        //}
    }
}