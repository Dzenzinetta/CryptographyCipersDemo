using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereCiperMenu : ConsoleMenuBase //, IConsoleMenuBase
    {
        private IVegenereProgramBase _ciperBase;
        public override void FillMenuList()
        {
            Options = new List<string>
            {
                "Encryption algorithm",
                "Decryption algorithm",
                "Output alphabet table",
                "Go Back"
            };
        }

        public override void MenuSelector()
        {
            TextManipulator.ResetCursorVisible();
            switch (selectedOption)
            {
                case 0:
                    {
                        _ciperBase = VegenereCiperFactory.CreateVegenereEncryptionProgram();
                        _ciperBase.VegenereProgramMain();
                        break;
                    }
                case 1:
                    {
                        _ciperBase = VegenereCiperFactory.CreateVegenerDecryptionProgram();
                        _ciperBase.VegenereProgramMain();
                        break;
                    }
                case 2:
                    {
                        VegenereTable.VegenereTableOutput();
                        break;
                    }
            }
        }

        protected override string SetProgramTitle()
        {
            return "Vegenere";
        }
    }
}
