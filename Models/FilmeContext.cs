using Microsoft.EntityFrameworkCore;

namespace mvc_movie.Models 
{
    public class FilmeContext : DbContext 
    {
        public FilmeContext (DbContextOptions<FilmeContext> options) 
            : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
    }
}