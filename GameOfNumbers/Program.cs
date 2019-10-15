using System;

namespace GameOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());

			int magicalNumber = int.Parse(Console.ReadLine());

			int sum = 0;
			int counter = 0;
			for (int i = secondNumber; i >= firstNumber; i--)
			{
				for (int j = secondNumber; j >= firstNumber; j--)
				{
					sum = i + j;
					
					if (sum == magicalNumber)
					{
						Console.WriteLine($"Number found! {i} + {j} = {sum}");
						return;
					}
					counter++;
				}
			}

			Console.WriteLine($"{counter} combinations - neither equals {magicalNumber} ");

		}
	}
}
