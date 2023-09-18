using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace MovieManagement.DataAccess
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            string connectionString = "Data Source = KHANHS; Database = MovieManagementVersion3; Trusted_Connection = True; TrustServerCertificate = True";
            optionBuilder.UseSqlServer(connectionString);
            return new AppDbContext(optionBuilder.Options);
        }
    }
}
