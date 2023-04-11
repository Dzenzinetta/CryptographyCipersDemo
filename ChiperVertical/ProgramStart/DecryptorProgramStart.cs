namespace VerticalShiftCiper
{
    public class DecryptorProgramStart : VerticalShiftCiperStartBase
    {
        protected override IVerticalShiftCiperBase GetVerticalShiftCiperProgramType()
        {
            return VerticalShiftCiperFactory.CreateVerticalShitfDecryptor(_verticalShiftCiperModel);
        }
    }
}
