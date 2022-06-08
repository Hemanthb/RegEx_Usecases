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
Console.WriteLine("Enter the Email-Id of user :");
string Email = Console.ReadLine();
registrationCheck.ValidateMailId(Email);