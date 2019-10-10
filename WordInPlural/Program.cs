using System;

namespace WordInPlural
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			//string neoWord = "";

			if (word != null && word.EndsWith("y"))
			{
				var result = word.Remove(word.Length - 1, 1) + "ies";
				Console.WriteLine(result);
			}
			else if (word != null && (word.EndsWith("o") || word.EndsWith("ch")||word.EndsWith("s") || word.EndsWith("sh")|| word.EndsWith("x")|| word.EndsWith("z")))
			{
				var result = word + "es";
				Console.WriteLine(result);
			}
			else
			{
				var result = word + "s";
				Console.WriteLine(result);
			}
		}
	}
}
