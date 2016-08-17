using System.Data.Entity;

namespace WebNeighbors.Models
{
  public class PersonContext: DbContext
  {
    public DbSet<Person> Persons { get; set; }
  }
}