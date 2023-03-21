using AffineCiper;

namespace AffineCiper
{
    public class StartDecryptor : ProgramStart, IAffineProgramStart
    {
        public override IAffineProcessBase CryptoType { get; }

        public StartDecryptor()
        {
            CryptoType = AffineCiperFactory.CreateDecryptionProcess();
        }
    }
}
