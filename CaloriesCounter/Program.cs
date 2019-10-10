using System;

namespace CaloriesCounter
{
	class Program
	{
		static void Main(string[] args)
		{
			int nLines = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
			var cheese = 500;
			var tomatoSauce = 150;
			var salami = 600;
			var pepper = 50;
			var sum = 0;
			for (int i = 0; i < nLines; i++)
			{
				var ingredient = Console.ReadLine().ToLower();
				if (ingredient == "cheese")
				{
					sum += cheese;
				}

				if (ingredient == "tomato sauce")
				{
					sum += tomatoSauce;

				}

				if (ingredient == "salami")
				{
					sum += salami;
				}

				if (ingredient == "pepper")
				{
					sum += pepper;
				}
			}

			Console.WriteLine($"Total calories: {sum}");


		}
	}
}
