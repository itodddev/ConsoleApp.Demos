// Declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// Prompt user for input
Console.Write("Enter your name: ");
name = Console.ReadLine() ?? string.Empty;
Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Display the collected information
Console.WriteLine($"Hello, {name}. You are {age} years old.");
Console.WriteLine($"You will retire in {retirementAge - age} years.");

