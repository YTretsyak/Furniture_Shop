using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_Store.Classes
{
    class UserControlSingleton
    {
        private static UserControlSingleton instance;
        public bool IsLogged;
        public int UserID;
        public string Name;
        public string Role;
        private UserControlSingleton()
        {
        
        }

        public static UserControlSingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new UserControlSingleton();
            }
            return instance;
        }
    }
}
