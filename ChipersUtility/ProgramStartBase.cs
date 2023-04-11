
namespace ChipersUtility
{
    public abstract class ProgramStartBase : IProgramStartBase
    {
        protected IConsoleMenuBase CiperProgramMenu;

        public void RunMenu()
        {
            TextManipulator.ResetCursorVisible();
            do
            {
                CiperProgramMenu?.RunMenu();
            } while (QuestioinAfterProgram.RepeatProgram());
        }

        protected abstract IConsoleMenuBase InitMenuType();
    }
}