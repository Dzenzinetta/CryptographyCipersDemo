
namespace ChipersUtility.ChiperVertical
{
    interface IVerticalKeyValidationModel
    {
        bool IsValidationFail(VerticalKeyModel verticalKeyModel);

        string GetErrorMessage(VerticalKeyModel verticalKeyModel);

    }
}
