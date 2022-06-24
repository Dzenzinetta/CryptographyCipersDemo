using ChipersUtility;

namespace ChiperAffine
{
    public class AffineEncryptionProcess : AffineProcessBase, IAffineProcessBase
    {
        //private IAffineBaseModel _model;
        //public AffineEncryptionProcess(IAffineProcessBase processBase)
        //{
        //    AdditiveKeyObject = processBase.AdditiveKeyObject;
        //    MultiplicativeKeyObject = processBase.MultiplicativeKeyObject;
        //    AffineProcessObject = processBase.AffineProcessObject;
        //    Model = processBase.Model;
        //    ConsoleInput = processBase.ConsoleInput;
        //}

        public override string Greeteengs { get; } = $"Welcome to the Programm demonstration of Affine Ciper algorithm\n" +
            $"In this proramm you will encrypt your text by following algorythm.\n";
        public override string SymbolOutputTitle { get; } = $"Index (by Alphabet) of Encrypted text: ";


        public new AffineKeyBase AdditiveKeyObject { get; set; }
        public new AffineKeyBase MultiplicativeKeyObject { get; set; }

        public new AffineCryptographyTypeBase AffineProcessObject { get; set; }

        public new IAffineBaseModel Model { get; set; }
        public new IInputFromConsole ConsoleInput { get; set; }

        public override void GetInverseMultiplicativeKeyForDecryption()
        {
            Console.WriteLine();
        }
    }
}
