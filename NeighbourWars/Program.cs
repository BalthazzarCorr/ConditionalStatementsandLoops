using System;
using System.Diagnostics.Tracing;

namespace NeighbourWars
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputPesho = int.Parse(Console.ReadLine());

			int inputGosho = int.Parse(Console.ReadLine());

			const string peshosAttack = "Roundhouse kick";
			const string goshosAttack = "Thunderous fist";

			int goshosHealth = 100;
			int peshosHealt = 100;
			int counter = 0;


			while (goshosHealth > 0 && peshosHealt > 0)
			{
				counter++;

				if (counter % 2 == 1)
				{
					goshosHealth -= inputPesho;
					if (goshosHealth > 0)
					{
						Console.WriteLine($"Pesho used {peshosAttack} and reduced Gosho to {goshosHealth} health.");

					}
					
				}
				else
				{
					peshosHealt -= inputGosho;
					if (peshosHealt > 0)
					{
						Console.WriteLine($"Gosho used {goshosAttack} and reduced Pesho to {peshosHealt} health.");
					}
					

				}

				if ((counter % 3) == 0 && goshosHealth > 0 && peshosHealt > 0)
				{

					goshosHealth += 10;
					peshosHealt += 10;
				}





			}
			var output = goshosHealth > 0 ? "Gosho" : "Pesho";
			Console.WriteLine($"{output} won in {counter}th round.");

		}
	}
}
