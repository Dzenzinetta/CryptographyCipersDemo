using ChipersUtility;

namespace ChiperAffine
{



 //   class ChiperAffine
 //   {
	//	private AffineKeyBase _additiveKeyObject;
	//	private AffineKeyBase _multiplicativeKeyObject;

	//	private IAffineBaseModel _affine;
	//	private IInputFromConsole _inputFromConsole;

 //       public ChiperAffine()
 //       {
	//		_inputFromConsole = UtilityControl.CreateInputFromConsole();
	//		_additiveKeyObject = new AdditiveKey();
	//		_multiplicativeKeyObject = new MultiplicativeKey();
	//		_affine = new AffineBaseModel();
	//	}

	//	public void ChiperAffineEncryption()
	//	{
	//		Console.Clear();
	//		Console.WriteLine($"Алгоритм шифрования Аффинным шифром");
	//		GetPropertiesForAffineChiper();
	//		Console.WriteLine($"Номер (по алфавиту) буквы зашифрованного слова: ");

	//		AffineCryptographyTypeBase encryptionObject = new AffineEncryptor(_affine);

	//		Console.WriteLine($"\nРезультат: { encryptionObject.AffineChiperProcess() }");
	//	}

	//	public void ChiperAffineDecryption()
	//	{
	//		Console.Clear();
	//		Console.WriteLine($"Алгоритм deшифрования Аффинным шифром");
	//		GetPropertiesForAffineChiper();
	//		Console.WriteLine($"Номер (по алфавиту) буквы расшифрованного слова: ");

	//		GetInverseKey();
	//		AffineCryptographyTypeBase decryptionObject = new AffineDecryptor(_affine);

	//		Console.WriteLine($"\nРезультат: { decryptionObject.AffineChiperProcess() }");
	//	}


	//	private void GetPropertiesForAffineChiper()
	//	{
	//		_affine.TextFromConsole	= _inputFromConsole.GetStringInputFromConsole("Введите слово, с которым будете работать");
	//		_affine.AddictiveKey = _additiveKeyObject.KeyProcess();
	//		_affine.MultiplicativeKey = _multiplicativeKeyObject.KeyProcess();
	//	}

	//	private void GetInverseKey()
	//	{
	//		for (int i = 0; i < Utility.AlphabetLength; i++)
	//			if ((_affine.MultiplicativeKey * i % Utility.AlphabetLength) == 1)
	//				_affine.MultiplicativeKey = i;	
	//	}

	//}



}
