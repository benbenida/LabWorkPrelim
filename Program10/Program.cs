using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
	class Program
	{
		static void Main(string[] args)
		{

			for (int i = 1; i < 1000; i++)
			{
					if ((i % 1 == 0) && ((i % 2 != 0) || i == 2) && ((i % 3 != 0) || i == 3) && ((i % 5 != 0) || i == 5))
					{
					if (i != 1)
					{
						Console.WriteLine("{0}", i);
					}
						
					}
			}
		}
	}
}
