using ChipersUtility;
using System;

/*
namespace VerticalShiftCiper
{
    partial class ChiperVerticalShiftMain
	{
		private VerticalShiftCiperModel _chiperVerticalShiftModel = new VerticalShiftCiperModel();
		private VerticalShiftCiperMatrix _matrixProperties;

		private string _textAfterManipulations = string.Empty;

		private void GetPropertiesForVerticalChiperShift(string titleForConsole)
		{
			//ITextInput inputFromConsole = new InputFromConsole();

			_chiperVerticalShiftModel.TextFromConsole = InputFromConsole.GetString(titleForConsole);
			_chiperVerticalShiftModel.TextLength = _chiperVerticalShiftModel.TextFromConsole.Length;

			VerticalKeyInput verticalKeyInput = new VerticalKeyInput(_chiperVerticalShiftModel.TextLength);

			_chiperVerticalShiftModel.VerticalKeyFromConsole = verticalKeyInput.GetVerticalKeyFromConsole();
			_chiperVerticalShiftModel.KeyLength = _chiperVerticalShiftModel.VerticalKeyFromConsole.Count;

			_matrixProperties = new VerticalShiftCiperMatrix(_chiperVerticalShiftModel);
			_matrixProperties.GetMatrixProperties();

			_chiperVerticalShiftModel.MatrixColumnCount = _matrixProperties.ColumnCount;
			_chiperVerticalShiftModel.MatrixRowCount = _matrixProperties.RowCount;

			

		}
	
		//Функция шифрования: перенос в строку столбца, номер которого соответствует ключу
		private string GetEncryptedText()
		{
			for (int i = 1; i <= _chiperVerticalShiftModel.KeyLength; i++)
				for (int j = 0; j < _chiperVerticalShiftModel.MatrixColumnCount; j++)
					if (i == _chiperVerticalShiftModel.VerticalKeyFromConsole[j])
						for (int l = 0; l < _chiperVerticalShiftModel.MatrixRowCount; l++)
							_textAfterManipulations += _chiperVerticalShiftModel.MatrixForVerticalChiper[l, j];
		 	return _textAfterManipulations;
		}

		//Функция дешифрования: перенос в строку символа по-столбцам в соответствие с ключом
		private string GetDecryptedText()
		{
			for (int j = 0; j < _chiperVerticalShiftModel.MatrixRowCount; j++)
				for (int k = 1; k <= _chiperVerticalShiftModel.KeyLength; k++)
					for (int l = 0; l < _chiperVerticalShiftModel.MatrixColumnCount; l++)
						if (k == _chiperVerticalShiftModel.VerticalKeyFromConsole[l])
							_textAfterManipulations += _chiperVerticalShiftModel.MatrixForVerticalChiper[j, l];
			return _textAfterManipulations;
		}

		public void ChiperVerticalShiftEncrytiption()
		{
			Console.Clear();
			Console.WriteLine("Welcome to Programm that demonstrate Vertical Shift Chiper encryption.\n\n");

			GetPropertiesForVerticalChiperShift("Input text to be encrypted");
			_chiperVerticalShiftModel.MatrixForVerticalChiper = _matrixProperties.GetEncryptionMatrix();
			Console.WriteLine($"Encrypted word: { GetEncryptedText() }");
		}

		public void ChiperVerticalShiftDecrytiption()
		{
			Console.Clear();
			Console.WriteLine("Welcome to Programm that demonstrate Vertical Shift Chiper decryption.\n\n");

			GetPropertiesForVerticalChiperShift("Input text to be decrypted");

			Console.WriteLine($"Decrypted word: { GetDecryptedText() }");
		}

	}
}
*/
