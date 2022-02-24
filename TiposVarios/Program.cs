using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // integers
            int intA = 9;
            int intB = 14;
            int intC = 1024;

            Console.WriteLine($"Integers: {intA}, {intB}, {intC}");


            // chars
            char letterA = 'A';
            char omega = '\u03a9';
            char arrow = '\u2192';

            Console.WriteLine($"Chars: {letterA}, {omega}, {arrow}");


            // floats
            float pi = 3.14f;
            float floatA = 123.45f;
            float floatB = 100.001f;

            Console.WriteLine($"Floats: {pi}, {floatA}, {floatB}");


            // booleans
            bool t = true;
            bool f = false;

            Console.WriteLine($"Bools: {t}, {f}");
        }
    }
}
