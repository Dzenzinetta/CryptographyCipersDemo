
namespace ChiperHill.ConsoleUI
{
    public class MatrixOutput
    {
		private readonly HillCiperModel _model;
		public MatrixOutput(HillCiperModel model)
		{
			_model = model;
		}
		public void ConsoleMatrixOutput()
		{
			for (int i = 0; i < HillCiperModel.AvailableLength; i++)
			{
				Console.Write("\t\t|");
				MatrtixRowOutput(i);
				Console.WriteLine("|");
			}
		}

		private void MatrtixRowOutput(int rowNumber)
		{
            for (int j = 0; j < HillCiperModel.AvailableLength; j++)
            {
                Console.Write("{0, -3}", _model.MatrixKey[rowNumber, j]);
            }
        }


    }
}
