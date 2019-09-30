using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using ValueObject;
using ValueObject.ViewModel;
using DatabaseAccessLayer;

namespace BusinessLogicLayer
{
    public class SystemUserBLL
    {
        private bool _isValid;
        private ValueObjectValidator _objectValidator;
        private List<ValidationResult> _validationResults;
        private SystemUserDAL _userDAL;


        public SystemUserBLL()
        {
            _userDAL = new SystemUserDAL();
        }

        public bool InsertUser(SystemUser user, out List<string> errorList)
        {
            errorList = new List<string>();
            _objectValidator = new ValueObjectValidator();
            _isValid = _objectValidator.TryValidate(user, out _validationResults);

            if (!_isValid)
            {
                foreach (var error in _validationResults)
                {
                    errorList.Add(error.ErrorMessage);
                }
                
                return false;
            }

            user.Pword = SetHashText(user.Pword);   //  set new user password
            _userDAL.InsertUser(user);

            return true;
        }

        public void InsertUser(SystemUser user)
        {
            user.Pword = SetHashText(user.Pword);   //  set new user password
            _userDAL.InsertUser(user);
        }

        public bool UpdateUser(SystemUser user, out List<string> errorList)
        {
            errorList = new List<string>();
            _objectValidator = new ValueObjectValidator();
            _isValid = _objectValidator.TryValidate(user, out _validationResults);

            if (!_isValid)
            {
                foreach (var error in _validationResults)
                {
                    errorList.Add(error.ErrorMessage);
                }

                return false;
            }

            _userDAL.UpdateUser(user);

            return true;
        }

        public void UpdateUser(SystemUser user)
        {
            _userDAL.UpdateUser(user);
        }

        //public bool DeleteUser(SystemUser user)
        //{
        //    _userDAL.DeleteUser(user);

        //    return false;
        //}

        public List<SystemUserViewModel> GetUserListViewModel()
        {
            return _userDAL.GetUserListViewModel();
        }

        public List<SystemUserViewModel> GetUserListByNameViewModel(string namePart)
        {
            return _userDAL.GetUserListByNameViewModel(namePart);
        }

        public int GetUserCount()
        {
            return _userDAL.GetUserCount();
        }

        //public User GetUserById(int userId)
        //{
        //    return _userDAL.GetUserById(userId);
        //}

        //public List<User> GetUserList()
        //{
        //    return _userDAL.GetUserList();
        //}

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