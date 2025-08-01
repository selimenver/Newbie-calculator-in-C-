using System;
using System.Linq;

namespace Calculator;

public static class Program
{
    public static void Main()
    {
        double num1, num2, result;
        char op;
        Console.WriteLine("enter your first number: \n");

        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator. (Supported operators: +,-*,/): \n");

        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter your second number: \n");

        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"your result is: {result}");

                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"your result is: {result}");

                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"your result is: {result}");

                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("cannot divide by 0.");
                    break;
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"your result is: {result}");
                }
                break;
        }
    }
}
