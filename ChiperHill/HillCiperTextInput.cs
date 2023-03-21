using ChipersUtility;

namespace ChiperHill
{
    public class HillCiperTextInput
    {
        private const string Promt = "Enter word that you want to encrypt (3 character only!)";
        
        private string _textForCiper = string.Empty;
        private bool _isValid;

        private readonly ITextInput _inputType; 

        public HillCiperTextInput()
        {
            _textForCiper = string.Empty;
            _inputType = UtilityControl.CreateInputFromConsole();
        }

        public string GetText()
        {
            _textForCiper = _inputType.GetString(Promt);
            _isValid = TextValidations.IsTextLengthValid(_textForCiper);

            return _textForCiper;
        }

        public bool IsTextValid()
        {
            return _isValid;
        }

        public static string GetConsoleMessage()
        {
            return TextValidations.GetValidationMessage();
        }
    }
}
