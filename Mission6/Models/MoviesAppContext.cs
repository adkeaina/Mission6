using Microsoft.EntityFrameworkCore;

namespace Mission6.Models;

public class MoviesAppContext : DbContext
{
    public MoviesAppContext(DbContextOptions<MoviesAppContext> options) : base(options)
    {
        
    }
    
    public DbSet<Movie> Movies { get; set; }
}