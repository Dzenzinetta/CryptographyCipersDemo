
namespace VerticalShiftCiper
{
    public class EncryptorProgramStart : VerticalShiftCiperStartBase
    {
        protected override IVerticalShiftCiperBase GetVerticalShiftCiperProgramType()
        {
            return VerticalShiftCiperFactory.CreateVerticalShitfEncryptor(_verticalShiftCiperModel);
        }
    }
}
