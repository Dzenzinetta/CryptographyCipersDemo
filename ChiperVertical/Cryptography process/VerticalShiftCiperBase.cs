using ChipersUtility;
using System;

namespace VerticalShiftCiper
{
    public abstract class VerticalShiftCiperBase : IVerticalShiftCiperBase
    {
        public abstract string Greeteengs { get; }
        public abstract string Rules { get; }

        protected IVerticalShiftCiperModel _chiperVerticalShiftModel;
        protected ChiperVerticalShiftMatrixProperties _matrixProperties;
        private VerticalKeyInput _verticalKeyInput;

        protected VerticalShiftCiperBase()
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
            PrepareVerticalMatrixForCiper();
            GetVerticalCiperMatrix();

            Console.WriteLine($"4. Output result:");
            VerticalShiftCiperCryptedText();
            Console.WriteLine($"\n\t{_chiperVerticalShiftModel.TextAfterChiperManipulations}");
        }

        protected abstract void VerticalShiftCiperCryptedText();

        protected abstract void GetVerticalCiperMatrix();

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
            _verticalKeyInput = VerticalShiftCiperFactory.CreateVerticalKeyInput(_chiperVerticalShiftModel.TextLength);
            _chiperVerticalShiftModel.VerticalKeyFromConsole = _verticalKeyInput.GetVerticalKeyFromConsole();
            _chiperVerticalShiftModel.KeyLength = _chiperVerticalShiftModel.VerticalKeyFromConsole.Count;
        }

        private void PrepareVerticalMatrixForCiper()
        {
            _matrixProperties = VerticalShiftCiperFactory.CreateVerticalShiftMatrix(_chiperVerticalShiftModel);
            _matrixProperties.GetMatrixProperties();

            _chiperVerticalShiftModel.MatrixColumnCount = _matrixProperties.ColumnCount;
            _chiperVerticalShiftModel.MatrixRowCount = _matrixProperties.RowCount;

            _chiperVerticalShiftModel.MatrixForVerticalChiper
                = new char[_chiperVerticalShiftModel.MatrixRowCount, _chiperVerticalShiftModel.MatrixColumnCount];
        }

    }
}
