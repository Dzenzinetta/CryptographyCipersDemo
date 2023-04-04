
namespace VerticalShiftCiper
{
    public abstract class ProgramStartBase : IVerticalShiftProgramStart
    {
        protected IVerticalShiftCiperBase _ciperBase;
        public static void Main()
        {
            IVerticalShiftCiperBase encryptor = new VerticalShiftCiperEncryption();

            encryptor.VerticalShiftCiperMain();
        }

        public void StartVerticalShiftCiperProgram()
        {
            _ciperBase?.VerticalShiftCiperMain();
        }

        protected abstract void GetVerticalShiftCiperProgramType();
    }
}
