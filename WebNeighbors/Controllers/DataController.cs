using System.Web.Mvc;
using WebNeighbors.Models;

namespace WebNeighbors.Controllers
{
  public class DataController : Controller
  {
    PersonContext db = new PersonContext();

    // GET: Data
    public ActionResult Index()
    {
      return View(db.Persons);
    }

    [HttpPost]
    public ActionResult Index(Person person)
    {
      db.Persons.Add(person);
      db.SaveChanges();

      return View(db.Persons);
    }
  }
}