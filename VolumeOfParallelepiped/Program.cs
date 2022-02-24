using System;

namespace VolumeOfParallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            // get parameters from user
            Console.Write("Enter length: ");
            string lengthStr = Console.ReadLine();
            Console.Write("Enter height: ");
            string heightStr = Console.ReadLine();
            Console.Write("Enter width: ");
            string widthStr = Console.ReadLine();

            // convert input to floats
            float length = Convert.ToSingle(lengthStr);
            float height = Convert.ToSingle(heightStr);
            float width = Convert.ToSingle(widthStr);

            // calculate volume
            float volume = length * width * height;

            // print result
            Console.WriteLine($"Volume = {volume}");
        }
    }
}
