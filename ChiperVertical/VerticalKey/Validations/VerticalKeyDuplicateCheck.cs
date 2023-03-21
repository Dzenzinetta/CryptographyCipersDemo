using System.Linq;

namespace VerticalShiftCiper
{
    class VerticalKeyDuplicateCheck : IVerticalKeyValidationModel
    {
        public bool IsValidationFail(VerticalKeyModel verticalKeyModel)
        {
            int[] verticalKey = verticalKeyModel.VerticalKey.ToArray();
            return verticalKey.Length != verticalKey.Distinct().Count();
        }

        public string GetErrorMessage(VerticalKeyModel verticalKeyModel)
        {
            return $"You input repeated symbol.\nFor this Chiper that's restricted.\n\t Please, try again";
        }
    }
}
