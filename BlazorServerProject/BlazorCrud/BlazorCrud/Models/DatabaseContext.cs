using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Models
{
    public class DatabaseContext : DbContext
    {
        //Constructor
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        //Properties
        public DbSet<Person> Persons { get; set; }

    }
}
