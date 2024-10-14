using System;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Меню:\n1 - Создать новый файл\n2 - Дописать в существующий\n3 - Прочитать файл");
                string userChoose = Console.ReadLine();
                switch (userChoose)
                {
                    case "1":
                        CreateFile();
                        break;
                    case "2":
                        AppendText();
                        break;
                    case "3":
                        ReadFile();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

        }

        static void CreateFile()
        {
            Console.WriteLine("Введите текст:");
            string userText = Console.ReadLine();
            Console.WriteLine("Введите название файла");
            string userTitle = Console.ReadLine();
            string res = $"{userTitle}.txt";
            File.WriteAllText(res, userText);
        }

        static void AppendText()
        {
            Console.WriteLine("1 - Файл в текущей папке\n2 - Ввести путь до папки c файлом");
            string userChoose = Console.ReadLine();
            switch (userChoose)
            {
                case "1":
                    ShowFiles();
                    break;
                case "2":
                    Console.Write("Введите путь: ");
                    string userPath = Console.ReadLine();
                    ShowFiles(userPath);
                    break;
                default: 
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine("Введите название файла:");
            string fileName = Console.ReadLine();


            Console.WriteLine("Введите текст:");
            string userText = Console.ReadLine();


            File.AppendAllText(fileName, $"\n{userText}");
        }

        static void ShowFiles()
        {
            ShowFiles(Environment.CurrentDirectory);
        }

        static void ShowFiles(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                var name = Path.GetFileName(file);
                Console.WriteLine(name);
            }
        }

        static void ReadFile()
        {
            Console.WriteLine("1 - Файл в текущей папке\n2 - Ввести путь до папки c файлом");
            string userChoose = Console.ReadLine();
            switch (userChoose)
            {
                case"1":
                    string dir = Environment.CurrentDirectory;
                    ShowFiles();
                    Console.WriteLine("Введите название файла:");
                    string fileName = Console.ReadLine();
                    try
                    {
                        Console.WriteLine(File.ReadAllText(Path.Combine(dir, fileName)));
                    }
                    catch (Exception ex)
                    {
                        string fileNameWithTXT = $"{fileName}.txt";
                        Console.WriteLine(File.ReadAllText(Path.Combine(dir, fileNameWithTXT)));
                    }
                    
                    break;
                case "2":
                    Console.Write("Введите путь: ");
                    string userPath = Console.ReadLine();
                    ShowFiles(userPath);
                    Console.WriteLine("Введите название файла:");
                    string fileName1 = Console.ReadLine();
                    Console.WriteLine(File.ReadAllText(Path.Combine(userPath, fileName1)));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
