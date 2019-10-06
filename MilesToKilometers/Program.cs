using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double oneMile = 1.60934;

            double kilometers = miles * oneMile;

            Console.WriteLine($"{kilometers:f2}");


        }
    }
}
