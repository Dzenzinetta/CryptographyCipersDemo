using ChipersUtility;

namespace ChiperAffine
{
    public abstract class ChiperAffineManipulationBase
    {
		private IChiperAffineBaseModel _affine;

		public ChiperAffineManipulationBase(IChiperAffineBaseModel model)
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
				cryptedWordCode = AffineChiperManipulation(wordCode);
				_wordAfterEncryption += Utility.CodeToText(cryptedWordCode);
				
				Console.Write("{0, -3}", cryptedWordCode);
			}			
			return _wordAfterEncryption;
		}

		public abstract int AffineChiperManipulation(int wordCode);

	}
}
