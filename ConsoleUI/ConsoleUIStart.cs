using ChipersUtility;

namespace ConsoleUI
{
    public class ConsoleUIStart : ProgramStartBase
    {
        private const string _title = "Welcome to the Classical Ciper Demonstration Program!\n" +
            "Here you can examine few historically important ciper's, like Affine Ciper (Cesar type) or Vertical Shift algorythm.\n" +
            "In Menu you can use arrow key's - when you choose preferred one press Enter, and continue on next screen\n\n" +
            "Program made by Kustov Artem for educational purposes\n\n" +
            "Press any key to continue...\n";

        public ConsoleUIStart()
        {
            CiperProgramMenu = InitMenuType();
        }

        public static void Main()
        {
            SetWindowSize();
            Console.WriteLine($"{_title}");
            Console.ReadKey(true);

            //ConsoleKeyInfo keyInfo;
            //ConsoleKey pressedKey;
            IProgramStartBase programStart = ConsoleUIFactory.CreateConsoleUIProgram();
            //do
            //{
                programStart.RunMenu();
                //keyInfo = Console.ReadKey(true);
                //pressedKey = keyInfo.Key;
            //} while (pressedKey != ConsoleKey.Escape);
        }

        private static void SetWindowSize()
        {
            if (Environment.OSVersion.ToString().Contains("Windows"))
                Console.SetWindowSize(140, 30);
        }

        protected override IConsoleMenuBase InitMenuType()
        {
            return ConsoleUIFactory.CreateMainMenu();
        }
    }
}