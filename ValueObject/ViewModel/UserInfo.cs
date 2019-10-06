using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.ViewModel
{
    public static class UserInfo
    {
        public static int UserId
        {
            get { return 1; }
            set { } 
        }


        public static string CurrentUser { get; set; }
        
        public static string UserLevel
        {
            get { return "Administrator"; }
            set { }
        }
    }
}