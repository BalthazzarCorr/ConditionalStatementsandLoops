using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfBeverage = Console.ReadLine();
            double volumeOfBeverage = (int.Parse(Console.ReadLine()));
            double energyOfBeveragePer100 = (double.Parse(Console.ReadLine()))/100;
            double sugarContentOfBeveragePer100 = double.Parse(Console.ReadLine())/100;

            double energyOfBottle = volumeOfBeverage * energyOfBeveragePer100;
            double sugarContentOfBottle = volumeOfBeverage * sugarContentOfBeveragePer100;

            Console.WriteLine($"{volumeOfBeverage}ml {nameOfBeverage}: \n{energyOfBottle}kcal, " +
                              $"{sugarContentOfBottle}g sugars");


        }
    }
}
