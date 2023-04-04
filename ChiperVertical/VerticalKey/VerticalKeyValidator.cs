using System;
using System.Collections.Generic;

namespace VerticalShiftCiper
{
    public sealed class VerticalKeyValidator
    {
        public bool IsNotValid;

        private readonly List<IVerticalKeyValidationModel> _validations;

        private string _errorMessageFromValidator { get; set; }

        public VerticalKeyValidator()
        {
            _validations = new List<IVerticalKeyValidationModel>();
            _errorMessageFromValidator = "No error's";
            FillValidationList();
        }

        public bool IsValidationFail(VerticalKeyModel verticalKeyModel)
        {
            foreach (IVerticalKeyValidationModel validation in _validations)
            {
                if (validation.IsValidationFail(verticalKeyModel))
                {
                    _errorMessageFromValidator = validation.SendErrorMessage(verticalKeyModel);
                    return IsNotValid = true;
                }
            }
            return IsNotValid = false;
        }
        
        public string GetErrorMessage()
        {
            return _errorMessageFromValidator;
        }

        private void FillValidationList()
        {
            _validations.Add(new VerticalKeyDuplicateCheck());
            _validations.Add(new VerticalKeySymbolExceed());
        }

    }
}
