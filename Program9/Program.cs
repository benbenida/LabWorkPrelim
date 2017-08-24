using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, result;
			Console.Write("Enter your number: ");
			num1 = int.Parse(Console.ReadLine());

			for (int i = 1; i <= 12; i++)
			{
				result = i * num1;
				Console.WriteLine("{0} x {1} = {2}", i, num1, result);
			}
		}
	}
}
