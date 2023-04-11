
namespace VerticalShiftCiper
{
    public abstract class VerticalShiftCiperStartBase : IVerticalShiftProgramStart
    {
        protected IVerticalShiftCiperBase _ciperBase;
        protected IVerticalShiftCiperModel _verticalShiftCiperModel;

        protected VerticalShiftCiperStartBase()
        {
           _verticalShiftCiperModel = VerticalShiftCiperFactory.CreateVerticalShiftModel();
           _ciperBase = GetVerticalShiftCiperProgramType();
        }

        public void StartVerticalShiftCiperProgram()
        {
            _ciperBase?.VerticalShiftCiperMain();
        }

        protected abstract IVerticalShiftCiperBase GetVerticalShiftCiperProgramType();
    }
}
