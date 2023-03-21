namespace VegenereCiper
{
    public interface IVegenereCiperBase
    {
        string CiperType { get; }

        string MessagePromt();
        int VegenereCiperCryptoProcess(VegenereCiperModel model);
        VegenereCiperModel VigenereChiperProcess(VegenereCiperModel _model);
    }
}