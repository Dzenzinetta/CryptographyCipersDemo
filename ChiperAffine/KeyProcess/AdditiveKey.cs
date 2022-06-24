using ChipersUtility;

namespace ChiperAffine
{
    public class AdditiveKey : AffineKeyBase, IAffineKeyBase
    {
        public new int InputKey { get; set; }

        public override string PromtMessage { get; } = "Input Additive key";

        public override bool IsKeyValid()
        {
            if (InputKey == 1)
            {
                Console.WriteLine("Additive key must differ from 1. Try again!");
                return false;
            }
            return true;
        }
    }
}
