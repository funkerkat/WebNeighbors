using System;
using System.Data.Entity;

namespace WebNeighbors.Models
{
  public class PersonsDbInitializer: DropCreateDatabaseAlways<PersonContext>
  {
    protected override void Seed(PersonContext db)
    {
      db.Persons.Add(new Person {PersonName = "Василий", ServiceName = "дворник", ServiceDescription = "Подметаю во дворе.", CoordinateX = 55.871030, CoordinateY = 37.658510 });
      db.Persons.Add(new Person { PersonName = "Марья", ServiceName = "уборщица", ServiceDescription = "Мою окна.", CoordinateX = 55.782392, CoordinateY = 37.614924 });

      base.Seed(db);
    }
  }
}