namespace CodeKatas.Classes
{
    internal class MessageSplit
    {
        public static string GetMessageSplit(string message, int K)
        {
            var ellipses = "...";
            var isValidMessage = message.Length < 501 && K > 2 && K < 501;

            if (isValidMessage)
            {
                return ellipses;
            }

            if (K >= message.Length)
            {
                return message;
            }

            var cutoffMessage = message[..^K].Trim();
            var reversedCharArray = cutoffMessage.Reverse().ToArray();
            var lastSpacePositionFromBack = 0;

            for (int i = 0; i < reversedCharArray.Length; i++)
            {
                if (reversedCharArray[i] == ' ')
                {
                    lastSpacePositionFromBack = i;
                    break;
                }
            }

            if (lastSpacePositionFromBack == 0)
            {
                return ellipses;
            }

            var newMessage = cutoffMessage[..^lastSpacePositionFromBack];

            return $"{newMessage}{ellipses}";            
        }
    }
}
