using MovieManagement.Model;

namespace MovieManagement.Service.MovieServices
{
    public class MovieMenu
    {
        protected Movie AddNewMenu(Movie movie)
        {
            Console.WriteLine("Enter movie name: ");
            movie.Name = Console.ReadLine();
            Console.WriteLine("Enter movie director id: ");
            movie.DirectorId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter release date: ");
            movie.ReleaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter country: ");
            movie.Country = Console.ReadLine();
            return movie;
        }
        protected void UpdateMenu()
        {
            Console.WriteLine("=========UPDATE=MENU=========");
            Console.WriteLine("| 1. Update movie name      |");
            Console.WriteLine("| 2. Update release date    |");
            Console.WriteLine("| 3. Update country         |");
            Console.WriteLine("| 4. Update director id     |");
            Console.WriteLine("| 5. Update all             |");
            Console.WriteLine("| 6. Exit                   |");
            Console.WriteLine("=============================");
            Console.Write("User choice: ");
        }
        protected Movie UpdateMovie(Movie movie, int choice)
        {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new name: ");
                        movie.Name = Console.ReadLine();
                        return movie;
                    case 2:
                        Console.WriteLine("Enter new release date: ");
                        movie.ReleaseDate = DateTime.Parse(Console.ReadLine());
                        return movie;
                    case 3:
                        Console.WriteLine("Enter new country: ");
                        movie.Country = Console.ReadLine();
                        return movie;
                    case 4:
                        Console.WriteLine("Enter new director id");
                        movie.DirectorId = int.Parse(Console.ReadLine());
                        return movie;
                    case 5:
                        Console.WriteLine("Enter new name: ");
                        movie.Name = Console.ReadLine();
                        Console.WriteLine("Enter new release date: ");
                        movie.ReleaseDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new country: ");
                        movie.Country = Console.ReadLine();
                        Console.WriteLine("Enter new director id");
                        movie.DirectorId = int.Parse(Console.ReadLine());
                        return movie;
                    case 6:
                        return null;
                    default:
                        throw new Exception("Please choose from 1 to 6");
                }
        }
        protected int FindId()
        {
            Console.WriteLine("Enter movie id: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        protected int Choice()
        {
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        protected void MovieMainMenu()
        {
            Console.WriteLine("============DIRECTOR=MENU============");
            Console.WriteLine("| 1. Get all movie                  |");
            Console.WriteLine("| 2. Get movie by id                |");
            Console.WriteLine("| 3. Add new movie                  |");
            Console.WriteLine("| 4. Update movie                   |");
            Console.WriteLine("| 5. Delete movie                   |");
            Console.WriteLine("| 6. Exit                           |");
            Console.WriteLine("=====================================");
            Console.Write("User choice: ");
        }

        protected string SeeCommentOption()
        {
            Console.WriteLine("Do you want to see comment ? (Y/N)");
            string option = Console.ReadLine().ToUpper();
            return option;
        }
        protected string AddCommentOption()
        {
            Console.WriteLine("Do you want to add comment ? (Y/N)");
            string option = Console.ReadLine().ToUpper();
            return option;
        }

        protected Review AddReview()
        {
            Review review = new Review();
            Console.WriteLine("Enter your review: ");
            review.Content = Console.ReadLine();
            return review;
        }
    }
}
