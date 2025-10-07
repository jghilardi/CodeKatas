using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Classes
{
    internal class MaxProfit
    {
        public static int GetMaxProfit(int[] A)
        {
            var response = 0;

            if (A.Length > 0)
            {
                var batchSize = 10000;
                var batchCount = A.Length < batchSize ? 1 : A.Length / batchSize;
                var batchStartPosition = 0;

                var highestProfitPerBatch = new List<int>();

                for (int i = 0; i < batchCount; i++) // batch count
                {
                    var batchProfits = new List<int>();

                    for (var x = batchStartPosition; x < A.Length; x++) // buy day
                    {
                        var buyDay = A[x];
                        var startPosition = x + 1;

                        for (var y = startPosition; y < A.Length; y++) // sell day
                        {
                            var sellDay = A[y];
                            var isProfit = buyDay < sellDay && buyDay != sellDay;

                            if (isProfit)
                            {
                                var profit = sellDay - buyDay;
                                batchProfits.Add(profit);
                            }
                            else
                            {
                                batchProfits.Add(0);
                            }
                        }
                    }

                    highestProfitPerBatch.Add(batchProfits.Max());
                    batchStartPosition += batchSize;
                }

                response = highestProfitPerBatch.Max();
            }

            return response;
        }
    }
}
