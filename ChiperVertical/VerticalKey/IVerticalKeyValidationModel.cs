
namespace VerticalShiftCiper
{
    interface IVerticalKeyValidationModel
    {
        bool IsValidationFail(VerticalKeyModel verticalKeyModel);

        string SendErrorMessage(VerticalKeyModel verticalKeyModel);

    }
}
