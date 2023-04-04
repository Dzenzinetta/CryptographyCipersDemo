﻿using ChipersUtility;

namespace AffineCiper
{
    public class AffineCiperMenu : ConsoleMenuBase, IConsoleMenuBase
    {
        public override List<string> Options { get; set; }

        public override string ProgramTitle { get; } = "Affine";

        private IAffineProgramStart _starter;

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
                        _starter = AffineCiperFactory.CreateEnctyptorStarter();
                        _starter.StartAffineCiperProgram();
                        break;
                    }
                case 1:
                    {
                        _starter = AffineCiperFactory.CreateDectyptorStarter();
                        _starter.StartAffineCiperProgram();
                        break;
                    }
            }
        }
    }
}
