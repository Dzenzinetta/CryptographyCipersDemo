using ChipersUtility;

namespace AffineCiper
{
    public class AffineEncryptionProcess : AffineProcessBase, IAffineProcessBase
    {
        public override string Greeteengs { get; } = $"Welcome to the Programm demonstration of Affine Ciper algorithm\n" +
            $"In this proramm you will encrypt your text by following algorythm.\n";
        public override string SymbolOutputTitle { get; } = $"\nIndexes (by Alphabet) and Encrypted word:";


        public override IAffineKeyBase AdditiveKeyObject { get; set; }
        public override IAffineKeyBase MultiplicativeKeyObject { get; set; }
        public override IAffineCryptographyTypeBase AffineProcessObject { get; set; }
        public override IAffineBaseModel Model { get; set; }
        public override IInputFromConsole ConsoleInput { get; set; }

        public override void GetInverseMultiplicativeKeyForDecryption() 
        {
            //Only for Decryption
        }
    }
}
