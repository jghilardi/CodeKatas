using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeKatas.Classes
{
    internal class MaxProfit
    {
        public static int GetMaxProfit(int[] inputArray)
        {
            var maxProfit = 0;

            if (inputArray.Length > 0)
            {
                var minValue = inputArray[0];

                for (int i = 1; i < inputArray.Length; i++)
                {
                    minValue = Math.Min(minValue, inputArray[i]);
                    maxProfit = Math.Max(maxProfit, inputArray[i] - minValue);
                } 
            }

            return maxProfit;
        }
    }
}
