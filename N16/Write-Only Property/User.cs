using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N16.Write_Only_Property
{
    internal class User
    {
        private string _password;

        public string Password
        {
            set
            {
                // reset - 
                // forgot - 
                // change - 

                _password = value + "text";
            }
        }
    }
}
