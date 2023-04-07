using System;

namespace ChipersUtility
{
	public static class TextManipulator
	{
		private static string _alphabet;
		public const int AlphabetLength = 26;

		public static void ResetCursorVisible()
		{
			Console.CursorVisible = Console.CursorVisible != true;
		}

		public static string GetAlphabet()
		{
			for (char a = 'A'; a <= 'Z'; a++)
				_alphabet += a;
			return _alphabet;
		}

		public static int TextToCode(char input)
		{
			for (int i = 0; i < AlphabetLength; i++)
				if (input == GetAlphabet()[i])
					return i;
			return 0;
		}

		public static char CodeToText(int input)
		{
			for (int i = 0; i < AlphabetLength; i++)
				if (input == i)
					return GetAlphabet()[i];
			return '\0';
		}

		public static void OutputStringSymbolBySymbol(string messageForOutput)
		{
			for (int i = 0; i < messageForOutput.Length; i++)
				Console.Write("{0, -3}", messageForOutput[i]);
            Console.WriteLine();
		}

        public static void MessageOutput(string msg)
        {
            Console.WriteLine(msg);
        }

		public static void ClearAndReturnLine(int lineNumber)
		{
            Console.SetCursorPosition(0, Console.CursorTop - lineNumber);
            for (int i = 0; i < lineNumber; i++)
                Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - lineNumber);
		}

    }
}
