
namespace VerticalShiftCiper
{
	public class VerticalShiftCiperMatrix
	{
		private readonly IVerticalShiftCiperModel _model;

        public VerticalShiftCiperMatrix(IVerticalShiftCiperModel VerticalShiftCiperModel)
        {
            _model = VerticalShiftCiperModel;
        }

		public void GetMatrixProperties()
		{
			_model.MatrixRowCount = GetMatrixRowCount();
			_model.MatrixColumnCount = _model.KeyLength;
		}

		public void GetEncryptionMatrix()
		{
			for (int i = 0, c = 0; i < _model.MatrixRowCount; i++)
			{
				for (int j = 0; j < _model.MatrixColumnCount; j++, c++)
				{
					if (c >= _model.TextLength)
					{
						_model.MatrixForVerticalCiper[i, j] = 'X';
						continue;
					}
					_model.MatrixForVerticalCiper[i, j] = _model.TextFromConsole[c];
				}
			}
		}

		public void GetDecryptionMatrix()
		{
			for (int i = 0, c = 0; i < _model.MatrixColumnCount; i++)
			{
				for (int j = 0; j < _model.MatrixRowCount; j++, c++)
				{
					_model.MatrixForVerticalCiper[j, i] = _model.TextFromConsole[c];
				}
			}
		}

        private int GetMatrixRowCount()
		{
			int lengthProportions = _model.TextLength / _model.KeyLength;

			if (lengthProportions * _model.KeyLength < _model.TextLength)
				return lengthProportions + 1;

			return lengthProportions;
		}
	}
}
