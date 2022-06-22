using System;

namespace ChiperVertical
{
	public class ChiperVerticalShiftMatrixProperties
	{
		private int _textLength, _keyLength;
		private string _textFromConsole;
		private char[,] _matrix;

		public int Columns, Rows;

		public ChiperVerticalShiftMatrixProperties(ChiperVerticalShiftModel verticalChiperModel)
		{
			_textFromConsole = verticalChiperModel.TextFromConsole;
			_textLength = verticalChiperModel.TextFromConsole.Length;
			_keyLength = verticalChiperModel.VerticalKeyFromConsole.Count;
		}

		public void GetMatrixProperties()
		{
			Columns = _keyLength;
			Rows = GetMatrixRowCount();
		}

		private int GetMatrixRowCount()
		{
			int lengthProportions = _textLength / _keyLength;

			if (lengthProportions * _keyLength < _textLength)
				return lengthProportions + 1;

			return lengthProportions;
		}

		public char[,] GetEncriptionMatrix()
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
			return _matrix;
		}

		public char[,] GetDecriptionMatrix()
		{
			for (int i = 0, c = 0; i < Columns; i++)
			{
				for (int j = 0; j < Rows; j++, c++)
				{
					_matrix[j, i] = _textFromConsole[c];
				}
			}
			return _matrix;
		}

	}

}
