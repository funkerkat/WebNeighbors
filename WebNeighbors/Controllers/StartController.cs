using System.Web.Mvc;
using WebNeighbors.Models;

namespace WebNeighbors.Controllers
{
  public class StartController : Controller
  {
    PersonContext db = new PersonContext();

    // GET: Start
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

    public ActionResult Temp()
    {
      return View();
    }

    public ActionResult Simple()
    {
      return View();
    }

    public ActionResult Map()
    {
      return View();
    }
  }
}