using ChipersUtility;

namespace ChiperAffine
{
    public abstract class AffineKeyBase : IAffineKeyBase
    {
        private readonly IInputFromConsole _inputFromConsole;

        public int InputKey { get; set; }

        public string PromtMessage { get; }

        public AffineKeyBase()
        {
            _inputFromConsole = UtilityControl.CreateInputFromConsole();
        }

        public int KeyProcess()
        {
            do
            {
                InputKey = _inputFromConsole.GetIntegerInputFromConsole(PromtMessage);

                while (InputKey < 0)
                    InputKey += Utility.AlphabetLength;

            } while (IsKeyValid() == false);

            return InputKey;
        }

        public abstract bool IsKeyValid();

    }
}
