namespace TestConsoleApp.Classes
{
    internal class Intersection
    {
        public static string GetIntersection(string[] stringArray)
        {
            var response = "false";
            var intersections = new List<string>();
            var firstList = stringArray[0].Split(',').ToList();
            var secondList = stringArray[1].Split(',').ToList();

            foreach (var item in firstList)
            {
                if (secondList.Contains(item))
                {
                    intersections.Add(item);
                }
            }

            if (intersections.Count != 0)
            {
                response = string.Join(",", intersections.Select(x => x));
            }

            return response;
        }
    }
}
