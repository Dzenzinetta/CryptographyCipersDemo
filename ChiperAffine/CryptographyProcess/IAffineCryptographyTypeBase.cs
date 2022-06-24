namespace ChiperAffine
{
    public interface IAffineCryptographyTypeBase
    {
        //IAffineBaseModel Model { get; set; }
        string AffineChiperProcess(IAffineBaseModel Model);
        int AffineSymbolManipulation(IAffineBaseModel Model, int wordCode);
    }
}