using ChipersUtility;

namespace ChiperAffine
{
    public interface IAffineProcessBase
    {
        AffineKeyBase AdditiveKeyObject { get; set; }

        AffineKeyBase MultiplicativeKeyObject { get; set; }

        AffineCryptographyTypeBase AffineProcessObject { get; set; }

        IAffineBaseModel Model { get; set; }

        IInputFromConsole ConsoleInput { get; set; }

        //string Greeteengs { get; }

        //string SymbolOutputTitle { get; }
    }
}