using System;
using System.Collections.Generic;

namespace ChipersUtility
{
    public abstract class ConsoleMenuBase : IConsoleMenuBase
    {
        public abstract string ProgramTitle { get; }
        public abstract List<string> Options { get; set; }

        public int SelectedOption = 0;

        private const int DefaultLineLength = 30;

        private readonly ConsoleColor _black = ConsoleColor.Black;
        private readonly ConsoleColor _white = ConsoleColor.White;

        public abstract void FillMenuList();
        public abstract void MenuSelector();


        public void RunMenu()
        {
            Console.Title = ProgramTitle + "Ciper demonstration program";
            //ResetCursorVisible();
            FillMenuList();
            
            SelectedOption = GetOptionFromMenu();
            MenuSelector();   
        }
    

        private string GetOptionCentered(string rawOption)
        {
            string newOption = string.Empty;
            int differ = DefaultLineLength - rawOption.Length;
            for (int i = 0; i < differ; i++)
            {
                newOption += " ";
            }
            return newOption.Insert(differ / 2, rawOption);
        }

        private void DispalayMenu()
        {
            for (int i = 0; i < Options.Count; i++)
            {
                string option = GetOptionCentered(Options[i]);
                //string prefix;
                if (i == SelectedOption)
                {
                    //prefix = "*";
                    SetConsoleTextColor(_black, _white);
                }
                else
                {
                    //prefix = " ";
                    SetConsoleTextColor(_white, _black);
                }

                Console.WriteLine($"<< {option} >>");
            }
            Console.ResetColor();
        }

        private void SetConsoleTextColor(ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
        }

        private int GetOptionFromMenu()
        {
            ConsoleKey pressedKey;
            do
            {
                Console.Clear();
                DispalayMenu();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                pressedKey = keyInfo.Key;

                if (pressedKey == ConsoleKey.UpArrow)
                {
                    SelectedOption--;
                    if (SelectedOption == -1)
                    {
                        SelectedOption = Options.Count - 1;
                    }
                }
                else if (pressedKey == ConsoleKey.DownArrow)
                {
                    SelectedOption++;
                    if (SelectedOption == Options.Count)
                    {
                        SelectedOption = 0;
                    }
                }

            } while (pressedKey != ConsoleKey.Enter);

            return SelectedOption;
        }

    }
}
