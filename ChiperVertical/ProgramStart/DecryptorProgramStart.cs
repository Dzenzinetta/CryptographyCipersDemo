namespace VerticalShiftCiper
{
    public class DecryptorProgramStart : ProgramStartBase
    {
        protected override IVerticalShiftCiperBase GetVerticalShiftCiperProgramType()
        {
            return VerticalShiftCiperFactory.CreateVerticalShitfDecryptor(_verticalShiftCiperModel);
        }
    }
}
