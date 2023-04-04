
namespace VerticalShiftCiper
{
    public sealed class VerticalKeySymbolExceed : IVerticalKeyValidationModel
    {
        public bool IsValidationFail(VerticalKeyModel verticalKeyModel)
        {
            return verticalKeyModel.SingleElementOfVerticalKey > verticalKeyModel.AllowedKeyLengthForVerticalCiper;
        }

        public string SendErrorMessage(VerticalKeyModel verticalKeyModel)
        {
            return $"\nSymbol \"{ verticalKeyModel.SingleElementOfVerticalKey }\" numerically greater than the length ({ verticalKeyModel.AllowedKeyLengthForVerticalCiper }).\n\t Please, try again";
        }
    }
}
