namespace VerticalShiftCiper
{
    public class VerticalShiftCiperEncryption : VerticalShiftCiperBase
    {
        protected override string Greetings { get; } = "Welcome to Program that demonstrate Vertical Shift Ciper encryption.\n\n";

        protected override string Rules { get; } = "Hello World!";

        protected override void GetVerticalCiperMatrix()
        {
			_matrixProperties.GetEncryptionMatrix();
        }

        protected override void VerticalShiftCiperCryptoText()
        {
            for (int i = 1; i <= _verticalShiftCiperModel.KeyLength; i++)
            {
                for (int j = 0; j < _verticalShiftCiperModel.MatrixColumnCount; j++)
                {
                    CheckAndGetCryptoText(i, j);
                }
            }
        }

        private void CheckAndGetCryptoText(int keyLengthIndex, int matrixColumnIndex)
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
                _verticalShiftCiperModel.TextAfterCiperManipulations 
                    += _verticalShiftCiperModel.MatrixForVerticalCiper[l, matrixColumnIndex];
            }
        }
    }
}
