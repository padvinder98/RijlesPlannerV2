using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RijlesPlanner.Data.EntityFramework.DatabaseContext.DatabaseContextFactory
{
    public class ApplicatiomDatabasebContextFactory : DesignTimeDbContextFactoryBase<ApplicationDatabaseContext>
    {
        protected override ApplicationDatabaseContext CreateNewInstance(DbContextOptions<ApplicationDatabaseContext> options)
        {
            return new ApplicationDatabaseContext(options);
        }

        public override ApplicationDatabaseContext Create(string basePath, string environmentName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            ConnectionString = config.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(ConnectionString))
                throw new InvalidOperationException(
                    "Could not find a connection string named 'Default'.");
            return Create(ConnectionString);
        }
    }
}