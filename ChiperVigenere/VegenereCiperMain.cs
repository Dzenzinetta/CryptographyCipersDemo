using ChipersUtility;

namespace VegenereCiper
{
	public class VegenereCiperMain
	{
		private IInputFromConsole _consoleInput = UtilityControl.CreateInputFromConsole();
		//Other other = new Other();
		int intWordCode,
			intKeyCode;

		public void VegenereCryptoMain(bool isCripto)
		{
			Console.Clear();
			Console.WriteLine("Алгоритм {0} шифром Виженера",
				isCripto ? "шифрования" : "deшифрования");
			Console.WriteLine();
			VigenereChiperProcess(isCripto);
			Console.WriteLine();
			Console.ReadKey();
		}

		private void VigenereChiperProcess(bool isCripto)
		{

			string strEncryptedWord = string.Empty,
				strKeyInput,
				strOriginWordInput;

			strOriginWordInput = _consoleInput.GetStringInputFromConsole("Введите слово, которое хотите зашифровать");
			strKeyInput = _consoleInput.GetStringInputFromConsole("Введите ключ");

			Console.WriteLine("Номер (по алфавиту) {0} буквы вашего слова",
				isCripto ? "зашифрованной" : "расшифрованной");
			Console.Write("\t\t");
			for (int i = 0, z = 0; i < strOriginWordInput.Length; i++, z++)
			{
				intWordCode = Utility.TextToCode(strOriginWordInput[i]);
				if (z == strKeyInput.Length)
					z = 0;
				intKeyCode = Utility.TextToCode(strKeyInput[z]);
				intWordCode = isCripto ? VigenereChiperCryptionProcess() :
					VigenereChiperDecryptionProcess();
				Console.Write("{0, -3}", intWordCode);
				strEncryptedWord += Utility.CodeToText(intWordCode);
			}
			Console.Write("\nРезультат:\t");
			for (int i = 0; i < strEncryptedWord.Length; i++)
				Console.Write("{0, -3}", strEncryptedWord[i]);
		}

		private int VigenereChiperCryptionProcess()
		{
			return (intWordCode + intKeyCode) % Utility.AlphabetLength;
		}

		private int VigenereChiperDecryptionProcess()
		{
			return (intWordCode + Utility.AlphabetLength - intKeyCode) % Utility.AlphabetLength;
		}

		public void VegenereTableOutput()
		{
			string alphabetStrLower = Utility.GetAlphabet().ToLower();
			Console.Clear();
			Console.Write("   ");
			for (int i = 0; i < Utility.AlphabetLength; i++)
				Console.Write("{0, -2}", Utility.GetAlphabet()[i]);
			Console.WriteLine();
			for (int i = 0, k = 0; i < Utility.AlphabetLength; i++, k++)
			{
				Console.Write("{0, -2}|", Utility.GetAlphabet()[i]);
				for (int j = 0; j < Utility.AlphabetLength; j++)
				{
					int positionShift = j + k;
					if (j + k > 25)
						positionShift %= Utility.AlphabetLength;
					Console.Write("{0, -2}", alphabetStrLower[positionShift]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
