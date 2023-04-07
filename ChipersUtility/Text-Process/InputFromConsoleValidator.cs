using System;
using System.Linq;

namespace ChipersUtility
{
    public static class InputFromConsoleValidator
    {
		

		public static string RemoveSpace(string input)
		{
			string inputSpaceless = string.Empty;
			for (int i = 0; i < input.Length; i++)
			{
                if (input[i] != ' ')
				{
                    inputSpaceless += input[i];
                }
            }
            return inputSpaceless;
		}

		public static string RemoveSpacesLinq(string input)
		{
			return new string(input.Where(c => c!=' ').ToArray());
		}

		public static bool DigitalInputValidationPass(string input, out int result)
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

		public static bool StringIputValidationPass(string input)
		{
			if (String.IsNullOrWhiteSpace(input))
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

        public static bool IsInputHaveRepeatedSymbol(string input, out int badSymbol)
		{
			for (int i = 0; i < input.Length; i++)
			{
				for (int j = 0; j < input.Length; j++)
				{
					if (j == i)
					{
                        continue;
                    }
                    if (input[j] == input[i])
					{
						badSymbol = input[j];
						return true;
					}
				}
			}
			badSymbol = 0;
			return false;
		}

		private static bool IsInputContainZero(string inputKey)
		{
			return (inputKey.Contains("0"));
		}
	}
}
