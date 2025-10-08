using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Classes
{
    internal class PassingCars
    {
        public static int GetPassingCars(int[] A)
        {
            var overflow = 1000000000;
            var len = A.Length;
            var count = 0;
            var zeroes = 0;

            if (len > 1)
            {
                for (int i = 0; i < len; i++)
                {
                    if (A[i] == 0)
                    {
                        zeroes++;
                    }
                    else if (A[i] == 1 && zeroes > 0)
                    {
                        count += zeroes;
                    }
                    if (count > overflow)
                    {
                        return -1;
                    }
                } 
            }

            return count;
        }
    }
}
