using System;
using System.Data.Entity;

namespace WebNeighbors.Models
{
  public class PersonsDbInitializer: DropCreateDatabaseAlways<PersonContext>
  {
    protected override void Seed(PersonContext db)
    {
      db.Persons.Add(new Person {PersonName = "Василий", ServiceName = "дворник", ServiceDescription = "Подметаю во дворе."});
      db.Persons.Add(new Person { PersonName = "Марья", ServiceName = "уборщица", ServiceDescription = "Мою окна."});

      base.Seed(db);
    }
  }
}