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
        public void FirstNameValidCheck(string fname)
        {
            if (Regex.Match(fname, firstName).Success)
            {
                Console.WriteLine("First Name Entered is Valid");
                return;
            }
            Console.WriteLine("First name isn't Valid...Re-Enter!");
        }
    }
}
