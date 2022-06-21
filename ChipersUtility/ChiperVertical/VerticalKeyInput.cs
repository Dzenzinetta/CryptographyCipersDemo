using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility.ChiperVertical
{
	class VerticalKeyInput
	{
		private readonly Other _other = new Other();
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


		public int[] GetVerticalKeyFromConsole()
		{
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
					verticalKeyModel.SingleElementOfVerticalKey = _other.GetInputForInteger(tmpTitle);
					verticalKeyModel.VerticalKey[i] = verticalKeyModel.SingleElementOfVerticalKey;

					verticalKeyModel.VerticalKey.ForEach(Print);

				} while (_verticalKeyValidator.IsValidationFail(verticalKeyModel));
			}

			Console.WriteLine("Validation passed. Good Vertical Key!");
			return verticalKeyModel.VerticalKey.ToArray();
		}

		private void Print(int s)
		{
			Console.Write(s);
		}
	}

}
