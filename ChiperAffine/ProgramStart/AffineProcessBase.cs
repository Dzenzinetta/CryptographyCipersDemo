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

        public abstract IAffineKeyBase AdditiveKeyObject { get; set; }
        public abstract IAffineKeyBase MultiplicativeKeyObject { get; set; }
        public abstract IAffineCryptographyTypeBase AffineProcessObject { get; set; }
        public abstract IAffineBaseModel Model { get; set; }
        public abstract IInputFromConsole ConsoleInput { get; set; }



        public void AffineMainProcess()
        {
            Console.Clear();
            Console.WriteLine($"{Greeteengs}");

            GetPropertiesForAffineChiper();
            Console.WriteLine($"{SymbolOutputTitle}");

            GetInverseMultiplicativeKeyForDecryption();

            Console.WriteLine($"\nРезультат: {AffineProcessObject.AffineChiperProcess(Model)}");
        }

        private void GetPropertiesForAffineChiper()
        {
            Model.TextFromConsole = ConsoleInput.GetStringInputFromConsole("Введите слово, с которым будете работать");
            Model.AddictiveKey = AdditiveKeyObject.KeyProcess(ConsoleInput);
            Model.MultiplicativeKey = MultiplicativeKeyObject.KeyProcess(ConsoleInput);
        }

        public abstract void GetInverseMultiplicativeKeyForDecryption();

    }
}
