using ChipersUtility;

namespace AffineCiper
{
    public class AffineDecryptor : AffineCryptographyTypeBase, IAffineCryptographyTypeBase
    {
        public override string OutputMessage { get; } = "Decrypted text";

        public override int AffineSymbolManipulation(IAffineBaseModel model, int wordCode)
        {
            if (wordCode >= model.AddictiveKey)
                return ((wordCode - model.AddictiveKey) * model.MultiplicativeKey) % TextManipulator.AlphabetLength;
            return ((wordCode + TextManipulator.AlphabetLength - model.AddictiveKey) * model.MultiplicativeKey) % TextManipulator.AlphabetLength;
        }
    }
}
