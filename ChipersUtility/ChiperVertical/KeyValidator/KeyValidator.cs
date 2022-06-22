using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipersUtility.ChiperVertical
{
    class VerticalKeyValidator
    {
        private List<IVerticalKeyValidationModel> _validations = new List<IVerticalKeyValidationModel>();

        public VerticalKeyValidator()
        {
            _validations = AddValidationList();
        }

        private List<IVerticalKeyValidationModel> AddValidationList()
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
                    return true;
                }
            }
            return false;
        }

    }
}
