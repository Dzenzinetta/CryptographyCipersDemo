
namespace VerticalShiftCiper
{
    interface IVerticalKeyValidationModel
    {
        bool IsValidationFail(VerticalKeyModel verticalKeyModel);

        string GetErrorMessage(VerticalKeyModel verticalKeyModel);

    }
}
