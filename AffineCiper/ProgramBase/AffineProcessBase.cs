using ChipersUtility;

namespace AffineCiper
{
    public abstract class AffineProcessBase : IAffineProcessBase
    {
       
        public abstract string Greeteengs { get; }
        public abstract string SymbolOutputTitle { get; }
        public string Rules { get; } = "Please, read Rules before start working with Ciper:\n" +
            "1) Text: There is no specific limitation for text, but do not use Very long one, just because it will not contain Console Line\n" +
            "2) Additive key: it is a \"Shift\" of your key, so it could be arbitrary\n" +
            "3) Multiplicative key: must! be comprime to 26 (Length of Alphabet). For example: 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25\n\n" +
            "That's all Rules. Press any key to continue...\n";

        public abstract IAffineKeyBase AdditiveKeyObject { get; set; }
        public abstract IAffineKeyBase MultiplicativeKeyObject { get; set; }
        public abstract IAffineCryptographyTypeBase AffineProcessObject { get; set; }
        public abstract IAffineBaseModel Model { get; set; }
        public abstract ITextInput ConsoleInput { get; set; }


        public void AffineMainProcess()
        {
            Console.Clear();
            Console.WriteLine($"{Greeteengs}");

            Console.WriteLine($"{Rules}");
            Console.ReadKey();

            GetPropertiesForAffineChiper();
            Console.WriteLine($"{SymbolOutputTitle}");

            GetInverseMultiplicativeKeyForDecryption();
            AffineProcessObject.AffineChiperProcess(Model);

            Console.WriteLine($"\n\nPress any key to continue...");
            Console.ReadKey();
        }

        private void GetPropertiesForAffineChiper()
        {
            Model.TextFromConsole = ConsoleInput.GetString("Input text");
            Model.AddictiveKey = AdditiveKeyObject.KeyProcess(ConsoleInput);
            Model.MultiplicativeKey = MultiplicativeKeyObject.KeyProcess(ConsoleInput);
        }

        public abstract void GetInverseMultiplicativeKeyForDecryption();

    }
}
