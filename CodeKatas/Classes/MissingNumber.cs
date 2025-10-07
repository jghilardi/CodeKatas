using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Classes
{
    internal class MissingNumber
    {
        public static int GetMissingNumber(int[] inputArray)
        {
            var response = 0;

            if (inputArray.Length > 1)
            {
                var orderedArray = inputArray.ToHashSet().OrderBy(x=>x).ToArray();

                for (int i = 0; i < orderedArray.Length - 1; i++)
                {
                    var expectedNextPosition = orderedArray[i] + 1;
                    var actualNextPosition = orderedArray[i + 1];

                    if (expectedNextPosition != actualNextPosition)
                    {
                        response = expectedNextPosition;
                        break;
                    }
                } 
            }

            return response;
        }
    }
}
