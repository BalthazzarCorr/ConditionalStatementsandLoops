using System;

namespace CakeIngredients
{
	class Program
	{
		static void Main(string[] args)
		{
			var input  = Console.ReadLine();
			var count = 0;
			while (input != "Bake!" )
			{
				
				Console.WriteLine($"Adding ingredient {input}.");
				count++;
				input= Console.ReadLine();
			}

			Console.WriteLine($"Preparing cake with {count} ingredients.");
		}
	}
}
