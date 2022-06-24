using ChipersUtility;

namespace ChiperAffine
{
    public abstract class AffineCryptographyTypeBase : IAffineCryptographyTypeBase
    {

        //public abstract IAffineBaseModel Model { get; set; }


        public string AffineChiperProcess(IAffineBaseModel model)
        {
            string _wordAfterEncryption = string.Empty;
            int wordCode, cryptedWordCode;
            for (int i = 0; i < model.TextFromConsole.Length; i++)
            {
                wordCode = Utility.TextToCode(model.TextFromConsole[i]);
                cryptedWordCode = AffineSymbolManipulation(model, wordCode);
                _wordAfterEncryption += Utility.CodeToText(cryptedWordCode);

                Console.Write("{0, -3}", cryptedWordCode);
            }
            return _wordAfterEncryption;
        }

        public abstract int AffineSymbolManipulation(IAffineBaseModel model, int wordCode);

    }
}
