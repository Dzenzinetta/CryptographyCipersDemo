using ChipersUtility;

namespace AffineCiper
{
    public class Program
    {
        public static void Main()
        {
            IConsoleMenuBase newMenu = new AffineCiperMenu();
        
            newMenu.RunMenu();
        }

    }
}
