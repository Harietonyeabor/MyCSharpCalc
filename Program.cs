using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Thank you for using my Calculator!");

        // Ask for first number
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        // Ask for second number
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        // Ask for operator
        Console.Write("Enter an operator (+, -, *, /, %): ");
        string op = Console.ReadLine();

        double result = 0;

        // Perform calculation without methods
        if (op == "+")
        {
            result = num1 + num2;
        }
        else if (op == "-")
        {
            result = num1 - num2;
        }
        else if (op == "*")
        {
            result = num1 * num2;
        }
        else if (op == "/")
        {
            result = num1 / num2;
        }
        else if (op == "%")
        {
            result = num1 % num2;
        }
        else
        {
            Console.WriteLine("Invalid operator! Please try again.");
            return; // exit program
        }

        Console.WriteLine($"The result is: {result}");
    }
}
