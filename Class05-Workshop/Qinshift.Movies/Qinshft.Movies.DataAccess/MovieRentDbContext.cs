using Microsoft.EntityFrameworkCore;
using Qinshft.Movies.DataAccess.DataSource;
using Qinshift.Movies.DomainModels;

namespace Qinshft.Movies.DataAccess
{
    public class MovieRentDbContext : DbContext
    {
        public MovieRentDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Movie>()
            //    .ToTable("Movies")
            //    .Property(x => x.Title)
            //    .IsRequired();

            InitialDb.InitDb(modelBuilder);
        }
    }
}
