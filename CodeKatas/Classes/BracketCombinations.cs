namespace TestConsoleApp.Classes
{
    internal class BracketCombinations
    {
        public static int GetBracketCombinations(int num)
        {
            var output = 0;

            if (num <= 1)
            {
                return 1;
            }

            for (int i = 0; i < num; i++)
            {
                output += GetBracketCombinations(i) * GetBracketCombinations(num - i - 1);
            }
            return output;
        }
    }
}
