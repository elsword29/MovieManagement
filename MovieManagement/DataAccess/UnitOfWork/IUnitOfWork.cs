using MovieManagement.DataAccess.IRepository;

namespace MovieManagement.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        int SaveChange();
        public IDirectorRepository DirectorRepository { get; }
        public IMovieRepository MovieRepository { get; }
        public IReviewRepository ReviewRepository { get; }
    }
}
