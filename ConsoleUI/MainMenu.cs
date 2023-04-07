using ChipersUtility;
using AffineCiper;
using VegenereCiper;
using PlayfairCiper;

namespace ConsoleUI
{
    public class MainMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override List<string> Options { get; set; }

        public override string ProgramTitle { get; } = "Cryptography Demonstration Software";

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
            
            switch (SelectedOption)
            {
            case 0:
                {
                    IConsoleMenuBase affineMenu = ConsoleUIFactory.CreateAffineMenu();
                    affineMenu.RunMenu();
                    break;
                }
            case 1:
                {
                    VegenereCiperMenu vigenereCiper = ConsoleUIFactory.CreateVegenereCiperMenu();
                    vigenereCiper.RunMenu();
                    break;
                }
            case 2:
                {
                    PlayfairCiperMenu playfairCiper = ConsoleUIFactory.CreatePlayfairCiperMenu();
                    playfairCiper.RunMenu();
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
                    Console.WriteLine("Not Complete");
                    Console.ReadKey();
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }

            }
            ConsoleUIStart.RunMainMenu();

        }

    }
}
