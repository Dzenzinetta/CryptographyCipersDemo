using System;
using static ChipersUtility.InputFromConsoleValidator;

namespace ChipersUtility
{
    public static class InputFromConsole // : ITextInput
    {
        private static string _tmpInput = string.Empty;
     
        public static string GetString(string message)
        {
            do
            {
                Console.Write($"{message}:\n> ");
                _tmpInput = Console.ReadLine();

            } while (StringIputValidationPass(_tmpInput) == false);

            return RemoveSpacesLinq(_tmpInput.ToUpper());
        }

        public static int GetInteger(string message)
        {
            int output = 0;
            do
            {
                _tmpInput = GetString(message);

                if (DigitalInputValidationPass(_tmpInput, out int result))
                {
                    output = result;
                }

            } while (output == 0);

            return output;
        }

    }
}
