using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereCiperMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override string ProgramTitle { get; } = "Vegenere";

        public override List<string> Options { get; set; }

        private VegenereCiperMain _starter;

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
            Utility.ResetCursorVisible();
            switch (SelectedOption)
            {
                case 0:
                    {
                        _starter = VegenereCiperFactory.CreateCiperMain();
                        _starter.VegenereCryptoMain(true);
                        break;
                    }
                case 1:
                    {
                        _starter = VegenereCiperFactory.CreateCiperMain();
                        _starter.VegenereCryptoMain(false);
                        break;
                    }
                case 2:
                    {
                        _starter = VegenereCiperFactory.CreateCiperMain();
                        _starter.VegenereTableOutput();
                        break;
                    }
            }
        }
    }
}
