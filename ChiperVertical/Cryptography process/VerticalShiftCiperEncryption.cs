namespace VerticalShiftCiper
{
    public class VerticalShiftCiperEncryption : VerticalShiftCiperBase
    {
        protected override string Greeteengs { get; } = "Welcome to Programm that demonstrate Vertical Shift Chiper encryption.\n\n";

        protected override string Rules { get; } = "Hello World!";

        protected override void GetVerticalCiperMatrix()
        {
			_verticalShiftCiperModel.MatrixForVerticalChiper = _matrixProperties.GetEncryptionMatrix();
        }

        protected override void VerticalShiftCiperCryptedText()
        {
            for (int i = 1; i <= _verticalShiftCiperModel.KeyLength; i++)
            {
                for (int j = 0; j < _verticalShiftCiperModel.MatrixColumnCount; j++)
                {
                    CheckAndGetCryptedText(i, j);
                }
            }
        }

        private void CheckAndGetCryptedText(int keyLengthIndex, int matrixColumnIndex)
        {
            if (CompareIndexWithKey(keyLengthIndex, matrixColumnIndex))
            {
                InsertSymbolFromMatrix(matrixColumnIndex);
            }
        }

        private bool CompareIndexWithKey(int keyLengthIndex, int matrixColumnIndex)
        {
            return keyLengthIndex == _verticalShiftCiperModel.VerticalKeyFromConsole[matrixColumnIndex];
        }

        private void InsertSymbolFromMatrix(int matrixColumnIndex)
        {
            for (int l = 0; l < _verticalShiftCiperModel.MatrixRowCount; l++)
            {
                _verticalShiftCiperModel.TextAfterChiperManipulations += _verticalShiftCiperModel.MatrixForVerticalChiper[l, matrixColumnIndex];
            }
        }
    }
}
