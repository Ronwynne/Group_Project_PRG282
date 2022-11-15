using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    class Validation
    {
        public Validation()
        {

        }

        //Login Form Data Validation
        public bool LogInValidation(string username, string password)
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

        public bool newUserValidation(string username, string password, string confirmPassword)
        {
            if (username != string.Empty && password != string.Empty && confirmPassword != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Main Form Data Validation
        public bool searchValidation(string number)
        {
            if (number != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool studentDataValidation( int studentID, string studentName, string  Surname,string  gender, DateTime dob, string phone, string address, Byte[] img, string course)
        {
            if (studentID != null && studentName != string.Empty && Surname != string.Empty  && dob != null && gender != string.Empty && phone != string.Empty && address != string.Empty && course != null && img != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Courses Data Validation
        public bool courseDataValidation(string courseID, string courseName, string description)
        {
            if (courseID != string.Empty && courseName != string.Empty && description != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        public bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }

    }
}
