using ChipersUtility;

namespace VerticalShiftCiper
{
    public static class VerticalShiftCiperFactory
    {
        public static IVerticalShiftCiperModel CreateVerticalShiftModel()
        {
            return new VerticalShiftCiperModel();
        }

    }
}
