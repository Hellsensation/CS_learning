using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoteBook
{
    public static class FileManager
    {
        public static void CreateDirectory()
        {
            if (!Directory.Exists("Notes"))
            {
                Directory.CreateDirectory("Notes");
                Console.WriteLine($"Директория '{"Notes"}' создана.");
            }
            else
            {
                Console.WriteLine($"Директория '{"Notes"}' уже существует.");
            }
        }
        public static void CreateTextFile(string fileName, string content = "")
        {
            if (!File.Exists($"Notes\\{fileName}"))
            {
                File.WriteAllText($"Notes\\{fileName}", content);
                Console.WriteLine($"Файл '{fileName}' создан.");
            }
            else
            {
                Console.WriteLine($"Файл '{fileName}' уже существует.");
            }
        }
    }
}