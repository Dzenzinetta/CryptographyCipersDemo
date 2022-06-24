using ChipersUtility;

namespace ChiperAffine
{
    public class AffineDecryptor : AffineCryptographyTypeBase
    {
        public override IAffineBaseModel Model { get; set; }

        public override int AffineSymbolManipulation(int wordCode)
        {
            if (wordCode >= Model.AddictiveKey)
                return ((wordCode - Model.AddictiveKey) * Model.MultiplicativeKey) % Utility.AlphabetLength;
            return ((wordCode + Utility.AlphabetLength - Model.AddictiveKey) * Model.MultiplicativeKey) % Utility.AlphabetLength;
        }
    }
}
