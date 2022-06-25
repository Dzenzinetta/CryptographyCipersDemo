namespace AffineCiper
{
    public interface IAffineCryptographyTypeBase
    {
        string OutputMessage { get; }
        void AffineChiperProcess(IAffineBaseModel Model);
        int AffineSymbolManipulation(IAffineBaseModel Model, int wordCode);
    }
}