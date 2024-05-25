// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Before swap:");
Console.WriteLine($"a = {a}, b = {b}");

// Swap logic
int temp = a;
a = b;
b = temp;

Console.WriteLine("After swap:");
Console.WriteLine($"a = {a}, b = {b}");
