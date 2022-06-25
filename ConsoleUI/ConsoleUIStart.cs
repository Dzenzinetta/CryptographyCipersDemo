using ChipersUtility;
using AffineCiper;


namespace ConsoleUI
{

    public static class ConsoleUIStart
    {

        private static string _title = "Welcome to the Classical Ciper Demonstration Program!\n" +
            "Here you can examine few historically important ciper's, like Affine Ciper (Cesar type) or Vertical Shift algorythm.\n" +
            "In Menu you can use arrow key's - when you choose preferred one press Enter, and continue on next screen\n\n" +
            "Program made by Kustov Artem for educational purposes\n\n" +
            "Press any key to continue...\n";
        
        
        public static void Main()
        {
            SetWindowSize();
            Console.WriteLine($"{_title}");
            Console.ReadKey(true);

            RunMainMenu();
        }

        public static void RunMainMenu()
        {
            IConsoleMenuBase main = ConsoleUIFactory.CreateMainMenu();
            main.RunMenu();
        }
        private static void SetWindowSize()
        {
            if (Environment.OSVersion.ToString().Contains("Windows"))
                Console.SetWindowSize(140, 30);
        }

    }
}