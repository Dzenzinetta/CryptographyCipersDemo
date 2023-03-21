using ChipersUtility;
using System.Collections.Generic;

namespace VerticalShiftCiper
{
    public interface IVerticalShiftCiperModel : ICiperBaseModel
    {
        int KeyLength { get; set; }
        int MatrixColumnCount { get; set; }
        char[,] MatrixForVerticalChiper { get; set; }
        int MatrixRowCount { get; set; }
        int TextLength { get; set; }
        List<int> VerticalKeyFromConsole { get; set; }
    }
}