using ChipersUtility;

namespace VegenereCiper
{
	public abstract class VegenereCiperBase : IVegenereCiperBase
	{
		public abstract string CiperType { get; }

		public VegenereCiperModel VigenereChiperProcess(VegenereCiperModel _model)
		{
			GetTextForCiper(_model);

			for (int i = 0, z = 0; i < _model.TextForCiper.Length; i++, z++)
			{
				_model.WordCode = TextManipulator.TextToCode(_model.TextForCiper[i]);

				if (z == _model.VegenereKey.Length)
					z = 0;

				_model.KeyCode = TextManipulator.TextToCode(_model.VegenereKey[z]);
				_model.WordCode = VegenereCiperCryptoProcess(_model);
				_model.EncryptedText += TextManipulator.CodeToText(_model.WordCode);
			}
			
			return _model;
		}

		public abstract string MessagePromt();
		public abstract int VegenereCiperCryptoProcess(VegenereCiperModel model);

		private void GetTextForCiper(VegenereCiperModel _model)
		{
			_model.TextForCiper = InputFromConsole.GetString($"Input Text that you need to {CiperType}");
			_model.VegenereKey = InputFromConsole.GetString("Input key word");
		}
	}
}
