using MovieManagement.DataAccess;
using MovieManagement.DataAccess.UnitOfWork;
using MovieManagement.Model;

namespace MovieManagement.Service.MovieServices
{
    public class MovieController : MovieMenu
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly AppDbContext context;
        public MovieController(IUnitOfWork _unitOfWork, AppDbContext _context)
        {
            unitOfWork = _unitOfWork;
            context = _context;
        }


        private void GetAllMovie()
        {
            var list = unitOfWork.MovieRepository.GetAll();
            foreach (var movie in list)
            {
                context.Entry(movie).Reference(movie => movie.Director).Load();
                Console.WriteLine($"{movie.Id} - {movie.Name} - {movie.Director.Name} - {movie.Country} - {movie.ReleaseDate}\n");
            }
        }
        private void AddNewMovie()
        {
            Movie movie = new Movie();
            movie = base.AddNewMenu(movie);
            unitOfWork.MovieRepository.Add(movie);
            unitOfWork.SaveChange();
        }

        private void EditMovie()
        {
            var id = base.FindId();
            var movie = GetMovieById(id);
            int choice = 0;
            do
            {
                try
                {
                    base.UpdateMenu();
                    choice = base.Choice();
                    var update = base.UpdateMovie(movie, choice);
                    unitOfWork.MovieRepository.Edit(movie);
                    unitOfWork.SaveChange();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (choice != 6);
        }

        private void DeleteMovie()
        {
            var id = base.FindId();
            var movie = GetMovieById(id);
            unitOfWork.MovieRepository.Delete(movie);
            unitOfWork.SaveChange();
        }

        private Movie GetMovieById(int id)
        {
            var movie = unitOfWork.MovieRepository.GetById(id);
            return movie;
        }

        private Movie ShowMovieById()
        {
            int id = base.FindId();
            var movie = GetMovieById(id);
            context.Entry(movie).Reference(movie => movie.Director).Load();
            context.Entry(movie).Collection(movie => movie.Reviews).Load();
            Console.WriteLine($"{movie.Id} - {movie.Name} - {movie.Director.Name} - {movie.Country} - {movie.ReleaseDate}\n");
            return movie;
        }

        private void SeeComment(Movie movie)
        {
            string seeCommentOption = base.SeeCommentOption();
            if (seeCommentOption.Equals("Y"))
            {
                foreach (var review in movie.Reviews)
                {
                    Console.WriteLine($"{review.Content}\n");
                }
            }
        }

        private void AddComment(Movie movie)
        {
            string addCommentOption = base.AddCommentOption();
            if (addCommentOption.Equals("Y"))
            {
                var review = base.AddReview();
                movie.Reviews.Add(review);
                unitOfWork.ReviewRepository.Add(review);
                unitOfWork.SaveChange();
            }
        }
        public void MovieManagement()
        {
            int choice = 0;
            do
            {
                try
                {
                    base.MovieMainMenu();
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            GetAllMovie();
                            break;
                        case 2:
                            var movie = ShowMovieById();
                            SeeComment(movie);
                            AddComment(movie);
                            break;
                        case 3:
                            AddNewMovie();
                            break;
                        case 4:
                            EditMovie();
                            break;
                        case 5:
                            DeleteMovie();
                            break;
                        case 6:
                            break;
                        default:
                            throw new Exception("Please choose from 1 to 6");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (choice != 6);
        }
    }
}
