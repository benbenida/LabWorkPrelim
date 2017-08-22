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
                result = i + num;
				if ((result % 3 == 0)||(result % 5 == 0))
				{
					Console.WriteLine("{0}", result);
				}
                
            }
    }
}
