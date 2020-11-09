using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RijlesPlanner.Data.EntityFramework.Entities;
using RijlesPlanner.Interface.Interfaces.DatabaseContext;

namespace RijlesPlanner.Data.EntityFramework.DatabaseContext
{
    public class ApplicationDatabaseContext : IdentityDbContext<UserEntity>, IApplicationDatabaseContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options)
            : base(options)
        {
        }

        // DbSets here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureRockstarEventsContext(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureRockstarEventsContext(ModelBuilder builder)
        {
            //builder.Entity<Activity>().ToTable(TableConsts.Activities);
        }
    }
}