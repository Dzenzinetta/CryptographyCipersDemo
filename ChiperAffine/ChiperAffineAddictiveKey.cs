using ChipersUtility;

namespace ChiperAffine
{
    internal class ChiperAffineAddictiveKey : ChiperAffineKeyBase
    {
        public override bool IsKeyValid(int inputedKey)
        {
            return (inputedKey % Utility.AlphabetLength) != 0;
        }
    }
}
