
namespace VegenereCiper
{
    public abstract class VegenereProgramBase : IVegenereProgramBase
    {
        private const string rules =
            "Rules for this Ciper:\n" +
            "1. You can use any text length.\n" +
            "2. Key is a single word (or text, but spaces would removed)\n\n";
        public void VegenereProgramMain()
        {
            Greatings();
            RulesOutput();
            FillVegenereModel();
            ResultOutput();
        }

        public abstract void Greatings();
        public abstract void FillVegenereModel();
        public abstract void ResultOutput();

        private void RulesOutput()
        {
            Console.WriteLine(rules);
        }
    }
}
