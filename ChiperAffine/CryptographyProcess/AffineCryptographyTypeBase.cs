using ChipersUtility;

namespace AffineCiper
{
    public abstract class AffineCryptographyTypeBase : IAffineCryptographyTypeBase
    {
        public abstract string OutputMessage { get; }

        public void AffineChiperProcess(IAffineBaseModel model)
        {
            string _wordAfterEncryption = string.Empty;
            int wordCode, cryptedWordCode;

            Console.Write("Text code:\t");
            for (int i = 0; i < model.TextFromConsole.Length; i++)
            {
                wordCode = Utility.TextToCode(model.TextFromConsole[i]);
                cryptedWordCode = AffineSymbolManipulation(model, wordCode);
                _wordAfterEncryption += Utility.CodeToText(cryptedWordCode);

                Console.Write("{0, -3}", cryptedWordCode);
            }
            Console.Write($"\n{OutputMessage}\t");
            Utility.OutputStringSymbolBySymbol(_wordAfterEncryption);
        }

        public abstract int AffineSymbolManipulation(IAffineBaseModel model, int wordCode);

    }
}
