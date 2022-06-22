using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility
{
    public class InputFromConsoleValidator
    {
		private bool IsInputContainZero(string inputKey)
		{
			return (inputKey.Contains("0"));
		}

		public string RemoveSpace(string strInput)
		{
			string inputSpaceless = string.Empty;
			for (int i = 0; i < strInput.Length; i++)
				if (strInput[i] != ' ') inputSpaceless += strInput[i];
			return inputSpaceless;
		}

		public bool DigitalInputValidationPass(string input, out int result)
        {
            if (int.TryParse(input, out int tmpResult))
			{
				result = tmpResult;
				return true;	
			}
			Console.WriteLine("Error! Inputed key is not digital");
			result = 0;
			return false;
        }

		public bool StringIputValidationPass(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("Error! No input detected");
				return false;
			}
			if (IsInputContainZero(input))
			{
				Console.WriteLine("You input Zero (For cryptography zero key is not allowed!).\n\t Please, try again");
				return false;
			}
			return true;
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
	}
}
