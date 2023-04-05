using ChipersUtility;
using System;
using System.Collections.Generic;

namespace VerticalShiftCiper
{
	public class VerticalKeyInput
	{
		private readonly VerticalKeyValidator _verticalKeyValidator;
		private readonly VerticalKeyModel _verticalKeyModel;

		private const int MinimalLengthForDivider = 7;
		private readonly int _wordLength;

		private readonly string _titleForInput = "Rules for this key:" +
			"\n\t1. No Duplicates." +
			"\n\t2. Single element couldn't exceed allowed length of the key" +
			"\n\t3. Key couldn't contain zero";

		public VerticalKeyInput(int wordLength)
		{
			_verticalKeyValidator = VerticalShiftCiperFactory.CreateVerticalKeyValidator();
			_wordLength = wordLength;
			_verticalKeyModel = CreateKeyModel();
		}

		public List<int> GetVerticalKeyFromConsole()
		{
			Console.WriteLine($"{ _titleForInput }\n\n");

			for (int i = 0; i < _verticalKeyModel.AllowedKeyLengthForVerticalCiper; i++)
			{
                Console.WriteLine();
				Console.WriteLine("Your key: {0}", String.Join(", ", _verticalKeyModel.VerticalKey));

                do
				{
					string tmpTitle = $"Input {i + 1} - symbol from {_verticalKeyModel.AllowedKeyLengthForVerticalCiper} and press Enter";

					_verticalKeyModel.SingleElementOfVerticalKey = InputFromConsole.GetInteger(tmpTitle);

					_verticalKeyModel.VerticalKey.Insert(i, _verticalKeyModel.SingleElementOfVerticalKey);

					TextManipulator.ClearAndReturnLine(4);
					if (_verticalKeyValidator.IsValidationFail(_verticalKeyModel))
					{
						TextManipulator.ClearAndReturnLine(1);
						Console.WriteLine(_verticalKeyValidator.GetErrorMessage());
						_verticalKeyModel.VerticalKey.RemoveAt(i);
					}

				} while (_verticalKeyValidator.IsNotValid);

			}

			Console.WriteLine("Validation passed. Good Vertical Key!");
			return _verticalKeyModel.VerticalKey;
		}

		private int GetKeyLength()
		{
			double wordLengthRoot = Math.Sqrt(_wordLength);

			if (_wordLength <= MinimalLengthForDivider)
			{
				return _wordLength;
			}
			if (wordLengthRoot - (int)wordLengthRoot == 0.0)
			{
				return (int)wordLengthRoot;
			}
			return (int)wordLengthRoot + 1;
		}

		private VerticalKeyModel CreateKeyModel()
		{
			return VerticalShiftCiperFactory.CreateVerticalKeyModel(GetKeyLength());
		}
	}

}
