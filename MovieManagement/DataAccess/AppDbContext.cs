using Microsoft.EntityFrameworkCore;
using MovieManagement.Model;

namespace MovieManagement.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public AppDbContext(DbContextOptions option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>()
                .HasMany(director => director.Movies)
                .WithOne(movie => movie.Director)
                .HasForeignKey(movie => movie.DirectorId);
            modelBuilder.Entity<Movie>()
                .HasMany(movie => movie.Reviews)
                .WithOne(review => review.Movie)
                .HasForeignKey(review => review.MovieId);

            modelBuilder.Entity<Director>()
                .HasData
                (
                    new Director { Id = 1, Name = "Khanh" },
                    new Director { Id = 2, Name = "James Cameron" },
                    new Director { Id = 3, Name = "Joss Whedon" }
                );
            modelBuilder.Entity<Movie>()
                .HasData
                (
                    new Movie { Id = 1, Name = "C# Fuck My Life Every Days", DirectorId = 1, ReleaseDate = DateTime.Parse("09/13/2023"), Country = "Viet Nam"},
                    new Movie { Id = 2, Name = "Avatar", DirectorId = 2, ReleaseDate = DateTime.Parse("09/12/2012"), Country = "US"},
                    new Movie { Id = 3, Name = "Avatar 2: The ways of water", DirectorId = 2, ReleaseDate = DateTime.Parse("04/20/2022"), Country = "US"},
                    new Movie { Id = 4, Name = "Justice League", DirectorId = 3, ReleaseDate = DateTime.Now, Country = "US"},
                    new Movie { Id = 5, Name = "The flash", DirectorId = 3, ReleaseDate = DateTime.Now, Country = "US"}
                );
            modelBuilder.Entity<Review>()
                .HasData
                (
                    new Review { Id = 1, MovieId = 1, Content = "Haha"},
                    new Review { Id = 2, MovieId = 2, Content = "Haha"},
                    new Review { Id = 3, MovieId = 3, Content = "Haha"},
                    new Review { Id = 4, MovieId = 4, Content = "Haha"},
                    new Review { Id = 5, MovieId = 5, Content = "Haha"}
                );
        }


    }
}

