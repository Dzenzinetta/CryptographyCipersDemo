using System.Collections.Generic;

namespace ChipersUtility
{
    public interface IConsoleMenuBase
    {
        List<string> Options { get; set; }
        string ProgramTitle { get; }

        void FillMenuList();
        void MenuSelector();
        void RunMenu();
    }
}