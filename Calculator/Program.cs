using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            int result = 0;
            Console.Write("Please enter a number that you would like to use in our calculator problem: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter a second number that you would like to use in our calculator problem: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to add, subtract, multiply or divide?");
            Console.Write("Please enter which operation you would like to perform, in word form here: ")

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }
    }
}
