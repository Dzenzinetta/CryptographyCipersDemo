using System;
using System.Collections.Generic;

namespace VerticalShiftCiper
{
    class VerticalKeyValidator
    {
        private List<IVerticalKeyValidationModel> _validations = new List<IVerticalKeyValidationModel>();

        public bool IsNotValid;

        public VerticalKeyValidator()
        {
            _validations = FillValidationList();
        }

        private List<IVerticalKeyValidationModel> FillValidationList()
        {
            List<IVerticalKeyValidationModel> output = new List<IVerticalKeyValidationModel>();

            output.Add(new VerticalKeyDuplicateCheck());
            output.Add(new VerticalKeySymbolExceed());

            return output;
        }

        public bool IsValidationFail(VerticalKeyModel verticalKeyModel)
        {
            foreach (IVerticalKeyValidationModel validation in _validations)
            {
                if (validation.IsValidationFail(verticalKeyModel))
                {
                    Console.WriteLine(validation.GetErrorMessage(verticalKeyModel));
                    return IsNotValid = true;
                }
            }
            return IsNotValid = false;
        }
    }
}
