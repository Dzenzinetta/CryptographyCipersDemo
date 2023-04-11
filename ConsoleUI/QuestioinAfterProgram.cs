//using ChipersUtility;

//namespace ConsoleUI
//{
//    public static class QuestioinAfterProgram
//    {
//        private const string _question 
//            = "Would you like to use this Ciper again or return to Main menu?(Y\\N)";
//        private static string _tmpInput = String.Empty;

//        public static bool Question()
//        {
//            Console.WriteLine("This program is done.");
//            do
//            {
//                _tmpInput = InputFromConsole.GetString(_question);
//            }while (QuestionValidation(_tmpInput) != true);

//            return ShouldRepeatProgram(_tmpInput);
//        }

//        private static bool QuestionValidation(string input)
//        {
//                return (input.Contains('Y') || input.Contains('N'));
//        }

//        private static bool ShouldRepeatProgram(string condition)
//        {
//            return condition.Contains('Y');
//        }
//    }
//}
