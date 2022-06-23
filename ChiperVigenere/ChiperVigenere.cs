using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtypto_update
{
	class ChiperVigenere
	{
		Other other = new Other();
		int intWordCode,
			intKeyCode;

		public void VigenereCryptoMain(bool isCripto)
		{
			Console.Clear();
			Console.WriteLine("Алгоритм {0} шифром Виженера",
				isCripto ? "шифрования" : "deшифрования");
			Console.WriteLine();
			VigenereChiperProcess(isCripto);
			Console.WriteLine();
		}

		void VigenereChiperProcess(bool isCripto)
		{

			string strEncryptedWord = string.Empty,
				strKeyInput,
				strOriginWordInput;

			strOriginWordInput = other.TextBox("Введите слово, которое хотите зашифровать");
			strKeyInput = other.TextBox("Введите ключ");

			Console.WriteLine("Номер (по алфавиту) {0} буквы вашего слова",
				isCripto ? "зашифрованной" : "расшифрованной");
			Console.Write("\t\t");
			for (int i = 0, z = 0; i < strOriginWordInput.Length; i++, z++)
			{
				intWordCode = other.TextToCode(strOriginWordInput[i]);
				if (z == strKeyInput.Length)
					z = 0;
				intKeyCode = other.TextToCode(strKeyInput[z]);
				intWordCode = isCripto ? VigenereChiperCryptionProcess() :
					VigenereChiperDecryptionProcess();
				Console.Write("{0, -3}", intWordCode);
				strEncryptedWord += other.CodeToText(intWordCode);
			}
			Console.Write("\nРезультат:\t");
			for (int i = 0; i < strEncryptedWord.Length; i++)
				Console.Write("{0, -3}", strEncryptedWord[i]);
		}

		int VigenereChiperCryptionProcess()
		{
			return (intWordCode + intKeyCode) % Other.AlphabetLength;
		}

		int VigenereChiperDecryptionProcess()
		{
			return (intWordCode + Other.AlphabetLength - intKeyCode) % Other.AlphabetLength;
		}

		public void VigenereTableOutput()
		{
			string alphabetStrLower = other.AlphabetStr.ToLower();
			Console.Clear();
			Console.Write("   ");
			for (int i = 0; i < Other.AlphabetLength; i++)
				Console.Write("{0, -2}", other.AlphabetStr[i]);
			Console.WriteLine();
			for (int i = 0, k = 0; i < Other.AlphabetLength; i++, k++)
			{
				Console.Write("{0, -2}|", other.AlphabetStr[i]);
				for (int j = 0; j < Other.AlphabetLength; j++)
				{
					int positionShift = j + k;
					if (j + k > 25)
						positionShift %= Other.AlphabetLength;
					Console.Write("{0, -2}", alphabetStrLower[positionShift]);
				}
				Console.WriteLine();
			}
		}
	}
}
