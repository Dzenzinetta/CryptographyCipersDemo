namespace VerticalShiftCiper
{
    public interface IVerticalShiftCiperBase
    {
        string Greeteengs { get; }
        string Rules { get; }

        void GetVerticalCiperMatrix();
        void VerticalShiftCiperMain();
        string VerticalShiftCiperCryptedText();
    }
}