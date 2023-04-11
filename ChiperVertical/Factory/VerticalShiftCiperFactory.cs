using ChipersUtility;
using ChiperVerticalShift;

namespace VerticalShiftCiper
{
    public static class VerticalShiftCiperFactory
    {
        public static IVerticalShiftCiperModel CreateVerticalShiftModel()
        {
            return new VerticalShiftCiperModel();
        }

        public static VerticalKeyInput CreateVerticalKeyInput(int TextLength)
        {
            return new VerticalKeyInput(TextLength);
        }

        public static VerticalShiftCiperMatrix CreateVerticalShiftMatrix(IVerticalShiftCiperModel model)
        {
            return new VerticalShiftCiperMatrix(model);
        }

        public static VerticalKeyValidator CreateVerticalKeyValidator()
        {
            return new VerticalKeyValidator();
        }

        public static VerticalKeyModel CreateVerticalKeyModel(int keyLength)
        {
            return new VerticalKeyModel(keyLength);
        }

        public static IVerticalShiftCiperBase CreateVerticalShitfEncryptor(IVerticalShiftCiperModel _model)
        {
            return new VerticalShiftCiperEncryption(_model);
        }

        public static IVerticalShiftCiperBase CreateVerticalShitfDecryptor(IVerticalShiftCiperModel _model)
        {
            return new VerticalShiftCiperDecryption(_model);
        }

        public static IVerticalShiftProgramStart CreateVerticalShiftCiperEncryptor()
        {
            return new EncryptorProgramStart();
        }

        public static IVerticalShiftProgramStart CreateVerticalShiftCiperDecryptor()
        {
            return new DecryptorProgramStart();
        }

        public static IConsoleMenuBase CreateVerticalShiftCiperMenu()
        {
            return new VerticalShiftCiperMenu();
        }

        public static IProgramStartBase CreateVerticalShiftProgram()
        {
            return new VerticalShiftProgram();
        }
    }
}
