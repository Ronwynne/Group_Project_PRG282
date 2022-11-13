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

        public static bool Login(string username, string password)
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

        public static void CreateAccount(string username, string password)
        {
            if (File.Exists(filename) != true)
            {
                File.CreateText(filename).Close();
            }
            FileStream fs = new FileStream(filename, FileMode.Append);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(username + "," + password);
            writer.Close();
        }
    }
}
