using ChipersUtility;

namespace ChiperAffine
{
    public class ChiperAffineKeyValidator
    {
		private readonly IInputFromConsole _inputFromConsole;
		private int _addictiveKey, _multiplicativeKey;

        public ChiperAffineKeyValidator()
        {
			_inputFromConsole = UtilityControl.CreateInputFromConsole();
		}

		private int AffineChiperKeyProcess(string title)
		{
			int inputKey;
			bool isKeyGood;
			do
			{
				inputKey = _inputFromConsole.GetIntegerInputFromConsole(title);

				while (inputKey < 0)
					inputKey += Utility.AlphabetLength;


				isKeyGood = isAddictiveKey ?
					AddictiveKeyCheck(inputKey) : MultiplicativeKeyCheck(inputKey);

				if (!isKeyGood)
					Console.WriteLine("Invalid Key!");
			} while (!isKeyGood);
			
			return inputKey;
		}

		private int GetAddictiveKey()
		{
			_addictiveKey = AffineChiperKeyProcess($"Введите аддивный ключ");

		}
		private int GetMultiplicativeKey()
		{
			_multiplicativeKey = AffineChiperKeyProcess($"Введите мультипликативный ключ");
		}

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
