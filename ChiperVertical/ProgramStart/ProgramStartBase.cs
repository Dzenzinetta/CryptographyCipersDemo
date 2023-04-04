
namespace VerticalShiftCiper
{
    public abstract class ProgramStartBase : IVerticalShiftProgramStart
    {

        public static void Main()
        {
            //ChiperVerticalShiftMain main = new ChiperVerticalShiftMain();

            //main.ChiperVerticalShiftEncrytiption();

            IVerticalShiftCiperBase encryptor = new VerticalShiftCiperEncryption();

            encryptor.VerticalShiftCiperMain();
        }

        public void StartVerticalShiftCiperProgram()
        {
            throw new System.NotImplementedException();
        }
    }
}
