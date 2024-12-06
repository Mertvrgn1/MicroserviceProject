using MicroserviceProject.Catalog.Api.Features.Categories;
using MicroserviceProject.Catalog.Api.Features.Courses;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System.Reflection;

namespace MicroserviceProject.Catalog.Api.Repository
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }

        public static AppDbContext Create(IMongoDatabase database)
        {
            var optionsBuilder= new DbContextOptionsBuilder<AppDbContext>().UseMongoDB(database.Client,database.DatabaseNamespace.DatabaseName);
            return new AppDbContext(optionsBuilder.Options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }
    }
}
