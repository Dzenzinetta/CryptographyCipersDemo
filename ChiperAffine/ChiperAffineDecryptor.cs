using ChipersUtility;

namespace ChiperAffine
{
    public class ChiperAffineDecryptor : ChiperAffineManipulationBase
    {
        private IChiperAffineBaseModel _affine;
        public ChiperAffineDecryptor(IChiperAffineBaseModel model) : base(model)
        {
            _affine = model;
        }

        public override int AffineChiperManipulation(int wordCode)
        {
            if (wordCode >= _affine.AddictiveKey)
                return ((wordCode - _affine.AddictiveKey) * _affine.MultiplicativeKey) % Utility.AlphabetLength;
            return ((wordCode + Utility.AlphabetLength - _affine.AddictiveKey) * _affine.MultiplicativeKey) % Utility.AlphabetLength;
        }
    }
}
