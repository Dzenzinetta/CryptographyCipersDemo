using ChipersUtility;

namespace AffineCiper
{
    public abstract class AffineKeyBase// : IAffineKeyBase
    {

        public abstract int InputKey { get; set; }

        public abstract string PromtMessage { get; }

        public int KeyProcess()
        {
            do
            {
                InputKey = InputFromConsole.GetIntegerInputFromConsole(PromtMessage);

                while (InputKey < 0)
                    InputKey += Utility.AlphabetLength;

            } while (IsKeyValid() == false);

            return InputKey;
        }

        public abstract bool IsKeyValid();

    }
}
