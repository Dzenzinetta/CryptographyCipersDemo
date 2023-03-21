using ChipersUtility;

namespace AffineCiper
{
    public abstract class AffineKeyBase// : IAffineKeyBase
    {

        public abstract int InputKey { get; set; }

        public abstract string PromtMessage { get; }

        public int KeyProcess(ITextInput input)
        {
            do
            {
                InputKey = input.GetInteger(PromtMessage);

                while (InputKey < 0)
                    InputKey += TextManipulator.AlphabetLength;

            } while (IsKeyValid() == false);

            return InputKey;
        }

        public abstract bool IsKeyValid();

    }
}
