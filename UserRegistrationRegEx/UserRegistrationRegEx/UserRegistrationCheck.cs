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
    }
}
