using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // get numbers from user
            Console.Write("Enter first real number: ");
            string firstInput = Console.ReadLine();
            Console.Write("Enter second real number: ");
            string secondInput = Console.ReadLine();

            // convert input to doubles
            double firstDouble = Convert.ToDouble(firstInput);
            double secondDouble = Convert.ToDouble(secondInput);

            // get value of firstDouble^secondDouble
            double result = Math.Pow(firstDouble, secondDouble);

            // print result
            Console.WriteLine($"{firstDouble}^({secondDouble}) = {result}");
        }
    }
}
