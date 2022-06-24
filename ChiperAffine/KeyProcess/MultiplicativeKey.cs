using ChipersUtility;

namespace ChiperAffine
{
    internal class MultiplicativeKey : AffineKeyBase, IAffineKeyBase
    {
        public new int InputKey { get; set; }

        public new string PromtMessage { get; } = "Input multiplicative key";

        public override bool IsKeyValid()
        {
            for (int j = 0; j < Utility.AlphabetLength; j++)
                if (InputKey * j % Utility.AlphabetLength == 1)
                {
                    Console.WriteLine("Key is not comprime with 26. Try again.");
                    return true;
                }
            return false;
        }
    }
}
