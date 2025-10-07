using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class TreeConstructor
    {
        public static string GetTreeConstructor(string[] inputStringArray)
        {
            var childNodesPerParent = new Dictionary<string, int>(); // key is parent, int is childCount

            foreach (var item in inputStringArray)
            {
                var parentChildPair = item.Split(',');
                var parent = parentChildPair[1];

                if (!childNodesPerParent.ContainsKey(parent))
                {
                    childNodesPerParent[parent] = 0;
                }

                childNodesPerParent[parent] = childNodesPerParent[parent] + 1;

                if (childNodesPerParent[parent] > 2)
                {
                    return "false";
                }
            }

            return "true";

            //public static string GetTreeConstructor(string[] strArr)
            //{
            //    var children = strArr.ToList().Select(i => i.Split(',')[0].Replace("(", string.Empty)).ToList();
            //    var parents = strArr.ToList().Select(i => i.Split(',')[1].Replace(")", string.Empty)).ToList();
            //    return children.Distinct().Count() == strArr.Count() &&
            //          !parents.GroupBy(p => p).Where(g => g.Count() > 2).Any() ? "true" : "false";
            //}
        }
    }
}
