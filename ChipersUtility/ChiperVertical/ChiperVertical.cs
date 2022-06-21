using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility
{
	class ChiperVerticalEncryptor
	{
		public string strKey {get; set;}
		Other other = new Other();
		
		const int NumeralAmount = 9;
		string errorMessage = string.Empty;
		string strShortVerticalKey = string.Empty;

		/*Функция для получения и последующей проверки ключа для шифра вертикальной перестановки, 
		которая получается длину ключа, и возвращает корректный, проверенный ключ */
		public string VerticalKey(int calculatedLength)
		{
			//string key;
			if (calculatedLength > NumeralAmount)
				return verticalKeyInputProcess.LongVerticalKey(calculatedLength);
			return verticalKeyInputProcess.ShortVerticalKeyInput(calculatedLength);
		}


		/*----------------------------------------------------------------------------------------------------------*/


		int KeyLengthCounter(int word_length)
		{
			const int MinLengthForDivider = 7;

			double length_root = Math.Sqrt(word_length);
			int int_root = (int)length_root;
			
			if (word_length <= MinLengthForDivider)
				return word_length;
			if (length_root - int_root == 0.0) 
				return int_root;			
			return int_root + 1;
		}

		/*	Функция расчета количества столбцов - расширение матрицы для лучшего эффекта "смешивания" происходит вправо
		например: (23/7) * 7 будет меньше 23, т.к. int округляется в меньшую сторону т.е. 21 < 23
		*/
		int RowCounter(int word_length, int key_length)
		{
			if ((word_length / key_length) * key_length < word_length)
				return word_length / key_length + 1;
			return word_length / key_length;
		}

		/*
		Функция перевода ключа из строки в целочисленный массив:
		для короткого ключа(до 10 символов) производится перевод каждого символа строки
		для длинного(больше 10 символов) применяется разделитель "*"
		*параметры функции: option - режим работы(шифр\дешифр), key - ключ в строке(>10 - с разделителями)
		*результатом работы функции является целочисленный ключевой массив
		*/
		int[] KeyDigitization(bool option, int key_length, string key, int[] digit_key)
		{
			const int SingleDigitKeyLength = 9;

			int a = 0,
				numb,
				counter = 0;
			string tmp = " ";

			if (key_length <= SingleDigitKeyLength)
			{
				for (int i = 0; i < key.Length; i++)
				{
					if (option)
						Console.Write("{0, -3}", key[i]);
					digit_key[i] = Convert.ToInt32(key[i]);
				}
				return digit_key;
			}

            while (a < key_length)
			{
				if (a + 2 >= key_length)
					break;
				if (key[a] != '*')
					continue;
				
				tmp += key[a + 1];

				if (key[a + 2] == '*')
				{                                   //однозначеное числ
					if (option)
						Console.WriteLine("{0, -3}", key[a + 1]);
					a += 2;
				}
				if (key[a + 3] == '*')
				{									// двузначное число

					if (option)
						Console.WriteLine("{0, -2} {1}", key[a + 1], key[a + 2]);

					tmp += key[a + 2];
					a += 3;
				}
				numb = Convert.ToInt32(tmp);
				tmp = string.Empty;
				digit_key[counter] = numb;
				counter++;
			}
			return digit_key;
		
			
		}

		/*
	Функция создания и заполнения матрицы с текстом и вывод её на экран
	при шифровании: ключ выводится первой строкой; при дешифровании - первым столбцом
	оставшиеся пустые символы заполняются символом "Х"
	*результом работы функции является двумерный массив с матрицей
*/
		char[][] MatrixMaker(bool option, int rows, int columns, int word_length, char[][] matrix, string word, int[] digit_key)
		{
			if (option)
			{
				for (int i = 0, c = 0; i < rows; i++)
				{
					Console.WriteLine();
					for (int j = 0; j < columns; j++, c++)
					{
						if (c >= word_length)
						{
							matrix[i][j] = 'X';
							continue;
						}
						matrix[i][j] = word[c];
						Console.WriteLine("{0, -3}", matrix[i][j]);
					}
					Console.WriteLine();
				}
				return matrix;
			}
			for (int i = 0, c = 0; i < columns; i++)
			{
				Console.WriteLine("\t{0}", digit_key[i]);
				for (int j = 0; j < rows; j++, c++)
				{
					matrix[j][i] = word[c];
					Console.WriteLine("{0, -3}", matrix[j][i]);
				}
				Console.WriteLine();
			}
			return matrix;
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
			//setlocale(LC_CTYPE, "Russian");

			//Other other = new Other();

			string encrypted_word, title_text = "ВВЕДИТЕ ТЕКСТ, С КОТОРЫМ БУДЕТЕ РАБОТАТЬ: ";

			char[,] matrix;

			int word_length,
				key_length = 7,
				columns = 0,
				rows = 0;

			Console.Clear();

			if (option)
				Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ШИФРОВАНИЯ МЕТОДОМ ВЕРТИКАЛЬНОЙ ПЕРЕСТАНОВКИ\n\n");
			else
				Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ДЕШИФРОВАНИЯ МЕТОДОМ ВЕРТИКАЛЬНОЙ ПЕРЕСТАНОВКИ\n\n");

			string word = other.TextBox(title_text);

			word_length = word.Length;
			key_length = KeyLengthCounter(word_length);



			VerticalKeyInput verticalKeyInput = new VerticalKeyInput(key_length);

			//io.clear_screen();
			//key = VerticalKey(key_length);

			columns = key_length;

			if (option)
			{

				rows = RowCounter(word_length, key_length);
			}
			else
			{

				rows = word_length / key_length;
			}

			//std::cout << "\n\n\t";

			int[] digit_key = new int[key_length];
			digit_key = KeyDigitization(option, key_length, key, digit_key);

			//std::cout << '\n';                                                      // вывод матрицы с разбитым текстом на экран

			matrix = new char[rows, columns];
			//for (int i = 0; i < rows; i++)
			//	matrix[i] = new char[columns];

			matrix = matrix_maker(option, rows, columns, word_length, matrix, word, digit_key);

			encrypted_word = vertical_cryptography(option, rows, columns, key_length, matrix, digit_key, encrypted_word);

			io.display("**ПЕРВОНАЧАЛЬНОЕ СЛОВО: *" + word);                         // вывод зашифрованного слова
			if (option)
			{
				io.display("**" + title_encrypt_final + '*' + encrypted_word);      // вывод зашифрованного слова
			}
			else
			{
				io.display("**" + title_decrypt_final + '*' + encrypted_word);      // вывод дешифрованного слова
			}

			for (int i = 0; i < rows; i++)
			{                                       // освобождение памяти, выделенной
				delete[] matrix[i];                                                 // под матрицу введенного слова
			}
			delete[] digit_key;
			return 0;
		}
	

	}

}
