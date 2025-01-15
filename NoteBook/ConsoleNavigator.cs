using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{

    class ConsoleNavigator
    {
        public void Navigation(string[] menuItems)
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
                        if (menuItems[selectedIndex] == "Создать заметку")
                        {
                            Console.WriteLine("Введите название заметки");
                            string noteName = Console.ReadLine();
                            Console.WriteLine("Введите текст");
                            string noteText = Console.ReadLine();
                            FileManager.CreateTextFile($"{noteName}.txt", noteText);
                        }
                        else if (menuItems[selectedIndex] == "Посмотреть заметки")
                        {
                            //Path.GetFileName("Notes");
                            Directory.GetFiles(Environment.CurrentDirectory);
                        }
                        else if (menuItems[selectedIndex] == "Выход")
                        {
                            Environment.Exit(0);
                        }
                        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }

}
