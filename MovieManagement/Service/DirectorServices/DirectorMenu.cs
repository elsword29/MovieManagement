using MovieManagement.Model;

namespace MovieManagement.Service.DirectorServices
{
    public class DirectorMenu
    {
        protected Director AddNewMenu(Director director)
        {
            Console.WriteLine("Enter director name: ");
            director.Name = Console.ReadLine();
            return director;
        }

        protected int FindId()
        {
            Console.WriteLine("Enter director id: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        protected Director UpdateMenu(Director director)
        {
            Console.WriteLine("Enter new name: ");
            director.Name = Console.ReadLine();
            return director;
        }

        protected void DirectorMainMenu()
        {
            Console.WriteLine("============DIRECTOR=MENU============");
            Console.WriteLine("| 1. Get all director               |");
            Console.WriteLine("| 2. Get director by id             |");
            Console.WriteLine("| 3. Add new director               |");
            Console.WriteLine("| 4. Update director                |");
            Console.WriteLine("| 5. Delete director                |");
            Console.WriteLine("| 6. Exit                           |");
            Console.WriteLine("=====================================");
            Console.Write("User choice: ");
        }
    }
}
