
using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereEncryptionProgram : VegenereProgramBase
    {
        private VegenereCiperModel _model;
        private readonly IVegenereCiperBase _encryptor;
        public VegenereEncryptionProgram()
        {
            _model = VegenereCiperFactory.CreateVegenereModel(); 
            _encryptor = VegenereCiperFactory.CreateVegenereEncryptor();
        }
        public override void Greatings()
        {
            Console.WriteLine("Greetings!\nWelcome to Demonstration of Vegenere Ciper.\n" +
                "In this Demonstration you can Encrypt your text by folowing algorithm.\n\n");
        }

        public override void FillVegenereModel()
        {
            _model = _encryptor.VigenereChiperProcess(_model); 
        }

        public override void ResultOutput()
        {
            Console.Write("Encrypted text:");
            TextManipulator.OutputStringSymbolBySymbol(_model.EncryptedText);
        }
    }
}
