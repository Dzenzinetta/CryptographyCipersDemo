using System.Linq;

namespace VerticalShiftCiper
{
    public sealed class VerticalKeyDuplicateCheck : IVerticalKeyValidationModel
    {
        public bool IsValidationFail(VerticalKeyModel verticalKeyModel)
        {
            int[] verticalKey = verticalKeyModel.VerticalKey.ToArray();
            return verticalKey.Length != verticalKey.Distinct().Count();
        }

        public string SendErrorMessage(VerticalKeyModel verticalKeyModel)
        {
            return $"You input repeated symbol.\nFor this Ciper that's restricted.\n\t Please, try again";
        }
    }
}
