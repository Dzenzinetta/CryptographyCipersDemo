using System.Collections.Generic;

namespace VerticalShiftCiper
{
    public class VerticalKeyModel
    {
        public int AllowedKeyLengthForVerticalChiper { get; set; }

        public int SingleElementOfVerticalKey { get; set; }

        public List<int> VerticalKey { get; set; } = new List<int>();

    }
}
