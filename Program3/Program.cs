using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please kindly enter your name");
            String uName = Console.ReadLine();
            if ((uName=="Ryan")||(uName=="Alden"))
            {
                Console.WriteLine("Greetings {0}!", uName);
            }
            else
            {
                Console.WriteLine("Not greeted");
            }
            
        }
    }
}
