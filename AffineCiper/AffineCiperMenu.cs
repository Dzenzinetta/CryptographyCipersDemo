using ConsoleUI;
using ChipersUtility;

namespace AffineCiper
{
    public class AffineCiperMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override List<string> Options { get; set; }

        public override string ProgramTitle { get; } = "Affine";

        private IAffineProgramStart _starter;

        public override void FillMenuList()
        {
            Options = new List<string>();
            Options.Add("Encryption algorithm");
            Options.Add("Decryption algorithm");
            Options.Add("Go Back");
        }

        

        public override void MenuSelector()
        {
            TextManipulator.ResetCursorVisible();
            switch (SelectedOption)
            {
                case 0:
                    {
                        _starter = AffineCiperFactory.CreateEnctyptorStarter();
                        _starter.StartAffineCiperProgramm();
                        break;
                    }
                case 1:
                    {
                        _starter = AffineCiperFactory.CreateDectyptorStarter();
                        _starter.StartAffineCiperProgramm();
                        break;
                    }
            }
        }
    }
}
