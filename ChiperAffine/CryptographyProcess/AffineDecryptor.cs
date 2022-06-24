using ChipersUtility;

namespace ChiperAffine
{
    public class AffineDecryptor : AffineCryptographyTypeBase, IAffineCryptographyTypeBase
    {
        //public override IAffineBaseModel Model { get; set; }

        public override int AffineSymbolManipulation(IAffineBaseModel model, int wordCode)
        {
            if (wordCode >= model.AddictiveKey)
                return ((wordCode - model.AddictiveKey) * model.MultiplicativeKey) % Utility.AlphabetLength;
            return ((wordCode + Utility.AlphabetLength - model.AddictiveKey) * model.MultiplicativeKey) % Utility.AlphabetLength;
        }
    }
}
