using System;

namespace ChiperVertical
{
	public class ChiperVerticalShiftMatrixProperties
	{
		private ChiperVerticalShiftModel _model;

        public ChiperVerticalShiftMatrixProperties(ChiperVerticalShiftModel chiperVerticalShiftModel)
        {
            _model = chiperVerticalShiftModel;
        }

        public int ColumnCount {get; set;}
		public int RowCount {get; set;}

		public void GetMatrixProperties()
		{
			RowCount = GetMatrixRowCount();
			ColumnCount = _model.KeyLength;
		}

		private int GetMatrixRowCount()
		{
			int lengthProportions = _model.TextLength / _model.KeyLength;

			if (lengthProportions * _model.KeyLength < _model.TextLength)
				return lengthProportions + 1;

			return lengthProportions;
		}

		public char[,] GetEncriptionMatrix()
		{
			for (int i = 0, c = 0; i < RowCount; i++)
			{
				for (int j = 0; j < ColumnCount; j++, c++)
				{
					if (c >= _model.TextLength)
					{
						_model.MatrixForVerticalChiper[i, j] = 'X';
						continue;
					}
					_model.MatrixForVerticalChiper[i, j] = _model.TextFromConsole[c];
				}
			}
			return _model.MatrixForVerticalChiper;
		}

		public char[,] GetDecriptionMatrix()
		{
			for (int i = 0, c = 0; i < ColumnCount; i++)
			{
				for (int j = 0; j < RowCount; j++, c++)
				{
					_model.MatrixForVerticalChiper[j, i] = _model.TextFromConsole[c];
				}
			}
			return _model.MatrixForVerticalChiper;
		}

	}

}
