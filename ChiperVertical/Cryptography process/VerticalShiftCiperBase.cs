using ChipersUtility;
using System;

namespace VerticalShiftCiper
{
    public abstract class VerticalShiftCiperBase : IVerticalShiftCiperBase
    {
        protected abstract string Greeteengs { get; }
        protected abstract string Rules { get; }

        private VerticalKeyInput _verticalKeyInput;
        protected IVerticalShiftCiperModel _verticalShiftCiperModel;
        protected ChiperVerticalShiftMatrixProperties _matrixProperties;

        protected VerticalShiftCiperBase()
        {
            _verticalShiftCiperModel = VerticalShiftCiperFactory.CreateVerticalShiftModel();
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
            PrepareVerticalMatrixForCiper();
            GetVerticalCiperMatrix();

            Console.WriteLine($"4. Output result:");
            VerticalShiftCiperCryptedText();
            Console.WriteLine($"\n\t{_verticalShiftCiperModel.TextAfterChiperManipulations}");
        }

        protected abstract void VerticalShiftCiperCryptedText();

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

            _verticalShiftCiperModel.MatrixColumnCount = _matrixProperties.ColumnCount;
            _verticalShiftCiperModel.MatrixRowCount = _matrixProperties.RowCount;

            _verticalShiftCiperModel.MatrixForVerticalChiper
                = new char[_verticalShiftCiperModel.MatrixRowCount, _verticalShiftCiperModel.MatrixColumnCount];
        }

    }
}
