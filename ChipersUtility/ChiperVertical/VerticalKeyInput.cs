using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtypto_update
{
	class VerticalKeyInput
	{
		private int _allowedLengthForVerticalChiper;
		private string _titleForInput = @"Rules for this key:
											1. No Duplicates.
											2. Single element couldn't exceed allowed length of the key
											3. Key couldn't contain zero";

		public VerticalKeyInput(int length)
		{
			_allowedLengthForVerticalChiper = length;
		}

		public int[] GetVerticalKeyFromConsole()
		{
			VerticalKeyValidator keyValidation = new VerticalKeyValidator(_allowedLengthForVerticalChiper);
			Other other = new Other();

			var verticalKeyFromConsole = new List<int>();
	
			Console.WriteLine($"{ _titleForInput }\n\n");

			for (int i = 0; i < _allowedLengthForVerticalChiper; i++)
			{
				do
				{
					string tmpTitle = $"Input {i + 1} - symbol from {_allowedLengthForVerticalChiper} and press Enter";
					verticalKeyFromConsole[i] = other.GetInputForInteger(tmpTitle);

				} while (keyValidation.IsKeyValid(verticalKeyFromConsole, verticalKeyFromConsole[i]) == false);
			}
			return verticalKeyFromConsole.ToArray();
		}
	}

}
