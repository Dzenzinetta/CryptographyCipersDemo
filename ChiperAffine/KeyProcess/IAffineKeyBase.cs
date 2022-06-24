using ChipersUtility;

namespace ChiperAffine
{
    public interface IAffineKeyBase
    {
        int InputKey { get; set; }
        string PromtMessage { get; }
        public int KeyProcess(IInputFromConsole input);
        bool IsKeyValid();
    }
}