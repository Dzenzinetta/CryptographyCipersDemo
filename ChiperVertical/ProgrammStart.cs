
namespace VerticalShiftCiper
{
    class ProgrammStart
    {
        public static void Main()
        {
            //ChiperVerticalShiftMain main = new ChiperVerticalShiftMain();

            //main.ChiperVerticalShiftEncrytiption();

            IVerticalShiftCiperBase encryptor = new VerticalShiftCiperEncryption();

            encryptor.VerticalShiftCiperMain();
        }


    }
}
