using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 0, i = 0, guess, tries = 0, guess2 = 0;
			Random rnd = new Random();
			int ranNum = rnd.Next(1,50);

			do
			{
				Console.Write("Enter your guess: ");
				guess = int.Parse(Console.ReadLine());
				

				if (guess == ranNum)
				{
					Console.WriteLine("Congratulations! You are Correct! You have tried {0} time(s)", tries);
					i++;
				}
				else if (guess > ranNum)
				{
					Console.WriteLine("Make your number lower");
					if (guess2 != guess)
					{
						tries++;
					}
				}
				else if (guess < ranNum)
				{
					Console.WriteLine("Make your number higher");
					if (guess2 != guess)
					{
						tries++;
					}
				}
				guess2 = guess;
			} while (i == 0);
		}
	}
}
