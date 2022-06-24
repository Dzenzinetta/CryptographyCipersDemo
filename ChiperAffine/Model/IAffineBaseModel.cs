using ChipersUtility;

namespace ChiperAffine
{
    public interface IAffineBaseModel : IChiperBaseModel
    {
        int AddictiveKey { get; set; }
        int MultiplicativeKey { get; set; }
    }
}