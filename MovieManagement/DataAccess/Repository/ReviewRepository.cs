using MovieManagement.DataAccess.IRepository;
using MovieManagement.Model;

namespace MovieManagement.DataAccess.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
