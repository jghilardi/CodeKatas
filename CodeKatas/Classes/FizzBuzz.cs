using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class FizzBuzz
    {
        public static void GetFizzBuzz()
        {
            for (int i = 0; i <= 100; i++)
            {
                var fizz = i % 3 == 0;
                var buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
            }       
        }
    }
}
