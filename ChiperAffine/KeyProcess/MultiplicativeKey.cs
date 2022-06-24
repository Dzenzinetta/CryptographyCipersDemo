using ChipersUtility;

namespace ChiperAffine
{
    public class MultiplicativeKey : AffineKeyBase, IAffineKeyBase
    {
        public new int InputKey { get; set; }

        public override string PromtMessage { get; } = "Input Multiplicative key";

        public override bool IsKeyValid()
        {
            for (int i = 0; i < Utility.AlphabetLength; i++)
                if ((InputKey * i) % Utility.AlphabetLength == 1)
                {
                    Console.WriteLine("Key is not comprime with 26. Try again.");
                    return false;
                }
            return true;
        }
    }
}
