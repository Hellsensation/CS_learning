using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook;

class Navigator
{
    public void MainMenu(string[] menuItems)
    {
        int selectedIndex = 0;

        while (true)
        {
            Console.Clear();

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"> {menuItems[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {menuItems[i]}");
                }
            }

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex--;
                    if (selectedIndex < 0)
                        selectedIndex = menuItems.Length - 1;
                    break;

                case ConsoleKey.DownArrow:
                    selectedIndex++;
                    if (selectedIndex >= menuItems.Length)
                        selectedIndex = 0;
                    break;

                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine($"Вы выбрали: {menuItems[selectedIndex]}");



                    Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                    Console.ReadKey(true);
                    break;
            }


        }

    }
}
