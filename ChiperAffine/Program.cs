using ChipersUtility;

namespace ChiperAffine
{
    public class Programm
    {
        //public AffineProcessBase AffineEncryption = new AffineDecryptionProcess();
        public static void Main()
        {
            //IAffineProcessBase encryptionBase = new 

            AffineProcessBase affineEncryption = new AffineEncryptionProcess
            {
                AdditiveKeyObject = new AdditiveKey(),
                MultiplicativeKeyObject = new MultiplicativeKey(),
                AffineProcessObject = new AffineEncryptor(),
                Model = new AffineBaseModel(),
                ConsoleInput = UtilityControl.CreateInputFromConsole();
            }  
        
        }
    
    }


}


