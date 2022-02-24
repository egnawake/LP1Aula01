using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int intA = 9;
            int intB = 14;
            int intC = 1024;

            Console.WriteLine($"Integers: {intA}, {intB}, {intC}");


            char letterA = 'A';
            char omega = '\u03a9';
            char arrow = '\u2192';

            Console.WriteLine($"Chars: {letterA}, {omega}, {arrow}");


            float pi = 3.14f;
            float floatA = 123.45f;
            float floatB = 100.001f;

            Console.WriteLine($"Floats: {pi}, {floatA}, {floatB}");
        }
    }
}
