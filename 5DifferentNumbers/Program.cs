using System;

namespace _5DifferentNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstNumber = int.Parse(Console.ReadLine());
			var secondNumber = int.Parse(Console.ReadLine());

			if (firstNumber >secondNumber)
			{
				for (int i = 1; i <= 5; i++)
				{
					Console.WriteLine(firstNumber++);
				}
			}
		}
	}
}
