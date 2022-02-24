using System;

namespace AddTwoInts
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for two numbers
            Console.Write("Enter first number: ");
            string firstInput = Console.ReadLine();
            Console.Write("Enter second number: ");
            string secondInput = Console.ReadLine();

            // parse ints from input
            int firstNumber = int.Parse(firstInput);
            int secondNumber = int.Parse(secondInput);
            // calculate sum
            int result = firstNumber + secondNumber;

            // print result
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        }
    }
}
