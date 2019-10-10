using System;

namespace ChooseАDrink2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			var profession = Console.ReadLine();
			var quantity = int.Parse(Console.ReadLine());

			var water = 0.70;
			var coffee = 1.00;
			var beer = 1.70;
			var tea = 1.20;

			if (profession == "Athlete")
			{
				Console.WriteLine($"The Athlete has to pay {quantity*water:F2}.");
			}
			else if (profession == "SoftUni Student")
			{
				Console.WriteLine($"The SoftUni Student has to pay {quantity * beer:F2}.");
			}
			else if (profession == "Businessman" || profession == "Businesswoman")
			{
				Console.WriteLine($"The {profession} has to pay {quantity * coffee:F2}.");
			}
			else 
			{
				Console.WriteLine($"The {profession} has to pay {quantity*tea:F2}.");	
			}
			

		}
	}
}
