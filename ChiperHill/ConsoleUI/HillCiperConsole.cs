using ChiperHill.ConsoleUI;
using ChipersUtility;

namespace ChiperHill
{
    public class HillCiperConsole
	{
		//private readonly ITextInput _consoleInput;
		private readonly HillCiperTextInput _textInput;
		private readonly HillCiperModel _model;
		private MatrixOutput _matrix; 
		private HillEncryptor _encryptor;

		public HillCiperConsole()
		{
			//_consoleInput = UtilityControl.CreateInputFromConsole();
			_textInput = new HillCiperTextInput();
			_model = new HillCiperModel();
		}

		public void HillChiperMain()
		{

			Console.Clear();
			Console.WriteLine("Welcome to Hill Ciper Example\n" +
					"There is only one available option of key because of sequencing complexity\n");

            Console.WriteLine("\n1. <- Getting text for Ciper	->\n");
			_model.TextForCiper = ConsoleTextInput();

            Console.WriteLine("\n2. <- Output key matrix		->\n");
			
			_matrix = new MatrixOutput(_model);
			_matrix.ConsoleMatrixOutput();

			_encryptor = new HillEncryptor(_model);
			_model.EncryptedText = _encryptor.HillChiperCtyptoProcess();

            Console.WriteLine("\nOriginal word:\t");
            TextManipulator.OutputStringSymbolBySymbol(_model.TextForCiper);

            Console.WriteLine("\nEncrypted word:\t");
            TextManipulator.OutputStringSymbolBySymbol(_model.EncryptedText);
			Console.WriteLine();
		}

		private string ConsoleTextInput()
		{
			do
			{
				_model.TextForCiper = _textInput.GetText();
				Console.WriteLine(HillCiperTextInput.GetConsoleMessage());

			}while(_textInput.IsTextValid() == false);

			return _model.TextForCiper;
		}


	}
}
