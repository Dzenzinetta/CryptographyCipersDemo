using ChipersUtility;

namespace ChiperAffine
{
    public class AffineEncryptor : AffineCryptographyTypeBase, IAffineCryptographyTypeBase
    {
        //public override IAffineBaseModel Model { get; set; }

        public override int AffineSymbolManipulation(IAffineBaseModel model, int wordCode)
        {
            return (model.MultiplicativeKey * wordCode + model.AddictiveKey) % Utility.AlphabetLength;
        }
    }
}
