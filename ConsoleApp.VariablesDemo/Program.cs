// See https://aka.ms/new-console-template for more information

// Different datatypes
/*
 * text - string
 * integers - int
 * decimal - float, double, decimal
 * logical - bool
 */

string name = "John Doe"; // string

Console.WriteLine("I am " + name); // String concatenation
Console.WriteLine("I am {0}", name); // String formatting
Console.WriteLine($"I am {name}"); // String interpolation
Console.WriteLine($"I am {name.ToUpper()}"); // String interpolation with method

int age = 56;

Console.WriteLine($"My age: {age}");

bool isRetired = false;

Console.WriteLine($"Is retired: {isRetired}");
