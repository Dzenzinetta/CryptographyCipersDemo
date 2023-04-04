
namespace AffineCiper
{
    public abstract class ProgramStart : IAffineProgramStart
    {

        protected IAffineProcessBase CryptoType { get; set; }

        public IAffineCryptographyTypeBase GetProcessType()
        {
            if (CryptoType is AffineEncryptionProcess)
            {
                return AffineCiperFactory.GetAffineEncryptor();
            }
            return AffineCiperFactory.GetAffineDecryptor();
        }

        public void StartAffineCiperProgram()
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


