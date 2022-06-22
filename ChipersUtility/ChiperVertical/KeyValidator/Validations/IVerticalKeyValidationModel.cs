
namespace ChipersUtility
{
    interface IVerticalKeyValidationModel
    {
        bool IsValidationFail(VerticalKeyModel verticalKeyModel);

        string GetErrorMessage(VerticalKeyModel verticalKeyModel);

    }
}
