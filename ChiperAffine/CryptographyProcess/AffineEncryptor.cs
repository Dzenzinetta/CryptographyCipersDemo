using ChipersUtility;

namespace ChiperAffine
{
    public class AffineEncryptor : AffineCryptographyTypeBase
    {
        private IAffineBaseModel _affine;
        public AffineEncryptor(IAffineBaseModel model) : base(model)
        {
            _affine = model;
        }

        public override int AffineSymbolManipulation(int wordCode)
        {
            return (_affine.MultiplicativeKey * wordCode + _affine.AddictiveKey) % Utility.AlphabetLength;
        }
    }
}
