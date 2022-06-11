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
        [Test]
        public void GivenSampleMailIds_ChecksRegexPattern_ReturnTrueIfMatches()
        {
            UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
            string[] sampleId = File.ReadAllLines(@"D:\blabz_fellowship\RegEx_Usecases\UserRegistrationRegEx\UserRegistrationRegEx\MailIds.txt");
            bool actualResult;
            foreach (string id in sampleId)
                Assert.IsTrue(check.CheckSampleMailIds(id));
        }
        [Test]
        public void GivenInvalidFirstName_ChecksRegexPattern_ThrowsExcapetion()
        {
            try
            {
                string fName = "hari";
                UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
                bool actualResult = check.FirstNameValidCheck(fName);
            }
            catch(UserRegistrationRegEx.UserDetailsException exc)
            {
                Assert.AreEqual("Invalid First Name", exc.Message);
            }

        }
        [Test]
        public void GivenInvalidLastName_ChecksRegexPattern_ThrowsExcapetion()
        {
            try
            {
                string lName = "H";
                UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
                bool actualResult = check.LastNameValidCheck(lName);
            }
            catch (UserRegistrationRegEx.UserDetailsException exc)
            {
                Assert.AreEqual("Invalid Last Name", exc.Message);
            }

        }
        [Test]
        public void GivenInvalidEmailId_ChecksRegexPattern_ThrowsExcapetion()
        {
            try
            {
                string mail = "hari@gm.1";
                UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
                bool actualResult = check.CheckSampleMailIds(mail);
            }
            catch (UserRegistrationRegEx.UserDetailsException exc)
            {
                Assert.AreEqual("Invalid EmailID", exc.Message);
            }

        }
        [Test]
        public void GivenInvalidPhoneNo_ChecksRegexPattern_ThrowsExcapetion()
        {
            try
            {
                string phno = "98989898";
                UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
                bool actualResult = check.ValidatePhoneNo(phno);
            }
            catch (UserRegistrationRegEx.UserDetailsException exc)
            {
                Assert.AreEqual("Invalid Phone Number", exc.Message);
            }

        }
        [Test]
        public void GivenInvalidPassword_ChecksRegexPattern_ThrowsExcapetion()
        {
            try
            {
                string pwd = "hari@";
                UserRegistrationRegEx.UserRegistrationCheck check = new UserRegistrationRegEx.UserRegistrationCheck();
                bool actualResult = check.ValidatePasswordRule4(pwd);
            }
            catch (UserRegistrationRegEx.UserDetailsException exc)
            {
                Assert.AreEqual("Invalid Password", exc.Message);
            }

        }

    }
}