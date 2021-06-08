using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace Apollo.Dal
{
    public class ApolloDbContextFactory : IDesignTimeDbContextFactory<ApolloDbContext>
    {
        public ApolloDbContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            var config = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApolloDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            return new ApolloDbContext(optionsBuilder.Options);
        }
    }
}
