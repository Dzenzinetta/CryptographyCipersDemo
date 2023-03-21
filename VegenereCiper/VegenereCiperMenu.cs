using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereCiperMenu : ConsoleMenuBase //, IConsoleMenuBase
    {
        public override string ProgramTitle { get; } = "Vegenere";

        public override List<string> Options { get; set; }

        private IVegenereProgramBase _encryptionProgram;
        private IVegenereProgramBase _decryptorProgram;
        public override void FillMenuList()
        {
            Options = new List<string>();
            Options.Add("Encryption algorithm");
            Options.Add("Decryption algorithm");
            Options.Add("Output alphabet table");
            Options.Add("Go Back");
        }

        public override void MenuSelector()
        {
            TextManipulator.ResetCursorVisible();
            switch (SelectedOption)
            {
                case 0:
                    {
                        _encryptionProgram = VegenereCiperFactory.CreateVegenereEncryptionProgram();
                        _encryptionProgram.VegenereProgramMain();
                        break;
                    }
                case 1:
                    {
                        _decryptorProgram = VegenereCiperFactory.CreateVegenerDecryptionProgram();
                        _decryptorProgram.VegenereProgramMain();
                        break;
                    }
                case 2:
                    {
                        VegenereTable.VegenereTableOutput();
                        break;
                    }
            }
        }
    }
}
