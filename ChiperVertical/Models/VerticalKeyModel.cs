using System.Collections.Generic;

namespace ChiperVertical
{
    public class VerticalKeyModel
    {
        public int AllowedKeyLengthForVerticalChiper { get; set; }

        public int SingleElementOfVerticalKey { get; set; }

        public List<int> VerticalKey { get; set; } = new List<int>();

    }
}
