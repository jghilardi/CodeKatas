using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeKatas.Classes
{
    internal class MessageSplit
    {
        public static string GetMessageSplit(string message, int K)
        {
            var finalString = "...";
            if (message.Length < 501 && K > 2 && K < 501)
            {
                if (K >= message.Length)
                {
                    return message;
                }

                var cutoffMessage = message.Substring(0, message.Length - K).Trim();
                var charArray = cutoffMessage.Reverse().ToArray();
                var lastSpacePositionFromBack = 0;

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] == ' ')
                    {
                        lastSpacePositionFromBack = i;
                        break;
                    }
                }

                if (lastSpacePositionFromBack == 0)
                {
                    return finalString;
                }

                var newMessage = cutoffMessage.Substring(0, cutoffMessage.Length - lastSpacePositionFromBack);
                finalString = $"{newMessage}{finalString}";
            }

            return finalString;
        }
    }
}
