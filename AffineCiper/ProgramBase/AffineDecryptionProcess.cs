using ChipersUtility;

namespace AffineCiper
{
    public class AffineDecryptionProcess : AffineProcessBase, IAffineProcessBase
    {
       
        public override string Greeteengs { get; } = $"Welcome to the Programm demonstration of Affine Ciper algorithm\n" +
            $"In this proramm you cold decrypt some text, that you already encrypted by Affine Ciper.\n" +
            $"For that you need to have two key's: Additive and Multiplicative\n\n";
        public override string SymbolOutputTitle { get; } = $"\nIndexes (by Alphabet) and Decrypted word:";

        public override IAffineKeyBase AdditiveKeyObject { get; set; }
        public override IAffineKeyBase MultiplicativeKeyObject { get; set; }
        public override IAffineCryptographyTypeBase AffineProcessObject { get; set; }
        public override IAffineBaseModel Model { get; set; }
        public override ITextInput ConsoleInput { get; set; }

        public override void GetInverseMultiplicativeKeyForDecryption()
        {
            for (int i = 0; i < TextManipulator.AlphabetLength; i++)
                if ((Model.MultiplicativeKey * i % TextManipulator.AlphabetLength) == 1)
                    Model.MultiplicativeKey = i;
        }
    }
}
