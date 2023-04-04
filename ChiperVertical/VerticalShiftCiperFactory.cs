using ChipersUtility;

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

        public static IVerticalShiftCiperBase CreateVerticalShitfEncryptor()
        {
            return new VerticalShiftCiperEncryption();
        }

        public static IVerticalShiftCiperBase CreateVerticalShitfDecryptor()
        {
            return new VerticalShiftCiperDecryption();
        }
    }
}
