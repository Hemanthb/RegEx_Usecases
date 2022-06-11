namespace UserRegistrationTest
{
    public class UserDetailsTest
    {
        
        [Test]
        public void GivenFirstName_ChecksRegexPattern_ReturnTrueIfMatches()
        {
            string fName = "Hari";
            UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
            bool actualResult = check.FirstNameValidCheck(fName);
            Assert.IsTrue(actualResult);
        }
        [Test]
        public void GivenLasttName_ChecksRegexPattern_ReturnTrueIfMatches()
        {
            string lName = "Krishan";
            UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
            bool actualResult = check.FirstNameValidCheck(lName);
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void GivenMailId_ChecksRegexPattern_ReturnTrueIfMatches()
        {
            string mail = "Krishan@gmail.com";
            UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
            bool actualResult = check.CheckSampleMailIds(mail);
            Assert.IsTrue(actualResult);
        }
        [Test]
        public void GivenPassword_ChecksRegexPattern_ReturnTrueIfMatches()
        {
            string password = "Krishan@gm12";
            UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
            bool actualResult = check.ValidatePasswordRule4(password);
            Assert.IsTrue(actualResult);
        }
        [Test]
        public void GivenPhoneNo_ChecksRegexPattern_ReturnTrueIfMatches()
        {
            string phno = "91 9898123467";
            UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
            bool actualResult = check.ValidatePhoneNo(phno);
            Assert.IsTrue(actualResult);
        }

    }
}