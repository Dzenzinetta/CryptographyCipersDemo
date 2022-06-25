using ChipersUtility;
using AffineCiper;
using VegenereCiper;
using PlayfairCiper;

namespace ConsoleUI
{
    public static class ConsoleUIFactory
    {
        public static IConsoleMenuBase CreateMainMenu()
        {
            return new MainMenu();
        }

        public static IConsoleMenuBase CreateAffineMenu()
        {
            return new AffineCiperMenu();
        }

        public static VegenereCiperMain CreateVegenereMenu()
        { 
            return new VegenereCiperMain();
        }

        public static VegenereCiperMenu CreateVegenereCiperMenu()
        {
            return new VegenereCiperMenu();
        }

        public static PlayfairCiperMenu CreatePlayfairCiperMenu()
        {
            return new PlayfairCiperMenu();
        }

    }
}
