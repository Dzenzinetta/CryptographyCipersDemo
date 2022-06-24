using ChipersUtility;

namespace ChiperAffine
{
    public class AffineDecryptor : AffineCryptographyTypeBase
    {
        private IAffineBaseModel _affine;
        public AffineDecryptor(IAffineBaseModel model) : base(model)
        {
            _affine = model;
        }

        public override int AffineSymbolManipulation(int wordCode)
        {
            if (wordCode >= _affine.AddictiveKey)
                return ((wordCode - _affine.AddictiveKey) * _affine.MultiplicativeKey) % Utility.AlphabetLength;
            return ((wordCode + Utility.AlphabetLength - _affine.AddictiveKey) * _affine.MultiplicativeKey) % Utility.AlphabetLength;
        }
    }
}
