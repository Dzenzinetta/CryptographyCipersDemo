using System;

namespace ChipersUtility
{
    public class InputFromConsole
    {
		private string _tmpInput = string.Empty;
		private readonly InputFromConsoleValidator _validator = new InputFromConsoleValidator();

		public string GetInputForString(string title)
		{
			do
			{
				Console.Write($"{ title }: ");
				_tmpInput = Console.ReadLine();
			} while (_validator.StringIputValidationPass(_tmpInput) == false);

			return _validator.RemoveSpace(_tmpInput.ToUpper());
		}

		public int GetInputForInteger(string title)
		{
			int output = 0;
			do
			{
				_tmpInput = GetInputForString(title);
				if (_validator.DigitalInputValidationPass(_tmpInput, out int result))
					output = result;
			} while (output == 0);

			return output;
		}

	}
}
