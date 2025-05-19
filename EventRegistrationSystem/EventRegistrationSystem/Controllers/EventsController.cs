using EventRegistrationSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View(InMemoryDatabase.Events);
        }
        public IActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateNewEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewEvent(EventModel model) {

            if (!ModelState.IsValid)
            {
                return View("CreateNewEvent", model); 
            }

            model.Id = InMemoryDatabase.Events.Count + 1;
            InMemoryDatabase.Events.Add(model);

            return RedirectToAction("Create");
        }
    }

}
