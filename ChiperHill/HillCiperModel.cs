namespace ChiperHill
{
    public class HillCiperModel
    {
        public const int AvailableLength = 3;
        public int[,] ColumnWordCode { get; set; }
        public int[,] ColumnCryptoCode { get; set; }
        public string TextForCiper { get; set; }
        public string EncryptedText { get; set; }
        public int[,] MatrixKey { get => _matrixKey; }
     
        private readonly int[,] _matrixKey;

        public HillCiperModel()
        {
            _matrixKey = new int[3, 3] {
			            { 6, 24, 1 },
			            { 13, 16, 10 },
			            { 20, 17, 15 } };
			ColumnWordCode = new int[3, 1];
			ColumnCryptoCode = new int[3, 1];
            TextForCiper = string.Empty;
            EncryptedText = string.Empty;
        }
    }
}