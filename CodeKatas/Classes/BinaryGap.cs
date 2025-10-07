using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class BinaryGap
    {
        public static int GetBinaryGap(int number)
        {
            Console.WriteLine("number: " + number);
            var count = 0;
            var binary = Convert.ToString(number, 2);
            var gapList = new List<int>();

            foreach (var item in binary)
            {
                if (item.Equals('0'))
                {
                    count++;
                }
                else 
                {
                    gapList.Add(count);
                    count = 0;
                }
            }

            return gapList.Max();
        }
    }
}
