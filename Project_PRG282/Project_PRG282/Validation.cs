using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG282
{
    class Validation
    {
        public Validation()
        {
        }

        //Login Form Validation
        public bool LogInVal(string username, string password)
        {
            if (username != string.Empty && password != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool newUserVal(string username, string password, string confirmPass)
        {
            if (username != string.Empty && password != string.Empty && confirmPass != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
