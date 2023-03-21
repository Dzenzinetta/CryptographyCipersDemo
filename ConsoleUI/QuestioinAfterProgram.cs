
using ChipersUtility;

namespace ConsoleUI
{
    public class QuestioinAfterProgram
    {
        private const string _question 
            = "Would you like to use this Ciper again or return to Main menu?(Y\\N)";
        private string _tmpInput;
        public bool Question()
        {
            Console.WriteLine("This program is done.");
            do
            {
                _tmpInput = InputFromConsole.GetString(_question);
            }while (QuestionValidation(_tmpInput) != true);

            return ShouldRepeatProgram(_tmpInput);
        }

        private bool QuestionValidation(string input)
        {
                return (input.Contains('Y') || input.Contains('N'));
        }

        private bool ShouldRepeatProgram(string condition)
        {
            return condition.Contains('Y');
        }
    }
}
