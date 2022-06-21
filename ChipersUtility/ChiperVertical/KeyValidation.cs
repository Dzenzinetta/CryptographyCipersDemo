using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtypto_update
{
    class VerticalKeyValidator
    {
		private int _allowedLengthForVerticalChiper;

		public VerticalKeyValidator(int allowedLength)
		{
			_allowedLengthForVerticalChiper = allowedLength;
		}

		public bool IsKeyValid(List<int> verticalKey, int symbolFromVerticalKey)
		{
            Console.WriteLine(KeyValidationMessage(verticalKey, symbolFromVerticalKey));
			return IsVerticalKeyPassesValidation(verticalKey, symbolFromVerticalKey);
		}

		private bool IsKeySymbolBiggerThanKeyLength(int keySymbol)
		{
			return keySymbol > _allowedLengthForVerticalChiper;
		}

		private bool IsKeyContainsRepeatedSymbols(List<int> verticalKey)
		{
			return verticalKey.ToArray().Length != verticalKey.ToArray().Distinct().Count();
		}

		private bool IsVerticalKeyPassesValidation(List<int> verticalKey, int symbolFromVerticalKey)
		{
			if (IsKeySymbolBiggerThanKeyLength(symbolFromVerticalKey))
				return false;
			if (IsKeyContainsRepeatedSymbols(verticalKey))
				return false;
			return true;
		}

		private string KeyValidationMessage(List<int> verticalKey, int symbolFromVerticalKey)
		{
			if (IsKeySymbolBiggerThanKeyLength(symbolFromVerticalKey))
				return $"Symbol \"{symbolFromVerticalKey}\" numerically greater than the length ({_allowedLengthForVerticalChiper}).\n\t Please, try again";

			if (IsKeyContainsRepeatedSymbols(verticalKey))
				return $"You input repeated symbol.\nFor this Chiper that's restricted.\n\t Please, try again";

			return "Validation passed. Good key!";
		}
		
	}
}
