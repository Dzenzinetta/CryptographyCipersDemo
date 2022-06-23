using System;
using System.Collections.Generic;
using System.Linq;
using ChipersUtility;

namespace ChiperAffine
{
    public abstract class ChiperAffineKeyBase
    {
		private readonly IInputFromConsole _inputFromConsole;
		private bool _isKeyValid;

        public ChiperAffineKeyBase()
        {
            _inputFromConsole = UtilityControl.CreateInputFromConsole();
        }

        public int KeyProcess(string title)
        {
			int inputKey;
			do
			{
				inputKey = _inputFromConsole.GetIntegerInputFromConsole(title);

				while (inputKey < 0)
					inputKey += Utility.AlphabetLength;
				if (IsKeyValid(inputKey) == false)
					Console.WriteLine("Invalid Key!");

			} while (_isKeyValid);

			return inputKey;
		}
		
		public abstract bool IsKeyValid(int inputedKey);

    }
}
