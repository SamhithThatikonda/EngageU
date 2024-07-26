using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    // ApplicationDbContext is a class that inherits from DbContext, which is a class provided by Entity Framework Core, and applicationDbContext acts as a bridge between our entities and the database.
    // DbContext is a class that represents a session with the database and allows us to query and save instances of our entities.
    // ApplicationDbContext is a class that represents a session with the database and allows us to query and save instances of our entities.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        // DBSet is a collection of entities that can be queried from the database, and it includes methods for filtering, sorting, and more.
        public DbSet<Student> MyProperty { get; set; }
        
    }
}