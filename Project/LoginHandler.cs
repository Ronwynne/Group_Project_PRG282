using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class LoginHandler
    {
        private static string filename = @"accounts.txt";

        public bool Login(string username, string password)
        {
            bool flag = false;
            if (File.Exists(filename) != true)
            {
                File.CreateText(filename).Close();
            }
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] details = line.Split(',');
                    if ((username == details[0]) && (password == details[1]))
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }

        public string CreateAccount(string username, string password, string conPass)
        {
            bool Exists = false;
            string Message = "";
            if (File.Exists(filename) != true)
            {
                File.CreateText(filename).Close();   
            }
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] details = line.Split(',');
                    if ((username == details[0]) && (password == details[1]))
                    {
                        Exists = true;
                    }
                }
            }
            if (Exists == true)
            {
                Message = "The username already exists";
            }
            else if ((Exists == false) && (password != conPass))
            {
                Message = "The password and the confirm password does not match.";
            }
            else if ((Exists == false) && (password == conPass))
            {
                FileStream fs = new FileStream(filename, FileMode.Append);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(username + "," + password);
                writer.Close();

                Message = "Account successfully created";
            }

            return Message;
        }
    }
}
