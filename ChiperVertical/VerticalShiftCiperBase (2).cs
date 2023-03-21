using ChipersUtility;
using System;

namespace VerticalShiftCiper
{
    class VerticalShiftCiperBase
    {
        private IVerticalShiftCiperModel _chiperVerticalShiftModel; 
		private ChiperVerticalShiftMatrixProperties _matrixProperties;
        private VerticalKeyInput _verticalKeyInput;

        public string Greeteengs;
        public string Rules;
        VerticalShiftCiperBase()
        {
            _chiperVerticalShiftModel = VerticalShiftCiperFactory.CreateVerticalShiftModel();
        }

        public void VerticalShiftCiperMain()
        { 
            Console.Clear();
            Console.WriteLine($"{Greeteengs}");

            Console.WriteLine($"{Rules}");
            Console.ReadKey();

            Console.WriteLine("1. Getting Text:");
            GetTextFromConsole();
            GetTextLength();

            Console.WriteLine("2. Getting Key:");
            GetVerticalKey();

            Console.WriteLine("3. Calculating matrix for Vertical Shift ciper");


        }

        private void GetTextFromConsole()
        {
            _chiperVerticalShiftModel.TextFromConsole = InputFromConsole.GetString("Input Text");
        }

        private void GetTextLength()
        {
            _chiperVerticalShiftModel.TextLength = _chiperVerticalShiftModel.TextFromConsole.Length;
        }

        private void GetVerticalKey()
        {
            _verticalKeyInput = new VerticalKeyInput(_chiperVerticalShiftModel.TextLength);
            _chiperVerticalShiftModel.VerticalKeyFromConsole = _verticalKeyInput.GetVerticalKeyFromConsole();
			_chiperVerticalShiftModel.KeyLength = _chiperVerticalShiftModel.VerticalKeyFromConsole.Count;
        }
    }
}
