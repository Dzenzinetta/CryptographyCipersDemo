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


        public override IAffineKeyBase AdditiveKeyObject { get; set; }
        public override IAffineKeyBase MultiplicativeKeyObject { get; set; }
        public override IAffineCryptographyTypeBase AffineProcessObject { get; set; }
        public override IAffineBaseModel Model { get; set; }
        public override IInputFromConsole ConsoleInput { get; set; }

        public override void GetInverseMultiplicativeKeyForDecryption()
        {
            Console.WriteLine();
        }
    }
}
