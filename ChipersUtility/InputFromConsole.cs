using System;
using static ChipersUtility.InputFromConsoleValidator;

namespace ChipersUtility
{
    public class InputFromConsole : IInputFromConsole
    {
        private string _tmpInput = string.Empty;
     
        public string GetStringInputFromConsole(string message)
        {
            do
            {
                Console.Write($"{message}: ");
                _tmpInput = Console.ReadLine();
            } while (StringIputValidationPass(_tmpInput) == false);

            return RemoveSpace(_tmpInput.ToUpper());
        }

        public int GetIntegerInputFromConsole(string message)
        {
            int output = 0;
            do
            {
                _tmpInput = GetStringInputFromConsole(message);
                if (DigitalInputValidationPass(_tmpInput, out int result))
                    output = result;
            } while (output == 0);

            return output;
        }

    }
}
