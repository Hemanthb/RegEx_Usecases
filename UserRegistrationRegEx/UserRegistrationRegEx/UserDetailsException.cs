using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegEx
{
    public class UserDetailsException:Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_EMAIL, INVALID_PHNUMBER, INVALID_PASSWORD
        }
        ExceptionType type;
        public UserDetailsException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

