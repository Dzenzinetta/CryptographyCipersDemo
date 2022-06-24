namespace ChiperAffine
{
    public interface IAffineKeyBase
    {
        int InputKey { get; set; }
        string PromtMessage { get; }
        bool IsKeyValid();
    }
}