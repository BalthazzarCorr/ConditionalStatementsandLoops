﻿using System;

namespace TriangleOfNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfRows = int.Parse(Console.ReadLine());

			for (int i = 1; i <= numberOfRows; i++)
			{
				for (int j = 1; j <=i; j ++)
				{
					Console.Write(i+" ");
				}

				Console.WriteLine();
			}
		}
	}
}
