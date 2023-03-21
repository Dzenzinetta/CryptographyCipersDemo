using ChipersUtility;

namespace VegenereCiper
{
    public class Program
    {
        public static void Main()
        {
            VegenereCiperMenu menu = new VegenereCiperMenu();
            QuestioinAfterProgram questioin = new QuestioinAfterProgram();

            do
            {
                menu.RunMenu();
            } while (questioin.Question());
        }
    }
}