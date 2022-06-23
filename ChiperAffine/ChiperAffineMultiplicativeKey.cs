using ChipersUtility;

namespace ChiperAffine
{
    internal class ChiperAffineMultiplicativeKey : ChiperAffineKeyBase
    {
        public override bool IsKeyValid(int inputedKey)
        {
            for (int j = 0; j < Utility.AlphabetLength; j++)
                if ((inputedKey * j) % Utility.AlphabetLength == 1)
                    return true;
            return false;
        }
    }
}
