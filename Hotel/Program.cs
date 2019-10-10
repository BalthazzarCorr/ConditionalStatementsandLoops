using System;
namespace Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());


			switch (month)
			{
				case "May":
					if (count > 0 && count <= 7)
					{
						Console.WriteLine($"Studio: {50 * count:F2} lv.");
						Console.WriteLine($"Double: {65 * count:F2} lv.");
						Console.WriteLine($"Suite: {75 * count:F2} lv.");
					}
					else
					{
						Console.WriteLine($"Studio: {(50 * 0.95) * count:F2} lv.");
						Console.WriteLine($"Double: {65 * count:F2} lv.");
						Console.WriteLine($"Suite: {75 * count:F2} lv.");
					}

					break;
				case "October":
					if (count > 0 && count <= 7)
					{
						Console.WriteLine($"Studio: {50 * count:F2} lv.");
						Console.WriteLine($"Double: {65 * count:F2} lv.");
						Console.WriteLine($"Suite: {75 * count:F2} lv.");
					}
					else
					{
						if (count>7)
						{
							Console.WriteLine($"Studio: {((50 * 0.95) * count)-(50*0.95):F2} lv.");
						}
						Console.WriteLine($"Double: {65 * count:F2} lv.");
						Console.WriteLine($"Suite: {75 * count:F2} lv.");
					}

					break;
				case "June":
					if (count > 0 && count <= 14)
					{
						Console.WriteLine($"Studio: {60 * count:F2} lv.");
						Console.WriteLine($"Double: {72 * count:F2} lv.");
						Console.WriteLine($"Suite: {82 * count:F2} lv.");
					}
					else
					{
						Console.WriteLine($"Studio: {60 * count:F2} lv.");
						Console.WriteLine($"Double: {(72 * 0.9) * count:F2} lv.");
						Console.WriteLine($"Suite: {82 * count:F2} lv.");
					}

					break;
				case "September":
					if (count > 0 && count <= 14)
					{
						if (count>7)
						{
							Console.WriteLine($"Studio: {(60 * count)-60:F2} lv.");
						}
						Console.WriteLine($"Double: {72 * count:F2} lv.");
						Console.WriteLine($"Suite: {82 * count:F2} lv.");
					}
					else
					{
						Console.WriteLine($"Studio: {60 * count:F2} lv.");
						Console.WriteLine($"Double: {(72 * 0.9) * count:F2} lv.");
						Console.WriteLine($"Suite: {82 * count:F2} lv.");
					}

					break;
				case "July":
				case "August":
				case "December":
					if (count > 0 && count <= 14)
					{
						Console.WriteLine($"Studio: {68 * count:F2} lv.");
						Console.WriteLine($"Double: {77 * count:F2} lv.");
						Console.WriteLine($"Suite: {89 * count:F2} lv.");
					}
					else
					{
						Console.WriteLine($"Studio: {68 * count:F2} lv.");
						Console.WriteLine($"Double: {77 * count:F2} lv.");
						Console.WriteLine($"Suite: {(89*0.85) * count:F2} lv.");
					}

					break;
			}
		}
	}
}
