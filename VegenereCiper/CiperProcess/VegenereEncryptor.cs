using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereEncryptor : VegenereCiperBase
    {
        public override string CiperType { get; } = "Encrypt";

        public override string MessagePromt()
        {
            return "Encrypted letters index (by alphabet)";
        }

        public override int VegenereCiperCryptoProcess(VegenereCiperModel model)
        {
			return (model.WordCode + model.KeyCode) % TextManipulator.AlphabetLength;
        }
    }
}
