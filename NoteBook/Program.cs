namespace NoteBook
{
    class Program
    {
        static void Main()
        {
            FileManager.CreateDirectory();
            string[] mainMenuItems = {"Создать заметку", "Посмотреть заметки", "Редактировать заметки", "Выход"};
            ConsoleNavigator consoleNavigator = new ConsoleNavigator();
            consoleNavigator.Navigation(mainMenuItems);
            

             
        }

    }
}
