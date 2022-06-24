using ChiperAffine;


namespace AffineCiper
{
    public static class Factory
    {
        public static IAffineProcessBase CreateEncryptionProcess()
        {
            return new AffineEncryptionProcess();
        }

        public static IAffineProcessBase CreateDecryptionProcess()
        {
            return new AffineDecryptionProcess();
        }

    }
}
