using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class TwoSum
    {
        public static string GetTwoSum(int[] array, int numberToMatch)
        {
            var dictionary = new Dictionary<int, int>();
            
            for (int i = 0; i < array.Length; i++) 
            {
                dictionary.Add(i, array[i]);
            };

            var copyDictionary = dictionary;

            foreach (var kvp in dictionary)
            {
                foreach (var copyKvp in copyDictionary)
                {
                    if (kvp.Key != copyKvp.Key && (kvp.Value + copyKvp.Value == numberToMatch))
                    {
                        return "true";
                    }
                }
            }

            return "false";
        }
    }
}
