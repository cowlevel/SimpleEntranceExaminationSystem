using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ValueObject;
using ValueObject.ViewModel;

namespace DatabaseAccessLayer
{
    public class UserDAL
    {
        private ExaminationContext _context;

        public UserDAL()
        {
            //_context = new ExaminationContext();
        }

        public void InsertUser(User user)
        {
            using (_context = new ExaminationContext())
            {
                _context.User.Add(user); //_context.Entry(user).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (_context = new ExaminationContext())
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            using (_context = new ExaminationContext())
            {
                _context.Entry(user).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public List<UserViewModel> GetUserListByNameViewModel(string namePart)
        {
            List<UserViewModel> userListViewModel;

            using (_context = new ExaminationContext())
            {
                userListViewModel = _context.User
                    .Where(u => u.LastName.Contains(namePart) ||
                                u.FirstName.Contains(namePart))
                        .Select(u => new UserViewModel
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

        public List<UserViewModel> GetUserListViewModel()
        {
            List<UserViewModel> userListViewModel;

            using (_context = new ExaminationContext())
            {
                userListViewModel = _context.User
                    .Select(u => new UserViewModel {
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
                userCount = _context.User.Count();
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