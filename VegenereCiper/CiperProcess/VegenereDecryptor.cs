using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereDecryptor : VegenereCiperBase
    {
        public override string CiperType { get; } = "Decrypt";

        public override string MessagePromt()
        {
            return "Decrypted letters index (by alphabet)";
        }

        public override int VegenereCiperCryptoProcess(VegenereCiperModel model)
        {
			return (model.WordCode + TextManipulator.AlphabetLength - model.KeyCode) % TextManipulator.AlphabetLength;
        }
    }
}
