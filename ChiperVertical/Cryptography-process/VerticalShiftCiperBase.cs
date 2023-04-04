using ChipersUtility;
using System;

namespace VerticalShiftCiper
{
    public abstract class VerticalShiftCiperBase : IVerticalShiftCiperBase
    {
        protected abstract string Greetings { get; }
        protected abstract string Rules { get; }

        protected IVerticalShiftCiperModel _verticalShiftCiperModel;
        protected VerticalShiftCiperMatrix _matrixProperties;
        private VerticalKeyInput _verticalKeyInput;

        protected VerticalShiftCiperBase(IVerticalShiftCiperModel model)
        {
            _verticalShiftCiperModel = model;
        }

        public void VerticalShiftCiperMain()
        {
            Console.Clear();
            Console.WriteLine($"{Greetings}");

            Console.WriteLine($"{Rules}");
            Console.ReadKey();

            Console.WriteLine("1. Getting Text:");
            GetTextFromConsole();
            GetTextLength();

            Console.WriteLine("2. Getting Key:");
            GetVerticalKey();

            Console.WriteLine("3. Calculating matrix for Vertical Shift Ciper");
            PrepareVerticalMatrixForCiper();
            GetVerticalCiperMatrix();

            Console.WriteLine($"4. Output result:");
            VerticalShiftCiperCryptoText();
            OutputCryptoText();
        }

        protected abstract void VerticalShiftCiperCryptoText();

        protected abstract void GetVerticalCiperMatrix();

        private void GetTextFromConsole()
        {
            _verticalShiftCiperModel.TextFromConsole = InputFromConsole.GetString("Input Text");
        }

        private void GetTextLength()
        {
            _verticalShiftCiperModel.TextLength = _verticalShiftCiperModel.TextFromConsole.Length;
        }

        private void GetVerticalKey()
        {
            _verticalKeyInput = VerticalShiftCiperFactory.CreateVerticalKeyInput(_verticalShiftCiperModel.TextLength);
            _verticalShiftCiperModel.VerticalKeyFromConsole = _verticalKeyInput.GetVerticalKeyFromConsole();
            _verticalShiftCiperModel.KeyLength = _verticalShiftCiperModel.VerticalKeyFromConsole.Count;
        }

        private void PrepareVerticalMatrixForCiper()
        {
            _matrixProperties = VerticalShiftCiperFactory.CreateVerticalShiftMatrix(_verticalShiftCiperModel);
            _matrixProperties.GetMatrixProperties();

            _verticalShiftCiperModel.MatrixForVerticalCiper
                = new char[_verticalShiftCiperModel.MatrixRowCount, _verticalShiftCiperModel.MatrixColumnCount];
        }

        private void OutputCryptoText()
        {
            Console.WriteLine();
            Console.WriteLine($"\t{_verticalShiftCiperModel.TextAfterCiperManipulations}");
        }
    }
}
