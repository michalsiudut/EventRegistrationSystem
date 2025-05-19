using EventRegistrationSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    public class ParticipantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View(InMemoryDatabase.Participants);
        }
        public IActionResult ListByEvent()
        {
            return View();
        }
    }
}
