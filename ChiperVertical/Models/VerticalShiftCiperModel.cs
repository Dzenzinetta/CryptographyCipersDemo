using System.Collections.Generic;

namespace VerticalShiftCiper
{
    public class VerticalShiftCiperModel : IVerticalShiftCiperModel
    {
        public string TextFromConsole { get; set; }

        public string TextAfterCiperManipulations { get; set; }

        public int TextLength { get; set; }

        public List<int> VerticalKeyFromConsole { get; set; } = new List<int>();

        public int KeyLength { get; set; }

        public char[,] MatrixForVerticalCiper { get; set; }

        public int MatrixColumnCount { get; set; }

        public int MatrixRowCount { get; set; }

    }
}
