
namespace AffineCiper
{
    public interface IAffineProgramStart
    {
        //public IAffineProcessBase CryptoType { get; }
        
        IAffineCryptographyTypeBase GetProcessType();

        void StartAffineCiperProgram();
    }
}