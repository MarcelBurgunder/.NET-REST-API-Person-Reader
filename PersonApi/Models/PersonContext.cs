using Microsoft.EntityFrameworkCore;

namespace PersonApi.Models;

// Database context class for the PersonApi controller - main data model holding a list of Persons
public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; } = null!;
}
