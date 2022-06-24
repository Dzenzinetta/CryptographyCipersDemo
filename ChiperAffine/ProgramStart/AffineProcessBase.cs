using ChipersUtility;

namespace ChiperAffine
{
    public abstract class AffineProcessBase : IAffineProcessBase
    {
        //private AffineKeyBase _additiveKeyObject;
        //private AffineKeyBase _multiplicativeKeyObject;

        //private AffineCryptographyTypeBase _affineProcessObject;

        //private IAffineBaseModel _model;
        //private IInputFromConsole _inputFromConsole;

        //public AffineProcessBase(AffineCryptographyTypeBase cryptographyBase, IAffineBaseModel affine)
        //{
        //    _inputFromConsole = UtilityControl.CreateInputFromConsole();
        //    _additiveKeyObject = new AdditiveKey();
        //    _multiplicativeKeyObject = new MultiplicativeKey();
        //    _model = affine;
        //    _affineProcessObject = cryptographyBase;
        //}

        public abstract string Greeteengs { get; }
        public abstract string SymbolOutputTitle { get; }

        public AffineKeyBase AdditiveKeyObject { get; set; }
        public AffineKeyBase MultiplicativeKeyObject { get; set; }

        public AffineCryptographyTypeBase AffineProcessObject { get; set; }

        public IAffineBaseModel Model { get; set; }
        public IInputFromConsole ConsoleInput { get; set; }



        public void AffineMainProcess()
        {
            Console.Clear();
            Console.WriteLine($"{ Greeteengs }");

            GetPropertiesForAffineChiper();
            Console.WriteLine($"{ SymbolOutputTitle }");

            GetInverseMultiplicativeKeyForDecryption();

            Console.WriteLine($"\nРезультат: { AffineProcessObject.AffineChiperProcess() }");
        }

        private void GetPropertiesForAffineChiper()
        {
            Model.TextFromConsole = ConsoleInput.GetStringInputFromConsole("Введите слово, с которым будете работать");
            Model.AddictiveKey = AdditiveKeyObject.KeyProcess();
            Model.MultiplicativeKey = MultiplicativeKeyObject.KeyProcess();
        }

        public abstract void GetInverseMultiplicativeKeyForDecryption();

    }
}
