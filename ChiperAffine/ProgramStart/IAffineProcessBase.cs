using ChipersUtility;

namespace ChiperAffine
{
    public interface IAffineProcessBase
    {
        IAffineKeyBase AdditiveKeyObject { get; set; }

        IAffineKeyBase MultiplicativeKeyObject { get; set; }

        IAffineCryptographyTypeBase AffineProcessObject { get; set; }

        IAffineBaseModel Model { get; set; }

        IInputFromConsole ConsoleInput { get; set; }

        public void AffineMainProcess();

    }
}