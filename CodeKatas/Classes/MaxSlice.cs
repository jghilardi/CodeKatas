namespace CodeKatas.Classes
{
    internal class MaxSlice
    {
        public static int GetMaxSlice(int[] A)
        {
            var maxSum = 0;
            var maxValue = (0, 0);

            if (A.Length == 1)
            {
                maxSum = A[0];
                return maxSum;
            }
            if (A.Length == 0 || A.Length > 1000000)
            {
                return maxSum;
            }

            for (int i = 0; i < A.Length; i++)
            {
                var tempMax = Math.Max(maxValue.Item2, A[i]);

                if (tempMax > maxValue.Item2)
                {
                    maxValue = (i, Math.Max(maxValue.Item2, A[i]));
                }

                else if (i != maxValue.Item1)
                {
                    {
                        maxSum = Math.Max(maxSum, A[i] + maxValue.Item2);
                    }
                }
            }
            
            return maxSum;
        }
    }
}
