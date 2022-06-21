using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crtypto_update
{
    class ChiperHill
	{
		private const int AvailableLengthForHillChiper = 3;
		private int[,] matrixKey;
		private string strEncryptedWord = string.Empty,
				strOriginWord = string.Empty;
		private int[,] columnWordCode,
				columnEncryptedCode;
		Other other = new Other();

		public ChiperHill()
		{
			matrixKey = new int[3, 3] {
			{ 6, 24, 1 },
			{ 13, 16, 10 },
			{ 20, 17, 15 } };
			columnWordCode = new int[3, 1];
			columnEncryptedCode = new int[3, 1];
		}

		public void HillChiperMain()
		{
			Console.Clear();
			Console.WriteLine("Welcome to Example of Hill Chiper\n" +
					"There is only one available option of key matrix because of sequencing complexity\n");

			do
			{
				strOriginWord = other.TextBox("Введите слово, которое хотите зашифровать (3 символа)");
				if (strOriginWord.Length != AvailableLengthForHillChiper)
					Console.WriteLine("Invalid Key");
			} while (strOriginWord.Length != AvailableLengthForHillChiper);

			Console.WriteLine("\nEncripted by key below:\n");
			OutputMatrixKeyInTableView();

			GetColumnWordCode();
			HillChiperCtyptoProcess();

			Console.Write("\nOriginal word:\t");
			other.OutputStringSymbolBySymbol(strOriginWord);

			Console.Write("\nEncrypted word:\t");
			other.OutputStringSymbolBySymbol(strEncryptedWord);
			Console.WriteLine();
		}

		void OutputMatrixKeyInTableView()
		{
			for (int i = 0; i < AvailableLengthForHillChiper; i++)
			{
				Console.Write("\t\t|");
				for (int j = 0; j < AvailableLengthForHillChiper; j++)
					Console.Write("{0, -3}", matrixKey[i, j]);
				Console.WriteLine("|");
			}
		}

		void GetColumnWordCode()
		{
			for (int i = 0; i < strOriginWord.Length; i++)
				columnWordCode[i, 0] = other.TextToCode(strOriginWord[i]);
		}

		void HillChiperCtyptoProcess()
		{
			int rezult;
			for (int i = 0; i < strOriginWord.Length; i++)
			{
				rezult = 0;
				for (int j = 0; j < strOriginWord.Length; j++)
					rezult += (matrixKey[i, j] * columnWordCode[j, 0]);
				columnEncryptedCode[i, 0] = rezult % Other.AlphabetLength;
				strEncryptedWord += other.CodeToText(columnEncryptedCode[i, 0]);
			}
		}

	}
}
