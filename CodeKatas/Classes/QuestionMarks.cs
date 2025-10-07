using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Classes
{
    internal class QuestionMarks
    {
        public static string GetQuestionMarks(string input)
        {
            var charArray = input.ToCharArray();
            
            var numberOfQuestionMarks = 0;
            var numberOfMatches = 0;
            var numberOfFailures = 0;
            int? firstNumber = null;
            int? secondNumber = null;

            foreach (var item in charArray)
            {
                if (item == '?')
                {
                    numberOfQuestionMarks++;
                }

                else if (int.TryParse(item.ToString(), out var parsedItem)) 
                {
                    if (firstNumber == null)
                    {
                        numberOfQuestionMarks = 0;
                        firstNumber = parsedItem;
                    }
                    else
                    {
                        secondNumber = parsedItem;
                    }
                }

                if (secondNumber != null && firstNumber + secondNumber == 10)
                {
                    if (numberOfQuestionMarks == 3)
                    {
                        numberOfMatches++;
                    }
                    else
                    {
                        numberOfFailures++;
                    }                    
                    firstNumber = secondNumber;
                    secondNumber = null;
                    numberOfQuestionMarks = 0;
                }
            }

            if (numberOfMatches > 0 && numberOfFailures == 0)
            {
                return "true";
            }
            else 
            { 
                return "false"; 
            }
        }
    }
}
