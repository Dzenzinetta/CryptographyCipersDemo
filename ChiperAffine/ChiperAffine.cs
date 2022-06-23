using ChipersUtility;

namespace ChiperAffine
{
    class ChiperAffine
    {
		private ChiperAffineKeyBase _addictiveKeyObject;
		private ChiperAffineKeyBase _multiplicativeKeyObject;

		//private ChiperAffineManipulationBase _encryptionObject;
		//private ChiperAffineManipulationBase _decryptionObject;

		private IChiperAffineBaseModel _affine;
		private IInputFromConsole _inputFromConsole;

		private int addictiveKey, multiplicativeKey;
		string originalWord = string.Empty;

        public ChiperAffine()
        {
			_inputFromConsole = UtilityControl.CreateInputFromConsole();
			_addictiveKeyObject = new ChiperAffineAddictiveKey();
			_multiplicativeKeyObject = new ChiperAffineMultiplicativeKey();
			_affine = new ChiperAffineBaseModel();
		}

		public void ChiperAffineEncryption()
		{
			Console.Clear();
			Console.WriteLine($"Алгоритм шифрования Аффинным шифром");
			GetPropertiesForAffineChiper();
			Console.WriteLine($"Номер (по алфавиту) буквы зашифрованного слова: ");

			ChiperAffineManipulationBase encryptionObject = new ChiperAffineEncryptor(_affine);
			Console.WriteLine("\nРезультат: {0}", encryptionObject.AffineChiperProcess();
		}

		public void ChiperAffineDecryption()
		{
			Console.Clear();
			Console.WriteLine($"Алгоритм deшифрования Аффинным шифром");
			GetPropertiesForAffineChiper();
			Console.WriteLine($"Номер (по алфавиту) буквы расшифрованного слова: ");

			GetInverseKey();

			ChiperAffineManipulationBase decryptionObject = new ChiperAffineDecryptor(_affine);
			Console.WriteLine("\nРезультат: {0}", decryptionObject.AffineChiperProcess());
		}


		private void GetPropertiesForAffineChiper()
		{
			_affine.TextFromConsole	= _inputFromConsole.GetStringInputFromConsole("Введите слово, с которым будете работать");
			_affine.AddictiveKey = _addictiveKeyObject.KeyProcess("Input addictive key");
			_affine.MultiplicativeKey = _multiplicativeKeyObject.KeyProcess("Input multiplicative key");
		}

		private void GetInverseKey()
		{
			for (int i = 0; i < Utility.AlphabetLength; i++)
				if ((_affine.MultiplicativeKey * i % Utility.AlphabetLength) == 1)
					_affine.MultiplicativeKey = i;	
		}

		
		

	}
}
