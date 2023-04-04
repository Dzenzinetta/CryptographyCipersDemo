using AffineCiper;

namespace AffineCiper
{
    public class StartEncryptor : ProgramStart, IAffineProgramStart
    {
        //public override IAffineProcessBase CryptoType { get; }

        public StartEncryptor()
        {
            CryptoType = AffineCiperFactory.CreateEncryptionProcess();
        }
    }
}
