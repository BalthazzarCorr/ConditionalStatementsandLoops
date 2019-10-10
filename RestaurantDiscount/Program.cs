using System;

namespace RestaurantDiscount
{
	class Program
	{
		static void Main(string[] args)
		{
			var groupSize = int.Parse(Console.ReadLine());
			var package = Console.ReadLine();

			var priceOfSmallHall = 2500;
			var priceOfTerrace = 5000;
			var priceOfGreatHall = 7500;

			if (groupSize >= 1 && groupSize <= 50)
			{
				Console.WriteLine($"We can offer you the Small Hall");
				Console.WriteLine($"The price per person is {CalculatingDiscount(package, priceOfSmallHall) / groupSize:F2}$");

			}
			else if (groupSize > 51 && groupSize <= 100)
			{
				Console.WriteLine($"We can offer you the Terrace");
				Console.WriteLine($"The price per person is {CalculatingDiscount(package, priceOfTerrace) / groupSize:F2}$");
			}
			else if (groupSize>101 && groupSize<=120)
			{
				Console.WriteLine($"We can offer you the Great Hall");
				Console.WriteLine($"The price per person is {CalculatingDiscount(package, priceOfGreatHall) / groupSize:F2}$");
			}
			else
			{
				Console.WriteLine("We do not have an appropriate hall.");
			}
		}

		public static decimal CalculatingDiscount(string package, decimal priceOfHall)
		{
			decimal result = 0;
			switch (package)
			{
				case "Normal":
					priceOfHall += 500;
					result = Math.Abs((priceOfHall * 0.05m) - priceOfHall);

					break;
				case "Gold":
					priceOfHall += 750;
					result = Math.Abs((priceOfHall * 0.1m) - priceOfHall);
					break;
				case "Platinum":
					priceOfHall += 1000;
					result = Math.Abs((priceOfHall * 0.15m) - priceOfHall);
					break;

			}
			return result;
		}
	}
}
