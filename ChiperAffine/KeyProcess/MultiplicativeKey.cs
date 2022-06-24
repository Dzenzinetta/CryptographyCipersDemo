using ChipersUtility;

namespace ChiperAffine
{
    public class MultiplicativeKey : AffineKeyBase
    {
        public new int InputKey { get; set; }

        public override string PromtMessage { get; } = "Input multiplicative key";

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
