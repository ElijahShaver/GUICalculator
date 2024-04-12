using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string operation;

            Console.Write("Basic Calculator Program\nEnter the first integer: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the operator: ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    c = a + b;
                    Console.WriteLine("The result is: " + c);
                    break;
                case "-":
                    c = a - b;
                    Console.WriteLine("The result is: " + c);
                    break;
                case "*":
                    c = a * b;
                    Console.WriteLine("The result is: " + c);
                    break;
                case "/":
                    if (a == 0 || b == 0)
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                    }

                    else
                    {
                        c = a / b;
                        Console.WriteLine("The result is: " + c);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}
