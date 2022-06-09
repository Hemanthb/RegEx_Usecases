using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegEx
{
    public class UserRegistrationCheck
    {
        string firstName = "^[A-Z]{1}[a-z]{2,}";
        string lastName  = "^[A-Z]{1}[a-z]{2,}";
        string email = "^(abc).?(xyz)?@(bl){1}.?(co)?.(in){1}";
        string phone = @"^[0-9]{2}\s[0-9]{10}$";
        string password = "[a-z]*";
        //var hasMinOneUppercase = new Regex(@"[A-Z]+");
        string oneUpperCase = @"[A-Z]+";
        string hasMin8Chars =@".{8,}";

        public void FirstNameValidCheck(string fname)
        {
            if (Regex.Match(fname, firstName).Success)
            {
                Console.WriteLine("First Name Entered is Valid");
                return;
            }
            Console.WriteLine("First name isn't Valid...Re-Enter!");
        }
        public void LastNameValidCheck(string lname)
        {
            if (Regex.Match(lname, lastName).Success)
            {
                Console.WriteLine("Last Name Entered is Valid");
                return;
            }
            Console.WriteLine("Last name isn't Valid...Re-Enter!");
        }
        public void ValidateMailId(string mailId)
        {
            if (Regex.Match(mailId, email).Success)
            {
                Console.WriteLine("Entered Email-Id is Valid");
                return;
            }
            Console.WriteLine("Email-Id isn't Valid...Re-Enter!");
        }

        public void ValidatePhoneNo(string phoneNo)
        {
            if (Regex.Match(phoneNo, phone).Success)
            {
                Console.WriteLine("Entered Phone No is Valid");
                return;
            }
            Console.WriteLine("Phone Number isn't Valid...Re-Enter!");
        }
        public void ValidatePassword(string pwd)
        {
            if (Regex.Match(pwd, password).Success && Regex.Match(pwd,hasMin8Chars).Success)
            {
                Console.WriteLine("Entered Password is Valid");
                return;
            }
            Console.WriteLine("Password isn't Valid...Re-Enter!");
        }
        public void ValidatePasswordRule2(string pwd)
        {
            if (Regex.Match(pwd, password).Success && Regex.Match(pwd,hasMin8Chars).Success && Regex.Match(pwd, oneUpperCase).Success)
            {
                Console.WriteLine("Entered Password is valid & passes rule-2");
                return;
            }
            Console.WriteLine("Password isn't Valid...Re-Enter!");
        }
    }
}
