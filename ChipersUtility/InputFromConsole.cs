using System;
using static ChipersUtility.InputFromConsoleValidator;

namespace ChipersUtility
{
    public static class InputFromConsole// : IInputFromConsole
    {
        //private string _tmpInput = string.Empty;
     
        public static string GetStringInputFromConsole(string message)
        {
            string tmpInput = string.Empty;
            do
            {
                Console.Write($"{message}: ");
                tmpInput = Console.ReadLine();
            } while (StringIputValidationPass(tmpInput) == false);

            return RemoveSpace(tmpInput.ToUpper());
        }

        public static int GetIntegerInputFromConsole(string message)
        {
            string tmpInput = string.Empty;
            int output = 0;
            do
            {
                tmpInput = GetStringInputFromConsole(message);
                if (DigitalInputValidationPass(tmpInput, out int result))
                    output = result;
            } while (output == 0);

            return output;
        }

    }
}
