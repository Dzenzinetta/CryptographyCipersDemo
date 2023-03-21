
using ChipersUtility;

namespace ChiperHill
{
    public class HillEncryptor
    {
		private string _encryptedText;
		private readonly HillCiperModel _model;

		public HillEncryptor(HillCiperModel model)
		{
			_model = model;
			_encryptedText = string.Empty;
			GetColumnWordCode();
		}

		private void GetColumnWordCode()
		{
			for (int i = 0; i < HillCiperModel.AvailableLength; i++)
			{
                _model.ColumnWordCode[i, 0] = TextManipulator.TextToCode(_model.TextForCiper[i]);
            }
        }
		
		public string HillChiperCtyptoProcess()
		{
			int rezult;
			for (int i = 0; i < HillCiperModel.AvailableLength; i++)
			{
				rezult = 0;
				for (int j = 0; j < HillCiperModel.AvailableLength; j++)
				{
                    rezult += (_model.MatrixKey[i, j] * _model.ColumnWordCode[j, 0]);
                }
                _model.ColumnCryptoCode[i, 0] = rezult % TextManipulator.AlphabetLength;
				_encryptedText += TextManipulator.CodeToText(_model.ColumnCryptoCode[i, 0]);
			}
			return _encryptedText;
		}
    }
}
