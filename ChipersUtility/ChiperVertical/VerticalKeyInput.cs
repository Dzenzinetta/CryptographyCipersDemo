using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility
{
	class VerticalKeyInput
	{		
		private readonly VerticalKeyValidator _verticalKeyValidator = new VerticalKeyValidator();

		private const int MinimalLengthForDivider = 7;
		private readonly int _wordLength;

		private readonly string _titleForInput = "Rules for this key:" +
			"\n\t1. No Duplicates." +
			"\n\t2. Single element couldn't exceed allowed length of the key" +
			"\n\t3. Key couldn't contain zero";

		public VerticalKeyInput(int wordLength)
		{
			_wordLength = wordLength;
		}

		private int GetKeyLength()
		{
			double wordLengthRoot = Math.Sqrt(_wordLength);

			if (_wordLength <= MinimalLengthForDivider)
				return _wordLength;
			if (wordLengthRoot - (int)wordLengthRoot == 0.0)
				return (int)wordLengthRoot;
			return (int)wordLengthRoot + 1;
		}


		public List<int> GetVerticalKeyFromConsole()
		{
			InputFromConsole inputFromConsole = new InputFromConsole();
			VerticalKeyModel verticalKeyModel = new VerticalKeyModel
			{
				AllowedKeyLengthForVerticalChiper = GetKeyLength()
			};

			Console.WriteLine($"{ _titleForInput }\n\n");

			for (int i = 0; i < verticalKeyModel.AllowedKeyLengthForVerticalChiper; i++)
			{
				do
				{
					string tmpTitle = $"Input {i + 1} - symbol from {verticalKeyModel.AllowedKeyLengthForVerticalChiper} and press Enter";
					verticalKeyModel.SingleElementOfVerticalKey = inputFromConsole.GetInputForInteger(tmpTitle);
					verticalKeyModel.VerticalKey.Insert(i, verticalKeyModel.SingleElementOfVerticalKey);
					if (_verticalKeyValidator.IsValidationFail(verticalKeyModel))
						verticalKeyModel.VerticalKey.Remove(i);
					verticalKeyModel.VerticalKey.ForEach(Print);

				} while (_verticalKeyValidator.IsValidationFail(verticalKeyModel));
			}

			Console.WriteLine("Validation passed. Good Vertical Key!");
			return verticalKeyModel.VerticalKey;
		}

		private void Print(int s)
		{
			Console.Write(s);
		}
	}

}
