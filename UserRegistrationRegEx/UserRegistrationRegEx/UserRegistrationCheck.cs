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
        string lastName = "^[A-Z]{1}[a-z]{2,}";
        string email = "^(abc).?(xyz)?@(bl){1}.?(co)?.(in){1}";
        string phone = @"^[0-9]{2}\s[0-9]{10}$";
        string password = "[a-z]*";
        string oneUpperCase = @"[A-Z]+";
        string hasMin8Chars = @".{8,}";
        string hasANumber = @"[0-9]+";
        string specialChar = @"[\W]+";
        string sampleMailIds = "^[a-zA-Z]+[0-9]*([._+-][0-9A-Za-z]+)*@[a-zA-Z]+.([a-zA-Z]{2,}.)?[a-zA-Z]{2,3}$";

        public bool FirstNameValidCheck(string fname)
        {
            Func<string, bool> match = fname => Regex.Match(fname, firstName).Success;
            if (match(fname))
            {
                Console.WriteLine("First Name Entered is Valid");
                return true;
            }
            else{
                Console.WriteLine("First name isn't Valid...Re-Enter!");
                throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
            
            }
        }
        public bool LastNameValidCheck(string lname)
        {
            Func<string, bool> match = lname => Regex.Match(lname, lastName).Success;
            if (match(lname))
            {
                Console.WriteLine("Last Name Entered is Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Last name isn't Valid...Re-Enter!");
                throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");

            }
        }
        public void ValidateMailId(string mailId)
        {
            Func<string, bool> match = mailId => Regex.Match(mailId, email).Success;
            if (match(mailId))
            {
                Console.WriteLine("Entered Email-Id is Valid");
                return;
            }
            Console.WriteLine("Email-Id isn't Valid...Re-Enter!");
           
            
        }

        public bool ValidatePhoneNo(string phoneNo)
        {
            Func<string, bool> match = phoneNo => Regex.Match(phoneNo, phone).Success;
            if (match(phoneNo))
            {
                Console.WriteLine("Entered Phone No is Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Phone Number isn't Valid...Re-Enter!");
                throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_PHNUMBER, "Invalid Phone Number");
            }
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
            Console.WriteLine("Password isn't Valid-Must have atleast a UPPERCASE...Re-Enter!");
        }

        public void ValidatePasswordRule3(string pwd)
        {
            if (Regex.Match(pwd, password).Success && Regex.Match(pwd, hasMin8Chars).Success && Regex.Match(pwd, oneUpperCase).Success &&
                Regex.Match(pwd,hasANumber).Success)
            {
                Console.WriteLine("Entered Password is valid & passes rule-3");
                return;
            }
            Console.WriteLine("Password isn't Valid-Must have atleast 1 number...Re-Enter!");
        }
        public bool ValidatePasswordRule4(string pwd)
        {
            if (Regex.Match(pwd, password).Success && Regex.Match(pwd, hasMin8Chars).Success && Regex.Match(pwd, oneUpperCase).Success &&
                Regex.Match(pwd, hasANumber).Success && Regex.Match(pwd, specialChar).Success)
            {
                Console.WriteLine("Entered Password is valid & passes rule-4");
                return true;
            }
            else
            {
                Console.WriteLine("Password isn't Valid-Must have atleast 1 special Character...Re-Enter!");
                throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }

        public bool CheckSampleMailIds(string emailID)
        {
            Func<string, bool> match = emailID => Regex.Match(emailID, sampleMailIds).Success;
            if (match(emailID))
            {
                Console.WriteLine("Email-Id -- {0} --> Valid", emailID);
                return true;
            }
            else
            {
                Console.WriteLine("Email-Id -- {0} --> INVALID...Re-Enter!", emailID);
                throw new UserDetailsException(UserDetailsException.ExceptionType.INVALID_EMAIL, "Invalid EmailID");
            }
        }
        
    }
}
