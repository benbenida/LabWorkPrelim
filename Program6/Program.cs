using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
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
                result += i;

            }
			Console.WriteLine("The sum of 1 to {0} is {1}",num,result);

		}
	}
}
