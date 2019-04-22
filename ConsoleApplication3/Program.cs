using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Program
	{ 
		// Third commit 3
		static readonly List<char> Alphabet = new List<char>() { 'а', 'б', 'в', 'г', 'г', 'д', 'е', 'є', 'ж', 'з', 'и', 'і', 'ї', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я' };

		static void Main(string[] args)
		{
			Console.WriteLine(Alphabet.Count);
			Console.Write("Enter encrypted word: ");
			string enword = Console.ReadLine();
			if (enword.Length != 0)
			{
				for (int i = 1; i < 33; i++)
				{
					string deword = "";
					foreach (char c in enword)
					{
						if (Alphabet.Contains(c))
						{
							deword += Alphabet[(Alphabet.IndexOf(c) + i) % Alphabet.Count];
						}
						else
						{
							deword += "!";
						}
					}
					Console.WriteLine("+{0}: {1}", i, deword);
				}
			}


			Console.ReadKey();
		}
	}
}
