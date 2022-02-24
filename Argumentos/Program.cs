using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < args.Length; i++) {
                Console.WriteLine(args[i]);
            }
        }
    }
}
