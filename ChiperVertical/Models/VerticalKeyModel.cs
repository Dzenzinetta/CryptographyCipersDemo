using System.Collections.Generic;

namespace VerticalShiftCiper
{
    public class VerticalKeyModel
    {
        public int AllowedKeyLengthForVerticalCiper { get; set; }

        public int SingleElementOfVerticalKey { get; set; }

        public List<int> VerticalKey { get; set; } = new List<int>();

        public VerticalKeyModel(int keyLength) 
        {
            AllowedKeyLengthForVerticalCiper = keyLength;
        }

    }
}
