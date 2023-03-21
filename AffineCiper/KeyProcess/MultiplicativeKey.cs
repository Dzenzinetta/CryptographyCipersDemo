using ChipersUtility;

namespace AffineCiper
{
    public class MultiplicativeKey : AffineKeyBase, IAffineKeyBase
    {
        public override int InputKey { get; set; }

        public override string PromtMessage { get; } = "Input Multiplicative key";

        private readonly List<int> _compatibleList = new List<int> { 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25 };

        public override bool IsKeyValid()
        {
            
            if (_compatibleList.Contains(InputKey)) return true;

            Console.WriteLine("Key is not comprime with 26. Try again.");
            return false;
            
            
            
        }
    }
}
