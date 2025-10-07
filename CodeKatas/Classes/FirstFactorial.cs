namespace TestConsoleApp.Classes
{
    internal class FirstFactorial
    {
        public static int GetFirstFactorial(int num)
        {
            var result = 1;

            for (int i = num; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
