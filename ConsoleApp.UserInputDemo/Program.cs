// Declare variables

string? firstName = string.Empty; // ? makes variable nullable
string lastName = string.Empty;  // not nullable
int age;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue; // M or F, one character
bool working; // defaults to false if not initialized

// Prompt user for input
Console.Write("Enter your first name: ");
firstName = Console.ReadLine();
Console.Write("Enter your lastt name: ");
lastName = Console.ReadLine();  // Warning varible might be null

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

int workingYearsRemaining = retirementAge - age;

// Display the collected information
Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
Console.WriteLine($"You will retire in {workingYearsRemaining} years.");
Console.WriteLine($"Your salary is {salary:C}.");
Console.WriteLine($"Your gender is {gender}.");
Console.WriteLine($"Are you working? {working}.");

