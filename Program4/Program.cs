using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter temprature in Celsius");
            double celsius = double.Parse(Console.ReadLine());

            double farenheit = (9 / 5) * celsius + 32;

            Console.WriteLine("{0:F2} celcius in farenheit is {1:F2}", celsius, farenheit);
        }
    }
}
