
namespace ChiperHill
{
    public static class TextValidations
    {
        private static string _validationMessage = string.Empty;

        public static bool IsTextLengthValid(string text)
        {
            if (text.Length == 3)
            {
                _validationMessage = "Validation passed";
                return true;
            }
            _validationMessage = "Text length exceeded 3 symbols";
            return false;
        }

        public static string GetValidationMessage()
        {
            return _validationMessage;
        }
    }
}
