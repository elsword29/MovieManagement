using MovieManagement.DataAccess.IRepository;
using MovieManagement.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDirectorRepository directorRepository;
        private readonly IMovieRepository movieRepository;
        private readonly IReviewRepository reviewRepository;
        private readonly AppDbContext appDbContext;
        public UnitOfWork(AppDbContext context)
        {
            directorRepository = new DirectorRepository(context);
            movieRepository = new MovieRepository(context);
            reviewRepository = new ReviewRepository(context);
            appDbContext = context;
        }
        public IDirectorRepository DirectorRepository { get => directorRepository; }

        public IMovieRepository MovieRepository { get => movieRepository; }

        public IReviewRepository ReviewRepository { get => reviewRepository; }

        public int SaveChange()
        {
            return appDbContext.SaveChanges();
        }
    }
}
