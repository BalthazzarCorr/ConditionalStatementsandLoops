using System;

namespace MagicLetter
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstChar = char.Parse(Console.ReadLine());
			char secondChar = char.Parse(Console.ReadLine());
			char charToAvoid = char.Parse(Console.ReadLine());

			for (char i = firstChar; i <= secondChar; i++)
			{
				for (char j = firstChar; j <= secondChar; j++)
				{
					for (char k = firstChar; k <= secondChar; k++)
					{
						if (i != charToAvoid && j != charToAvoid && k != charToAvoid)
						{
							Console.Write($"{i}{j}{k} ");
						}
					}
				}
			}

		}
	}
}
