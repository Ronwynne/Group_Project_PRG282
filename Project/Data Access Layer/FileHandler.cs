using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class FileHandler
    {
        private static string filename = @"accounts.txt";

        public static List<string> Read()
        {
            List<string> temp = new List<string>();
            if (File.Exists(filename) != true)
            {
                File.CreateText(filename).Close();
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    temp.Add(line);
                }
            }

            return temp;
        }

        public static void Write(string line)
        {
            if (File.Exists(filename) != true)
            {
                File.CreateText(filename).Close();
            }

            FileStream fs = new FileStream(filename, FileMode.Append);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine(line);
            writer.Close();
        }
    }
}