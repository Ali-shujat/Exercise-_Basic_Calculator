using System;

namespace Basic_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
        //Exercise 1.Basic calculator
        //Write a basic calculator in C# to perform a basic operations. Ask the user for a number
        //and then ask the user if he / she want to addition, subtraction, multiplication and
        //division.And finally display the results to the user.
        //Input:
        // Enter first number: 5
        //Enter operation: +
        //Enter second number: 7
        //Output:  5 + 7 = 12
            var answer = 0;
            Console.WriteLine("Basic Calculator!");

            Console.WriteLine("Enter First Number :");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operation :");
            var operation = Console.ReadLine();

            Console.WriteLine("Enter Secound Number :");
            var num2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case "x":
                    answer = num1 * num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {answer}");
                    break;
                case "/":
                    answer = num1 / num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {answer}");
                    break;
                case "+":
                    answer = num1 + num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {answer}");
                    break;
                case "-":
                    answer = num1 - num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {answer}");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }


            Console.ReadKey();


        }
    }
}
