namespace VerticalShiftCiper
{
    public class VerticalShiftCiperEncryption : VerticalShiftCiperBase
    {
        public override string Greeteengs { get; } = "Welcome to Programm that demonstrate Vertical Shift Chiper encryption.\n\n";

        public override string Rules { get; } = "Hello World!";

        protected override void GetVerticalCiperMatrix()
        {
			_chiperVerticalShiftModel.MatrixForVerticalChiper = _matrixProperties.GetEncryptionMatrix();
        }

        protected override void VerticalShiftCiperCryptedText()
        {
            for (int i = 1; i <= _chiperVerticalShiftModel.KeyLength; i++)
            {
                for (int j = 0; j < _chiperVerticalShiftModel.MatrixColumnCount; j++)
                {
                    if (i == _chiperVerticalShiftModel.VerticalKeyFromConsole[j])
                        for (int l = 0; l < _chiperVerticalShiftModel.MatrixRowCount; l++)
                        {
                            _chiperVerticalShiftModel.TextAfterChiperManipulations += _chiperVerticalShiftModel.MatrixForVerticalChiper[l, j];
                        }
                }
            }
        }
    }
}
