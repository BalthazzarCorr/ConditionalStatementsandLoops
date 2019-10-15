using System;

namespace TestNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNUmber = int.Parse(Console.ReadLine());

			int secondNumber = int.Parse(Console.ReadLine());

			int maxSum = int.Parse(Console.ReadLine());
			var sum = 0;
			var count = 0;


			for (int i = firstNUmber; i >= 1; i--)
			{
				for (int j = 1; j <= secondNumber; j++)
				{
					sum = (i * j) * 3 + sum;
					count++;
					if (sum >= maxSum)
					{
						Console.WriteLine($"{count} combinations");
						Console.WriteLine($"Sum: {sum} >= {maxSum}");
						return;
					}


				}
				

			}

			Console.WriteLine($"{count} combinations");
			Console.WriteLine($"Sum: {sum}");

		}
	}
}
