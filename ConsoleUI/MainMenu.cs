using ChipersUtility;

namespace ConsoleUI
{
    public class MainMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        private IConsoleMenuBase _ciperMenu;

        public override void FillMenuList()
        {
            Options = new List<string>
            {
                "Affine Ciper",
                "Vegenere Ciper",
                "Playfair Ciper",
                "Hill Ciper",
                "Vertical Shift Ciper",
                "Exit"
            };
        }

        public override void MenuSelector()
        {
            
            switch (selectedOption)
            {
            case 0:
                {
                    _ciperMenu = ConsoleUIFactory.CreateAffineMenu();
                    break;
                }
            case 1:
                {
                    _ciperMenu = ConsoleUIFactory.CreateVegenereCiperMenu();
                    break;
                }
            case 2:
                {
                    _ciperMenu = ConsoleUIFactory.CreatePlayfairCiperMenu();
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Nothing Yet");
                    Console.ReadKey();
                    break;
                }
            case 4:
                {
                    _ciperMenu = ConsoleUIFactory.CreateVerticalShiftCiperMenu();
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }

            }

            _ciperMenu.RunMenu();
        }

        protected override string SetProgramTitle()
        {
            return "Cryptography Demonstration Software";
        }
    }
}
