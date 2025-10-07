using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class RemoveChars
    {
        public static string GetRemoveChars(char[] charArray, string input) 
        {
            var hashSet = charArray.Select(x => x.ToString()).ToHashSet();
            var response = new StringBuilder(input);

            foreach (var item in hashSet)
            {
                response.Replace(item, string.Empty);
            }

            return response.ToString();
        }        
    }
}
