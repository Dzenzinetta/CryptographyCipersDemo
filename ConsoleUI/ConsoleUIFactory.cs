using ChipersUtility;
using AffineCiper;
using VegenereCiper;
using PlayfairCiper;
using ChiperVerticalShift;

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

        public static IConsoleMenuBase CreateVegenereCiperMenu()
        {
            return new VegenereCiperMenu();
        }

        public static IConsoleMenuBase CreatePlayfairCiperMenu()
        {
            return new PlayfairCiperMenu();
        }

        public static IConsoleMenuBase CreateVerticalShiftCiperMenu()
        {
            return new VerticalShiftCiperMenu();
        }

        public static IProgramStartBase CreateConsoleUIProgram()
        {
            return new ConsoleUIStart();
        }
    }
}
