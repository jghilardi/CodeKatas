using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Classes
{
    internal class FrogJump
    {
        public static int GetFrogJump(int firstPosition, int secondPosition, int jumpDistance)
        {
            var jumpCounter = 0;
            var allValuesPositive = firstPosition >= 0 && secondPosition > 0 && jumpDistance > 0;
            var validPositions = firstPosition <= secondPosition;

            if (allValuesPositive && validPositions)
            {
                var pastTheFinishLine = false;
                jumpCounter = 1;

                while (!pastTheFinishLine)
                {
                    if (firstPosition + (jumpDistance * jumpCounter) - secondPosition > 0)
                    {
                        pastTheFinishLine = true;
                    }
                    else
                    {
                        jumpCounter++;
                    }
                } 
            }

            return jumpCounter;
        }
    }
}
