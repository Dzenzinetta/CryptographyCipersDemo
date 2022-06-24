using ChipersUtility;

namespace ChiperAffine
{
    public class AffineDecryptionProcess : AffineProcessBase//, IAffineProcessBase
    {
        public AffineDecryptionProcess(IAffineProcessBase processBase)
        {
            AdditiveKeyObject = processBase.AdditiveKeyObject;
            MultiplicativeKeyObject = processBase.MultiplicativeKeyObject;
            AffineProcessObject = processBase.AffineProcessObject;
            Model = processBase.Model;
            ConsoleInput = processBase.ConsoleInput;
        }

        public override string Greeteengs { get; } = $"Welcome to the Programm demonstration of Affine Ciper algorithm\n" +
            $"In this proramm you cold decrypt some text, that you already encrypted by Affine Ciper.\n" +
            $"For that you need to have two key's: Additive and Multiplicative\n\n";
        public override string SymbolOutputTitle { get; } = $"Index (by Alphabet) of Decrypted text: ";

        public override AffineKeyBase AdditiveKeyObject { get; set; }
        public override AffineKeyBase MultiplicativeKeyObject { get; set; }

        public override AffineCryptographyTypeBase AffineProcessObject { get; set; }

        public override IAffineBaseModel Model { get; set; }
        public override IInputFromConsole ConsoleInput { get; set; }

        public override void GetInverseMultiplicativeKeyForDecryption()
        {
            for (int i = 0; i < Utility.AlphabetLength; i++)
                if ((Model.MultiplicativeKey * i % Utility.AlphabetLength) == 1)
                    Model.MultiplicativeKey = i;
        }
    }
}
