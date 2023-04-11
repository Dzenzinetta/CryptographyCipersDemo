using ChipersUtility;

namespace ChiperHill
{
    public class HillCiperTextInputOld
    {
        private const string Promt = "Введите слово, которое хотите зашифровать (3 символа)";
        //private ITextInput _consoleInput;
        
        private string _strOriginWord;
        private bool _isTextValid;

        public HillCiperTextInputOld()
        {
            //_consoleInput = CreateInputFromConsole();
        }

        
        public string GetText()
        {
            do
            {
                _strOriginWord = GetInput();
                _isTextValid = IsValid();

            } while (_isTextValid == false);

            return _strOriginWord;
        }

        private string GetInput() 
            => InputFromConsole.GetString(Promt);
        

        private bool TextLengthValidaion() 
            => _strOriginWord.Length != 3;
        

        private bool IsValid()
        {
            if (TextLengthValidaion())
            {
                TextManipulator.MessageOutput("Validation passed!");
                return true;
            }
            TextManipulator.MessageOutput("Invalid Key!");
            return false;
        }
    }
}
