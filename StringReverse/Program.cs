using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            Console.WriteLine("Insert a string:");
            string inp = Console.ReadLine();

            // create string with input contents reversed
            string reverse = "";
            for (int i = 0; i < inp.Length; i++)
            {
                reverse = inp[i] + reverse;
            }

            // print reversed string
            Console.WriteLine("Reversed input: " + reverse);
        }
    }
}
