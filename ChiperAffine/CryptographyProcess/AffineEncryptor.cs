using ChipersUtility;

namespace ChiperAffine
{
    public class AffineEncryptor : AffineCryptographyTypeBase
    {
        public override IAffineBaseModel Model { get; set; }

        public override int AffineSymbolManipulation(int wordCode)
        {
            return (Model.MultiplicativeKey * wordCode + Model.AddictiveKey) % Utility.AlphabetLength;
        }
    }
}
