using ChipersUtility;
using VerticalShiftCiper;

namespace ChiperVerticalShift
{
    public class VerticalShiftProgram : ProgramStartBase
    {

        public VerticalShiftProgram()
        {
            CiperProgramMenu = InitMenuType();
        }

        public static void Main() 
        {
            IProgramStartBase programStart = VerticalShiftCiperFactory.CreateVerticalShiftProgram();
            programStart.RunMenu();
        }

        protected override IConsoleMenuBase InitMenuType()
        {
           return VerticalShiftCiperFactory.CreateVerticalShiftCiperMenu();
        }
    }
}
