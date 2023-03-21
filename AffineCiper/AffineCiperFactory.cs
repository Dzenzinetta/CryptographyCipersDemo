using AffineCiper;


namespace AffineCiper
{
    public static class AffineCiperFactory
    {
        public static IAffineProgramStart CreateEnctyptorStarter()
        {
            return new StartEncryptor();
        }

        public static IAffineProgramStart CreateDectyptorStarter()
        {
            return new StartDecryptor();
        }


        public static IAffineProcessBase CreateEncryptionProcess()
        {
            return new AffineEncryptionProcess();
        }

        public static IAffineProcessBase CreateDecryptionProcess()
        {
            return new AffineDecryptionProcess();
        }

        public static IAffineKeyBase CreateAdditiveKey()
        { 
            return new AdditiveKey(); 
        }

        public static IAffineKeyBase CreateMultiplicativeKey()
        {
            return new MultiplicativeKey();
        }

        public static IAffineCryptographyTypeBase GetAffineEncryptor()
        {
            return new AffineEncryptor();
        }

        public static IAffineCryptographyTypeBase GetAffineDecryptor()
        {
            return new AffineDecryptor();
        }

        public static IAffineBaseModel CreateAffineModel()
        {
            return new AffineBaseModel();
        }

    }
}
