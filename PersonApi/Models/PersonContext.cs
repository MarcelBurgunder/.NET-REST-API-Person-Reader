using Microsoft.EntityFrameworkCore;

namespace PersonApi.Models;

// Database context class for the PersonApi controller - main data model holding a list of Persons
public class PersonContext : DbContext
{
    // Empty constructor - no other constructors necessary for contexts construction
    public PersonContext(DbContextOptions<PersonContext> options)
        : base(options)
    {
    }

    // List of saved persons - in a DbSet object
    public DbSet<Person> Persons { get; set; } = null!;
}
