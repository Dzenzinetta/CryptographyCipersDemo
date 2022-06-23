using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility.ChiperAffine
{
    class ChiperAffine
    {
		Other other = new Other();
		private int addictiveKey, multiplicativeKey;
		string originalWord = string.Empty;

		void AffineCryptoMain(bool isCripto)
		{

			Console.Clear();
			Console.WriteLine($"Алгоритм {(isCripto ? "шифрования" : "deшифрования")} Аффинным шифром");

			originalWord = other.TextBox("Введите слово, с которым будете работать");

			addictiveKey = AffineChiperKeyProcess(true);

			multiplicativeKey = AffineChiperKeyProcess(false);

			Console.WriteLine();
			Console.WriteLine($"Номер (по алфавиту) буквы {(isCripto ? "зашифрованного" : "расшифрованного")} слова: ");

			if (!isCripto)
				for (int i = 0; i < Other.AlphabetLength; i++)
					if ((multiplicativeKey * i % Other.AlphabetLength) == 1)
						multiplicativeKey = i;

			Console.WriteLine();
			Console.WriteLine("\nРезультат: {0}", AffineChiperProcess(isCripto));
		}

		string AffineChiperProcess(bool isCripto)
		{
			string wordAfterEncription = string.Empty;
			int wordCode, cryptedWordCode;
			for (int i = 0; i < originalWord.Length; i++)
			{
				wordCode = other.TextToCode(originalWord[i]);
				cryptedWordCode = isCripto ? AffineSymbolEncriptor(wordCode)
					: AffineSymbolDecriptor(wordCode);

				Console.Write("{0, -3}", cryptedWordCode);
				wordAfterEncription += other.CodeToText(cryptedWordCode);
			}
			Console.WriteLine();
			other.OutputStringSymbolBySymbol(wordAfterEncription);
			return wordAfterEncription;
		}

		int AffineSymbolEncriptor(int wordCode) => (multiplicativeKey * wordCode + addictiveKey) % Other.AlphabetLength;

		int AffineSymbolDecriptor(int wordCode)
		{
			if (wordCode >= addictiveKey)
				return ((wordCode - addictiveKey) * multiplicativeKey) % Other.AlphabetLength;
			return ((wordCode + Other.AlphabetLength - addictiveKey) * multiplicativeKey) % Other.AlphabetLength;
		}

		int AffineChiperKeyProcess(bool isAddictiveKey)
		{
			bool isKeyGood = false;
			int inputKey = 0;
			while (!isKeyGood)
			{
				inputKey = other.GetInputForInteger($"Введите {(isAddictiveKey ? "аддивный" : "мультипликативный")} ключ");

				while (inputKey < 0)
					inputKey += Other.AlphabetLength;
				isKeyGood = isAddictiveKey ?
					AddictiveKeyCheck(inputKey) : MultiplicativeKeyCheck(inputKey);

				if (!isKeyGood)
					Console.WriteLine("Invalid Key!");
			}
			return inputKey;
		}

		bool AddictiveKeyCheck(int addictiveKey)
		{
			if (addictiveKey % Other.AlphabetLength != 0)
				return true;
			return false;
		}

		bool MultiplicativeKeyCheck(int multiplicativeKey)
		{
			for (int j = 0; j < Other.AlphabetLength; j++)
				if ((multiplicativeKey * j) % Other.AlphabetLength == 1)
					return true;
			return false;
		}


	}
}
