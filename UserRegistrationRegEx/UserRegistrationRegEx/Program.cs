UserRegistrationRegEx.UserRegistrationCheck registrationCheck = new UserRegistrationRegEx.UserRegistrationCheck();
Console.WriteLine("Enter the first name of user :");
string fName = Console.ReadLine();
registrationCheck.FirstNameValidCheck(fName);
Console.WriteLine();
Console.WriteLine("Enter the Last name of user :");
string lName = Console.ReadLine();
registrationCheck.LastNameValidCheck(lName);