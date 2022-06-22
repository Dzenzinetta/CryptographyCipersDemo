using ChipersUtility;
using System;


namespace ChiperVertical
{
    partial class ChiperVerticalShiftEncryptor
	{
		private ChiperVerticalShiftModel _chiperVerticalShiftModel = new ChiperVerticalShiftModel();

		private string _textAfterManipulations = string.Empty;

		private void GetPropertiesForVerticalChiperShift(string titleForConsole)
		{
			InputFromConsole inputFromConsole = new InputFromConsole();

			_chiperVerticalShiftModel.TextFromConsole = inputFromConsole.GetInputForString(titleForConsole);

			_chiperVerticalShiftModel.TextLength = _chiperVerticalShiftModel.TextFromConsole.Length;

			VerticalKeyInput verticalKeyInput = new VerticalKeyInput(_chiperVerticalShiftModel.TextLength);

			_chiperVerticalShiftModel.VerticalKeyFromConsole = verticalKeyInput.GetVerticalKeyFromConsole();

			_chiperVerticalShiftModel.KeyLength = _chiperVerticalShiftModel.VerticalKeyFromConsole.Count;

		}
		/*
		Функция шифрования\дешифрования 
		при шифровании: перенос в строку столбца, номер которого соответствует ключу
		при дешифровании: перенос в строку символа по-столбцам в соответствие с ключом
		*/

		private string GetEncryptedText()
		{
			for (int i = 1; i <= _chiperVerticalShiftModel.KeyLength; i++)
				for (int j = 0; j < _chiperVerticalShiftModel.MatrixColumnCount; j++)
					if (i == _chiperVerticalShiftModel.VerticalKeyFromConsole[j])
						for (int l = 0; l < _chiperVerticalShiftModel.MatrixRowCount; l++)
							_textAfterManipulations += _chiperVerticalShiftModel.MatrixForVerticalChiper[l, j];
			return _textAfterManipulations;
		}

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
			Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ШИФРОВАНИЯ МЕТОДОМ ВЕРТИКАЛЬНОЙ ПЕРЕСТАНОВКИ\n\n");

			GetPropertiesForVerticalChiperShift("Input text to be encrypted");

			ChiperVerticalShiftMatrixProperties matrixProperties = new ChiperVerticalShiftMatrixProperties(_chiperVerticalShiftModel);

			_chiperVerticalShiftModel.MatrixForVerticalChiper = matrixProperties.GetEncriptionMatrix();

            Console.WriteLine($"Encrypted word: { GetEncryptedText() }");
		}

		public void ChiperVerticalShiftDecrytiption()
		{
			Console.Clear();
			Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В ПРОГРАММУ ДЕШИФРОВАНИЯ МЕТОДОМ ВЕРТИКАЛЬНОЙ ПЕРЕСТАНОВКИ\n\n");

			GetPropertiesForVerticalChiperShift("Input text to be decrypted");

			ChiperVerticalShiftMatrixProperties matrixProperties = new ChiperVerticalShiftMatrixProperties(_chiperVerticalShiftModel);

			_chiperVerticalShiftModel.MatrixForVerticalChiper = matrixProperties.GetDecriptionMatrix();

			Console.WriteLine($"Decrypted word: { GetDecryptedText() }");
		}

		
	

	}

}
