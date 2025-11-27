using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my CLI Calculator!");
        Console.WriteLine("You can perform: +, -, *, /, %\n");

        // First number
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        double num1;
        while (!double.TryParse(input1, out num1))
        {
            Console.Write("Invalid number! Enter a valid first number: ");
            input1 = Console.ReadLine();
        }

        // Second number
        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();
        double num2;
        while (!double.TryParse(input2, out num2))
        {
            Console.Write("Invalid number! Enter a valid second number: ");
            input2 = Console.ReadLine();
        }

        // Operator
        Console.Write("Enter an operator (+, -, *, /, %): ");
        string op = Console.ReadLine();

        double result = 0;
        bool validOperator = true;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    validOperator = false;
                }
                break;
            case "%":
                if (num2 != 0)
                {
                    result = num1 % num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot find remainder with zero!");
                    validOperator = false;
                }
                break;
            default:
                Console.WriteLine("Invalid operator! Please use +, -, *, /, or %.");
                validOperator = false;
                break;
        }

        if (validOperator)
        {
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }
    }
}
