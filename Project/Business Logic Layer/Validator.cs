using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Validator
    {
        public static bool Login(string username, string password)
        {
            bool flag = false;
            foreach (string line in FileHandler.Read())
            {
                string[] fields = line.Split(',');
                if ((username == fields[0]) && (password == fields[1]))
                {
                    flag = true;
                }
            }

            return flag;
        }

        public static string CreateAccount(string username, string password, string confirm)
        {
            string acountLine = username + "," + password;
            //check if passwords match
            if (password != confirm)
            {
                return "The passwords you have entered do not match. Please enter them again.";
            }

            //check if account already exists
            foreach (string line in FileHandler.Read())
            {
                if (acountLine == line)
                {
                    return "Account already exists. Please log in";
                }
            }

            FileHandler.Write(acountLine);
            return "Account has successfully been created.";
        }
    }
}
