using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Please enter a year: ");
            int yearInput = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 20; i++)
            {
                if ((yearInput % 4 == 0) && (yearInput % 100 != 0))
                {
                    Console.WriteLine(yearInput);
                }
                yearInput++;
            }
		}
	}
}
