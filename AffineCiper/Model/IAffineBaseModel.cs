using ChipersUtility;

namespace AffineCiper
{
    public interface IAffineBaseModel : ICiperBaseModel
    {
        int AddictiveKey { get; set; }
        int MultiplicativeKey { get; set; }
    }
}