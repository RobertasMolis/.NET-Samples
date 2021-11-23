// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace SimpleConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Data types

            int number = 5;

            var arrayOfInts = new List<int>{1, 2, 3, 4, 5};

            // Console comands

            Console.WriteLine("Enter your input");

            var consoleInput = Console.ReadLine();

            // Console.WriteLine(consoleInput);

            // String manipulation: 5 + 4, 4 - 5

            // split string to smaller strings by spaces
            var consoleElements = consoleInput.Split(" ");

            // for loop
            for (int i = 0; i < consoleElements.Length; i++)
            {
                Console.WriteLine(consoleElements[i]);
            }

            foreach (var consoleElement in consoleElements)
            {
                Console.WriteLine(consoleElement);
            }

            try
            {
                var firstInput = consoleElements[0];
                var mathOperator = consoleElements[1];
                var secondInput = consoleElements[2];

                var firstNumber = Convert.ToInt32(firstInput);
                var secondNumber = Convert.ToInt32(secondInput);

                // if statments
                if (mathOperator == "+")
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
                if (mathOperator == "-")
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }
            }
             catch (Exception ex)
            {
                Console.WriteLine("The input is incorectly formatted");
            }
        }
    }
}