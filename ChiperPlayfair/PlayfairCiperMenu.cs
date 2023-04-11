using ChipersUtility;

namespace PlayfairCiper
{
    public class PlayfairCiperMenu : ConsoleMenuBase//, IConsoleMenuBase
    {
        public override void FillMenuList()
        {
            Options = new List<string>
            {
                "Encryption algorithm",
                "Decryption algorithm",
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

        protected override string SetProgramTitle()
        {
            return "Playfair";
        }
    }
}
