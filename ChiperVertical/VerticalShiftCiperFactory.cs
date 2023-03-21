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

        public static ChiperVerticalShiftMatrixProperties CreateVerticalShiftMatrix(IVerticalShiftCiperModel model)
        {
            return new ChiperVerticalShiftMatrixProperties(model);

        }

    }
}
