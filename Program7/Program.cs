using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number");
			int num = int.Parse(Console.ReadLine());
			int result = 0;

			for (int i = 1; i <= num; i++)
			{
				

				if ((i % 3 == 0) || (i % 5 == 0))
				{
					result += i;
				}

			}
			Console.WriteLine("The sum of the range that is divisible only by 3 and 5 is: {0}",result);
		}
	}
}
