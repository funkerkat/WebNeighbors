using System;
using System.Data.Entity;

namespace WebNeighbors.Models
{
  public class PersonsDbInitializer: DropCreateDatabaseAlways<PersonContext>
  {
    protected override void Seed(PersonContext db)
    {
      db.Persons.Add(new Person {PersonName = "Василий", ServiceName = "дворник", ServiceDescription = "Подметаю во дворе.", PostingDate = DateTime.Now});
      db.Persons.Add(new Person { PersonName = "Марья", ServiceName = "уборщица", ServiceDescription = "Мою окна.", PostingDate = DateTime.Now });

      base.Seed(db);
    }
  }
}