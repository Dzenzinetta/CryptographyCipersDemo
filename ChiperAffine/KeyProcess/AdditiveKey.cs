using ChipersUtility;

namespace ChiperAffine
{
    internal class AdditiveKey : AffineKeyBase, IAffineKeyBase
    {
        public new int InputKey { get; set; }

        public new string PromtMessage { get; } = "Input Additive key";

        public override bool IsKeyValid()
        {
            if (InputKey == 1)
            {
                Console.WriteLine("Additive key must vary from 1. Try again!");
                return false;
            }
            return true;
        }
    }
}
