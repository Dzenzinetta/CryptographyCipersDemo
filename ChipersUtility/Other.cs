using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtypto_update
{
	class Other
	{
		public string AlphabetStr { get; set; }
		public const int AlphabetLength = 26;

		public Other()
		{
			AlphabetStr = Alphabet();
		}

		public int TextToCode(char input)
		{
			for (int i = 0; i < AlphabetLength; i++)
				if (input == AlphabetStr[i])
					return i;
			return 0;
		}

		public char CodeToText(int input)
		{
			for (int i = 0; i < AlphabetLength; i++)
				if (input == i)
					return AlphabetStr[i];
			return '\0';
		}

		public string Alphabet()
		{
			for (char a = 'A'; a <= 'Z'; a++)
				AlphabetStr += a;
			return AlphabetStr;
		}

		string SpaceCheck(string strInput)
		{
			string inputSpaceless = string.Empty;
			for (int i = 0; i < strInput.Length; i++)
				if (strInput[i] != ' ') inputSpaceless += strInput[i];
			return inputSpaceless;
		}

		public void OutputStringSymbolBySymbol(string messageForOutput)
		{
			for (int i = 0; i < messageForOutput.Length; i++)
				Console.Write("{0, -3}", messageForOutput[i]);
		}

		public bool IsInputHaveRepeatedSymbol(string input, out int badSymbol)
		{
			for (int i = 0; i < input.Length; i++)
				for (int j = 0; j < input.Length; j++)
				{
					if (j == i)
						continue;
					if (input[j] == input[i])
					{
						badSymbol = input[j];
						return true;
					}
				}
			badSymbol = 0;
			return false;
		}

		bool IsInputContainZero(string inputKey)
		{
			if (inputKey.Contains("0"))
				return true;
			return false;
		}

		public string TextBox(string title)
		{
			string strInput = string.Empty;
			do
			{
				Console.Write("{0}: ", title);
				strInput = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(strInput))
					Console.WriteLine("Error! No input detected");
				if (IsInputContainZero(strInput))
					Console.WriteLine("You input Zero (For cryptography zero key is not allowed!).\n\t Please, try again");
			} while (string.IsNullOrWhiteSpace(strInput) && IsInputContainZero(strInput));
			return SpaceCheck(strInput.ToUpper());
		}

		public int GetInputForInteger(string title)
		{
			string strInput = string.Empty;
			do
			{
				strInput = TextBox(title);
				if (int.TryParse(strInput, out int result))
					return result;
				Console.WriteLine("Error! Inputed key is not digital");
			} while (!int.TryParse(strInput, out int nonUsednteger));

			return 0;
		}

	}
}
