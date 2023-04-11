using ChipersUtility;

namespace VegenereCiper
{
    public class VegenereProgram : ProgramStartBase
    {

        public VegenereProgram()
        {
            CiperProgramMenu = InitMenuType();
        }

        public static void Main()
        {
            IProgramStartBase programStart = VegenereCiperFactory.CreateVegenereCiperProgram();
            programStart.RunMenu();
        }

        protected override IConsoleMenuBase InitMenuType()
        {
            return VegenereCiperFactory.CreateVegenereCiperMenu();
        }
    }
}