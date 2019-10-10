using System;

namespace ChooseADrink
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputString = Console.ReadLine();

			switch (inputString)
			{
				case "Athlete":
					Console.WriteLine("Water");
					break;
				case "Businessman":
				case "Businesswoman":
					Console.WriteLine("Coffee");
					break;
				case "SoftUni Student":
					Console.WriteLine("Beer");
					break;
				default:
					Console.WriteLine("Tea");
					break;
			}
		}
	}
}
