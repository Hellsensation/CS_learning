using System;

namespace Lesson_6;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Меню:\n1 - Создать новый файл\n2 - Дописать в существующий\n3 - Прочитать файл");
            string? userChoose = Console.ReadLine();
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
        string? userText = Console.ReadLine();
        Console.WriteLine("Введите название файла");
        string? userTitle = Console.ReadLine();
        Console.WriteLine("1 - Сохранить файл в текущей папке\n2 - Ввести путь до папки");
        string ?userChoose = Console.ReadLine();
        switch (userChoose)
        {
            case "1":
                string? res = userTitle;
                File.WriteAllText(res, userText);
                break;
            case "2":
                Console.Write("Введите путь до папки назначения: ");
                string? userPath = Console.ReadLine();
                File.WriteAllText(Path.Combine(userPath, userTitle), userText);
                break;
            default:
                Console.WriteLine("1 или 2");
                CreateFile();
                break;
        }
    }

    static void AppendText()
    {
        Console.WriteLine("1 - Файл в текущей папке\n2 - Ввести путь до папки c файлом");
        string? userChoose = Console.ReadLine();
        switch (userChoose)
        {
            case "1":
                ShowFiles();
                RecordData();
                break;
            case "2":
                Console.Write("Введите путь: ");
                string? userPath = Console.ReadLine();
                ShowFiles(userPath);
                RecordData(userPath);
                break;
            default: 
                Console.WriteLine("1 или 2");
                AppendText();
                break;
        }
    }


    static void ReadFile()
    {
        Console.WriteLine("1 - Файл в текущей папке\n2 - Ввести путь до папки c файлом");
        string? userChoose = Console.ReadLine();
        switch (userChoose)
        {
            case "1":
                ShowFiles();
                string currentDir = Environment.CurrentDirectory;
                Console.WriteLine("Введите название файла:");
                string? fileName = Console.ReadLine();
                Console.WriteLine(File.ReadAllText(Path.Combine(currentDir, fileName)));
                break;
            case "2":
                Console.Write("Введите путь: ");
                string? userPath = Console.ReadLine();
                ShowFiles(userPath);
                Console.WriteLine("Введите название файла:");
                string? fileName1 = Console.ReadLine(); //Мне вот этот момент тоже не нравится, но не придумал как обойти
                Console.WriteLine(File.ReadAllText(Path.Combine(userPath, fileName1))); 
                break;
            default:
                Console.WriteLine("1 или 2");
                ReadFile();
                break;
        }
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

    static void RecordData()
    {
        Console.WriteLine("Введите название файла:");
        string? fileName = Console.ReadLine();
        Console.WriteLine("Введите текст:");
        string? userText = Console.ReadLine();
        File.AppendAllText(fileName, $"\n{userText}");
    }

    static void RecordData(string path)
    {
        Console.WriteLine("Введите название файла:");
        string? fileName = Console.ReadLine();
        Console.WriteLine("Введите текст:");
        string? userText = Console.ReadLine();
        File.AppendAllText(Path.Combine(path, fileName), $"\n{userText}");
    }
}
