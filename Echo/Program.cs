using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a string:");
            string inp = Console.ReadLine();
            
            Console.WriteLine("You wrote " + inp);
        }
    }
}
