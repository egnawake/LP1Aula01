using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello world!";
            Console.WriteLine(hello);
            
            string tabs = "One\tTwo\tThree";
            Console.WriteLine(tabs);

            string newline = "This string has\na newline";
            Console.WriteLine(newline);

            string unicode = "\u2153 \u3042 \u232b";
            Console.WriteLine(unicode);

            string quotes = "\"Escaped quotes\"";
            Console.WriteLine(quotes);

            string verbatim = @"\n \t \u0101";
            Console.WriteLine(verbatim);


            string concat1 = "abc" + "def";
            Console.WriteLine(concat1);

            string concat2 = 2 + " + " + 5 + " = " + 7;
            Console.WriteLine(concat2);

            int x = 4;
            int y = 10;
            string interpolation1 = $"{x} - {y} = {x - y}";
            Console.WriteLine(interpolation1);

            string interpolation2 = String.Format("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine(interpolation2);

            Console.WriteLine("{0}^2 = {1}", x, x * x);
        }
    }
}
