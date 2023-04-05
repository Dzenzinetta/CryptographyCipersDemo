using ChipersUtility;
using System.Collections.Generic;
using VerticalShiftCiper;

namespace ChiperVerticalShift
{
    public class VerticalShiftCiperMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override string ProgramTitle { get; } = "Vertical Shift";

        public override List<string> Options { get; set; }

        private IVerticalShiftProgramStart _starter;

        public override void FillMenuList()
        {
            Options = new List<string>
            {
                "Encryption algorithm",
                "Decryption algorithm",
                "Go Back"
            };
        }

        public override void MenuSelector()
        {
            TextManipulator.ResetCursorVisible();

            switch (SelectedOption)
            {
                case 0:
                    {
                        _starter = VerticalShiftCiperFactory.CreateVerticalShiftCiperEncryptor();
                        _starter.StartVerticalShiftCiperProgram();
                        break;
                    }
                case 1:
                    {
                        _starter = VerticalShiftCiperFactory.CreateVerticalShiftCiperDecryptor();
                        _starter.StartVerticalShiftCiperProgram();
                        break;
                    }
            }
        }
    }
}
