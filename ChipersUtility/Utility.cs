using System;

namespace ChipersUtility
{
	public class Utility
	{
		private string _alphabet;
		public const int AlphabetLength = 26;


		public string GetAlphabet()
		{
			for (char a = 'A'; a <= 'Z'; a++)
				_alphabet += a;
			return _alphabet;
		}

		public int TextToCode(char input)
		{
			for (int i = 0; i < AlphabetLength; i++)
				if (input == _alphabet[i])
					return i;
			return 0;
		}

		public char CodeToText(int input)
		{
			for (int i = 0; i < AlphabetLength; i++)
				if (input == i)
					return _alphabet[i];
			return '\0';
		}

		public void OutputStringSymbolBySymbol(string messageForOutput)
		{
			for (int i = 0; i < messageForOutput.Length; i++)
				Console.Write("{0, -3}", messageForOutput[i]);
		}
	}
}
