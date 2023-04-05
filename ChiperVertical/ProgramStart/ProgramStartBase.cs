
namespace VerticalShiftCiper
{
    public abstract class ProgramStartBase : IVerticalShiftProgramStart
    {
        protected IVerticalShiftCiperBase _ciperBase;
        protected IVerticalShiftCiperModel _verticalShiftCiperModel;

        protected ProgramStartBase()
        {
           _verticalShiftCiperModel = VerticalShiftCiperFactory.CreateVerticalShiftModel();
           _ciperBase= GetVerticalShiftCiperProgramType();
        }

        public void StartVerticalShiftCiperProgram()
        {
            _ciperBase?.VerticalShiftCiperMain();
        }

        protected abstract IVerticalShiftCiperBase GetVerticalShiftCiperProgramType();
    }
}
