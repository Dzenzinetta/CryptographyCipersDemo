using ChipersUtility;

namespace PlayfairCiper
{
	public class PlayfairCiperMain
	{
		private IInputFromConsole _consoleInput = UtilityControl.CreateInputFromConsole();
		//Other other = new Other();
		PositionOfSymbolsOnMatrix position = new PositionOfSymbolsOnMatrix();

		char[,] keyMatrix = new char[5, 5];

		string strWordDividedByBigramm = string.Empty,
				strEncryptedWord = string.Empty,
				strInputKey = string.Empty,
				strInputWord = string.Empty;

		public struct PositionOfSymbolsOnMatrix
		{
			public int[] positionI, positionJ;

			public void Declaring(int arrayLength)
			{
				positionI = new int[arrayLength];
				positionJ = new int[arrayLength];
			}
		}

		void GetWordDevidedByBigramm()
		{
			for (int i = 0; i < strInputWord.Length; i += 2)
			{
				strWordDividedByBigramm += strInputWord[i];
				if ((i + 1) == strInputWord.Length)
					break;
				if (strInputWord[i] == strInputWord[i + 1])
					strWordDividedByBigramm += 'X';
				strWordDividedByBigramm += strInputWord[i + 1];
			}
			if (strWordDividedByBigramm.Length % 2 != 0)
				strWordDividedByBigramm += 'X';
		}

		void GetKeyAlphabetMatrix()
		{
			for (int i = 0; i < Utility.AlphabetLength; i++)
			{
				if (Utility.GetAlphabet()[i] == 'J') continue;
				if (strInputKey.Contains(Utility.GetAlphabet()[i]) == false)
					strInputKey += Utility.GetAlphabet()[i];
			}
		}

		void OutputWordDividedByBigramm()
		{
			for (int i = 0; i < strWordDividedByBigramm.Length; i += 2)
				Console.Write("{0}{1} ", strWordDividedByBigramm[i], strWordDividedByBigramm[i + 1]);
		}

		void FillKeyMatrixAndOutput()
		{
			for (int i = 0, t = 0; i < 5; i++)
			{
				Console.Write("\t\t|");
				for (int j = 0; j < 5; j++, t++)
				{
					keyMatrix[i, j] = strInputKey[t];
					Console.Write("{0, -2}", strInputKey[t]);
				}
				Console.WriteLine("|");
			}
		}

		void GetCordForShifting()
		{
			for (int n = 0, q = 0; n < strWordDividedByBigramm.Length; n++)
				for (int i = 0; i < 5; i++)
					for (int j = 0; j < 5; j++)
						if (strWordDividedByBigramm[n] == keyMatrix[i, j])
						{
							position.positionI[q] = i;
							position.positionJ[q] = j;
							q++;
						}
		}

		void FillContainerForEncriptedWord()
		{
			for (int i = 0; i < strWordDividedByBigramm.Length; i += 2)
				strEncryptedWord += GetEncryptionPairWithMatrix(i);

			string GetEncryptionPairWithMatrix(int iteration)
			{
				if (IsSymbolsInline(iteration))
					return GetInlineSymbols(GetKeyNormalLineColumnShift(iteration), GetKeyNormalLineColumnShiftNext(iteration));

				if (IsSymbolsOnColumn(iteration))
					return GetInlineSymbols(GetKeyShiftLineColumnNormal(iteration), GetKeyShiftNextLineColumnNormal(iteration));

				return GetInlineSymbols(GetKeyNormalLineColumnNext(iteration), GetKeyNextLineColumnNormal(iteration));
			}

			bool IsSymbolsInline(int iteration)
			{
				if (position.positionI[iteration] == position.positionI[iteration + 1])
					return true;
				return false;
			}

			bool IsSymbolsOnColumn(int iteration)
			{
				if (position.positionJ[iteration] == position.positionJ[iteration + 1])
					return true;
				return false;
			}

			int GetKeyNormalLineColumnShift(int iteration)
				=> keyMatrix[position.positionI[iteration], (position.positionJ[iteration] + 1) % 5];
			int GetKeyNormalLineColumnShiftNext(int iteration)
				=> keyMatrix[position.positionI[iteration], (position.positionJ[iteration + 1] + 1) % 5];
			int GetKeyNormalLineColumnNext(int iteration)
				=> keyMatrix[position.positionI[iteration], position.positionJ[iteration + 1]];
			int GetKeyShiftLineColumnNormal(int iteration)
				=> keyMatrix[(position.positionI[iteration] + 1) % 5, position.positionJ[iteration]];
			int GetKeyShiftNextLineColumnNormal(int iteration)
				=> keyMatrix[(position.positionI[iteration + 1] + 1) % 5, position.positionJ[iteration]];
			int GetKeyNextLineColumnNormal(int iteration)
				=> keyMatrix[position.positionI[iteration + 1], position.positionJ[iteration]];

			string GetInlineSymbols(int firstSymbol, int secondSymbol)
				=> Convert.ToString(firstSymbol) + Convert.ToString(secondSymbol);
		}

		public void PlayfairEncryptionProcess()
		{
			Console.Clear();
			Console.WriteLine("Welcome to Playfair encryptor");
			Console.WriteLine();
			strInputWord = _consoleInput.GetStringInputFromConsole("1. Enter word for encryption");

            //do
            //{
            //    strInputKey = _consoleInput.GetStringInputFromConsole("2. Enter key");
            //    if (other.IsInputHaveRepeatedSymbol(strInputKey, out int badSymbol))
            //        Console.WriteLine("Your key contains repeted symbol.\n\t Please, use non reapeated one");
            //} while (other.IsInputHaveRepeatedSymbol(strInputKey, out int noUsed));

            Console.WriteLine("\n3. Word divided by Bigramm (Pair of symbols):");
			GetWordDevidedByBigramm();
			position.Declaring(strWordDividedByBigramm.Length);
			OutputWordDividedByBigramm();

			Console.WriteLine("\n\n4. Key matrix maided from your Key and Alpabet:");
			GetKeyAlphabetMatrix();
			FillKeyMatrixAndOutput();

			Console.WriteLine("\n5. Processing encription...\n\n");
			GetCordForShifting();
			FillContainerForEncriptedWord();

			Console.Write("\nOriginal word:\t");
			//other.OutputStringSymbolBySymbol(strInputWord);

			Console.Write("\nEncrypted word:\t");
			//other.OutputStringSymbolBySymbol(strEncryptedWord);
			Console.WriteLine("\n");
		}
	}
}
