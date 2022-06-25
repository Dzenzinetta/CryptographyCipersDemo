using ChipersUtility;

namespace AffineCiper
{
    public interface IAffineBaseModel : IChiperBaseModel
    {
        int AddictiveKey { get; set; }
        int MultiplicativeKey { get; set; }
    }
}