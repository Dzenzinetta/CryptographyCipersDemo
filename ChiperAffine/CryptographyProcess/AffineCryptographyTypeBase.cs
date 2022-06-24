using ChipersUtility;

namespace ChiperAffine
{
    public abstract class AffineCryptographyTypeBase
    {
		private IAffineBaseModel _affine;

		public AffineCryptographyTypeBase(IAffineBaseModel model)
        {
			_affine = model;
		}

        public string AffineChiperProcess()
		{
			string _wordAfterEncryption = string.Empty;
			int wordCode, cryptedWordCode;
			for (int i = 0; i < _affine.TextFromConsole.Length; i++)
			{
				wordCode = Utility.TextToCode(_affine.TextFromConsole[i]);
				cryptedWordCode = AffineSymbolManipulation(wordCode);
				_wordAfterEncryption += Utility.CodeToText(cryptedWordCode);
				
				Console.Write("{0, -3}", cryptedWordCode);
			}			
			return _wordAfterEncryption;
		}

		public abstract int AffineSymbolManipulation(int wordCode);

	}
}
