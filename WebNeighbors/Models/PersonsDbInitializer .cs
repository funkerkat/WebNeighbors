using System;
using System.Data.Entity;

namespace WebNeighbors.Models
{
  public class PersonsDbInitializer: DropCreateDatabaseAlways<PersonContext>
  {
    protected override void Seed(PersonContext db)
    {
      db.Persons.Add(new Person {PersonName = "Василий", ServiceName = "дворник", ServiceDescription = "Подметаю во дворе.", CoordinateX = 55.86, CoordinateY = 37.74 });
      db.Persons.Add(new Person { PersonName = "Марья", ServiceName = "уборщица", ServiceDescription = "Мою окна.", CoordinateX = 55.88, CoordinateY = 37.74 });

      base.Seed(db);
    }
  }
}