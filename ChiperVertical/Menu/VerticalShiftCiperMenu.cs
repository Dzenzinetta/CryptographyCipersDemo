using ChipersUtility;
using System.Collections.Generic;
using VerticalShiftCiper;

namespace ChiperVerticalShift
{
    public sealed class VerticalShiftCiperMenu : ConsoleMenuBase //, IConsoleMenuBase
    {
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
            switch (selectedOption)
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

        protected override string SetProgramTitle()
        {
            return "Vertical Shift";
        }
    }
}
