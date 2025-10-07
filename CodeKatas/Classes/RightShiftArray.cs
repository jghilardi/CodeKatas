using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class RightShiftArray
    {
        public static int[] GetRightShiftArray(int[] inputArray, int shiftCounter)
        {
            int[] response = [];

            if (inputArray.Length > 0 && shiftCounter > 0)
            {
                var passedFirstLoop = false;
                var finalPositions = new Dictionary<int, int[]>();

                for (int i = 0; i < shiftCounter; i++)
                {
                    var positionCache = new Dictionary<int, int>();
                    int[] arrayToUse;

                    if (!passedFirstLoop) // choose which array to use, inputArray or rightShiftedArray from previous iteration
                    {
                        passedFirstLoop = true;
                        arrayToUse = inputArray;
                    }
                    else // use most recent array from finalPositions
                    {
                        arrayToUse = finalPositions.OrderByDescending(x => x.Key).First().Value;
                    }

                    for (int x = 0; x < arrayToUse.Length; x++)
                    {
                        if (x < arrayToUse.Length - 1)
                        {
                            positionCache.Add(x + 1, arrayToUse[x]);
                        }
                        else
                        {
                            positionCache.Add(0, arrayToUse[x]);
                        }
                    }

                    finalPositions.Add(i, [.. positionCache.OrderBy(x => x.Key).Select(x => x.Value)]);
                }

                response = finalPositions.OrderByDescending(x => x.Key).FirstOrDefault().Value; 
            }
           
            return response;
        }
    }
}
