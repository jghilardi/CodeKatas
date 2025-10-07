using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class LonelyIntArray
    {
        public static int GetLonelyIntArray(int[] inputArray)
        {
            try
            {
                var lonelyIntDictionary = new Dictionary<int, int>();

                foreach (var arrayItem in inputArray)
                {
                    var dictionaryItemExists = lonelyIntDictionary.ContainsKey(arrayItem);

                    if (dictionaryItemExists)
                    {
                        lonelyIntDictionary.TryGetValue(arrayItem, out var currentValue);
                        lonelyIntDictionary[arrayItem] = currentValue = currentValue + 1;
                    }
                    else
                    {
                        lonelyIntDictionary.Add(arrayItem, 1);
                    }
                }
                var response = lonelyIntDictionary.OrderBy(x=>x.Value).First().Key;
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
