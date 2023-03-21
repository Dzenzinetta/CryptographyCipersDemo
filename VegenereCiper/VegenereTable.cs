using ChipersUtility;

namespace VegenereCiper
{
    public static class VegenereTable
    {
		public static void VegenereTableOutput()
		{
			string alphabetStrLower = TextManipulator.GetAlphabet().ToLower();
			Console.Clear();
			Console.Write("   ");
			for (int i = 0; i < TextManipulator.AlphabetLength; i++)
			{
				Console.Write("{0, -2}", TextManipulator.GetAlphabet()[i]);
			}
			Console.WriteLine();
			for (int i = 0, k = 0; i < TextManipulator.AlphabetLength; i++, k++)
			{
				Console.Write("{0, -2}|", TextManipulator.GetAlphabet()[i]);
				for (int j = 0; j < TextManipulator.AlphabetLength; j++)
				{
					int positionShift = j + k;
					if (j + k > 25)
						positionShift %= TextManipulator.AlphabetLength;
					Console.Write("{0, -2}", alphabetStrLower[positionShift]);
				}
				Console.WriteLine();
			}
		}
    }
}
