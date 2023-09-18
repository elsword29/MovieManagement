using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieManagement.DataAccess;

namespace MovieManagement.Helper
{
    public static class Helper
    {
        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appSetting.json", true, true);
            IConfiguration configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("Connection");
            return connectionString;
        }

        public static AppDbContext GetContext()
        {
            string connectionString = GetConnectionString();
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            var context = new AppDbContext(optionBuilder.Options);
            return context;
        }
    }
}
