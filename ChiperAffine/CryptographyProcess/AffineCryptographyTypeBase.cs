using ChipersUtility;

namespace ChiperAffine
{
    public abstract class AffineCryptographyTypeBase// : IAffineCryptographyTypeBase
    {

        public abstract IAffineBaseModel Model { get; set; }


        public string AffineChiperProcess()
        {
            string _wordAfterEncryption = string.Empty;
            int wordCode, cryptedWordCode;
            for (int i = 0; i < Model.TextFromConsole.Length; i++)
            {
                wordCode = Utility.TextToCode(Model.TextFromConsole[i]);
                cryptedWordCode = AffineSymbolManipulation(wordCode);
                _wordAfterEncryption += Utility.CodeToText(cryptedWordCode);

                Console.Write("{0, -3}", cryptedWordCode);
            }
            return _wordAfterEncryption;
        }

        public abstract int AffineSymbolManipulation(int wordCode);

    }
}
