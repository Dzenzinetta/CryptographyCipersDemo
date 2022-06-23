
namespace ChiperVertical
{
    class VerticalKeySymbolExceed : IVerticalKeyValidationModel
    {
        public bool IsValidationFail(VerticalKeyModel verticalKeyModel)
        {
            return verticalKeyModel.SingleElementOfVerticalKey > verticalKeyModel.AllowedKeyLengthForVerticalChiper;
        }

        public string GetErrorMessage(VerticalKeyModel verticalKeyModel)
        {
            return $"Symbol \"{ verticalKeyModel.SingleElementOfVerticalKey }\" numerically greater than the length ({ verticalKeyModel.AllowedKeyLengthForVerticalChiper }).\n\t Please, try again";
        }
    }
}
