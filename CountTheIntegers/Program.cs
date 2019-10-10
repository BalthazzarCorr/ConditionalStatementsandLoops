using System;
using System.Globalization;

namespace CountTheIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			var count = 0;
			bool input;
			int result = 0;
			input = int.TryParse(Console.ReadLine(), out result);
			while (input)
			{
				
				input = int.TryParse(Console.ReadLine(), out result);
				count++;

			} 

			Console.WriteLine(count);
		}
	}
}
