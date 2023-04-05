
namespace VerticalShiftCiper
{
    public class EncryptorProgramStart : ProgramStartBase
    {
        protected override IVerticalShiftCiperBase GetVerticalShiftCiperProgramType()
        {
            return VerticalShiftCiperFactory.CreateVerticalShitfEncryptor(_verticalShiftCiperModel);
        }
    }
}
