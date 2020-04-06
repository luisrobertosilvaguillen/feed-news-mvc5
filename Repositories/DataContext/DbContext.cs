using Domain.Models;
using Repositories.DataContext.Configurations;
using Repositories.DataContext.Seed;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
namespace Repositories.DataContext
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new DataContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FeedNews> FeedNews { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            modelBuilder.Configurations.Add(new CategoryConfigurations());
            modelBuilder.Configurations.Add(new FeedNewsConfigurations());
            modelBuilder.Configurations.Add(new NewsConfigurations());
            modelBuilder.Configurations.Add(new CommentsConfiguration());

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }


    }
}
