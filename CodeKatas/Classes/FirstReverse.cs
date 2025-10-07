using System.Text;

namespace TestConsoleApp.Classes
{
    internal class FirstReverse
    {
        public static string GetFirstReverse(string input)
        {
            var reversedInput = input.Reverse();

            var stringBuilder = new StringBuilder();

            foreach (var item in reversedInput)
            {
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }
    }
}
