namespace ChipersUtility
{
    public interface IInputFromConsole
    {
        int GetIntegerInputFromConsole(string message);
        string GetStringInputFromConsole(string message);
    }
}