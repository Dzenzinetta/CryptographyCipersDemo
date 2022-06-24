using AffineCiper;
using ChipersUtility;

namespace ChiperAffine
{
    public class Programm
    {
        //public AffineProcessBase AffineEncryption = new AffineDecryptionProcess();
        public static void Main()
        {
            //IAffineProcessBase encryptionBase = new 

            IAffineProcessBase affineEncryption = Factory.CreateEncryptionProcess();

            affineEncryption.AdditiveKeyObject = new AdditiveKey();
            affineEncryption.MultiplicativeKeyObject = new MultiplicativeKey();
            affineEncryption.AffineProcessObject = new AffineEncryptor();
            affineEncryption.Model = new AffineBaseModel();
            affineEncryption.ConsoleInput = UtilityControl.CreateInputFromConsole();
             
        
        }
    
    }


}


