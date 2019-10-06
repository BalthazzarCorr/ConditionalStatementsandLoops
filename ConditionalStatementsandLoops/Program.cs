using System;

namespace ConditionalStatementsandLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSetOfNumbers = int.Parse(Console.ReadLine());
            int secondSetOfNumbers = int.Parse(Console.ReadLine());
            int thirdSetOfNumbers = int.Parse(Console.ReadLine());
            int forthSetOfNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstSetOfNumbers:D4} {secondSetOfNumbers:D4} {thirdSetOfNumbers:D4} {forthSetOfNumbers:D4}");

        }
    }
}
