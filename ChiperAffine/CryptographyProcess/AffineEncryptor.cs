using ChipersUtility;

namespace AffineCiper
{
    public class AffineEncryptor : AffineCryptographyTypeBase, IAffineCryptographyTypeBase
    {
        public override string OutputMessage { get; } = "Decrypted text";

        public override int AffineSymbolManipulation(IAffineBaseModel model, int wordCode)
        {
            return (model.MultiplicativeKey * wordCode + model.AddictiveKey) % Utility.AlphabetLength;
        }
    }
}
