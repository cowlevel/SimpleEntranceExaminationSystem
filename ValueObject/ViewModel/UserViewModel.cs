using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public class UserViewModel
    {
        
        public UserViewModel()
        {
            
        }

        public int UserId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Username { get; set; }

        public string UserLevel { get; set; }

        public bool AccountStatus { get; set; }

        public string AccountStatusFormat
        {
            get
            {
                if (AccountStatus.ToString() == "True")
                {
                    return "✓ Active";
                }

                return "✘ Inactive";
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0}, {1} {2}", LastName, FirstName, MiddleName);
            }
        }
    }
}
