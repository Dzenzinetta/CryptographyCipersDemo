using ChipersUtility;

namespace ChiperAffine
{
    public class ChiperAffineEncryptor : ChiperAffineManipulationBase
    {
        private IChiperAffineBaseModel _affine;
        public ChiperAffineEncryptor(IChiperAffineBaseModel model) : base(model)
        {
            _affine = model;
        }

        public override int AffineChiperManipulation(int wordCode)
        {
            return (_affine.MultiplicativeKey * wordCode + _affine.AddictiveKey) % Utility.AlphabetLength;
        }
    }
}
