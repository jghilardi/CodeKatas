using System.Text.RegularExpressions;

namespace TestConsoleApp.Classes
{
    internal class LongestWord
    {
        public static string GetLongestWord(string sentence)
        {
            var wordList = new List<string>();

            foreach (var word in sentence.Split(' '))
            {
                var sanitizedWord = Regex.Replace(word, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
                wordList.Add(sanitizedWord);
            }
            return wordList.OrderByDescending(x => x.Length).First();
        }
    }
}
