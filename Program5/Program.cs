using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the radius");
            double rad = double.Parse(Console.ReadLine());
            double area = Math.PI * (rad*rad);

            double circum = 2 * (Math.PI) * rad;

            Console.WriteLine("The area is {0:F2} and the circumference is {1:F2}", area, circum);
        }
    }
}
