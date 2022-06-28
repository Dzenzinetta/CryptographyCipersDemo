using ChipersUtility;

namespace AffineCiper
{
    public abstract class ProgramStart : IAffineProgramStart
    {

        public abstract IAffineProcessBase CryptoType { get; }

        public IAffineCryptographyTypeBase GetProcessType()
        {
            if (CryptoType is AffineEncryptionProcess)
                return AffineCiperFactory.GetAffineEncryptor();
            return AffineCiperFactory.GetAffineDecryptor();
        }

        public void StartAffineCiperProgramm()
        {
            CryptoType.AdditiveKeyObject = AffineCiperFactory.CreateAdditiveKey();
            CryptoType.MultiplicativeKeyObject = AffineCiperFactory.CreateMultiplicativeKey();
            CryptoType.AffineProcessObject = GetProcessType();
            CryptoType.Model = AffineCiperFactory.CreateAffineModel();
            //CryptoType.ConsoleInput = UtilityControl.CreateInputFromConsole();

            CryptoType.AffineMainProcess();
        }

    }

}


