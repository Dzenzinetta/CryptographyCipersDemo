using ChipersUtility;

namespace ChiperVerticalShift
{
    public class Program
    {
        public static void Main() 
        {
            IConsoleMenuBase verticalShiftMenu = new VerticalShiftCiperMenu();
        
            verticalShiftMenu.RunMenu();
        }
    }
}
