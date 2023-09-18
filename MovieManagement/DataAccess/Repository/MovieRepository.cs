using MovieManagement.DataAccess.IRepository;
using MovieManagement.Model;

namespace MovieManagement.DataAccess.Repository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
