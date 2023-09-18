using MovieManagement.DataAccess.IRepository;
using MovieManagement.Model;

namespace MovieManagement.DataAccess.Repository
{
    public class DirectorRepository : GenericRepository<Director> , IDirectorRepository
    {
        public DirectorRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
