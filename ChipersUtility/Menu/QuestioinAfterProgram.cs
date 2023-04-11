using System;
using System.Linq;

namespace ChipersUtility
{
    public static class QuestioinAfterProgram
    {
        private const string _questionPromt 
            = "Would you like to use this Ciper again?(Y\\N)";
        private static string _answer = String.Empty;

        public static bool RepeatProgram()
        {
            Console.WriteLine("This program is done.");
            do
            {
                _answer = InputFromConsole.GetString(_questionPromt);
            } while (DoesAnswerCorrect(_answer) != true);

            return ShouldRepeatProgram(_answer);
        }

        private static bool DoesAnswerCorrect(string input)
        {
                return input.Contains('Y') || input.Contains('N');
        }

        private static bool ShouldRepeatProgram(string condition)
        {
            return condition.Contains('Y');
        }
    }
}
