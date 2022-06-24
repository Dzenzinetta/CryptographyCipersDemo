using ChipersUtility;

namespace ChiperAffine
{
    public class MultiplicativeKey : AffineKeyBase, IAffineKeyBase
    {
        public new int InputKey { get; set; }

        public override string PromtMessage { get; } = "Input Multiplicative key";

        public override bool IsKeyValid()
        {
            for (int j = 0; j < Utility.AlphabetLength; j++)
                if (InputKey * j % Utility.AlphabetLength == 1)
                {
                    Console.WriteLine("Key is not comprime with 26. Try again.");
                    return false;
                }
            return true;
        }
    }
}
