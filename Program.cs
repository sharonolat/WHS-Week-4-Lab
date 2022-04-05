// See https://aka.ms/new-console-template for more information
Console.WriteLine("This program returns True if the sum of two numbers is less than 100 and false other wise");
Console.WriteLine("Input first number:");
var first = Console.ReadLine();
Console.WriteLine("Input second number:");
var second = Console.ReadLine();
int num1 = Convert.ToInt32(first);
int num2 = Convert.ToInt32(second);
int sum = num1 + num2;
if(sum <= 100)
    {
        Console.WriteLine("True\n" + num1 + " + " + num2 + " = " + sum);
    }
else Console.WriteLine("False\n" + num1 + " + " + num2 + " = " + sum);