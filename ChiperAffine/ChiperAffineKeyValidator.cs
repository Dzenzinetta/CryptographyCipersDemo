using ChipersUtility;

namespace ChiperAffine
{
    public class ChiperAffineKeyValidator
    {
		private readonly InputFromConsole _inputFromConsole = new InputFromConsole();

		public int AffineChiperKeyProcess(bool isAddictiveKey)
		{
			 
			bool isKeyGood = false;
			int inputKey = 0;
			while (!isKeyGood)
			{
				inputKey = _inputFromConsole.GetInputForInteger($"Введите {(isAddictiveKey ? "аддивный" : "мультипликативный")} ключ");

				while (inputKey < 0)
					inputKey += Utility.AlphabetLength;
				isKeyGood = isAddictiveKey ?
					AddictiveKeyCheck(inputKey) : MultiplicativeKeyCheck(inputKey);

				if (!isKeyGood)
					Console.WriteLine("Invalid Key!");
			}
			return inputKey;
		}

		private int GetAddictiveKey()
		{ }
		private int GetMultiplicativeKey()
		{ }

		private bool AddictiveKeyCheck(int addictiveKey)
		{
			return (addictiveKey % Utility.AlphabetLength) != 0;
		}

		private bool MultiplicativeKeyCheck(int multiplicativeKey)
		{
			for (int j = 0; j < Utility.AlphabetLength; j++)
				if ((multiplicativeKey * j) % Utility.AlphabetLength == 1)
					return true;
			return false;
		}

	}
}
