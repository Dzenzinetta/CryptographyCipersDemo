using System;

namespace ChipersUtility
{
	public class VerticalChiperMatrixProperties
	{
		private int _textLength, _keyLength;
		private string _textFromConsole;
		private char[,] _matrix;

		public int Columns, Rows;

		public VerticalChiperMatrixProperties(VerticalChiperModel verticalChiperModel)
		{
			_textFromConsole = verticalChiperModel.TextFromConsole;
			_textLength = verticalChiperModel.TextFromConsole.Length;
			_keyLength = verticalChiperModel.VerticalKeyFromConsole.Count;
			
			GetMatrixProperties();
		}

		public void GetMatrixProperties()
		{
			Columns = _keyLength;
			Rows = MatrixRowCounter();
		}

		private int MatrixRowCounter()
		{
			int lengthProportions = _textLength / _keyLength;

			if (lengthProportions * _keyLength < _textLength)
				return lengthProportions + 1;
			return lengthProportions;
		}

		private void NewEncriptionMatrixFiler()
		{
			for (int i = 0, c = 0; i < Rows; i++)
			{
				for (int j = 0; j < Columns; j++, c++)
				{
					if (c >= _textLength)
					{
						_matrix[i, j] = 'X';
						continue;
					}
					_matrix[i, j] = _textFromConsole[c];
				}
			}
		}

		private void NewDecriptionMatrixFiler()
		{
			for (int i = 0, c = 0; i < Columns; i++)
			{
				for (int j = 0; j < Rows; j++, c++)
				{
					_matrix[j, i] = _textFromConsole[c];
				}
			}
		}

	}

}
