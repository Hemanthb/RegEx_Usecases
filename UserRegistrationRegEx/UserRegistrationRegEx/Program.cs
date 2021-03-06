UserRegistrationRegEx.UserRegistrationCheck registrationCheck = new UserRegistrationRegEx.UserRegistrationCheck();

/* ----- FIRST NAME ----- */

Console.WriteLine("Enter the first name of user :");
string fName = Console.ReadLine();
registrationCheck.FirstNameValidCheck(fName);
Console.WriteLine();

/* ----- LAST NAME ----- */

Console.WriteLine("Enter the Last name of user :");
string lName = Console.ReadLine();
registrationCheck.LastNameValidCheck(lName);
Console.WriteLine();

/* ----- EMAIL ID ----- */

Console.WriteLine("Enter the Email-Id of user :");
string Email = Console.ReadLine();
registrationCheck.ValidateMailId(Email);
Console.WriteLine();

/* ----- PHONE NO  ----- */

Console.WriteLine("Enter the Phone Noof user :");
string phoneNo = Console.ReadLine();
registrationCheck.ValidatePhoneNo(phoneNo);
Console.WriteLine();

/* ----- PASSWORD  ----- */

Console.WriteLine("Enter the Password :");
string pwd = Console.ReadLine();
registrationCheck.ValidatePassword(pwd);
Console.WriteLine("----RULE:2 ATLEAST 1 UPPERCASE----");
registrationCheck.ValidatePasswordRule2(pwd);
Console.WriteLine("----RULE:3 ATLEAST 1 NUMERIC----");
registrationCheck.ValidatePasswordRule3(pwd);
Console.WriteLine("----RULE:4 ATLEAST 1 SPECIAL CHAR----");
registrationCheck.ValidatePasswordRule4(pwd);
Console.WriteLine();

/* ----- SAMPLE MAIL-ID's ----- */

Console.WriteLine("Enter a sample Id :");
string sample = Console.ReadLine();
registrationCheck.CheckSampleMailIds(sample);
string[] sampleId = File.ReadAllLines(@"D:\blabz_fellowship\RegEx_Usecases\UserRegistrationRegEx\UserRegistrationRegEx\MailIds.txt");
foreach (string id in sampleId)
    registrationCheck.CheckSampleMailIds(id);