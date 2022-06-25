using ChipersUtility;

namespace PlayfairCiper
{
    public class PlayfairCiperMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override string ProgramTitle { get; } = "Playfair";

        public override List<string> Options { get; set; }
        
        
        public override void FillMenuList()
        {
            Options = new List<string>();
            Options.Add("Encryption algorithm");
            Options.Add("Decryption algorithm");
            Options.Add("Go Back");
        }

        public override void MenuSelector()
        {
            ResetCursorVisible();
            switch (SelectedOption)
            {
                case 0:
                    {
                        Console.WriteLine("Not Complete. Please wait)");
                        Console.ReadKey(true);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Not Complete. Please wait)");
                        Console.ReadKey(true);
                        break;
                    }
            }
        }
    }
}
