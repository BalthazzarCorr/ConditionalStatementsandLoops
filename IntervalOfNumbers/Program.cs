using System;

namespace IntervalOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputOne = int.Parse(Console.ReadLine());
			int inputTwo = int.Parse(Console.ReadLine());

			if (inputOne>inputTwo)
			{
				for (int i = inputTwo; i <= inputOne; i++)
				{
					Console.WriteLine(i);
				}
			}

			if (inputTwo>inputOne)
			{
				for (int i = inputOne; i <= inputTwo; i++)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
