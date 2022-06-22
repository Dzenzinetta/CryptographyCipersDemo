using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility
{
    partial class ChiperVerticalEncryptor
	{
		
		private string _textFromConsole;
		//private int[] _keyFromConsole;

        public ChiperVerticalEncryptor()
        {
            _textFromConsole = string.Empty;
        }


		/*
		Функция шифрования\дешифрования 
		при шифровании: перенос в строку столбца, номер которого соответствует ключу
		при дешифровании: перенос в строку символа по-столбцам в соответствие с ключом
		*/
		string VerticalCryptography(bool option, int rows, int columns, int key_length, char[,] matrix, int[] digit_key, string encrypted_word)
		{
			if (option)
			{
				for (int i = 1; i <= key_length; i++)
					for (int j = 0; j < columns; j++)
						if (i == digit_key[j])
							for (int l = 0; l < rows; l++)
								encrypted_word += matrix[l, j];
				return encrypted_word;
			}
			for (int j = 0; j < rows; j++)
				for (int k = 1; k <= key_length; k++)
					for (int l = 0; l < columns; l++)
						if (k == digit_key[l])
							encrypted_word += matrix[j, l];
			return encrypted_word;
		}

	

		int VerticalMain(bool option)
		{
			InputFromConsole inputFromConsole = new InputFromConsole();

			VerticalChiperModel verticalChiperModel = new VerticalChiperModel();

			//List<int> keyFromConsole = new List<int>();

			Console.Clear();

			if (option)
				Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ШИФРОВАНИЯ МЕТОДОМ ВЕРТИКАЛЬНОЙ ПЕРЕСТАНОВКИ\n\n");
			else
				Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ДЕШИФРОВАНИЯ МЕТОДОМ ВЕРТИКАЛЬНОЙ ПЕРЕСТАНОВКИ\n\n");

			verticalChiperModel.TextFromConsole = inputFromConsole.GetInputForString("Input text to be encrypted");

			int textLength = verticalChiperModel.TextFromConsole.Length;

			VerticalKeyInput verticalKeyInput = new VerticalKeyInput(textLength);

			verticalChiperModel.VerticalKeyFromConsole = verticalKeyInput.GetVerticalKeyFromConsole();

			int keyLength = verticalChiperModel.VerticalKeyFromConsole.Count;

			VerticalChiperMatrixProperties matrixProperties = new VerticalChiperMatrixProperties(verticalChiperModel); 



			//std::cout << '\n';                                                      // вывод матрицы с разбитым текстом на экран

			matrix = new char[rows, columns];
			//for (int i = 0; i < rows; i++)
			//	matrix[i] = new char[columns];

			matrix = matrix_maker(option, rows, columns, word_length, matrix, _textFromConsole, digit_key);

			encrypted_word = vertical_cryptography(option, rows, columns, key_length, matrix, digit_key, encrypted_word);


			return 0;
		}
	

	}

}
