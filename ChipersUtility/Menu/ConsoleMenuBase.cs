using System;
using System.Collections.Generic;

namespace ChipersUtility
{
    public abstract class ConsoleMenuBase : IConsoleMenuBase
    {
        private const int DefaultLineLength = 30;
        private const ConsoleColor Black = ConsoleColor.Black;
        private const ConsoleColor White = ConsoleColor.White;
       
        protected List<string> Options { get; set; }

        protected int selectedOption = 0;

        public abstract void FillMenuList();
        public abstract void MenuSelector();
        protected abstract string SetProgramTitle();

        public void RunMenu()
        {
            Console.Title = SetProgramTitle() + "Ciper demonstration program";
            //ResetCursorVisible();
            FillMenuList();
            
            selectedOption = GetOptionFromMenu();
            MenuSelector();   
        }
    

        private string SetOptionCentered(string rawOption)
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
                string option = SetOptionCentered(Options[i]);
                //string prefix;
                if (i == selectedOption)
                {
                    //prefix = "*";
                    SetConsoleTextColor(Black, White);
                }
                else
                {
                    //prefix = " ";
                    SetConsoleTextColor(White, Black);
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
                    selectedOption--;
                    if (selectedOption == -1)
                    {
                        selectedOption = Options.Count - 1;
                    }
                }
                else if (pressedKey == ConsoleKey.DownArrow)
                {
                    selectedOption++;
                    if (selectedOption == Options.Count)
                    {
                        selectedOption = 0;
                    }
                }

            } while (pressedKey != ConsoleKey.Enter);

            return selectedOption;
        }

     

    }
}
