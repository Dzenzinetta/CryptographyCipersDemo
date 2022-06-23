using ChipersUtility;

namespace ChiperAffine
{
    public interface IChiperAffineBaseModel : IChiperBaseModel
    {
        int AddictiveKey { get; set; }
        int MultiplicativeKey { get; set; }
    }
}