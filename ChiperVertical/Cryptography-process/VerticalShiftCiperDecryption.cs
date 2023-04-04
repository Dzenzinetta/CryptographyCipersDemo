
namespace VerticalShiftCiper
{
    public sealed class VerticalShiftCiperDecryption : VerticalShiftCiperBase
    {
        protected override string Greetings { get; } = "Welcome to Program that demonstrate Vertical Shift Ciper decryption.\n\n";

        protected override string Rules { get; } = "Hello World!";

        protected override void GetVerticalCiperMatrix()
        {
            _matrixProperties.GetDecryptionMatrix();
        }

        protected override void VerticalShiftCiperCryptoText()
        {
            for (int j = 0; j < _verticalShiftCiperModel.MatrixRowCount; j++)
            {
				for (int k = 1; k <= _verticalShiftCiperModel.KeyLength; k++)
                {
                    CheckAndGetCryptoText(k, j);
                }
            }
        }

        private void CheckAndGetCryptoText(int keyLengthIndex, int matrixRowIndex)
        {
            for (int l = 0; l < _verticalShiftCiperModel.MatrixColumnCount; l++)
            {
                if (CompareIndexWithKey(keyLengthIndex, _verticalShiftCiperModel.MatrixColumnCount))
                {
                    InsertSymbolFromMatrix(matrixRowIndex, l);
                }
            }
        }

        private bool CompareIndexWithKey(int keyLengthIndex, int matrixColumnIndex)
        {
            return keyLengthIndex == _verticalShiftCiperModel.VerticalKeyFromConsole[matrixColumnIndex];
        }

        private void InsertSymbolFromMatrix(int matrixRowIndex, int matrixColumnCount)
        {
                _verticalShiftCiperModel.TextAfterCiperManipulations 
                    += _verticalShiftCiperModel.MatrixForVerticalCiper[matrixRowIndex, matrixColumnCount];
        }
    }
}
