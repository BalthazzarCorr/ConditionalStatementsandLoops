using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double with = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double sum = with * height;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
