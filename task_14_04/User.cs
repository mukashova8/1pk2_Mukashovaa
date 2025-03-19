using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14_04
{
    public static class User
    {
        private static string _currentUser;
        public static string CurrentUser 
        { 
            get
            {
                return _currentUser; 
            }
            set
            {
                _currentUser = value;
            }
        }
    }
}

